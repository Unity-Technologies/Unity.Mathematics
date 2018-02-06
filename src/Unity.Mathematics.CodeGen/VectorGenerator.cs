using System;
using System.Text;

namespace Unity.Mathematics.Mathematics.CodeGen
{
    class VectorGenerator
    {
        string[] m_Types;
        private GeneratorJob m_Job;

        [Flags]
        private enum Features
        {
            Arithmetic = 1 << 0,
            Shifts = 1 << 1,
            BitwiseLogic = 1 << 2,
            BitwiseComplement = 1 << 3,
            UnaryNegation = 1 << 4,
            All = Arithmetic | Shifts | BitwiseLogic | BitwiseComplement | UnaryNegation
        }

        static readonly string[] floatTypes = { "float", "float2", "float3", "float4" };
        static readonly string[] intTypes = { "int", "int2", "int3", "int4" };
        static readonly string[] uintTypes = { "uint", "uint2", "uint3", "uint4" };
        static readonly string[] boolTypes = { "bool", "bool2", "bool3", "bool4" };
        static readonly string[] components = { "x", "y", "z", "w" };
        static readonly string[] fields = { "x", "y", "z", "w" };

        private struct GeneratorJob
        {
            public Features features;
            public string[] typeNames;
            public string indexOperatorReturnType;
        }

        private static readonly GeneratorJob[] s_Jobs = new[]
        {
            new GeneratorJob { indexOperatorReturnType = "float", typeNames = floatTypes, features = Features.Arithmetic | Features.UnaryNegation },
            new GeneratorJob { indexOperatorReturnType = "int", typeNames = intTypes, features = Features.All },
            new GeneratorJob { indexOperatorReturnType = "uint", typeNames = uintTypes, features = Features.All & ~Features.UnaryNegation },
            new GeneratorJob { indexOperatorReturnType = "bool1", typeNames = boolTypes, features = Features.BitwiseLogic },
        };

        private VectorGenerator(GeneratorJob job)
        {
            m_Job = job;
            m_Types = m_Job.typeNames;
        }

        public static void Write(string dir)
        {
            foreach (GeneratorJob job in s_Jobs)
            {
                var typeNames = job.typeNames;
                for (int i = 1; i < typeNames.Length; i++)
                {
                    StringBuilder builder = new StringBuilder();
                    VectorGenerator gen = new VectorGenerator(job);

                    gen.Generate(i + 1, builder);

                    var text = builder.ToString();
                    // Convert all tabs to spaces
                    text = text.Replace("\t", "    ");
                    // Convert all EOL to platform EOL
                    text = text.Replace("\n", Environment.NewLine);

                    System.IO.File.WriteAllText(dir + "/" + typeNames[i] + ".gen.cs", text);

                }
            }
        }



