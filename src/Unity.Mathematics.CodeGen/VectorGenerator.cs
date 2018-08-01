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

        private uint m_NextPrime = 0;
        private uint NextPrime()
        {
            return m_primes[m_NextPrime++ & 255]; //TOOD: fix
        }

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
        static readonly string[] shuffleComponents = { "LeftX", "LeftY", "LeftZ", "LeftW", "RightX", "RightY", "RightZ", "RightW" };

        public static string ToTypeName(string baseType, int rows, int columns)
        {
            string name = baseType;
            if (rows == 1 && columns > 1)
                return name + columns;  // row vector

            if (rows > 1)
                name += rows;
            if (columns > 1)
                name += "x" + columns;
            return name;
        }

        public static string ToTypedLiteral(string baseType, int value)
        {
            switch(baseType)
            {
                case "int":
                case "uint":
                    return "" + value;
                case "float":
                    return "" + value + ".0f";
                case "double":
                    return "" + value + ".0";
                default:
                    return "";
            }
        }

        private static string UpperCaseFirstLetter(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private static void WriteFile(string filename, string text)
        {
            // Convert all tabs to spaces
            text = text.Replace("\t", "    ");
            // Normalize line endings, convert all EOL to platform EOL (and let git handle it)
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);

            System.IO.File.WriteAllText(filename, text);
        }

        private void WriteMatrix()
        {
            StringBuilder str = new StringBuilder();
            GenerateMatrixImplementation(str);
            WriteFile(m_ImplementationDirectory + "/matrix.gen.cs", str.ToString());
        }

        private void WriteType(string baseType, int rows, int columns, Features features)
        {
            m_BaseType = baseType;
            m_TypeName = ToTypeName(baseType, rows, columns);
            m_Rows = rows;
            m_Columns = columns;
            m_Features = features;

            // implementation
            StringBuilder str = new StringBuilder();
            GenerateTypeImplementation(str);
            WriteFile(m_ImplementationDirectory + "/" + m_TypeName + ".gen.cs", str.ToString());
            

            // test
            str = new StringBuilder();
            GenerateTests(str);
            WriteFile(m_TestDirectory + "/Test" + UpperCaseFirstLetter(m_TypeName) + ".gen.cs", str.ToString());
        }


        public static void Write(string implementationDirectory, string testDirectory)
        {
            VectorGenerator vectorGenerator = new VectorGenerator();
            vectorGenerator.m_ImplementationDirectory = implementationDirectory;
            vectorGenerator.m_TestDirectory = testDirectory;

            vectorGenerator.WriteType("bool", 3, 1, Features.BitwiseLogic);
            vectorGenerator.WriteType("bool", 4, 1, Features.BitwiseLogic);

            for(int rows = 1; rows <= 4; rows++)
            {
                for(int columns = 1; columns <= 4; columns++)
                {
                    if (rows == 1 && columns == 1)  // don't generate type1x1
                        continue;
                    if (rows == 1)  // ignore row vectors for now
                        continue;

                    vectorGenerator.WriteType("bool", rows, columns, Features.BitwiseLogic);
                    vectorGenerator.WriteType("int", rows, columns, Features.All);
                    vectorGenerator.WriteType("uint", rows, columns, Features.All);
                    vectorGenerator.WriteType("float", rows, columns, Features.Arithmetic | Features.UnaryNegation);
                    vectorGenerator.WriteType("double", rows, columns, Features.Arithmetic | Features.UnaryNegation);
                }
            }

            vectorGenerator.WriteMatrix();
        }


        private void GenerateMemberVariables(StringBuilder str)
        {
            if(m_Columns > 1)
            {
                string columnType = ToTypeName(m_BaseType, m_Rows, 1);
                for (int i = 0; i < m_Columns; i++)
                    str.AppendFormat("\t\tpublic {0} {1};\n", columnType, matrixFields[i]);
            }
            else
            {
                for (int i = 0; i < m_Rows; i++)
                {
                    if (m_Columns == 1 && m_BaseType == "bool")
                        str.Append("\t\t[MarshalAs(UnmanagedType.U1)]\n");
                    str.AppendFormat("\t\tpublic {0} {1};\n", m_BaseType, vectorFields[i]);
                }
            }
            str.Append("\n");
        }

        private void GenerateStaticFields(StringBuilder str)
        {
            if (m_BaseType == "int" || m_BaseType == "uint" || m_BaseType == "float" || m_BaseType == "double")
            {
                string zeroStr = ToTypedLiteral(m_BaseType, 0);

                // identity
                if (m_Rows == m_Columns)
                {
                    string oneStr = ToTypedLiteral(m_BaseType, 1);
                    str.AppendFormat("\t\tpublic static readonly {0} identity = new {0}(", m_TypeName);
                    for (int row = 0; row < m_Rows; row++)
                    {
                        for (int column = 0; column < m_Columns; column++)
                        {
                            if (row != 0 || column != 0)
                                str.Append(", ");
                            if (row != 0 && column == 0)
                                str.Append("  ");
                            str.Append(row == column ? oneStr : zeroStr);
                        }
                    }
                    str.Append(");\n");
                }

                // zero
                str.AppendFormat("\t\tpublic static readonly {0} zero = new {0}(", m_TypeName);

                for (int row = 0; row < m_Rows; row++)
                {
                    for (int column = 0; column < m_Columns; column++)
                    {
                        if (row != 0 || column != 0)
                            str.Append(", ");
                        if (row != 0 && column == 0)
                            str.Append("  ");
                        str.Append(zeroStr);
                    }
                }
                str.Append(");\n");
            }

            str.Append("\n");
        }

        private void GenerateDebuggerTypeProxy(StringBuilder str)
        {
            if (m_Columns > 1)
                return;

            str.Append("\t\tinternal sealed class DebuggerProxy\n");
            str.Append("\t\t{\n");
            for (int i = 0; i < m_Rows; i++)
            {
                str.AppendFormat("\t\t\tpublic {0} {1};\n", m_BaseType, vectorFields[i]);
            }

            str.AppendFormat("\t\t\tpublic DebuggerProxy({0} v)\n", m_TypeName);
            str.Append("\t\t\t{\n");
            for (int i = 0; i < m_Rows; i++)
            {
                str.AppendFormat("\t\t\t\t{0} = v.{0};\n", vectorFields[i]);
            }
            str.Append("\t\t\t}\n");
            str.Append("\t\t}\n\n");
        }

        private void GenerateConversion(StringBuilder str, StringBuilder opStr, StringBuilder mathStr, string sourceBaseType, bool isExplicit, bool isScalar)
        {
            string sourceType = isScalar ? sourceBaseType : ToTypeName(sourceBaseType, m_Rows, m_Columns);

            int fieldCount = (m_Columns > 1) ? m_Columns : m_Rows;
            string[] fields = (m_Columns > 1) ? matrixFields : vectorFields;
            string dstFieldType = (m_Columns > 1) ? ToTypeName(m_BaseType, m_Rows, 1) : m_BaseType;

            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic {0}({1} v)\n", m_TypeName, sourceType);
            str.Append("\t\t{\n");
            for(int i = 0; i < fieldCount; i++)
            {
                string rhs = "v";
                if (!isScalar)
                    rhs = rhs + "." + fields[i];
                if (isExplicit)
                    rhs = "(" + dstFieldType + ")" + rhs;

                str.AppendFormat("\t\t\tthis.{0} = {1};\n", fields[i], rhs);
            }
            str.Append("\t\t}\n\n");

            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.AppendFormat("\t\tpublic static {0} {0}({1} v) {{ return new {0}(v); }}\n\n", m_TypeName, sourceType);

            opStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            opStr.AppendFormat("\t\tpublic static {0} operator {1}({2} v) {{ return new {1}(v); }}\n", isExplicit ? "explicit" : "implicit", m_TypeName, sourceType);
        }

        private void GenerateConversionConstructorsAndOperators(StringBuilder str, StringBuilder mathStr)
        {
            StringBuilder opStr = new StringBuilder();

            opStr.Append("\t\t// conversions\n");
            
            GenerateConversion(str, opStr, mathStr, m_BaseType, false, true);

            if (m_BaseType == "int")
            {
                GenerateConversion(str, opStr, mathStr, "uint", true, true);
                GenerateConversion(str, opStr, mathStr, "uint", true, false);
                GenerateConversion(str, opStr, mathStr, "float", true, true);
                GenerateConversion(str, opStr, mathStr, "float", true, false);
            }
            else if (m_BaseType == "uint")
            {
                GenerateConversion(str, opStr, mathStr, "int", true, true);
                GenerateConversion(str, opStr, mathStr, "int", true, false);
                GenerateConversion(str, opStr, mathStr, "float", true, true);
                GenerateConversion(str, opStr, mathStr, "float", true, false);
            }
            else if (m_BaseType == "float")
            {
                GenerateConversion(str, opStr, mathStr, "int", false, true);
                GenerateConversion(str, opStr, mathStr, "int", false, false);
                GenerateConversion(str, opStr, mathStr, "uint", false, true);
                GenerateConversion(str, opStr, mathStr, "uint", false, false);
            }

            str.Append("\n");
            str.Append(opStr);
            str.Append("\n");
        }

        private void GenerateTypeImplementation(StringBuilder str)
        {
            StringBuilder mathStr = new StringBuilder();

            str.Append("// GENERATED CODE\n");
            str.Append("using System;\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            if (m_Columns == 1 && m_BaseType == "bool")
                str.Append("using System.Runtime.InteropServices;\n");  // for MarshalAs
            if (m_Columns == 1)
                str.Append("using System.Diagnostics;\n");   // for DebuggerTypeProxy
            str.Append("\n");
            str.Append("#pragma warning disable 0660, 0661\n\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");

            if (m_Columns == 1)
                str.AppendFormat("\t[DebuggerTypeProxy(typeof({0}.DebuggerProxy))]\n", m_TypeName);
            str.Append("\t[System.Serializable]\n");
            str.AppendFormat("\tpublic partial struct {0} : System.IEquatable<{0}>", m_TypeName);
            if (m_BaseType != "bool")
                str.Append(", IFormattable");
            str.Append("\n\t{\n");

            GenerateMemberVariables(str);

            GenerateStaticFields(str);

            GenerateConstructors(str, mathStr);

            GenerateConversionConstructorsAndOperators(str, mathStr);

            GenerateOperators(str);

            GenerateTransposeFunction(mathStr);
            GenerateInverseFunction(mathStr);
            GenerateDeterminantFunction(mathStr);
            GenerateHashFunction(mathStr);

            if (m_Columns == 1)
            {
                GenerateSwizzles(str);
                GenerateSelectShuffleComponentImplementation(mathStr);
                GenerateShuffleImplementation(mathStr);
            }
            
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

            GenerateDebuggerTypeProxy(str);

            str.Append("\t}\n\n");

            str.Append("\tpublic static partial class math\n");
            str.Append("\t{\n");
            str.Append(mathStr);
            str.Append("\t}\n}\n");
        }

        private void GenerateSelectShuffleComponentImplementation(StringBuilder str)
        {
            if (m_Columns > 1)
                return;

            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tinternal static {0} select_shuffle_component({1} a, {1} b, ShuffleComponent component)\n", m_BaseType, m_TypeName);
            str.Append("\t\t{\n");
            str.Append("\t\t\tswitch(component)\n");
            str.Append("\t\t\t{\n");
            for(int i = 0; i < m_Rows; i++)
            {
                str.AppendFormat("\t\t\t\tcase ShuffleComponent.{0}:\n", shuffleComponents[i]);
                str.AppendFormat("\t\t\t\t\treturn a{0};\n", m_Rows > 1 ? "." + vectorFields[i] : "");
            }
            for (int i = 0; i < m_Rows; i++)
            {
                str.AppendFormat("\t\t\t\tcase ShuffleComponent.{0}:\n", shuffleComponents[i + 4]);
                str.AppendFormat("\t\t\t\t\treturn b{0};\n", m_Rows > 1 ? "." + vectorFields[i] : "");
            }
            str.Append("\t\t\t\tdefault:\n");
            str.Append("\t\t\t\t\tthrow new System.ArgumentException(\"Invalid shuffle component: \" + component);\n");
            str.Append("\t\t\t}\n");
            str.Append("\t\t}\n\n");    
        }

        private void GenerateShuffleImplementation(StringBuilder str)
        {
            if (m_Columns > 1)
                return;

            for (int resultComponents = 1; resultComponents <= 4; resultComponents++)
            {
                string resultType = ToTypeName(m_BaseType, resultComponents, 1);
                    
                str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
                str.AppendFormat("\t\tpublic static {0} shuffle({1} a, {2} b", resultType, m_TypeName, m_TypeName);
                for(int i = 0; i < resultComponents; i++)
                {
                    str.AppendFormat(", ShuffleComponent {0}", vectorFields[i]);
                }
                str.Append(")\n");
                str.Append("\t\t{\n");

                if(resultComponents != 1)
                    str.AppendFormat("\t\t\treturn {0}(\n", resultType);
                else
                    str.AppendFormat("\t\t\treturn ", resultType);
                            
                for(int i = 0; i < resultComponents; i++)
                {
                    if (resultComponents != 1)
                        str.Append("\t\t\t\t");

                    str.AppendFormat("select_shuffle_component(a, b, {0})", vectorFields[i]);
                    if(i != resultComponents - 1)
                        str.Append(",\n");
                }

                if (resultComponents != 1)
                    str.Append(");\n");
                else
                    str.Append(";\n");

                str.Append("\t\t}\n\n");
            }
        }

        private void GenerateMulImplementation(string baseType, StringBuilder str)
        {
            // typenxk = mul(typenxm, typemxk)
            for(int n = 1; n <= 4; n++)
            {
                for(int m = 1; m <= 4; m++)
                {
                    for(int k = 1; k <= 4; k++)
                    {
                        // mul(a,b): if a is vector it is treated as a row vector. if b is a vector it is treaded as a column vector.

                        if (n > 1 && m == 1)
                            continue;   // lhs cannot be column vector
                        if (m == 1 && k > 1)
                            continue;   // rhs cannot be row vector
                        string resultType = ToTypeName(baseType, n, k);
                        string lhsType = ToTypeName(baseType, n, m);
                        string rhsType = ToTypeName(baseType, m, k);

                        bool isScalarResult = (n == 1 && k == 1);

                        str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
                        str.AppendFormat("\t\tpublic static {0} mul({1} a, {2} b)\n", resultType, lhsType, rhsType);
                        str.Append("\t\t{\n");

                        str.Append("\t\t\treturn ");
                        if (!isScalarResult)
                            str.Append(resultType + "(\n\t\t\t\t");
                        for(int i = 0; i < k; i++)
                        {
                            if(i > 0)
                            str.Append("\n\t\t\t\t");
                            for(int j = 0; j < m; j++)
                            {
                                if (j != 0)
                                    str.Append(" + ");

                                if (n == 1 && m == 1)
                                    str.Append("a");
                                else if(n == 1 || m == 1)
                                    str.Append("a." + vectorFields[j]);
                                else
                                    str.Append("a." + matrixFields[j]);

                                str.Append(" * ");

                                if (m == 1 && k == 1)
                                    str.Append("b");
                                else if (m == 1 || k == 1)
                                    str.Append("b." + vectorFields[j]);
                                else
                                    str.Append("b." + matrixFields[i] + "." + vectorFields[j]);
                            }
                            if (i != k - 1)
                                str.Append(",");
                        }
                        if (!isScalarResult)
                            str.Append(")");
                        str.Append(";\n");
                        str.Append("\t\t}\n\n");
                    }
                }
            }
        }

        private void GenerateMatrixImplementation(StringBuilder str)
        {
            str.Append("// GENERATED CODE\n");
            str.Append("using System;\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            str.Append("\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");
            str.Append("\tpartial class math\n");
            str.Append("\t{\n");

            str.Append("\t\t// mul\n");
            GenerateMulImplementation("float", str);
            GenerateMulImplementation("double", str);
            GenerateMulImplementation("int", str);
            GenerateMulImplementation("uint", str);


            str.Append("\t}\n");
            str.Append("}\n");
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
                str.AppendFormat("0x{0:X}u", NextPrime());
            }
            str.Append(")");
        }

        public void GenerateTransposeFunction(StringBuilder str)
        {
            if (m_Columns == 1 || m_Rows == 1)
                return;

            string resultType = ToTypeName(m_BaseType, m_Columns, m_Rows);
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {0} transpose({1} v)\n", resultType, m_TypeName);
            str.Append("\t\t{\n");

            str.AppendFormat("\t\t\treturn {0}(\n", resultType);
            for(int i = 0; i < m_Columns; i++)
            {
                str.Append("\t\t\t\t");
                for(int j = 0; j < m_Rows; j++)
                {
                    if (j != 0)
                        str.Append(", ");
                    str.AppendFormat("v.c{0}.{1}", i, vectorFields[j]);
                }
                if(i != m_Columns - 1)
                    str.Append(",\n");
            }

            str.Append(");\n");
            str.Append("\t\t}\n\n");
        }

        public void GenerateInverseFunction(StringBuilder str)
        {
            if (m_Rows != m_Columns || m_Rows == 1)
                return;

            if (m_BaseType != "float" && m_BaseType != "double")
                return;

            string oneStr = (m_BaseType == "float") ? "1.0f" : "1.0";

            if(m_Rows == 2)
            {
                str.AppendFormat(
                    @"        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {0}2x2 inverse({0}2x2 m)
        {{
            {0} a = m.c0.x;
            {0} b = m.c1.x;
            {0} c = m.c0.y;
            {0} d = m.c1.y;

            {0} det = a * d - b * c;

            return {0}2x2(d, -b, -c, a) * ({1} / det);
        }}

",
                    m_BaseType, oneStr);
            }
            else if(m_Rows == 3)
            {
                str.AppendFormat(
                    @"public static {0}3x3 inverse({0}3x3 m)
        {{
            // naive scalar implementation using direct calculation by cofactors
            {0}3 c0 = m.c0;
            {0}3 c1 = m.c1;
            {0}3 c2 = m.c2;

            // calculate minors
            {0} m00 = c1.y * c2.z - c1.z * c2.y;
            {0} m01 = c0.y * c2.z - c0.z * c2.y;
            {0} m02 = c0.y * c1.z - c0.z * c1.y;

            {0} m10 = c1.x * c2.z - c1.z * c2.x;
            {0} m11 = c0.x * c2.z - c0.z * c2.x;
            {0} m12 = c0.x * c1.z - c0.z * c1.x;

            {0} m20 = c1.x * c2.y - c1.y * c2.x;
            {0} m21 = c0.x * c2.y - c0.y * c2.x;
            {0} m22 = c0.x * c1.y - c0.y * c1.x;

            {0} det = c0.x * m00 - c1.x * m01 + c2.x * m02;

            return {0}3x3(
                 m00,-m10, m20,
                -m01, m11,-m21,
                 m02, -m12, m22) * ({1} / det);
        }}

",
                m_BaseType, oneStr);
            }
            else if(m_Rows == 4)
            {
                str.AppendFormat(
                    @"        public static {0}4x4 inverse({0}4x4 m)
        {{
            {0}4 c0 = m.c0;
            {0}4 c1 = m.c1;
            {0}4 c2 = m.c2;
            {0}4 c3 = m.c3;

            {0}4 r0y_r1y_r0x_r1x = movelh(c1, c0);
            {0}4 r0z_r1z_r0w_r1w = movelh(c2, c3);
            {0}4 r2y_r3y_r2x_r3x = movehl(c0, c1);
            {0}4 r2z_r3z_r2w_r3w = movehl(c3, c2);

            {0}4 r1y_r2y_r1x_r2x = shuffle(c1, c0, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            {0}4 r1z_r2z_r1w_r2w = shuffle(c2, c3, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            {0}4 r3y_r0y_r3x_r0x = shuffle(c1, c0, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);
            {0}4 r3z_r0z_r3w_r0w = shuffle(c2, c3, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);

            {0}4 r0_wzyx = shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            {0}4 r1_wzyx = shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            {0}4 r2_wzyx = shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            {0}4 r3_wzyx = shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            {0}4 r0_xyzw = shuffle(r0y_r1y_r0x_r1x, r0z_r1z_r0w_r1w, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);

            // Calculate remaining inner term pairs. inner terms have zw=-xy, so we only have to calculate xy and can pack two pairs per vector.
            {0}4 inner12_23 = r1y_r2y_r1x_r2x * r2z_r3z_r2w_r3w - r1z_r2z_r1w_r2w * r2y_r3y_r2x_r3x;
            {0}4 inner02_13 = r0y_r1y_r0x_r1x * r2z_r3z_r2w_r3w - r0z_r1z_r0w_r1w * r2y_r3y_r2x_r3x;
            {0}4 inner30_01 = r3z_r0z_r3w_r0w * r0y_r1y_r0x_r1x - r3y_r0y_r3x_r0x * r0z_r1z_r0w_r1w;

            // Expand inner terms back to 4 components. zw signs still need to be flipped
            {0}4 inner12 = shuffle(inner12_23, inner12_23, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            {0}4 inner23 = shuffle(inner12_23, inner12_23, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            {0}4 inner02 = shuffle(inner02_13, inner02_13, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            {0}4 inner13 = shuffle(inner02_13, inner02_13, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            // Calculate minors
            {0}4 minors0 = r3_wzyx * inner12 - r2_wzyx * inner13 + r1_wzyx * inner23;

            {0}4 denom = r0_xyzw * minors0;

            // Horizontal sum of denominator. Free sign flip of z and w compensates for missing flip in inner terms.
            denom = denom + shuffle(denom, denom, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightZ);   // x+y		x+y			z+w			z+w
            denom = denom - shuffle(denom, denom, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightX);   // x+y-z-w  x+y-z-w		z+w-x-y		z+w-x-y

            {0}4 rcp_denom_ppnn = {0}4({1}) / denom;
            {0}4x4 res;
            res.c0 = minors0 * rcp_denom_ppnn;

            {0}4 inner30 = shuffle(inner30_01, inner30_01, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            {0}4 inner01 = shuffle(inner30_01, inner30_01, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            {0}4 minors1 = r2_wzyx * inner30 - r0_wzyx * inner23 - r3_wzyx * inner02;
            res.c1 = minors1 * rcp_denom_ppnn;

            {0}4 minors2 = r0_wzyx * inner13 - r1_wzyx * inner30 - r3_wzyx * inner01;
            res.c2 = minors2 * rcp_denom_ppnn;

            {0}4 minors3 = r1_wzyx * inner02 - r0_wzyx * inner12 + r2_wzyx * inner01;
            res.c3 = minors3 * rcp_denom_ppnn;
            return res;
        }}

",
                    m_BaseType, oneStr);
            }

        }

        public void GenerateDeterminantFunction(StringBuilder str)
        {
            if (m_Rows != m_Columns || m_Rows == 1)
                return;

            if (m_BaseType != "float" && m_BaseType != "double" && m_BaseType != "int")
                return;

            if (m_Rows == 2)
            {
                str.AppendFormat(
                    @"        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {0} determinant({0}2x2 m)
        {{
            {0} a = m.c0.x;
            {0} b = m.c1.x;
            {0} c = m.c0.y;
            {0} d = m.c1.y;

            return a * d - b * c;
        }}

",
                    m_BaseType);
            }
            else if (m_Rows == 3)
            {
                str.AppendFormat(
                    @"        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {0} determinant({0}3x3 m)
        {{
            {0}3 c0 = m.c0;
            {0}3 c1 = m.c1;
            {0}3 c2 = m.c2;

            {0} m00 = c1.y * c2.z - c1.z * c2.y;
            {0} m01 = c0.y * c2.z - c0.z * c2.y;
            {0} m02 = c0.y * c1.z - c0.z * c1.y;

            return c0.x * m00 - c1.x * m01 + c2.x * m02;
        }}

",
                m_BaseType);
            }
            else if (m_Rows == 4)
            {
                str.AppendFormat(
                    @"        public static {0} determinant({0}4x4 m)
        {{
            {0}4 c0 = m.c0;
            {0}4 c1 = m.c1;
            {0}4 c2 = m.c2;
            {0}4 c3 = m.c3;

            {0} m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            {0} m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            {0} m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            {0} m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            return c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
        }}

",
                    m_BaseType);
            }

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
                    {
                        if(m_BaseType == "double")
                            columnName = "fold_to_uint(" + columnName + ")";
                        else
                            columnName = "asuint(" + columnName + ")";
                    }
                        
                    str.Append(columnName);
                    str.Append(" * ");
                    GeneratePrimeUIntVector(str, m_Rows);
                }
                str.AppendFormat(") + 0x{0:X}u;\n", NextPrime());
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
                if (i != resultCount - 1)
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

        // Test Generation

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
                    string value = m_BaseType == "bool" ? "true" : m_BaseType == "uint" ? "17u" : m_BaseType == "int" ? "17" : m_BaseType == "float" ? "17.0f" : m_BaseType == "double" ? "17.0" : "";
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

            BeginTest(str, "operator_" + opName);

            int numValues = m_Rows * m_Columns;
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
                double double_a = 0.0;
                double double_b = 0.0;

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
                    } else if (m_BaseType == "double")
                    {
                        if (i == 0 || lhsWide) double_a = rnd.NextDouble() * 1024.0 - 512.0;
                        if (i == 0 || rhsWide) double_b = rnd.NextDouble() * 1024.0 - 512.0;

                        lhsValue = "" + double_a.ToString("R");
                        rhsValue = "" + double_b.ToString("R");
                        switch (op)
                        {
                            case "+": resultValue = "" + (isBinary ? (double_a + double_b) : +double_a).ToString("R"); break;
                            case "-": resultValue = "" + (isBinary ? (double_a - double_b) : -double_a).ToString("R"); break;
                            case "*": resultValue = "" + (double_a * double_b).ToString("R"); break;
                            case "/": resultValue = "" + (double_a / double_b).ToString("R"); break;
                            case "%": resultValue = "" + (double_a % double_b).ToString("R"); break;

                            case "<": resultValue = (double_a < double_b) ? "true" : "false"; break;
                            case ">": resultValue = (double_a > double_b) ? "true" : "false"; break;
                            case "==": resultValue = (double_a == double_b) ? "true" : "false"; break;
                            case "!=": resultValue = (double_a != double_b) ? "true" : "false"; break;
                            case "<=": resultValue = (double_a <= double_b) ? "true" : "false"; break;
                            case ">=": resultValue = (double_a >= double_b) ? "true" : "false"; break;

                            case "++": resultValue = "" + (isPrefix ? ++double_a : double_a++).ToString("R"); break;
                            case "--": resultValue = "" + (isPrefix ? --double_a : double_a--).ToString("R"); break;
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

        private void TestShuffle(StringBuilder str)
        {
            if (m_BaseType == "bool")
                return;

            var rnd = new Random(0);

            for (int resultComponents = 1; resultComponents <= 4; resultComponents++)
            {
                BeginTest(str, "shuffle_result_" + resultComponents);

                string resultType = ToTypeName(m_BaseType, resultComponents, 1);
                str.AppendFormat("\t\t\t{0} a = {0}", m_TypeName);
                var a_data = (from row in Enumerable.Range(0, m_Rows) select m_BaseType == "bool" ? ((row & 1) != 0 ? "true" : "false") : "" + (row)).ToArray();
                var b_data = (from row in Enumerable.Range(0, m_Rows) select m_BaseType == "bool" ? ((row & 1) != 1 ? "true" : "false") : "" + (row + m_Rows)).ToArray();

                AddParenthesized(str, a_data);
                str.Append(";\n");
                str.AppendFormat("\t\t\t{0} b = {0}", m_TypeName);
                AddParenthesized(str, b_data);
                str.Append(";\n\n");


                int totalTests = (int)Math.Pow(m_Rows * 2, resultComponents);
                int targetTests = 16;
                int numTests = Math.Min(totalTests, targetTests);

                int[] shuffleIndices = new int[resultComponents];
                string[] shuffleValues = new string[resultComponents];

                for (int testIndex = 0; testIndex < numTests; testIndex++)
                {
                    if(numTests == totalTests)
                    {
                        // just enumerate all of them
                        int t = testIndex;
                        for(int i = 0; i < resultComponents; i++)
                        {
                            shuffleIndices[i] = t % (m_Rows * 2);
                            t /= m_Rows * 2;
                        }
                    }
                    else
                    {
                        // sample randomly
                        for (int i = 0; i < resultComponents; i++)
                            shuffleIndices[i] = rnd.Next(m_Rows * 2);
                    }
                    
                    str.Append("\t\t\tTestUtils.AreEqual(shuffle(a, b");
                    for(int i = 0; i < resultComponents; i++)
                    {
                        int t = shuffleIndices[i];
                        shuffleValues[i] = t >= m_Rows ? b_data[t - m_Rows] : a_data[t];
                        str.AppendFormat(", ShuffleComponent.{0}", shuffleComponents[t >= m_Rows ? (t - m_Rows + 4) : t]);
                    }
                    str.Append("), ");
                    if (resultComponents > 1)
                        str.Append(resultType);

                    AddParenthesized(str, shuffleValues);
                    str.Append(");\n");
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
            
            if (m_BaseType == "int" || m_BaseType == "uint" || m_BaseType == "float" || m_BaseType == "double")
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

            if(m_Columns == 1)
            {
                TestShuffle(str);
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
                             
                             
                             
                             
                             
                             