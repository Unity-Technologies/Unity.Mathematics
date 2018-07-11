using System;
using System.Linq;
using System.Text;

namespace Unity.Mathematics.Mathematics.CodeGen
{
    class VectorGenerator
    {
        private string m_ImplementationDirectory;
        private string m_TestDirectory;
        private string m_BaseType;
        private string m_TypeName;
        private int m_Rows;
        private int m_Columns;
        private Features m_Features;
        private uint[] m_primes = new uint[] {  0x6E624EB7u,    0x7383ED49u,    0xDD49C23Bu,    0xEBD0D005u,            0x91475DF7u,    0x55E84827u,    0x90A285BBu,    0x5D19E1D5u,
                                                0xFAAF07DDu,    0x625C45BDu,    0xC9F27FCBu,    0x6D2523B1u,            0x6E2BF6A9u,    0xCC74B3B7u,    0x83B58237u,    0x833E3E29u,
                                                0xA9D919BFu,    0xC3EC1D97u,    0xB8B208C7u,    0x5D3ED947u,            0x4473BBB1u,    0xCBA11D5Fu,    0x685835CFu,    0xC3D32AE1u,
                                                0xB966942Fu,    0xFE9856B3u,    0xFA3A3285u,    0xAD55999Du,            0xDCDD5341u,    0x94DDD769u,    0xA1E92D39u,    0x4583C801u,
                                                0x9536A0F5u,    0xAF816615u,    0x9AF8D62Du,    0xE3600729u,            0x5F17300Du,    0x670D6809u,    0x7AF32C49u,    0xAE131389u,
                                                0x5D1B165Bu,    0x87096CD7u,    0x4C7F6DD1u,    0x4822A3E9u,            0xAAC3C25Du,    0xD21D0945u,    0x88FCAB2Du,    0x614DA60Du,
                                                0x5BA2C50Bu,    0x8C455ACBu,    0xCD266C89u,    0xF1852A33u,            0x77E35E77u,    0x863E3729u,    0xE191B035u,    0x68586FAFu,
                                                0xD4DFF6D3u,    0xCB634F4Du,    0x9B13B92Du,    0x4ABF0813u,            0x86068063u,    0xD75513F9u,    0x5AB3E8CDu,    0x676E8407u,
                                                0xB36DE767u,    0x6FCA387Du,    0xAF0F3103u,    0xE4A056C7u,            0x841D8225u,    0xC9393C7Du,    0xD42EAFA3u,    0xD9AFD06Du,
                                                0x97A65421u,    0x7809205Fu,    0x9C9F0823u,    0x5A9CA13Bu,            0xAFCDD5EFu,    0xA88D187Du,    0xCF6EBA1Du,    0x9D88E5A1u,
                                                0xEADF0775u,    0x747A9D7Bu,    0x4111F799u,    0xB5F05AF1u,            0xFD80290Bu,    0x8B65ADB7u,    0xDFF4F563u,    0x7069770Du,
                                                0xD1224537u,    0xE99ED6F3u,    0x48125549u,    0xEEE2123Bu,            0xE3AD9FE5u,    0xCE1CF8BFu,    0x7BE39F3Bu,    0xFAB9913Fu,
                                                0xB4501269u,    0xE04B89FDu,    0xDB3DE101u,    0x7B6D1B4Bu,            0x58399E77u,    0x5EAC29C9u,    0xFC6014F9u,    0x6BF6693Fu,
                                                0x9D1B1D9Bu,    0xF842F5C1u,    0xA47EC335u,    0xA477DF57u,            0xC4B1493Fu,    0xBA0966D3u,    0xAFBEE253u,    0x5B419C01u,
                                                0x515D90F5u,    0xEC9F68F3u,    0xF9EA92D5u,    0xC2FAFCB9u,            0x616E9CA1u,    0xC5C5394Bu,    0xCAE78587u,    0x7A1541C9u,
                                                0xF83BD927u,    0x6A243BCBu,    0x509B84C9u,    0x91D13847u,            0x52F7230Fu,    0xCF286E83u,    0xE121E6ADu,    0xC9CA1249u,
                                                0x69B60C81u,    0xE0EB6C25u,    0xF648BEABu,    0x6BDB2B07u,            0xEF63C699u,    0x9001903Fu,    0xA895B9CDu,    0x9D23B201u,
                                                0x4B01D3E1u,    0x7461CA0Du,    0x79725379u,    0xD6258E5Bu,            0xEE390C97u,    0x9C8A2F05u,    0x4DDC6509u,    0x7CF083CBu,
                                                0x5C4D6CEDu,    0xF9137117u,    0xE857DCE1u,    0xF62213C5u,            0x9CDAA959u,    0xAA269ABFu,    0xD54BA36Fu,    0xFD0847B9u,
                                                0x8189A683u,    0xB139D651u,    0xE7579997u,    0xEF7D56C7u,            0x66F38F0Bu,    0x624256A3u,    0x5292ADE1u,    0xD2E590E5u,
                                                0xF25BE857u,    0x9BC17CE7u,    0xC8B86851u,    0x64095221u,            0xADF428FFu,    0xA3977109u,    0x745ED837u,    0x9CDC88F5u,
                                                0xFA62D721u,    0x7E4DB1CFu,    0x68EEE0F5u,    0xBC3B0A59u,            0x816EFB5Du,    0xA24E82B7u,    0x45A22087u,    0xFC104C3Bu,
                                                0x5FFF6B19u,    0x5E6CBF3Bu,    0xB546F2A5u,    0xBBCF63E7u,            0xC53F4755u,    0x6985C229u,    0xE133B0B3u,    0xC3E0A3B9u,
                                                0xFE31134Fu,    0x712A34D7u,    0x9D77A59Bu,    0x4942CA39u,            0xB40EC62Du,    0x565ED63Fu,    0x93C30C2Bu,    0xDCAF0351u,
                                                0x6E050B01u,    0x750FDBF5u,    0x7F3DD499u,    0x52EAAEBBu,            0x4599C793u,    0x83B5E729u,    0xC267163Fu,    0x67BC9149u,
                                                0xAD7C5EC1u,    0x822A7D6Du,    0xB492BF15u,    0xD37220E3u,            0x7AA2C2BDu,    0xE16BC89Du,    0x7AA07CD3u,    0xAF642BA9u,
                                                0xA8F2213Bu,    0x9F3FDC37u,    0xAC60D0C3u,    0x9263662Fu,            0xE69626FFu,    0xBD010EEBu,    0x9CEDE1D1u,    0x43BE0B51u,
                                                0xAF836EE1u,    0xB130C137u,    0x54834775u,    0x7C022221u,            0xA2D00EDFu,    0xA8977779u,    0x9F1C739Bu,    0x4B1BD187u,
                                                0x9DF50593u,    0xF18EEB85u,    0x9E19BFC3u,    0x8196B06Fu,            0xD24EFA19u,    0x7D8048BBu,    0x713BD06Fu,    0x753AD6ADu,
                                                0xD19764C7u,    0xB5D0BF63u,    0xF9102C5Fu,    0x9881FB9Fu,            0x56A1530Du,    0x804B722Du,    0x738E50E5u,    0x4FC93C25u,
                                                0xCD0445A5u,    0xD2B90D9Bu,    0xD35C9B2Du,    0xA10D9E27u,            0x568DAAA9u,    0x7530254Fu,    0x9F090439u,    0x5E9F85C9u,
                                                0x8C4CA03Fu,    0xB8D969EDu,    0xAC5DB57Bu,    0xA91A02EDu,            0xB3C49313u,    0xF43A9ABBu,    0x84E7E01Bu,    0x8E055BE5u
        };

