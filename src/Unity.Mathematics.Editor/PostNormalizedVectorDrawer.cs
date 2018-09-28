using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityObject = UnityEngine.Object;

namespace Unity.Mathematics.Editor
{
    [CustomPropertyDrawer(typeof(PostNormalizeAttribute))]
    class PostNormalizedVectorDrawer : PrimitiveVectorDrawer
    {
        static class Content
        {
            public static readonly string tooltip =
                L10n.Tr("Values you enter will be post-normalized. You will see the normalized result if you change selection and view the values again.");
        }

        class VectorPropertyGUIData
        {
            public readonly bool Valid;

            // parent property
            readonly SerializedProperty m_VectorProperty;
            // per child property relative path; value is null if there are multiple different values
            readonly KeyValuePair<string, double?>[] m_PreNormalizedValues = new KeyValuePair<string, double?>[4];
            // per target; used to revert actual values for each object after displaying pre-normalized values
            readonly Dictionary<SerializedObject, double4> m_PostNormalizedValues = new Dictionary<SerializedObject, double4>();

            public VectorPropertyGUIData(SerializedProperty property)
            {
                m_VectorProperty = property;
                if (Valid = TryUpdatePreNormalizedValues())
                    UpdatePostNormalizedValues();
            }

            bool TryUpdatePreNormalizedValues()
            {
                var iterator = m_VectorProperty.Copy();
                var parentPath = m_VectorProperty.propertyPath;
                var i = 0;
                while (iterator.Next(true) && iterator.propertyPath.StartsWith(parentPath))
                {
                    if (i >= m_PreNormalizedValues.Length || iterator.propertyType != SerializedPropertyType.Float)
                        return false;
                    m_PreNormalizedValues[i] = new KeyValuePair<string, double?>(
                        iterator.propertyPath.Substring(parentPath.Length + 1),
                        iterator.hasMultipleDifferentValues ? (double?)null : iterator.doubleValue
                    );
                    ++i;
                }
                return true;
            }

            void UpdatePostNormalizedValues()
            {
                foreach (var target in m_VectorProperty.serializedObject.targetObjects)
                {
                    var postNormalizedValue = new double4();
                    var parentProperty = new SerializedObject(target).FindProperty(m_VectorProperty.propertyPath);
                    for (var i = 0; i < 4; ++i)
                    {
                        if (string.IsNullOrEmpty(m_PreNormalizedValues[i].Key))
                            break;
                        postNormalizedValue[i] =
                            parentProperty.FindPropertyRelative(m_PreNormalizedValues[i].Key).doubleValue;
                    }
                    m_PostNormalizedValues[parentProperty.serializedObject] = postNormalizedValue;
                }
            }

            public void UpdatePreNormalizedValues()
            {
                TryUpdatePreNormalizedValues();
            }

            public void ApplyPreNormalizedValues()
            {
                m_VectorProperty.serializedObject.ApplyModifiedProperties();
                foreach (var rawValue in m_PreNormalizedValues)
                {
                    if (rawValue.Value != null)
                        m_VectorProperty.FindPropertyRelative(rawValue.Key).doubleValue = rawValue.Value.Value;
                }
            }

            public void UnapplyPreNormalizedValues()
            {
                foreach (var target in m_PostNormalizedValues)
                {
                    target.Key.Update();
                    var sp = target.Key.FindProperty(m_VectorProperty.propertyPath);
                    for (var i = 0; i < 4; ++i)
                    {
                        if (string.IsNullOrEmpty(m_PreNormalizedValues[i].Key))
                            break;
                        sp.FindPropertyRelative(m_PreNormalizedValues[i].Key).doubleValue = target.Value[i];
                        target.Key.ApplyModifiedProperties();
                    }
                }
                m_VectorProperty.serializedObject.Update();
            }

            public void PostNormalize(Func<double4, double4> normalize)
            {
                m_VectorProperty.serializedObject.ApplyModifiedProperties();
                foreach (var target in m_VectorProperty.serializedObject.targetObjects)
                {
                    var postNormalizedValue = new double4();
                    var sp = new SerializedObject(target).FindProperty(m_VectorProperty.propertyPath);
                    for (var i = 0; i < 4; ++i)
                    {
                        if (string.IsNullOrEmpty(m_PreNormalizedValues[i].Key))
                            break;
                        postNormalizedValue[i] = sp.FindPropertyRelative(m_PreNormalizedValues[i].Key).doubleValue;
                    }
                    postNormalizedValue = normalize(postNormalizedValue);
                    for (var i = 0; i < 4; ++i)
                    {
                        if (string.IsNullOrEmpty(m_PreNormalizedValues[i].Key))
                            break;
                        sp.FindPropertyRelative(m_PreNormalizedValues[i].Key).doubleValue = postNormalizedValue[i];
                    }
                    sp.serializedObject.ApplyModifiedProperties();
                }
                UpdatePostNormalizedValues();
                m_VectorProperty.serializedObject.Update();
            }
        }

        Dictionary<string, VectorPropertyGUIData> m_GUIDataPerPropertyPath = new Dictionary<string, VectorPropertyGUIData>();

        protected virtual SerializedProperty GetVectorProperty(SerializedProperty property)
        {
            return property;
        }

        protected virtual double4 Normalize(double4 value)
        {
            return math.normalizesafe(value);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            VectorPropertyGUIData guiData;
            if (!m_GUIDataPerPropertyPath.TryGetValue(property.propertyPath, out guiData))
            {
                guiData = new VectorPropertyGUIData(GetVectorProperty(property));
                m_GUIDataPerPropertyPath[property.propertyPath] = guiData;
            }
            return guiData.Valid ? base.GetPropertyHeight(property, label) : EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var guiData = m_GUIDataPerPropertyPath[property.propertyPath];
            if (!guiData.Valid)
            {
                EditorGUI.HelpBox(
                    EditorGUI.PrefixLabel(position, label),
                    L10n.Tr($"{typeof(PostNormalizeAttribute).Name} only works with decimal vector types."),
                    MessageType.None
                );
                return;
            }

            if (string.IsNullOrEmpty(label.tooltip))
                label.tooltip = Content.tooltip;

            guiData.ApplyPreNormalizedValues();
            EditorGUI.BeginChangeCheck();
            base.OnGUI(position, property, label);
            if (EditorGUI.EndChangeCheck())
            {
                guiData.UpdatePreNormalizedValues();
                guiData.PostNormalize(Normalize);
            }
            else
            {
                guiData.UnapplyPreNormalizedValues();
            }
        }
    }
}