        public void Generate(int count, StringBuilder str)
        {
            str.Append("// GENERATED CODE\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            str.Append("#pragma warning disable 0660, 0661\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");
            str.AppendFormat("\tpublic partial struct {0} : System.IEquatable<{0}>\n", m_Types[count - 1]);
            str.Append("\t{\n");

            GenerateOperators(count, str);
            GenerateSwizzles(count, str);

            str.Append("\t}\n");
            str.Append("}\n");
        }

        public void GenerateOperators(int count, StringBuilder str)
        {
            string resultType = m_Types[count - 1];
            string resultBoolType = boolTypes[count - 1];

            if (0 != (m_Job.features & Features.Arithmetic))
            {
                str.Append("\n\t\t// mul\n");
                GenerateBinaryOperator(count, "*", count, resultType, str);

                str.Append("\n\t\t// add\n");
                GenerateBinaryOperator(count, "+", count, resultType, str);

                str.Append("\n\t\t// sub\n");
                GenerateBinaryOperator(count, "-", count, resultType, str);

                str.Append("\n\t\t// div\n");
                GenerateBinaryOperator(count, "/", count, resultType, str);

                str.Append("\n\t\t// smaller \n");
                GenerateBinaryOperator(count, "<", count, resultBoolType, str);
                GenerateBinaryOperator(count, "<=", count, resultBoolType, str);

                str.Append("\n\t\t// greater \n");
                GenerateBinaryOperator(count, ">", count, resultBoolType, str);
                GenerateBinaryOperator(count, ">=", count, resultBoolType, str);
            }

            if (0 != (m_Job.features & Features.UnaryNegation))
            {
                str.Append("\n\t\t// neg \n");
                GenerateUnaryOperator(count, "-", str);

                str.Append("\n\t\t// plus \n");
                GenerateUnaryOperator(count, "+", str);
            }

            if (0 != (m_Job.features & Features.Shifts))
            {
                str.Append("\n\t\t// left shift\n");
                GenerateShiftOperator(count, "<<", count, resultType, str);

                str.Append("\n\t\t// right shift\n");
                GenerateShiftOperator(count, ">>", count, resultType, str);
            }

            str.Append("\n\t\t// equal \n");
            GenerateBinaryOperator(count, "==", count, resultBoolType, str);


            str.Append("\n\t\t// not equal \n");
            GenerateBinaryOperator(count, "!=", count, resultBoolType, str);

            str.Append("\n\t\t// Equals \n");
            GenerateEquals(count, resultType, str);

            str.Append("\n\t\t// [int index] \n");
            GenerateIndexOperator(count, resultType, m_Job.indexOperatorReturnType, str);

            if (0 != (m_Job.features & Features.BitwiseLogic))
            {
                string[] binaryOps = { "&", "|", "^" };
                foreach (string binOp in binaryOps)
                {
                    str.AppendFormat("\n\t\t// operator {0}\n", binOp);
                    GenerateBinaryOperator(count, binOp, count, resultType, str);
                }

            }

            if (0 != (m_Job.features & Features.BitwiseComplement))
            {
                str.Append("\n\t\t// operator ~ \n");
                GenerateUnaryOperator(count, "~", str);
            }
        }

        void GenerateBinaryOperator(int count, string op, int resultCount, string resultType, StringBuilder str)
        {
            GenerateBinaryOperator(count - 1, count - 1, op, resultCount, resultType, str);
            GenerateBinaryOperatorScalarRhs(count, op, resultCount, resultType, str);
            GenerateBinaryOperator(0, count - 1, op, resultCount, resultType, str);
        }

        void GenerateBinaryOperatorScalarRhs(int count, string op, int resultCount, string resultType, StringBuilder str)
        {
            GenerateBinaryOperator(count - 1, 0, op, resultCount, resultType, str);
        }

        void GenerateBinaryOperator(int lhsTypeIndex, int rhsTypeIndex, string op, int resultCount, string resultType, StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(0x100)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({2} lhs, {3} rhs)", resultType, op, m_Types[lhsTypeIndex], m_Types[rhsTypeIndex]);
            str.Append(" { ");
            str.AppendFormat("return new {0} (", resultType);

            for (int i = 0; i < resultCount; i++)
            {
                if (lhsTypeIndex == 0)
                {
                    int rhsIndex = i;
                    str.AppendFormat("lhs {1} rhs.{0}", fields[rhsIndex], op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
                else if (rhsTypeIndex == 0)
                {
                    int lhsIndex = i;
                    str.AppendFormat("lhs.{0} {1} rhs", fields[lhsIndex], op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
                else
                {
                    int lhsIndex = i;
                    int rhsIndex = i;

                    str.AppendFormat("lhs.{0} {2} rhs.{1}", fields[lhsIndex], fields[rhsIndex], op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
            }


            str.Append("); }\n");
        }

        void GenerateIndexOperator(int count, string vectorType, string indexOperatorReturnType, StringBuilder str)
        {
            str.AppendFormat("\t\tunsafe public {0} this[int index]\n", indexOperatorReturnType);
            str.AppendLine("\t\t{");
            str.AppendLine("\t\t\tget");
            str.AppendLine("\t\t\t{");
            str.AppendLine("#if ENABLE_UNITY_COLLECTIONS_CHECKS");
            str.AppendFormat("\t\t\t\tif ((uint)index >= {0})\n", count);
            str.AppendFormat("\t\t\t\t\tthrow new System.ArgumentException(\"index must be between[0...{0}]\");\n", count - 1);
            str.AppendLine("#endif");
            // To workaround an undefined behavior with taking the fixed address of a struct field (that could be allocated on the stack)
            // we are fixing this instead of a field
            // See issue https://github.com/dotnet/coreclr/issues/16210
            str.Append("\t\t\t\tfixed (");
            str.Append(vectorType);
            str.Append("* array = &this) { return ((").Append(indexOperatorReturnType).Append("*)array)[index]; }\n");
            str.AppendLine("\t\t\t}");
            str.AppendLine("\t\t\tset");
            str.AppendLine("\t\t\t{");
            str.AppendLine("#if ENABLE_UNITY_COLLECTIONS_CHECKS");
            str.AppendFormat("\t\t\t\tif ((uint)index >= {0})\n", count);
            str.AppendFormat("\t\t\t\t\tthrow new System.ArgumentException(\"index must be between[0...{0}]\");\n", count - 1);
            str.AppendLine("#endif");
            str.Append("\t\t\t\tfixed (");
            str.Append(indexOperatorReturnType);
            str.Append("* array = &x) { array[index] = value; }\n");
            str.AppendLine("\t\t\t}");
            str.AppendLine("\t\t}");

        }

        void GenerateEquals(int resultCount, string resultType, StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(0x100)]\n");
            str.AppendFormat("\t\tpublic bool Equals({0} rhs) ", resultType);
            str.Append(" { ");
            str.AppendFormat("return ", resultType);

            for (int i = 0; i < resultCount; i++)
            {
                str.Append(fields[i] + " == rhs." + fields[i]);
                if (i != resultCount-1)
                    str.Append(" && ");
            }

            str.Append("; }\n");
        }


        void GenerateShiftOperator(int lhsTypeIndex, string op, int resultCount, string resultType, StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(0x100)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({2} lhs, int rhs)", resultType, op, m_Types[lhsTypeIndex - 1]);
            str.Append(" { ");
            str.AppendFormat("return new {0} (", resultType);

            for (int i = 0; i < resultCount; i++)
            {
                if (lhsTypeIndex == 0)
                {
                    str.AppendFormat("lhs {0} rhs", op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
                else
                {
                    int lhsIndex = i;
                    str.AppendFormat("lhs.{0} {1} rhs", fields[lhsIndex], op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
            }


            str.Append("); }\n");
        }

        void GenerateUnaryOperator(int count, string op, StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(0x100)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({0} val)", m_Types[count - 1], op);
            str.Append(" { ");
            str.AppendFormat("return new {0} (", m_Types[count - 1]);

            for (int i = 0; i < count; i++)
            {
                str.AppendFormat("{0}val.{1}", op, fields[i]);
                if (i != count - 1)
                    str.Append(", ");
            }

            str.Append("); }");
        }

        void GenerateSwizzles(int count, StringBuilder str)
        {
            // float4 swizzles
            {
                int[] swizzles = new int[4];
                for (int x = 0; x < count; x++)
                {
                    for (int y = 0; y < count; y++)
                    {
                        for (int z = 0; z < count; z++)
                        {
                            for (int w = 0; w < count; w++)
                            {
                                swizzles[0] = x;
                                swizzles[1] = y;
                                swizzles[2] = z;
                                swizzles[3] = w;

                                GenerateSwizzles(swizzles, str);
                            }
                        }
                    }
                }
            }

            // float3 swizzles
            {
                var swizzles = new int[3];
                for (int x = 0; x < count; x++)
                {
                    for (int y = 0; y < count; y++)
                    {
                        for (int z = 0; z < count; z++)
                        {
                            swizzles[0] = x;
                            swizzles[1] = y;
                            swizzles[2] = z;

                            GenerateSwizzles(swizzles, str);
                        }
                    }
                }
            }

            // float2 swizzles
            {
                var swizzles = new int[2];
                for (int x = 0; x < count; x++)
                {
                    for (int y = 0; y < count; y++)
                    {
                        swizzles[0] = x;
                        swizzles[1] = y;

                        GenerateSwizzles(swizzles, str);
                    }
                }
            }
        }

        void GenerateSwizzles(int[] swizzle, StringBuilder str)
        {
            int bits = 0;
            bool allowSetter = true;
            for (int i = 0; i < swizzle.Length; i++)
            {
                int bit = 1 << swizzle[i];
                if ((bits & bit) != 0)
                    allowSetter = false;

                bits |= 1 << swizzle[i];
            }

            bool hideAutoComplete = true;

            if (hideAutoComplete)
                str.Append("\t\t[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]\n");

            str.Append("\t\tpublic ");
            str.Append(m_Types[swizzle.Length - 1]);
            str.Append(' ');

            for (int i = 0; i < swizzle.Length; i++)
                str.Append(components[swizzle[i]]);

            // Getter

            str.Append("\n\t\t{");
            if (swizzle.Length != 1)
            {
                str.AppendFormat("\n\t\t\t[MethodImpl(0x100)]");
                str.Append("\n\t\t\tget { return new ");
                str.Append(m_Types[swizzle.Length - 1]);
                str.Append('(');
            }
            else
                str.Append("\n\t\t\tget { return ");

            for (int i = 0; i < swizzle.Length; i++)
            {
                str.Append(fields[swizzle[i]]);

                if (i != swizzle.Length - 1)
                    str.Append(", ");
            }

            if (swizzle.Length != 1)
                str.Append("); }");
            else
                str.Append("; }");

            //Setter
            if (allowSetter)
            {
                str.AppendFormat("\n\t\t\t[MethodImpl(0x100)]");
                str.Append("\n\t\t\tset { ");
                for (int i = 0; i < swizzle.Length; i++)
                {
                    str.Append(fields[swizzle[i]]);
                    if (swizzle.Length != 1)
                    {
                        str.Append(" = value.");
                        str.Append(fields[i]);
                    }
                    else
                    {
                        str.Append(" = value");
                    }

                    str.Append("; ");

                }

                str.Append("}");

            }

            str.Append("\n\t\t}\n\n");
            str.Append("\n");
        }

    }
}
