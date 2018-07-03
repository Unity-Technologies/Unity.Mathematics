using System;
using System.Text;

namespace Unity.Mathematics.Mathematics.CodeGen
{
    class VectorGenerator
    {
        private string m_BaseType;
        private string m_TypeName;
        private int m_Rows;
        private int m_Columns;
        private Features m_Features;

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

        static readonly string[] components = { "x", "y", "z", "w" };
        static readonly string[] vectorFields = { "x", "y", "z", "w" };
        static readonly string[] matrixFields = { "c0", "c1", "c2", "c3" };

        public static string ToTypeName(string baseType, int rows, int columns)
        {
            string name = baseType;
            if (rows > 1)
                name += rows;
            if (columns > 1)
                name += "x" + columns;
            return name;
        }

        private void Write(string dir, string baseType, int rows, int columns, Features features)
        {
            m_BaseType = baseType;
            m_TypeName = ToTypeName(baseType, rows, columns);
            m_Rows = rows;
            m_Columns = columns;
            m_Features = features;

            StringBuilder str = new StringBuilder();
            
            Generate(str);

            var text = str.ToString();
            // Convert all tabs to spaces
            text = text.Replace("\t", "    ");
            // Normalize line endings, convert all EOL to platform EOL (and let git handle it)
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);

            System.IO.File.WriteAllText(dir + "/" + m_TypeName + ".gen.cs", text);
        }


