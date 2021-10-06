using System;
using UnityEditor;
using UnityEngine;

namespace Unity.Mathematics.Editor
{
    [CustomPropertyDrawer(typeof(bool2)), CustomPropertyDrawer(typeof(bool3)), CustomPropertyDrawer(typeof(bool4))]
    [CustomPropertyDrawer(typeof(double2)), CustomPropertyDrawer(typeof(double3)), CustomPropertyDrawer(typeof(double4))]
    [CustomPropertyDrawer(typeof(float2)), CustomPropertyDrawer(typeof(float3)), CustomPropertyDrawer(typeof(float4))]
    [CustomPropertyDrawer(typeof(int2)), CustomPropertyDrawer(typeof(int3)), CustomPropertyDrawer(typeof(int4))]
    [CustomPropertyDrawer(typeof(uint2)), CustomPropertyDrawer(typeof(uint3)), CustomPropertyDrawer(typeof(uint4))]
    [CustomPropertyDrawer(typeof(DoNotNormalizeAttribute))]
    class PrimitiveVectorDrawer : PropertyDrawer
    {
        private string _PropertyType;

        string GetPropertyType(SerializedProperty property)
        {
            if (_PropertyType == null)
            {
                _PropertyType = property.type;
                var isManagedRef = property.type.StartsWith("managedReference", StringComparison.Ordinal);
                if (isManagedRef)
                {
                    var startIndex = "managedReference<".Length;
                    var length = _PropertyType.Length - startIndex - 1;
                    _PropertyType = _PropertyType.Substring("managedReference<".Length, length);
                }
            }

            return _PropertyType;
        }

        static class Content
        {
            public static readonly string doNotNormalizeCompatibility = L10n.Tr(
                $"{typeof(DoNotNormalizeAttribute).Name} only works with {typeof(quaternion)} and primitive vector types."
            );
            public static readonly string doNotNormalizeTooltip =
                L10n.Tr("This value is not normalized, which may produce unexpected results.");

            public static readonly GUIContent[] labels2 = { new GUIContent("X"), new GUIContent("Y") };
            public static readonly GUIContent[] labels3 = { new GUIContent("X"), new GUIContent("Y"), new GUIContent("Z") };
            public static readonly GUIContent[] labels4 = { new GUIContent("X"), new GUIContent("Y"), new GUIContent("Z"), new GUIContent("W") };
        }

        public override bool CanCacheInspectorGUI(SerializedProperty property)
        {
            return false;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var height = EditorGUIUtility.singleLineHeight;
            if (!EditorGUIUtility.wideMode)
                height += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            return height;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var subLabels = Content.labels4;
            var startIter = "x";
            var propertyType = GetPropertyType(property);
            switch (propertyType[propertyType.Length - 1])
            {
                case '2':
                    subLabels = Content.labels2;
                    break;
                case '3':
                    subLabels = Content.labels3;
                    break;
                case '4':
                    subLabels = Content.labels4;
                    break;
                default:
                {
                    if (property.type == nameof(quaternion))
                        startIter = "value.x";
                    else if (attribute is DoNotNormalizeAttribute)
                    {
                        EditorGUI.HelpBox(EditorGUI.PrefixLabel(position, label), Content.doNotNormalizeCompatibility, MessageType.None);
                        return;
                    }
                    break;
                }
            }

            if (attribute is DoNotNormalizeAttribute && string.IsNullOrEmpty(label.tooltip))
                label.tooltip = Content.doNotNormalizeTooltip;

            label = EditorGUI.BeginProperty(position, label, property);

            {
                // This code is basically EditorGUI.MultiPropertyField(Rect, GUIContent[], SerializedProperty, GUIContent), but with the
                // property visibility assumed to be "All" instead of "OnlyVisible". We really want to have "All" because
                // it's possible for someone to hide something in the inspector with [HideInInspector] but then manually
                // draw it themselves later. In this case, if you called EditorGUI.MultiPropertyField() directly, you'd
                // end up with some fields that point to some unrelated visible property.
                position = EditorGUI.PrefixLabel(position, label);
                position.height = 18f;
                int length = subLabels.Length;
                float num = (position.width - (length - 1) * 4f) / length;
                Rect position1 = new Rect(position)
                {
                    width = num
                };
                var child = property.FindPropertyRelative(startIter);
                float labelWidth = EditorGUIUtility.labelWidth;
                int indentLevel = EditorGUI.indentLevel;
                EditorGUI.indentLevel = 0;

                for (int index = 0; index < subLabels.Length; ++index)
                {
                    EditorGUIUtility.labelWidth = EditorStyles.label.CalcSize(subLabels[index]).x;
                    EditorGUI.PropertyField(position1, child, subLabels[index]);
                    position1.x += num + 4f;
                    child.Next(false);
                }

                EditorGUIUtility.labelWidth = labelWidth;
                EditorGUI.indentLevel = indentLevel;
            }

            EditorGUI.EndProperty();
        }
    }
}