        private uint nextPrime = 0;

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

        private static string UpperCaseFirstLetter(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void Write(string baseType, int rows, int columns, Features features)
        {
            m_BaseType = baseType;
            m_TypeName = ToTypeName(baseType, rows, columns);
            m_Rows = rows;
            m_Columns = columns;
            m_Features = features;

            // implementation
            StringBuilder str = new StringBuilder();
            GenerateImplementation(str);

            var text = str.ToString();
            // Convert all tabs to spaces
            text = text.Replace("\t", "    ");
            // Normalize line endings, convert all EOL to platform EOL (and let git handle it)
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);

            System.IO.File.WriteAllText(m_ImplementationDirectory + "/" + m_TypeName + ".gen.cs", text);

            // test
            str = new StringBuilder();
            GenerateTests(str);

            text = str.ToString();
            // Convert all tabs to spaces
            text = text.Replace("\t", "    ");
            // Normalize line endings, convert all EOL to platform EOL (and let git handle it)
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);

            System.IO.File.WriteAllText(m_TestDirectory + "/Test" + UpperCaseFirstLetter(m_TypeName) + ".gen.cs", text);
        }


        public static void Write(string implementationDirectory, string testDirectory)
        {
            VectorGenerator vectorGenerator = new VectorGenerator();
            vectorGenerator.m_ImplementationDirectory = implementationDirectory;
            vectorGenerator.m_TestDirectory = testDirectory;

            vectorGenerator.Write("float", 2, 1, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write("float", 2, 1, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write("float", 3, 1, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write("float", 4, 1, Features.Arithmetic | Features.UnaryNegation);

            vectorGenerator.Write("float", 2, 2, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write("float", 3, 3, Features.Arithmetic | Features.UnaryNegation);
            vectorGenerator.Write("float", 4, 4, Features.Arithmetic | Features.UnaryNegation);

            vectorGenerator.Write("int", 2, 1, Features.All);
            vectorGenerator.Write("int", 3, 1, Features.All);
            vectorGenerator.Write("int", 4, 1, Features.All);

            vectorGenerator.Write("int", 2, 2, Features.All);
            vectorGenerator.Write("int", 3, 3, Features.All);
            vectorGenerator.Write("int", 4, 4, Features.All);

            vectorGenerator.Write("uint", 2, 1, Features.All);
            vectorGenerator.Write("uint", 3, 1, Features.All);
            vectorGenerator.Write("uint", 4, 1, Features.All);

            vectorGenerator.Write("uint", 2, 2, Features.All);
            vectorGenerator.Write("uint", 3, 3, Features.All);
            vectorGenerator.Write("uint", 4, 4, Features.All);

            vectorGenerator.Write("bool", 2, 1, Features.BitwiseLogic);
            vectorGenerator.Write("bool", 3, 1, Features.BitwiseLogic);
            vectorGenerator.Write("bool", 4, 1, Features.BitwiseLogic);

            vectorGenerator.Write("bool", 2, 2, Features.BitwiseLogic);
            vectorGenerator.Write("bool", 3, 3, Features.BitwiseLogic);
            vectorGenerator.Write("bool", 4, 4, Features.BitwiseLogic);
        }


        private void GenerateImplementation(StringBuilder str)
        {
            StringBuilder mathStr = new StringBuilder();

            str.Append("// GENERATED CODE\n");
            str.Append("using System;\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            str.Append("#pragma warning disable 0660, 0661\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");
            str.AppendFormat("\tpublic partial struct {0} : System.IEquatable<{0}>", m_TypeName);
            if (m_BaseType != "bool")
                str.Append(", IFormattable");
            str.Append("\n\t{\n");

            GenerateConstructors(str, mathStr);
            GenerateOperators(str);
            GenerateHashFunction(mathStr);
            if(m_Columns == 1)
                GenerateSwizzles(str);

            str.Append("\n\t\t// [int index] \n");
            GenerateIndexOperator(str);

            str.Append("\n\t\t// Equals \n");
            GenerateEquals(str);

            str.Append("\n\t\t// GetHashCode \n");
            GenerateGetHashCode(str);

            str.Append("\n\t\t// ToString \n");
            GenerateToStringFunction(str, false);
            if(m_BaseType != "bool")
                GenerateToStringFunction(str, true);

            str.Append("\n\t}\n\n");

            str.Append("\tpublic static partial class math\n");
            str.Append("\t{\n");
            str.Append(mathStr);
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
        private void GenerateVectorConstructor(int numComponents, int numParameters, int[] parameterComponents, StringBuilder constructorStr, StringBuilder mathStr)
        {
            // Generate signatures
            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.Append("\t\tpublic static ");
            mathStr.Append(m_TypeName);
            mathStr.Append(" ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");

            int componentIndex = 0;
            for (int i = 0; i < numParameters; i++)
            {
                if (i != 0)
                {
                    constructorStr.Append(", ");
                    mathStr.Append(", ");
                }

                
                int paramComponents = parameterComponents[i];
                string paramType = ToTypeName(m_BaseType, paramComponents, 1);
                string componentString = GenerateComponentRangeString(componentIndex, paramComponents);

                constructorStr.Append(paramType);
                constructorStr.Append(" ");
                constructorStr.Append(componentString);
                mathStr.Append(paramType);
                mathStr.Append(" ");
                mathStr.Append(componentString);
                componentIndex += paramComponents;
            }
            constructorStr.Append(")\n");
            mathStr.Append(")");
            
            // Generate function bodies
            constructorStr.Append("\t\t{ ");
            mathStr.Append(" { return new ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");

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
                    mathStr.Append(", ");
                }
                mathStr.Append(componentString);
            }

            constructorStr.Append("\n\t\t}\n\n");
            mathStr.Append("); }\n\n");
        }

        // Recursively generate all constructor variants with every possibly partition or the components
        private void GenerateVectorConstructors(int numRemainingComponents, int numComponents, int numParameters, int[] parameterComponents, StringBuilder constructorStr, StringBuilder mathStr)
        {
            if (numRemainingComponents == 0)
            {
                GenerateVectorConstructor(numComponents, numParameters, parameterComponents, constructorStr, mathStr);
            }
            
            for(int i = 1; i <= numRemainingComponents; i++)
            {
                parameterComponents[numParameters] = i;
                GenerateVectorConstructors(numRemainingComponents - i, numComponents, numParameters + 1, parameterComponents, constructorStr, mathStr);
            }
        }

        public void GenerateMatrixColumnConstructor(StringBuilder constructorStr, StringBuilder mathStr)
        {
            // Generate signatures
            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.Append("\t\tpublic static ");
            mathStr.Append(m_TypeName);
            mathStr.Append(" ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");

            string columnType = ToTypeName(m_BaseType, m_Rows, 1);
            for (int column = 0; column < m_Columns; column++)
            {
                if (column != 0)
                {
                    constructorStr.Append(", ");
                    mathStr.Append(", ");
                }

                constructorStr.Append(columnType);
                constructorStr.Append(" ");
                constructorStr.Append(matrixFields[column]);
                mathStr.Append(columnType);
                mathStr.Append(" ");
                mathStr.Append(matrixFields[column]);
            }
            constructorStr.Append(")\n");
            mathStr.Append(")");

            // Generate function bodies
            constructorStr.Append("\t\t{ ");
            mathStr.Append(" { return new ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");

            for (int column = 0; column < m_Columns; column++)
            {
                constructorStr.Append("\n\t\t\tthis.");
                constructorStr.Append(matrixFields[column]);
                constructorStr.Append(" = ");
                constructorStr.Append(matrixFields[column]);
                constructorStr.Append(";");

                if (column != 0)
                {
                    mathStr.Append(", ");
                }
                mathStr.Append(matrixFields[column]);
            }

            constructorStr.Append("\n\t\t}\n\n");
            mathStr.Append("); }\n\n");
        }

        public void GenerateMatrixRowConstructor(StringBuilder constructorStr, StringBuilder mathStr)
        {
            // Generate signatures
            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.Append("\t\tpublic static ");
            mathStr.Append(m_TypeName);
            mathStr.Append(" ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");
            string indent0 = new string(' ', m_TypeName.Length + 16);
            string indent1 = new string(' ', m_TypeName.Length*2 + 24);
            string indent2 = new string(' ', m_TypeName.Length + 24);

            for (int row = 0; row < m_Rows; row++)
            {
                if(row != 0)
                {
                    constructorStr.Append(indent0);
                    mathStr.Append(indent1);
                }
                for (int column = 0; column < m_Columns; column++)
                {
                    string paramName = "m" + row + column;
                    constructorStr.Append(m_BaseType);
                    constructorStr.Append(" ");
                    constructorStr.Append(paramName);
                    mathStr.Append(m_BaseType);
                    mathStr.Append(" ");
                    mathStr.Append(paramName);

                    //string separator = (row == m_Rows - 1) ? (column == m_Columns - 1) ? "," : ", " : ", ";
                    string separator = (column == m_Columns - 1) ? (row == m_Rows - 1) ? ")\n" : ",\n" : ", ";
                    constructorStr.Append(separator);
                    mathStr.Append(separator);
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
            mathStr.AppendFormat("\t\t{{\n\t\t\treturn new {0}(", m_TypeName);
            for (int row = 0; row < m_Rows; row++)
            {
                if (row != 0)
                {
                    mathStr.Append(indent2);
                }
                for (int column = 0; column < m_Columns; column++)
                {
                    string paramName = "m" + row + column;
                    mathStr.Append(paramName);

                    //string separator = (row == m_Rows - 1) ? (column == m_Columns - 1) ? "," : ", " : ", ";
                    string separator = (column == m_Columns - 1) ? (row == m_Rows - 1) ? ");" : ",\n" : ", ";
                    mathStr.Append(separator);
                }
            }
            mathStr.Append("\n\t\t}\n\n");
        }

        public void GenerateMatrixConstructors(StringBuilder constructorStr, StringBuilder mathStr)
        {
            GenerateMatrixColumnConstructor(constructorStr, mathStr);
            GenerateMatrixRowConstructor(constructorStr, mathStr);
        }

        public void GenerateConstructors(StringBuilder constructorStr, StringBuilder mathStr)
        {
            constructorStr.Append("\t\t// constructors\n");
            
            if(m_Columns == 1)
            {
                int[] parameterComponenets = new int[4];
                GenerateVectorConstructors(m_Rows, m_Rows, 0, parameterComponenets, constructorStr, mathStr);
            }
            else
            {
                GenerateMatrixConstructors(constructorStr, mathStr);
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

                str.Append("\n\t\t// mod\n");
                GenerateBinaryOperator(m_Rows, m_Columns, "%", resultType, str);

                str.Append("\n\t\t// increment\n");
                GenerateUnaryOperator("++", str);

                str.Append("\n\t\t// decrement\n");
                GenerateUnaryOperator("--", str);

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

            if (0 != (m_Features & Features.BitwiseComplement))
            {
                str.Append("\n\t\t// operator ~ \n");
                GenerateUnaryOperator("~", str);
            }

            if (0 != (m_Features & Features.BitwiseLogic))
            {
                string[] binaryOps = { "&", "|", "^" };
                foreach (string binOp in binaryOps)
                {
                    str.AppendFormat("\n\t\t// operator {0}\n", binOp);
                    GenerateBinaryOperator(m_Rows, m_Columns, binOp, resultType, str);
                }

            }
        }

        private void GeneratePrimeUIntVector(StringBuilder str, int n)
        {
            str.AppendFormat("uint{0}(", n);
            for (int row = 0; row < n; row++)
            {
                if (row != 0)
                    str.Append(", ");
                str.AppendFormat("0x{0:X}u", m_primes[nextPrime++]);
            }
            str.Append(")");
        }

        public void GenerateHashFunction(StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static uint hash({0} v)\n", m_TypeName);
            str.Append("\t\t{\n");

            str.AppendFormat("\t\t\treturn csum(");
            if (m_BaseType == "bool")
            {
                for (int column = 0; column < m_Columns; column++)
                {
                    if (column > 0)
                        str.Append(" + \n\t\t\t\t\t\t");

                    str.Append("select(");
                    GeneratePrimeUIntVector(str, m_Rows);
                    str.Append(", ");
                    GeneratePrimeUIntVector(str, m_Rows);
                    str.Append(", ");
                    str.Append(m_Columns > 1 ? "v.c" + column : "v");
                    str.Append(")");
                }
                str.AppendFormat(");\n");
            }
            else
            {
                for(int column = 0; column < m_Columns; column++)
                {
                    if(column > 0)
                        str.Append(" + \n\t\t\t\t\t\t");
                    string columnName = m_Columns > 1 ? "v.c" + column : "v";
                    if (m_BaseType != "uint")
                        columnName = "asuint(" + columnName + ")";
                    str.Append(columnName);
                    str.Append(" * ");
                    GeneratePrimeUIntVector(str, m_Rows);
                }
                str.AppendFormat(") + 0x{0:X}u;\n", m_primes[nextPrime++]);
            }
            
            str.Append("\t\t}\n\n");
        }

        public void GenerateToStringFunction(StringBuilder str, bool useFormat)
        {
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            if(useFormat)
                str.Append("\t\tpublic string ToString(string format, IFormatProvider formatProvider)\n\t\t{\n");
            else
                str.Append("\t\tpublic override string ToString()\n\t\t{\n");

            str.AppendFormat("\t\t\treturn string.Format(\"{0}(", m_TypeName);
            for (int row = 0; row < m_Rows; row++)
            {
                for (int column = 0; column < m_Columns; column++)
                {
                    int idx = row * m_Columns + column;
                    if (idx > 0)
                    {
                        str.Append(", ");
                        if (m_Columns > 1 && column == 0)
                            str.Append(" ");
                    }
                    str.AppendFormat("{{{0}}}", idx);
                    if (m_BaseType == "float")
                        str.Append("f");
                }
            }
            str.Append(")\", ");
            
            for (int row = 0; row < m_Rows; row++)
            {
                for (int column = 0; column < m_Columns; column++)
                {
                    int idx = row * m_Columns + column;
                    if (idx > 0)
                        str.Append(", ");
                    if(m_Columns > 1)
                        str.Append(matrixFields[column] + "." + vectorFields[row]);
                    else
                        str.Append(vectorFields[row]);
                    if (useFormat)
                        str.Append(".ToString(format, formatProvider)");
                }
            }

            str.Append(");\n");
            str.Append("\t\t}\n\n");
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

            str.AppendFormat("\t\tpublic bool Equals({0} rhs) {{ return ", m_TypeName);
            
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

            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic override bool Equals(object o) {{ return Equals(({0})o); }}\n\n", m_TypeName);
        }

        void GenerateGetHashCode(StringBuilder str)
        {
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.Append("\t\tpublic override int GetHashCode() { return (int)math.hash(this); }\n\n");
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

            str.Append("); }\n\n");
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

        private void BeginTest(StringBuilder str, string name)
        {
            str.Append("\t\t[Test]\n");
            str.AppendFormat("\t\tpublic void {0}_{1}()\n", m_TypeName, name);
            str.Append("\t\t{\n");
        }

        private void EndTest(StringBuilder str)
        {
            str.Append("\t\t}\n\n");
        }

        private void AddParenthesized(StringBuilder str, string[] strings)
        {
            str.Append("(");
            str.Append(string.Join(", ", strings));
            str.Append(")");
        }

        private void TestConstructor(StringBuilder str, bool isStatic, bool isScalar)
        {
            if(m_Columns == 1)
            {
                string name = "constructor";
                if (isScalar)
                    name = "scalar_" + name;
                if (isStatic)
                    name = "static_" + name;

                BeginTest(str, name);
                str.AppendFormat("\t\t\t{0} a = ", m_TypeName);
                if (!isStatic)
                    str.Append("new ");
                str.Append(m_TypeName);

                if(isScalar)
                {
                    string value = m_BaseType == "bool" ? "true" : m_BaseType == "uint" ? "17u" : m_BaseType == "int" ? "17" : m_BaseType == "float" ? "17.0f" : "";
                    str.Append("(" + value + ");\n");

                    for (int row = 0; row < m_Rows; row++)
                    {
                        str.AppendFormat("\t\t\tAssert.AreEqual(a.{0}, {1});\n", components[row], value);
                    }
                }
                else
                {
                    string[] values = (from row in Enumerable.Range(0, m_Rows) select m_BaseType == "bool" ? ((row & 1) != 0 ? "true" : "false") : "" + (row + 1)).ToArray();
                    AddParenthesized(str, values);
                    str.Append(";\n");

                    for (int row = 0; row < m_Rows; row++)
                    {
                        str.AppendFormat("\t\t\tAssert.AreEqual(a.{0}, {1});\n", components[row], values[row]);
                    }
                }
                

                EndTest(str);
            }
            else
            {

            }
        }

        private void TestConstructors(StringBuilder str)
        {
            TestConstructor(str, false, false);
            TestConstructor(str, false, true);
            TestConstructor(str, true, false);
            TestConstructor(str, true, true);
        }

        private void TestOperator(StringBuilder str, bool lhsWide, bool rhsWide, string lhsType, string rhsType, string returnType, string op, string opName, bool isBinary, bool isPrefix)
        {
            var rnd = new Random(opName.GetHashCode());

            //if (m_Columns == 1)
            {
                BeginTest(str, "operator_" + opName);

                int numValues = m_Rows;
                int numPasses = 4;

                string[] lhsValues = new string[lhsWide ? numValues : 1];
                string[] rhsValues = new string[rhsWide ? numValues : 1];
                string[] resultValues = new string[numValues];

                for (int pass = 0; pass < numPasses; pass++)
                {
                    bool bool_a = false;
                    bool bool_b = false;
                    int int_a = 0;
                    int int_b = 0;
                    uint uint_a = 0;
                    uint uint_b = 0;
                    float float_a = 0.0f;
                    float float_b = 0.0f;

                    for (int i = 0; i < numValues; i++)
                    {
                        string lhsValue = "";
                        string rhsValue = "";
                        string resultValue = "";
                        
                        if (m_BaseType == "bool")
                        {
                            if (i == 0 || lhsWide) bool_a = (rnd.Next(2) == 1);
                            if (i == 0 || rhsWide) bool_b = (rnd.Next(2) == 1);

                            lhsValue = bool_a ? "true" : "false";
                            rhsValue = bool_b ? "true" : "false";
                            switch (op)
                            {
                                case "==": resultValue = (bool_a == bool_b) ? "true" : "false"; break;
                                case "!=": resultValue = (bool_a != bool_b) ? "true" : "false"; break;

                                case "&": resultValue = (bool_a & bool_b) ? "true" : "false"; break;
                                case "|": resultValue = (bool_a | bool_b) ? "true" : "false"; break;
                                case "^": resultValue = (bool_a ^ bool_b) ? "true" : "false"; break;
                            }
                        }
                        else if (m_BaseType == "int")
                        {
                            if (i == 0 || lhsWide) int_a = rnd.Next();
                            if (i == 0 || rhsWide) int_b = rnd.Next();
                            

                            lhsValue = "" + int_a;
                            rhsValue = "" + int_b;
                            switch (op)
                            {
                                case "+": resultValue = "" + (isBinary ? (int_a + int_b) : +int_a); break;
                                case "-": resultValue = "" + (isBinary ? (int_a - int_b) : -int_a); break;
                                case "*": resultValue = "" + (int_a * int_b); break;
                                case "/": resultValue = "" + (int_a / int_b); break;
                                case "%": resultValue = "" + (int_a % int_b); break;

                                case "<": resultValue = (int_a < int_b) ? "true" : "false"; break;
                                case ">": resultValue = (int_a > int_b) ? "true" : "false"; break;
                                case "==": resultValue = (int_a == int_b) ? "true" : "false"; break;
                                case "!=": resultValue = (int_a != int_b) ? "true" : "false"; break;
                                case "<=": resultValue = (int_a <= int_b) ? "true" : "false"; break;
                                case ">=": resultValue = (int_a >= int_b) ? "true" : "false"; break;

                                case "&": resultValue = "" + (int_a & int_b); break;
                                case "|": resultValue = "" + (int_a | int_b); break;
                                case "^": resultValue = "" + (int_a ^ int_b); break;
                                case "<<": resultValue = "" + (int_a << int_b); break;
                                case ">>": resultValue = "" + (int_a >> int_b); break;

                                case "~": resultValue = "" + (~int_a); break;
                                case "++": resultValue = "" + (isPrefix ? ++int_a : int_a++); break;
                                case "--": resultValue = "" + (isPrefix ? --int_a : int_a--); break;
                            }
                        }
                        else if (m_BaseType == "uint")
                        {
                            if (i == 0 || lhsWide) uint_a = (uint)rnd.Next();
                            if (i == 0 || rhsWide) uint_b = (uint)rnd.Next();

                            lhsValue = "" + uint_a;
                            rhsValue = "" + uint_b;
                            switch (op)
                            {
                                case "+": resultValue = "" + (isBinary ? (uint_a + uint_b) : +uint_a); break;
                                case "-": resultValue = "" + (isBinary ? (uint_a - uint_b) : (uint)-uint_a); break;
                                case "*": resultValue = "" + (uint_a * uint_b); break;
                                case "/": resultValue = "" + (uint_a / uint_b); break;
                                case "%": resultValue = "" + (uint_a % uint_b); break;

                                case "<": resultValue = (uint_a < uint_b) ? "true" : "false"; break;
                                case ">": resultValue = (uint_a > uint_b) ? "true" : "false"; break;
                                case "==": resultValue = (uint_a == uint_b) ? "true" : "false"; break;
                                case "!=": resultValue = (uint_a != uint_b) ? "true" : "false"; break;
                                case "<=": resultValue = (uint_a <= uint_b) ? "true" : "false"; break;
                                case ">=": resultValue = (uint_a >= uint_b) ? "true" : "false"; break;

                                case "&": resultValue = "" + (uint_a & uint_b); break;
                                case "|": resultValue = "" + (uint_a | uint_b); break;
                                case "^": resultValue = "" + (uint_a ^ uint_b); break;
                                case "<<": resultValue = "" + (uint_a << (int)uint_b); break;
                                case ">>": resultValue = "" + (uint_a >> (int)uint_b); break;

                                case "~": resultValue = "" + (~uint_a); break;
                                case "++": resultValue = "" + (isPrefix ? ++uint_a : uint_a++); break;
                                case "--": resultValue = "" + (isPrefix ? --uint_a : uint_a--); break;
                            }
                        }
                        else if (m_BaseType == "float")
                        {
                            if (i == 0 || lhsWide) float_a = (float)rnd.NextDouble() * 1024.0f - 512.0f;
                            if (i == 0 || rhsWide) float_b = (float)rnd.NextDouble() * 1024.0f - 512.0f;

                            lhsValue = "" + float_a.ToString("R") + "f";
                            rhsValue = "" + float_b.ToString("R") + "f";
                            switch (op)
                            {
                                case "+": resultValue = "" + (isBinary ? (float_a + float_b) : +float_a).ToString("R") + "f"; break;
                                case "-": resultValue = "" + (isBinary ? (float_a - float_b) : -float_a).ToString("R") + "f"; break;
                                case "*": resultValue = "" + (float_a * float_b).ToString("R") + "f"; break;
                                case "/": resultValue = "" + (float_a / float_b).ToString("R") + "f"; break;
                                case "%": resultValue = "" + (float_a % float_b).ToString("R") + "f"; break;

                                case "<": resultValue = (float_a < float_b) ? "true" : "false"; break;
                                case ">": resultValue = (float_a > float_b) ? "true" : "false"; break;
                                case "==": resultValue = (float_a == float_b) ? "true" : "false"; break;
                                case "!=": resultValue = (float_a != float_b) ? "true" : "false"; break;
                                case "<=": resultValue = (float_a <= float_b) ? "true" : "false"; break;
                                case ">=": resultValue = (float_a >= float_b) ? "true" : "false"; break;

                                case "++": resultValue = "" + (isPrefix ? ++float_a : float_a++).ToString("R") + "f"; break;
                                case "--": resultValue = "" + (isPrefix ? --float_a : float_a--).ToString("R") + "f"; break;
                            }
                        }

                        if (i == 0 || lhsWide) lhsValues[i] = lhsValue;
                        if (i == 0 || rhsWide) rhsValues[i] = rhsValue;
                        resultValues[i] = resultValue;
                    }
                    
                    str.AppendFormat("\t\t\t{0} a{1} = ", lhsType, pass);
                    if (lhsWide) str.Append(lhsType);
                    AddParenthesized(str, lhsValues);
                    str.Append(";\n");

                    if (isBinary)
                    {
                        str.AppendFormat("\t\t\t{0} b{1} = ", rhsType, pass);
                        if (rhsWide) str.Append(rhsType);
                        AddParenthesized(str, rhsValues);
                        str.Append(";\n");

                        str.AppendFormat("\t\t\t{0} r{1} = {0}", returnType, pass);
                        AddParenthesized(str, resultValues);
                        str.Append(";\n");

                        str.AppendFormat("\t\t\tTestUtils.AreEqual(a{1} {0} b{1}, r{1});\n", op, pass);
                    }
                    else
                    {
                        str.AppendFormat("\t\t\t{0} r{1} = {0}", returnType, pass);
                        AddParenthesized(str, resultValues);
                        str.Append(";\n");

                        if (isPrefix)
                            str.AppendFormat("\t\t\tTestUtils.AreEqual({0}a{1}, r{1});\n", op, pass);
                        else
                            str.AppendFormat("\t\t\tTestUtils.AreEqual(a{1}{0}, r{1});\n", op, pass);
                    }

                    if (pass != numPasses - 1)
                        str.Append("\n");

                }
                EndTest(str);
            }
        }

        private void TestUnaryOperator(StringBuilder str, string returnType, string op, string opName, bool isPrefix)
        {
            TestOperator(str, true, false, m_TypeName, m_BaseType, returnType, op, opName, false, isPrefix);
        }

        private void TestBinaryOperator(StringBuilder str, string returnType, string op, string opName)
        {
            TestOperator(str, true, true, m_TypeName, m_TypeName, returnType, op, opName + "_wide_wide", true, false);
            TestOperator(str, true, false, m_TypeName, m_BaseType, returnType, op, opName + "_wide_scalar", true, false);
            TestOperator(str, false, true, m_BaseType, m_TypeName, returnType, op, opName + "_scalar_wide", true, false);
        }

        private void TestOperators(StringBuilder str)
        {
            string boolResultType = ToTypeName("bool", m_Rows, m_Columns);

            TestBinaryOperator(str, boolResultType, "==", "equal");
            TestBinaryOperator(str, boolResultType, "!=", "not_equal");
            
            if (m_BaseType == "int" || m_BaseType == "uint" || m_BaseType == "float")
            {
                TestBinaryOperator(str, boolResultType, "<", "less");
                TestBinaryOperator(str, boolResultType, ">", "greater");
                TestBinaryOperator(str, boolResultType, "<=", "less_equal");
                TestBinaryOperator(str, boolResultType, ">=", "greater_equal");

                TestBinaryOperator(str, m_TypeName, "+", "add");
                TestBinaryOperator(str, m_TypeName, "-", "sub");
                TestBinaryOperator(str, m_TypeName, "*", "mul");
                TestBinaryOperator(str, m_TypeName, "/", "div");
                TestBinaryOperator(str, m_TypeName, "%", "mod");

                TestUnaryOperator(str, m_TypeName, "+", "plus", true);
                TestUnaryOperator(str, m_TypeName, "-", "neg", true);

                TestUnaryOperator(str, m_TypeName, "++", "prefix_inc", true);
                TestUnaryOperator(str, m_TypeName, "++", "postfix_inc", false);
                TestUnaryOperator(str, m_TypeName, "--", "prefix_dec", true);
                TestUnaryOperator(str, m_TypeName, "--", "postfix_dec", false);
            }

            if(m_BaseType == "bool" || m_BaseType == "int" || m_BaseType == "uint")
            {
                TestBinaryOperator(str, m_TypeName, "&", "bitwise_and");
                TestBinaryOperator(str, m_TypeName, "|", "bitwise_or");
                TestBinaryOperator(str, m_TypeName, "^", "bitwise_xor");
            }

            if(m_BaseType == "int" || m_BaseType == "uint")
            {
                TestOperator(str, true, false, m_TypeName, "int", m_TypeName, "<<", "left_shift", true, false);
                TestOperator(str, true, false, m_TypeName, "int", m_TypeName, ">>", "right_shift", true, false);

                TestUnaryOperator(str, m_TypeName, "~", "bitwise_not", true);
            }
        }

        private void GenerateTests(StringBuilder str)
        {
            StringBuilder mathStr = new StringBuilder();
            
            str.Append("// GENERATED CODE\n");
            str.Append("using NUnit.Framework;\n");
            str.Append("using static Unity.Mathematics.math;\n");
            str.Append("namespace Unity.Mathematics.Tests\n");
            str.Append("{\n");
            str.Append("\t[TestFixture]\n");
            str.AppendFormat("\tpublic class Test{0}\n", UpperCaseFirstLetter(m_TypeName));
            str.Append("\t{\n");

            TestConstructors(str);
            TestOperators(str);

            str.Append("\n\t}");
            str.Append("\n}\n");
        }
    }
}

//TODO: where is operator % ?
//TODO: what about operator '?', '&&', '||'. cannot be overloaded in C#!
//TODO: +=? yes: this should work automatically
//TODO: prefix/postfix ++/-- 
                             
                             