        public static void Write(string dir)
        {
            VectorGenerator vectorGenerator = new VectorGenerator();
            vectorGenerator.Write(dir, "float", 2, 1, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write(dir, "float", 2, 1, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write(dir, "float", 3, 1, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write(dir, "float", 4, 1, Features.Arithmetic | Features.UnaryNegation);

            vectorGenerator.Write(dir, "float", 2, 2, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write(dir, "float", 3, 3, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write(dir, "float", 4, 4, Features.Arithmetic | Features.UnaryNegation);

            vectorGenerator.Write(dir, "int", 2, 1, Features.All);
            vectorGenerator.Write(dir, "int", 3, 1, Features.All);
            vectorGenerator.Write(dir, "int", 4, 1, Features.All);

            vectorGenerator.Write(dir, "int", 2, 2, Features.All);
            vectorGenerator.Write(dir, "int", 3, 3, Features.All);
            vectorGenerator.Write(dir, "int", 4, 4, Features.All);

            vectorGenerator.Write(dir, "uint", 2, 1, Features.All);
            vectorGenerator.Write(dir, "uint", 3, 1, Features.All);
            vectorGenerator.Write(dir, "uint", 4, 1, Features.All);

            vectorGenerator.Write(dir, "uint", 2, 2, Features.All);
            vectorGenerator.Write(dir, "uint", 3, 3, Features.All);
            vectorGenerator.Write(dir, "uint", 4, 4, Features.All);

            vectorGenerator.Write(dir, "bool", 2, 1, Features.BitwiseLogic);
            vectorGenerator.Write(dir, "bool", 3, 1, Features.BitwiseLogic);
            vectorGenerator.Write(dir, "bool", 4, 1, Features.BitwiseLogic);

            vectorGenerator.Write(dir, "bool", 2, 2, Features.BitwiseLogic);
            vectorGenerator.Write(dir, "bool", 3, 3, Features.BitwiseLogic);
            vectorGenerator.Write(dir, "bool", 4, 4, Features.BitwiseLogic);
        }


        private void Generate(StringBuilder str)
        {
            StringBuilder staticConstructorStr = new StringBuilder();

            str.Append("// GENERATED CODE\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            str.Append("#pragma warning disable 0660, 0661\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");
            str.AppendFormat("\tpublic partial struct {0} : System.IEquatable<{0}>\n", m_TypeName);
            str.Append("\t{\n");

            GenerateConstructors(str, staticConstructorStr);
            GenerateOperators(str);
            if(m_Columns == 1)
                GenerateSwizzles(str);

            str.Append("\t}\n\n");

            str.Append("\tpublic static partial class math\n");
            str.Append("\t{\n");
            str.Append(staticConstructorStr);
            str.Append("\t}\n}\n");
        }


        private string GenerateComponentRangeString(int componentIndex, int numComponents)
        {
            string result = "";
            for(int i = 0; i < numComponents; i++)
            {
                result += components[componentIndex + i];
            }
            return result;
        }

        // Generate constructor and static constructor with a given component partitioning of input parameters
        private void GenerateVectorConstructor(int numComponents, int numParameters, int[] parameterComponents, StringBuilder constructorStr, StringBuilder staticConstructorStr)
        {
            // Generate signatures
            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            staticConstructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            staticConstructorStr.Append("\t\tpublic static ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append(" ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append("(");

            int componentIndex = 0;
            for (int i = 0; i < numParameters; i++)
            {
                if (i != 0)
                {
                    constructorStr.Append(", ");
                    staticConstructorStr.Append(", ");
                }

                
                int paramComponents = parameterComponents[i];
                string paramType = ToTypeName(m_BaseType, paramComponents, 1);
                string componentString = GenerateComponentRangeString(componentIndex, paramComponents);

                constructorStr.Append(paramType);
                constructorStr.Append(" ");
                constructorStr.Append(componentString);
                staticConstructorStr.Append(paramType);
                staticConstructorStr.Append(" ");
                staticConstructorStr.Append(componentString);
                componentIndex += paramComponents;
            }
            constructorStr.Append(")\n");
            staticConstructorStr.Append(")");
            
            // Generate function bodies
            constructorStr.Append("\t\t{ ");
            staticConstructorStr.Append(" { return new ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append("(");

            componentIndex = 0;
            for (int i = 0; i < numParameters; i++)
            {
                int paramComponents = parameterComponents[i];
                string componentString = GenerateComponentRangeString(componentIndex, paramComponents);
                for (int j = 0; j < paramComponents; j++)
                {
                    constructorStr.Append("\n\t\t\tthis.");
                    constructorStr.Append(components[componentIndex]);
                    constructorStr.Append(" = ");
                    constructorStr.Append(componentString);
                    if (paramComponents > 1)
                    {
                        constructorStr.Append(".");
                        constructorStr.Append(components[j]);
                    }
                    constructorStr.Append(";");
                    componentIndex++;
                }

                if (i != 0)
                {
                    staticConstructorStr.Append(", ");
                }
                staticConstructorStr.Append(componentString);
            }

            constructorStr.Append("\n\t\t}\n\n");
            staticConstructorStr.Append("); }\n\n");
        }

        // Recursively generate all constructor variants with every possibly partition or the components
        private void GenerateVectorConstructors(int numRemainingComponents, int numComponents, int numParameters, int[] parameterComponents, StringBuilder constructorStr, StringBuilder staticConstructorStr)
        {
            if (numRemainingComponents == 0)
            {
                GenerateVectorConstructor(numComponents, numParameters, parameterComponents, constructorStr, staticConstructorStr);
            }
            
            for(int i = 1; i <= numRemainingComponents; i++)
            {
                parameterComponents[numParameters] = i;
                GenerateVectorConstructors(numRemainingComponents - i, numComponents, numParameters + 1, parameterComponents, constructorStr, staticConstructorStr);
            }
        }

        public void GenerateMatrixColumnConstructor(StringBuilder constructorStr, StringBuilder staticConstructorStr)
        {
            // Generate signatures
            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            staticConstructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            staticConstructorStr.Append("\t\tpublic static ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append(" ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append("(");

            string columnType = ToTypeName(m_BaseType, m_Rows, 1);
            for (int column = 0; column < m_Columns; column++)
            {
                if (column != 0)
                {
                    constructorStr.Append(", ");
                    staticConstructorStr.Append(", ");
                }

                constructorStr.Append(columnType);
                constructorStr.Append(" ");
                constructorStr.Append(matrixFields[column]);
                staticConstructorStr.Append(columnType);
                staticConstructorStr.Append(" ");
                staticConstructorStr.Append(matrixFields[column]);
            }
            constructorStr.Append(")\n");
            staticConstructorStr.Append(")");

            // Generate function bodies
            constructorStr.Append("\t\t{ ");
            staticConstructorStr.Append(" { return new ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append("(");

            for (int column = 0; column < m_Columns; column++)
            {
                constructorStr.Append("\n\t\t\tthis.");
                constructorStr.Append(matrixFields[column]);
                constructorStr.Append(" = ");
                constructorStr.Append(matrixFields[column]);
                constructorStr.Append(";");

                if (column != 0)
                {
                    staticConstructorStr.Append(", ");
                }
                staticConstructorStr.Append(matrixFields[column]);
            }

            constructorStr.Append("\n\t\t}\n\n");
            staticConstructorStr.Append("); }\n\n");
        }

        public void GenerateMatrixRowConstructor(StringBuilder constructorStr, StringBuilder staticConstructorStr)
        {
            // Generate signatures
            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            staticConstructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            staticConstructorStr.Append("\t\tpublic static ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append(" ");
            staticConstructorStr.Append(m_TypeName);
            staticConstructorStr.Append("(");
            string indent0 = new string(' ', m_TypeName.Length + 16);
            string indent1 = new string(' ', m_TypeName.Length*2 + 24);
            string indent2 = new string(' ', m_TypeName.Length + 24);

            for (int row = 0; row < m_Rows; row++)
            {
                if(row != 0)
                {
                    constructorStr.Append(indent0);
                    staticConstructorStr.Append(indent1);
                }
                for (int column = 0; column < m_Columns; column++)
                {
                    string paramName = "m" + row + column;
                    constructorStr.Append(m_BaseType);
                    constructorStr.Append(" ");
                    constructorStr.Append(paramName);
                    staticConstructorStr.Append(m_BaseType);
                    staticConstructorStr.Append(" ");
                    staticConstructorStr.Append(paramName);

                    //string separator = (row == m_Rows - 1) ? (column == m_Columns - 1) ? "," : ", " : ", ";
                    string separator = (column == m_Columns - 1) ? (row == m_Rows - 1) ? ")\n" : ",\n" : ", ";
                    constructorStr.Append(separator);
                    staticConstructorStr.Append(separator);
                }
            }
            
            string columnType = ToTypeName(m_BaseType, m_Rows, 1);

            // constructor body
            constructorStr.Append("\t\t{ ");
            for (int column = 0; column < m_Columns; column++)
            {
                constructorStr.AppendFormat("\n\t\t\tthis.{0} = new {1}(", matrixFields[column], columnType);
                
                for (int row = 0; row < m_Rows; row++)
                {
                    constructorStr.Append("m" + row + column);
                    
                    if (row != m_Rows - 1)
                    {
                        constructorStr.Append(", ");
                    }
                }

                constructorStr.Append(");");
            }
            constructorStr.Append("\n\t\t}\n\n");

            // static constructor body
            staticConstructorStr.AppendFormat("\t\t{{\n\t\t\treturn new {0}(", m_TypeName);
            for (int row = 0; row < m_Rows; row++)
            {
                if (row != 0)
                {
                    staticConstructorStr.Append(indent2);
                }
                for (int column = 0; column < m_Columns; column++)
                {
                    string paramName = "m" + row + column;
                    staticConstructorStr.Append(paramName);

                    //string separator = (row == m_Rows - 1) ? (column == m_Columns - 1) ? "," : ", " : ", ";
                    string separator = (column == m_Columns - 1) ? (row == m_Rows - 1) ? ");" : ",\n" : ", ";
                    staticConstructorStr.Append(separator);
                }
            }
            staticConstructorStr.Append("\n\t\t}\n\n");
        }

        public void GenerateMatrixConstructors(StringBuilder constructorStr, StringBuilder staticConstructorStr)
        {
            GenerateMatrixColumnConstructor(constructorStr, staticConstructorStr);
            GenerateMatrixRowConstructor(constructorStr, staticConstructorStr);
        }

        public void GenerateConstructors(StringBuilder constructorStr, StringBuilder staticConstructorStr)
        {
            constructorStr.Append("\t\t// constructors\n");
            
            if(m_Columns == 1)
            {
                int[] parameterComponenets = new int[4];
                GenerateVectorConstructors(m_Rows, m_Rows, 0, parameterComponenets, constructorStr, staticConstructorStr);
            }
            else
            {
                GenerateMatrixConstructors(constructorStr, staticConstructorStr);
            }
        }
        
        public void GenerateOperators(StringBuilder str)
        {
            string resultType = m_BaseType;
            string resultBoolType = "bool";
            
            if (0 != (m_Features & Features.Arithmetic))
            {
                str.Append("\n\t\t// mul\n");
                GenerateBinaryOperator(m_Rows, m_Columns, "*", resultType, str);

                str.Append("\n\t\t// add\n");
                GenerateBinaryOperator(m_Rows, m_Columns, "+", resultType, str);

                str.Append("\n\t\t// sub\n");
                GenerateBinaryOperator(m_Rows, m_Columns, "-", resultType, str);

                str.Append("\n\t\t// div\n");
                GenerateBinaryOperator(m_Rows, m_Columns, "/", resultType, str);

                str.Append("\n\t\t// smaller \n");
                GenerateBinaryOperator(m_Rows, m_Columns, "<", resultBoolType, str);
                GenerateBinaryOperator(m_Rows, m_Columns, "<=", resultBoolType, str);

                str.Append("\n\t\t// greater \n");
                GenerateBinaryOperator(m_Rows, m_Columns, ">", resultBoolType, str);
                GenerateBinaryOperator(m_Rows, m_Columns, ">=", resultBoolType, str);
            }

            if (0 != (m_Features & Features.UnaryNegation))
            {
                str.Append("\n\t\t// neg \n");
                GenerateUnaryOperator("-", str);

                str.Append("\n\t\t// plus \n");
                GenerateUnaryOperator("+", str);
            }

            if (0 != (m_Features & Features.Shifts))
            {
                str.Append("\n\t\t// left shift\n");
                GenerateShiftOperator(m_Rows, "<<", resultType, str);

                str.Append("\n\t\t// right shift\n");
                GenerateShiftOperator(m_Rows, ">>", resultType, str);
            }

            str.Append("\n\t\t// equal \n");
            GenerateBinaryOperator(m_Rows, m_Columns, "==", resultBoolType, str);


            str.Append("\n\t\t// not equal \n");
            GenerateBinaryOperator(m_Rows, m_Columns, "!=", resultBoolType, str);

            str.Append("\n\t\t// Equals \n");
            GenerateEquals(str);

            str.Append("\n\t\t// [int index] \n");
            GenerateIndexOperator(str);

            if (0 != (m_Features & Features.BitwiseLogic))
            {
                string[] binaryOps = { "&", "|", "^" };
                foreach (string binOp in binaryOps)
                {
                    str.AppendFormat("\n\t\t// operator {0}\n", binOp);
                    GenerateBinaryOperator(m_Rows, m_Columns, binOp, resultType, str);
                }

            }

            if (0 != (m_Features & Features.BitwiseComplement))
            {
                str.Append("\n\t\t// operator ~ \n");
                GenerateUnaryOperator("~", str);
            }
        }

        void GenerateBinaryOperator(int rows, int columns, string op, string resultType, StringBuilder str)
        {
            GenerateBinaryOperator(rows, columns, rows, columns, op, resultType, rows, columns, str);
            GenerateBinaryOperator(rows, columns, 1, 1, op, resultType, rows, columns, str);
            GenerateBinaryOperator(1, 1, rows, columns, op, resultType, rows, columns, str);
        }

        void GenerateBinaryOperator(int lhsRows, int lhsColumns, int rhsRows, int rhsColumns, string op, string resultType, int resultRows, int resultColumns, StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({2} lhs, {3} rhs)", ToTypeName(resultType, resultRows, resultColumns), op, ToTypeName(m_BaseType, lhsRows, lhsColumns), ToTypeName(m_BaseType, rhsRows, rhsColumns));
            str.Append(" { ");
            str.AppendFormat("return new {0} (", ToTypeName(resultType, resultRows, resultColumns));

            string[] fields = (resultColumns > 1) ? matrixFields : vectorFields;
            int resultCount = (resultColumns > 1) ? resultColumns : resultRows;

            for (int i = 0; i < resultCount; i++)
            {
                if (lhsRows == 1)
                {
                    int rhsIndex = i;
                    str.AppendFormat("lhs {1} rhs.{0}", fields[rhsIndex], op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
                else if (rhsRows == 1)
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

        void GenerateIndexOperator(StringBuilder str)
        {
            int count = m_Columns > 1 ? m_Columns : m_Rows;
            string returnType = ToTypeName(m_BaseType, m_Columns > 1 ? m_Rows : 1, 1);
            
            str.AppendFormat("\t\tunsafe public {0} this[int index]\n", returnType);
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
            str.Append(m_TypeName);
            str.Append("* array = &this) { return ((");
            str.Append(returnType);
            str.Append("*)array)[index]; }\n");
            str.AppendLine("\t\t\t}");
            str.AppendLine("\t\t\tset");
            str.AppendLine("\t\t\t{");
            str.AppendLine("#if ENABLE_UNITY_COLLECTIONS_CHECKS");
            str.AppendFormat("\t\t\t\tif ((uint)index >= {0})\n", count);
            str.AppendFormat("\t\t\t\t\tthrow new System.ArgumentException(\"index must be between[0...{0}]\");\n", count - 1);
            str.AppendLine("#endif");
            str.Append("\t\t\t\tfixed (");
            str.Append(returnType);
            str.Append("* array = &");
            str.Append(m_Columns > 1 ? "c0" : "x");
            str.Append(") { array[index] = value; }\n");
            str.AppendLine("\t\t\t}");
            str.AppendLine("\t\t}");

        }

        void GenerateEquals(StringBuilder str)
        {
            string[] fields = (m_Columns > 1) ? matrixFields : vectorFields;
            int resultCount = (m_Columns > 1) ? m_Columns : m_Rows;

            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic bool Equals({0} rhs) ", m_TypeName);
            str.Append(" { return ");

            for (int i = 0; i < resultCount; i++)
            {
                if (m_Columns == 1)
                    str.AppendFormat("{0} == rhs.{0}", fields[i]);
                else
                    str.AppendFormat("{0}.Equals(rhs.{0})", fields[i]);
                if (i != resultCount-1)
                    str.Append(" && ");
            }

            str.Append("; }\n");
        }


        void GenerateShiftOperator(int lhsRows, string op, string resultBaseType, StringBuilder str)
        {
            string[] fields = (m_Columns > 1) ? matrixFields : vectorFields;
            int resultCount = (m_Columns > 1) ? m_Columns : m_Rows;

            string resultType = ToTypeName(resultBaseType, resultCount, 1);
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({0} lhs, int rhs)", m_TypeName, op);
            str.Append(" { ");
            str.AppendFormat("return new {0} (", m_TypeName);

            for (int i = 0; i < resultCount; i++)
            {
                if (lhsRows == 1)
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

        void GenerateUnaryOperator(string op, StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({0} val)", m_TypeName, op);
            str.Append(" { ");
            str.AppendFormat("return new {0} (", m_TypeName);

            string[] fields = (m_Columns > 1) ? matrixFields : vectorFields;
            int resultCount = (m_Columns > 1) ? m_Columns : m_Rows;

            for (int i = 0; i < resultCount; i++)
            {
                if(op == "-" && m_BaseType == "uint" && m_Columns == 1)
                    str.AppendFormat("(uint){0}val.{1}", op, fields[i]);
                else
                    str.AppendFormat("{0}val.{1}", op, fields[i]);
                if (i != m_Rows - 1)
                    str.Append(", ");
            }

            str.Append("); }");
        }

        void GenerateSwizzles(StringBuilder str)
        {
            int count = m_Rows;
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
            str.Append(ToTypeName(m_BaseType, swizzle.Length, 1));
            str.Append(' ');

            for (int i = 0; i < swizzle.Length; i++)
                str.Append(components[swizzle[i]]);

            // Getter

            str.Append("\n\t\t{");
            if (swizzle.Length != 1)
            {
                str.AppendFormat("\n\t\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                str.Append("\n\t\t\tget { return new ");
                str.Append(ToTypeName(m_BaseType, swizzle.Length, 1));
                str.Append('(');
            }
            else
                str.Append("\n\t\t\tget { return ");

            for (int i = 0; i < swizzle.Length; i++)
            {
                str.Append(components[swizzle[i]]);

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
                str.AppendFormat("\n\t\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]");
                str.Append("\n\t\t\tset { ");
                for (int i = 0; i < swizzle.Length; i++)
                {
                    str.Append(components[swizzle[i]]);
                    if (swizzle.Length != 1)
                    {
                        str.Append(" = value.");
                        str.Append(components[i]);
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
