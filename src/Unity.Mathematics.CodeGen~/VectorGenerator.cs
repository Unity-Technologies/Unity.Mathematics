using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Unity.Mathematics.Mathematics.CodeGen
{
    class VectorGenerator
    {
        private string m_ImplementationDirectory;
        private string m_TestDirectory;
        string m_PerformanceTestDirectory;
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
            return m_primes[m_NextPrime++ & 255]; //TODO: fix
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

        [StructLayout(LayoutKind.Explicit)]
        internal struct UIntFloatUnion
        {
            [FieldOffset(0)]
            public uint uintValue;
            [FieldOffset(0)]
            public float floatValue;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct ULongDoubleUnion
        {
            [FieldOffset(0)]
            public ulong ulongValue;
            [FieldOffset(0)]
            public double doubleValue;
        }

        public static uint AsUInt(float x)
        {
            UIntFloatUnion u;
            u.uintValue = 0;
            u.floatValue = x;
            return u.uintValue;
        }

        public static ulong AsULong(double x)
        {
            ULongDoubleUnion u;
            u.ulongValue = 0;
            u.doubleValue = x;
            return u.ulongValue;
        }

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


        public enum VectorType { Row, Column, DontCare };
        public static string ToValueDescription(string baseType, int rows, int columns, int n, bool addRowColumnVectorPrefix = false)
        {
            string name = ToTypeName(baseType, rows, columns);

            string numStr = "";
            switch(n)
            {
                case 1:
                    numStr = baseType == "int" ? "an " : "a ";
                    break;
                case 2:
                    numStr = "two ";
                    break;
                case 3:
                    numStr = "three ";
                    break;
                case 4:
                    numStr = "four ";
                    break;
            }

            string vectorPrefix = addRowColumnVectorPrefix ? ((rows == 1) ? " row" : (columns == 1) ? " column" : "") : "";

            if(n > 1)
                return numStr + name + ((rows == 1 && columns == 1) ? " values" : (rows > 1 && columns > 1) ? " matrices" : vectorPrefix + " vectors");
            else
                return numStr + name + ((rows == 1 && columns == 1) ? " value" : (rows > 1 && columns > 1) ? " matrix" : vectorPrefix + " vector");
        }

        public static string ToTypedLiteral(string baseType, int value)
        {
            switch(baseType)
            {
                case "int":
                    return "" + value;
                case "uint":
                    return "" + value + "u";
                case "half":
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

        private static string s_AutoGenHeader =
            "//------------------------------------------------------------------------------\n" +
            "// <auto-generated>\n" +
            "//     This code was generated by a tool.\n" +
            "//\n" +
            "//     Changes to this file may cause incorrect behavior and will be lost if\n" +
            "//     the code is regenerated. To update the generation of this file, modify and re-run Unity.Mathematics.CodeGen.\n" +
            "// </auto-generated>\n" +
            "//------------------------------------------------------------------------------\n";

        private static void WriteFile(string filename, string text)
        {
            // Convert all tabs to spaces
            text = text.Replace("\t", "    ");
            // Normalize line endings, convert all EOL to platform EOL (and let git handle it)
            text = text.Replace("\r\n", "\n");
            text = text.Replace("\n", Environment.NewLine);

            // Generate auto generated comment
            text = s_AutoGenHeader + text;

            // Trim trailing spaces that could have come from code gen.
            char[] trim = { ' ' };
            var lines = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; ++i)
            {
                lines[i] = lines[i].TrimEnd(trim);
            }

            text = string.Join(Environment.NewLine, lines);

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


            if(m_BaseType != "half")
            {
                str = new StringBuilder();
                GenerateTypeTests(str);
                WriteFile(m_TestDirectory + "/Test" + UpperCaseFirstLetter(m_TypeName) + ".gen.cs", str.ToString());
            }
        }
        private void WriteMath()
        {
            StringBuilder str = new StringBuilder();
            GenerateMathTests(str);
            WriteFile(m_TestDirectory + "/TestMath.gen.cs", str.ToString());
        }

        public static void Write(string implementationDirectory, string testDirectory, string performanceTestDirectory)
        {
            VectorGenerator vectorGenerator = new VectorGenerator();
            vectorGenerator.m_ImplementationDirectory = implementationDirectory;
            vectorGenerator.m_TestDirectory = testDirectory;
            vectorGenerator.m_PerformanceTestDirectory = performanceTestDirectory;

            for(int rows = 1; rows <= 4; rows++)
            {
                for(int columns = 1; columns <= 4; columns++)
                {
                    if (rows == 1 && columns == 1)  // don't generate type1x1
                        continue;

                    if (columns == 1)
                        vectorGenerator.WriteType("half", rows, columns, 0);

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
            vectorGenerator.WriteMath();
            vectorGenerator.WritePerformanceTests();
        }


        private void GenerateMemberVariables(StringBuilder str)
        {
            if(m_Columns > 1)
            {
                string columnType = ToTypeName(m_BaseType, m_Rows, 1);
                for (int i = 0; i < m_Columns; i++)
                {
                    str.AppendFormat($"\t\t/// <summary>Column {i} of the matrix.</summary>\n");
                    str.AppendFormat("\t\tpublic {0} {1};\n", columnType, matrixFields[i]);
                }
            }
            else
            {
                for (int i = 0; i < m_Rows; i++)
                {
                    str.AppendFormat($"\t\t/// <summary>{vectorFields[i]} component of the vector.</summary>\n");
                    if (m_Columns == 1 && m_BaseType == "bool")
                        str.Append("\t\t[MarshalAs(UnmanagedType.U1)]\n");
                    str.AppendFormat("\t\tpublic {0} {1};\n", m_BaseType, vectorFields[i]);
                }
            }
            str.Append("\n");
        }

        private void GenerateStaticFields(StringBuilder str)
        {
            if (m_BaseType == "int" || m_BaseType == "uint" || m_BaseType == "half" || m_BaseType == "float" || m_BaseType == "double")
            {
                string zeroStr = ToTypedLiteral(m_BaseType, 0);

                // identity
                if (m_Rows == m_Columns)
                {
                    string oneStr = ToTypedLiteral(m_BaseType, 1);
                    str.AppendFormat("\t\t/// <summary>{0} identity transform.</summary>\n", m_TypeName);
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
                    str.Append(");\n\n");
                }

                // zero
                str.AppendFormat("\t\t/// <summary>{0} zero value.</summary>\n", m_TypeName);
                str.AppendFormat("\t\tpublic static readonly {0} zero;\n", m_TypeName);
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
            string dstTypeCategory = (m_Columns > 1) ? "matrix" : "vector";
            string plicitlyString = isExplicit ? "Explicitly" : "Implicitly";

            if (isScalar)
            {
                if(sourceBaseType != m_BaseType)
                {
                    str.AppendFormat("\t\t/// <summary>Constructs a {0} {1} from a single {2} value by converting it to {3} and assigning it to every component.</summary>\n", m_TypeName, dstTypeCategory, sourceType, m_BaseType);
                    str.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");

                    mathStr.AppendFormat("\t\t/// <summary>Returns a {0} {1} constructed from a single {2} value by converting it to {3} and assigning it to every component.</summary>\n", m_TypeName, dstTypeCategory, sourceType, m_BaseType);
                    mathStr.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");

                    opStr.AppendFormat("\t\t/// <summary>{0} converts a single {1} value to a {2} {3} by converting it to {4} and assigning it to every component.</summary>\n", plicitlyString, sourceType, m_TypeName, dstTypeCategory, m_BaseType);
                    opStr.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");
                }
                else
                {
                    str.AppendFormat("\t\t/// <summary>Constructs a {0} {1} from a single {2} value by assigning it to every component.</summary>\n", m_TypeName, dstTypeCategory, sourceType);
                    str.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");

                    mathStr.AppendFormat("\t\t/// <summary>Returns a {0} {1} constructed from a single {2} value by assigning it to every component.</summary>\n", m_TypeName, dstTypeCategory, sourceType);
                    mathStr.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");

                    opStr.AppendFormat("\t\t/// <summary>{0} converts a single {1} value to a {2} {3} by assigning it to every component.</summary>\n", plicitlyString, sourceType, m_TypeName, dstTypeCategory);
                    opStr.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");
                }
            }
            else
            {
                if (sourceBaseType != m_BaseType)
                {
                    str.AppendFormat("\t\t/// <summary>Constructs a {0} {1} from a {2} {1} by componentwise conversion.</summary>\n", m_TypeName, dstTypeCategory, sourceType);
                    str.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");

                    mathStr.AppendFormat("\t\t/// <summary>Return a {0} {1} constructed from a {2} {1} by componentwise conversion.</summary>\n", m_TypeName, dstTypeCategory, sourceType);
                    mathStr.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");

                    opStr.AppendFormat("\t\t/// <summary>{0} converts a {1} {2} to a {3} {2} by componentwise conversion.</summary>\n", plicitlyString, sourceType, dstTypeCategory, m_TypeName);
                    opStr.AppendFormat($"\t\t/// <param name=\"v\">{sourceType} to convert to {m_TypeName}</param>\n");
                }
            }

            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic {0}({1} v)\n", m_TypeName, sourceType);
            str.Append("\t\t{\n");
            for(int i = 0; i < fieldCount; i++)
            {
                string rhs = "v";
                if (!isScalar)
                    rhs = rhs + "." + fields[i];
                if (isExplicit)
                {
                    if (sourceBaseType == "bool")
                    {
                        if (m_Columns > 1)
                            rhs = string.Format("math.select(new {0}({1}), new {0}({2}), {3})", dstFieldType, ToTypedLiteral(m_BaseType, 0), ToTypedLiteral(m_BaseType, 1), rhs);
                        else
                            rhs = rhs + " ? " + ToTypedLiteral(m_BaseType, 1) + " : " + ToTypedLiteral(m_BaseType, 0);
                    }

                    else
                        rhs = "(" + dstFieldType + ")" + rhs;
                }


                str.AppendFormat("\t\t\tthis.{0} = {1};\n", fields[i], rhs);
            }
            str.Append("\t\t}\n\n");

            mathStr.Append("\t\t/// <returns>Converted value.</returns>\n");
            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.AppendFormat("\t\tpublic static {0} {0}({1} v) {{ return new {0}(v); }}\n\n", m_TypeName, sourceType);

            opStr.Append("\t\t/// <returns>Converted value.</returns>\n");
            opStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            opStr.AppendFormat("\t\tpublic static {0} operator {1}({2} v) {{ return new {1}(v); }}\n\n", isExplicit ? "explicit" : "implicit", m_TypeName, sourceType);
        }

        private void GenerateConversionConstructorsAndOperators(StringBuilder str, StringBuilder mathStr)
        {
            StringBuilder opStr = new StringBuilder();

            GenerateConversion(str, opStr, mathStr, m_BaseType, false, true);

            if (m_BaseType == "int")
            {
                GenerateConversion(str, opStr, mathStr, "bool", true, true);
                GenerateConversion(str, opStr, mathStr, "bool", true, false);
                GenerateConversion(str, opStr, mathStr, "uint", true, true);
                GenerateConversion(str, opStr, mathStr, "uint", true, false);
                GenerateConversion(str, opStr, mathStr, "float", true, true);
                GenerateConversion(str, opStr, mathStr, "float", true, false);
                GenerateConversion(str, opStr, mathStr, "double", true, true);
                GenerateConversion(str, opStr, mathStr, "double", true, false);
            }
            else if (m_BaseType == "uint")
            {
                GenerateConversion(str, opStr, mathStr, "bool", true, true);
                GenerateConversion(str, opStr, mathStr, "bool", true, false);
                GenerateConversion(str, opStr, mathStr, "int", true, true);
                GenerateConversion(str, opStr, mathStr, "int", true, false);
                GenerateConversion(str, opStr, mathStr, "float", true, true);
                GenerateConversion(str, opStr, mathStr, "float", true, false);
                GenerateConversion(str, opStr, mathStr, "double", true, true);
                GenerateConversion(str, opStr, mathStr, "double", true, false);
            }
            else if (m_BaseType == "half")
            {
                GenerateConversion(str, opStr, mathStr, "float", true, true);
                GenerateConversion(str, opStr, mathStr, "float", true, false);
                GenerateConversion(str, opStr, mathStr, "double", true, true);
                GenerateConversion(str, opStr, mathStr, "double", true, false);
            }
            else if (m_BaseType == "float")
            {
                GenerateConversion(str, opStr, mathStr, "bool", true, true);
                GenerateConversion(str, opStr, mathStr, "bool", true, false);
                GenerateConversion(str, opStr, mathStr, "int", false, true);
                GenerateConversion(str, opStr, mathStr, "int", false, false);
                GenerateConversion(str, opStr, mathStr, "uint", false, true);
                GenerateConversion(str, opStr, mathStr, "uint", false, false);
                if(m_Columns == 1)
                {
                    GenerateConversion(str, opStr, mathStr, "half", false, true);
                    GenerateConversion(str, opStr, mathStr, "half", false, false);
                }

                GenerateConversion(str, opStr, mathStr, "double", true, true);
                GenerateConversion(str, opStr, mathStr, "double", true, false);
            }
            else if (m_BaseType == "double")
            {
                GenerateConversion(str, opStr, mathStr, "bool", true, true);
                GenerateConversion(str, opStr, mathStr, "bool", true, false);
                GenerateConversion(str, opStr, mathStr, "int", false, true);
                GenerateConversion(str, opStr, mathStr, "int", false, false);
                GenerateConversion(str, opStr, mathStr, "uint", false, true);
                GenerateConversion(str, opStr, mathStr, "uint", false, false);
                if (m_Columns == 1)
                {
                    GenerateConversion(str, opStr, mathStr, "half", false, true);
                    GenerateConversion(str, opStr, mathStr, "half", false, false);
                }
                GenerateConversion(str, opStr, mathStr, "float", false, true);
                GenerateConversion(str, opStr, mathStr, "float", false, false);
            }


            str.Append("\n");
            str.Append(opStr);
            str.Append("\n");
        }

        private void GenerateTypeImplementation(StringBuilder str)
        {
            StringBuilder mathStr = new StringBuilder();

            str.Append("using System;\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            if (m_Columns == 1 && m_BaseType == "bool")
                str.Append("using System.Runtime.InteropServices;\n");  // for MarshalAs
            if (m_Columns == 1)
                str.Append("using System.Diagnostics;\n");   // for DebuggerTypeProxy
            str.Append("using Unity.IL2CPP.CompilerServices;\n");
            str.Append("\n");
            str.Append("#pragma warning disable 0660, 0661\n\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");

            if (m_Columns > 1)
            {
                str.Append($"\t/// <summary>A {m_Rows}x{m_Columns} matrix of {m_BaseType}s.</summary>\n");
            }
            else
            {
                str.Append($"\t/// <summary>A {m_Rows} component vector of {m_BaseType}s.</summary>\n");
            }

            if (m_Columns == 1)
                str.AppendFormat("\t[DebuggerTypeProxy(typeof({0}.DebuggerProxy))]\n", m_TypeName);
            str.Append("\t[System.Serializable]\n");
            str.Append("\t[Il2CppEagerStaticClassConstruction]\n");
            str.AppendFormat("\tpublic partial struct {0} : System.IEquatable<{0}>", m_TypeName);
            if (m_BaseType != "bool")
                str.Append(", IFormattable");
            str.Append("\n\t{\n");

            GenerateMemberVariables(str);

            GenerateStaticFields(str);

            GenerateConstructors(str, mathStr);

            GenerateConversionConstructorsAndOperators(str, mathStr);

            GenerateOperators(str);

            var isMatrix = m_Rows > 1 && m_Columns > 1;

            if(m_Rows == 4 && m_Columns == 4 && (m_BaseType == "float" || m_BaseType == "double"))
            {

                GenerateMulImplementation("rotate", m_BaseType, mathStr, 4, 4, 3, 1, false, GenerateMulType.Rotate);
                GenerateMulImplementation("transform", m_BaseType, mathStr, 4, 4, 3, 1, true, GenerateMulType.Transform);
            }

            GenerateTransposeFunction(mathStr);
            GenerateInverseFunction(mathStr);
            GenerateFastInverseFunction(mathStr);
            GenerateDeterminantFunction(mathStr);
            GenerateHashFunction(mathStr, false);
            GenerateHashFunction(mathStr, true);

            if (m_Columns == 1)
            {
                str.Append("\n\n");
                GenerateSwizzles(str);
                GenerateShuffleImplementation(mathStr);
            }


            str.Append("\n");
            GenerateIndexOperator(str, isMatrix ? IndexerMode.ByRef : IndexerMode.ByValue);

            str.Append("\n");
            GenerateEquals(str);

            str.Append("\n");
            GenerateGetHashCode(str);

            str.Append("\n");
            GenerateToStringFunction(str, false);
            if(m_BaseType != "bool")
                GenerateToStringFunction(str, true);

            GenerateDebuggerTypeProxy(str);


            // Internal members last
            if (m_Columns == 1 && m_BaseType != "half")
            {
                GenerateSelectShuffleComponentImplementation(mathStr);
            }

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
            if (m_Columns > 1 || m_BaseType == "half")
                return;

            for (int resultComponents = 1; resultComponents <= 4; resultComponents++)
            {
                string resultType = ToTypeName(m_BaseType, resultComponents, 1);

                str.AppendFormat("\t\t/// <summary>Returns the result of specified shuffling of the components from {0} into {1}.</summary>\n",
                    ToValueDescription(m_BaseType, m_Rows, m_Columns, 2), ToValueDescription(m_BaseType, resultComponents, m_Columns, 1));
                str.AppendFormat($"\t\t/// <param name=\"left\">{ToTypeName(m_BaseType, m_Rows, m_Columns)} to use as the left argument of the shuffle operation.</param>\n");
                str.AppendFormat($"\t\t/// <param name=\"right\">{ToTypeName(m_BaseType, m_Rows, m_Columns)} to use as the right argument of the shuffle operation.</param>\n");

                if (resultComponents == 1)
                {
                    str.AppendFormat($"\t\t/// <param name=\"{vectorFields[0]}\">The ShuffleComponent to use when setting the resulting {resultType}.</param>\n");
                }
                else
                {
                    for (int i = 0; i < resultComponents; ++i)
                    {
                        str.AppendFormat($"\t\t/// <param name=\"{vectorFields[i]}\">The ShuffleComponent to use when setting the resulting {resultType} {vectorFields[i]} component.</param>\n");
                    }
                }

                str.AppendFormat($"\t\t/// <returns>{resultType} result of the shuffle operation.</returns>\n");
                str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
                str.AppendFormat("\t\tpublic static {0} shuffle({1} left, {2} right", resultType, m_TypeName, m_TypeName);
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

                    str.AppendFormat("select_shuffle_component(left, right, {0})", vectorFields[i]);
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

        enum GenerateMulType
        {
            Mul,
            Rotate,
            Transform
        }

        private void GenerateMulImplementation(string name, string baseType, StringBuilder str, int lhsRows, int lhsColumns, int rhsRows, int rhsColumns, bool doTranslation, GenerateMulType mulType)
        {
            // mul(a,b): if a is vector it is treated as a row vector. if b is a vector it is treaded as a column vector.
            bool isResultRowVector = (lhsRows == 1 && lhsColumns > 1);
            int resultRows = (lhsColumns != rhsRows) ? rhsRows : lhsRows;
            string resultType = ToTypeName(baseType, resultRows, rhsColumns);
            string lhsType = ToTypeName(baseType, lhsRows, lhsColumns);
            string rhsType = ToTypeName(baseType, rhsRows, rhsColumns);

            bool isScalarResult = (resultRows == 1 && rhsColumns == 1);

            switch (mulType)
            {
                case GenerateMulType.Mul:
                    str.AppendFormat("\t\t/// <summary>Returns the {0} result of a matrix multiplication between {1} and {2}.</summary>\n",
                        ToValueDescription(baseType, resultRows, rhsColumns, 0, true),
                        ToValueDescription(baseType, lhsRows, lhsColumns, 1, true),
                        ToValueDescription(baseType, rhsRows, rhsColumns, 1, true));
                    str.AppendFormat("\t\t/// <param name=\"a\">Left hand side argument of the matrix multiply.</param>\n");
                    str.AppendFormat("\t\t/// <param name=\"b\">Right hand side argument of the matrix multiply.</param>\n");
                    str.AppendFormat("\t\t/// <returns>The computed matrix multiplication.</returns>\n");
                    break;
                case GenerateMulType.Rotate:
                    str.AppendFormat("\t\t/// <summary>{0}</summary>\n", string.Format("Return the result of rotating a {0} vector by a {1} matrix", ToTypeName(m_BaseType, rhsRows, rhsColumns), ToTypeName(m_BaseType, lhsRows, lhsColumns)));
                    str.AppendFormat("\t\t/// <param name =\"a\">Left hand side matrix argument that specifies the rotation.</param>\n");
                    str.AppendFormat("\t\t/// <param name =\"b\">Right hand side vector argument to be rotated.</param>\n");
                    str.AppendFormat("\t\t/// <returns>The rotated vector.</returns>\n");
                    break;
                case GenerateMulType.Transform:
                    str.AppendFormat("\t\t/// <summary>{0}</summary>\n", string.Format("Return the result of transforming a {0} point by a {1} matrix", ToTypeName(m_BaseType, rhsRows, rhsColumns), ToTypeName(m_BaseType, lhsRows, lhsColumns)));
                    str.AppendFormat("\t\t/// <param name =\"a\">Left hand side matrix argument that specifies the transformation.</param>\n");
                    str.AppendFormat("\t\t/// <param name =\"b\">Right hand side point argument to be transformed.</param>\n");
                    str.AppendFormat("\t\t/// <returns>The transformed point.</returns>\n");
                    break;
            }

            bool needsSwizzle = (resultRows != lhsRows);

            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {1} {0}({2} a, {3} b)\n", name, resultType, lhsType, rhsType);
            str.Append("\t\t{\n");

            str.Append("\t\t\treturn ");

            bool needsParen = rhsColumns > 1 || needsSwizzle;

            if (rhsColumns > 1)
                str.Append(resultType);
            if (needsParen)
                str.Append("(");

            for (int i = 0; i < rhsColumns; i++)
            {
                if (i > 0 || rhsColumns > 1)
                    str.Append("\n\t\t\t\t");
                for (int j = 0; j < lhsColumns; j++)
                {
                    if(j < rhsRows || doTranslation)
                    {
                        if (j != 0)
                            str.Append(" + ");

                        if (lhsRows == 1 && lhsColumns == 1)
                            str.Append("a");
                        else if (lhsRows == 1 || lhsColumns == 1)
                            str.Append("a." + vectorFields[j]);
                        else
                            str.Append("a." + matrixFields[j]);

                        if(j < rhsRows)
                        {
                            str.Append(" * ");

                            if (rhsRows == 1 && rhsColumns == 1)
                                str.Append("b");
                            else if (rhsRows == 1 || rhsColumns == 1)
                                str.Append("b." + vectorFields[j]);
                            else
                                str.Append("b." + matrixFields[i] + "." + vectorFields[j]);
                        }
                    }

                }

                if (i != rhsColumns - 1)
                    str.Append(",");
            }
            if (needsParen)
                str.Append(")");
            if (needsSwizzle)
                str.Append("." + GenerateComponentRangeString(0, resultRows));

            str.Append(";\n");
            str.Append("\t\t}\n\n");
        }

        private void GenerateMulImplementations(string baseType, StringBuilder str)
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

                        GenerateMulImplementation("mul", baseType, str, n, m, m, k, false, GenerateMulType.Mul);
                    }
                }
            }
        }

        private void GenerateMatrixImplementation(StringBuilder str)
        {
            str.Append("using System;\n");
            str.Append("using System.Runtime.CompilerServices;\n");
            str.Append("\n");
            str.Append("namespace Unity.Mathematics\n");
            str.Append("{\n");
            str.Append("\tpartial class math\n");
            str.Append("\t{\n");

            GenerateMulImplementations("float", str);
            GenerateMulImplementations("double", str);
            GenerateMulImplementations("int", str);
            GenerateMulImplementations("uint", str);

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
            string dstTypeCategory = (m_Columns > 1) ? "matrix" : "vector";

            StringBuilder descriptionStr = new StringBuilder();
            {
                int idx = 0;
                bool first = true;
                while(true)
                {
                    int paramComponents = parameterComponents[idx];
                    string paramType = ToTypeName(m_BaseType, paramComponents, 1);

                    int n = 1;
                    while(idx + 1 < numParameters && parameterComponents[idx + 1] == paramComponents)
                    {
                        n++;
                        idx++;
                    }
                    idx++;

                    bool last = (idx == numParameters);
                    if (!first)
                        descriptionStr.Append(last ? " and " : ", ");

                    descriptionStr.Append(ToValueDescription(m_BaseType, paramComponents, 1, n));
                    if (last)
                        break;
                    first = false;
                }
            }


            constructorStr.AppendFormat("\t\t/// <summary>Constructs a {0} {1} from {2}.</summary>\n", m_TypeName, dstTypeCategory, descriptionStr.ToString());

            int componentIndex = 0;
            for (int i = 0; i < numParameters; ++i)
            {
                int paramComponents = parameterComponents[i];
                string componentString = GenerateComponentRangeString(componentIndex, paramComponents);
                string componentPluralOrSingular = paramComponents > 1 ? "components" : "component";
                constructorStr.Append($"\t\t/// <param name=\"{componentString}\">The constructed vector's {componentString} {componentPluralOrSingular} will be set to this value.</param>\n");
                componentIndex += paramComponents;
            }

            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");

            mathStr.AppendFormat("\t\t/// <summary>Returns a {0} {1} constructed from {2}.</summary>\n", m_TypeName, dstTypeCategory, descriptionStr.ToString());

            componentIndex = 0;
            for (int i = 0; i < numParameters; ++i)
            {
                int paramComponents = parameterComponents[i];
                string componentString = GenerateComponentRangeString(componentIndex, paramComponents);
                string componentPluralOrSingular = paramComponents > 1 ? "components" : "component";
                mathStr.Append($"\t\t/// <param name=\"{componentString}\">The constructed vector's {componentString} {componentPluralOrSingular} will be set to this value.</param>\n");
                componentIndex += paramComponents;
            }

            mathStr.Append($"\t\t/// <returns>{m_TypeName} constructed from arguments.</returns>\n");
            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.Append("\t\tpublic static ");
            mathStr.Append(m_TypeName);
            mathStr.Append(" ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");

            componentIndex = 0;
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
            string columnType = ToTypeName(m_BaseType, m_Rows, 1);
            string columnDescription = ToValueDescription(m_BaseType, m_Rows, 1, m_Columns);
            constructorStr.AppendFormat("\t\t/// <summary>Constructs a {0} matrix from {1}.</summary>\n", m_TypeName, columnDescription);

            for (int col = 0; col < m_Columns; ++col)
            {
                constructorStr.Append($"\t\t/// <param name=\"{matrixFields[col]}\">The matrix column {matrixFields[col]} will be set to this value.</param>\n");
            }

            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");

            mathStr.AppendFormat("\t\t/// <summary>Returns a {0} matrix constructed from {1}.</summary>\n", m_TypeName, columnDescription);

            for (int col = 0; col < m_Columns; ++col)
            {
                mathStr.Append($"\t\t/// <param name=\"{matrixFields[col]}\">The matrix column {matrixFields[col]} will be set to this value.</param>\n");
            }

            mathStr.Append($"\t\t/// <returns>{m_TypeName} constructed from arguments.</returns>\n");
            mathStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            mathStr.Append("\t\tpublic static ");
            mathStr.Append(m_TypeName);
            mathStr.Append(" ");
            mathStr.Append(m_TypeName);
            mathStr.Append("(");

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
            constructorStr.AppendFormat("\t\t/// <summary>Constructs a {0} matrix from {1} {2} values given in row-major order.</summary>\n", m_TypeName, m_Rows * m_Columns, m_BaseType);

            for (int row = 0; row < m_Rows; ++row)
            {
                for (int col = 0; col < m_Columns; ++col)
                {
                    constructorStr.Append($"\t\t/// <param name=\"m{row}{col}\">The matrix at row {row}, column {col} will be set to this value.</param>\n");
                }
            }

            constructorStr.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            constructorStr.Append("\t\tpublic ");
            constructorStr.Append(m_TypeName);
            constructorStr.Append("(");
            mathStr.AppendFormat("\t\t/// <summary>Returns a {0} matrix constructed from from {1} {2} values given in row-major order.</summary>\n", m_TypeName, m_Rows * m_Columns, m_BaseType);

            for (int row = 0; row < m_Rows; ++row)
            {
                for (int col = 0; col < m_Columns; ++col)
                {
                    mathStr.Append($"\t\t/// <param name=\"m{row}{col}\">The matrix at row {row}, column {col} will be set to this value.</param>\n");
                }
            }

            mathStr.Append($"\t\t/// <returns>{m_TypeName} constructed from arguments.</returns>\n");
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
                GenerateBinaryOperator(m_Rows, m_Columns, "*", resultType, str, "multiplication");

                GenerateBinaryOperator(m_Rows, m_Columns, "+", resultType, str, "addition");

                GenerateBinaryOperator(m_Rows, m_Columns, "-", resultType, str, "subtraction");

                GenerateBinaryOperator(m_Rows, m_Columns, "/", resultType, str, "division");

                GenerateBinaryOperator(m_Rows, m_Columns, "%", resultType, str, "modulus");

                GenerateUnaryOperator("++", str, "increment");

                GenerateUnaryOperator("--", str, "decrement");

                GenerateBinaryOperator(m_Rows, m_Columns, "<", resultBoolType, str, "less than");
                GenerateBinaryOperator(m_Rows, m_Columns, "<=", resultBoolType, str, "less or equal");

                GenerateBinaryOperator(m_Rows, m_Columns, ">", resultBoolType, str, "greater than");
                GenerateBinaryOperator(m_Rows, m_Columns, ">=", resultBoolType, str, "greater or equal");
            }

            if (0 != (m_Features & Features.UnaryNegation))
            {
                GenerateUnaryOperator("-", str, "unary minus");
                GenerateUnaryOperator("+", str, "unary plus");
            }

            if (0 != (m_Features & Features.Shifts))
            {
                GenerateShiftOperator(m_Rows, "<<", resultType, str, "left shift");
                GenerateShiftOperator(m_Rows, ">>", resultType, str, "right shift");
            }

            GenerateBinaryOperator(m_Rows, m_Columns, "==", resultBoolType, str, "equality");
            GenerateBinaryOperator(m_Rows, m_Columns, "!=", resultBoolType, str, "not equal");

            if (0 != (m_Features & Features.BitwiseComplement))
            {
                GenerateUnaryOperator("~", str, "bitwise not");
            }

            if(m_BaseType == "bool")
            {
                GenerateUnaryOperator("!", str, "not");
            }

            if (0 != (m_Features & Features.BitwiseLogic))
            {
                GenerateBinaryOperator(m_Rows, m_Columns, "&", resultType, str, "bitwise and");
                GenerateBinaryOperator(m_Rows, m_Columns, "|", resultType, str, "bitwise or");
                GenerateBinaryOperator(m_Rows, m_Columns, "^", resultType, str, "bitwise exclusive or");

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
            str.AppendFormat("\t\t/// <summary>Return the {0} transpose of a {1} matrix.</summary>\n", resultType, m_TypeName);
            str.Append($"\t\t/// <param name=\"v\">Value to transpose.</param>\n");
            str.Append($"\t\t/// <returns>Transposed value.</returns>\n");
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

            string oneStr = ToTypedLiteral(m_BaseType, 1);

            if(m_Rows == 2)
            {
                str.AppendFormat("        /// <summary>Returns the {0}2x2 full inverse of a {0}2x2 matrix.</summary>\n", m_BaseType);
                str.AppendFormat("        /// <param name=\"m\">Matrix to invert.</param>\n");
                str.AppendFormat("        /// <returns>The inverted matrix.</returns>\n");
                str.AppendFormat(@"        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
                str.AppendFormat("        /// <summary>Returns the {0}3x3 full inverse of a {0}3x3 matrix.</summary>\n", m_BaseType);
                str.AppendFormat("        /// <param name=\"m\">Matrix to invert.</param>\n");
                str.AppendFormat("        /// <returns>The inverted matrix.</returns>\n");
                str.AppendFormat(@"        public static {0}3x3 inverse({0}3x3 m)
        {{
            {0}3 c0 = m.c0;
            {0}3 c1 = m.c1;
            {0}3 c2 = m.c2;

            {0}3 t0 = {0}3(c1.x, c2.x, c0.x);
            {0}3 t1 = {0}3(c1.y, c2.y, c0.y);
            {0}3 t2 = {0}3(c1.z, c2.z, c0.z);

            {0}3 m0 = t1 * t2.yzx - t1.yzx * t2;
            {0}3 m1 = t0.yzx * t2 - t0 * t2.yzx;
            {0}3 m2 = t0 * t1.yzx - t0.yzx * t1;

            {0} rcpDet = {1} / csum(t0.zxy * m0);
            return {0}3x3(m0, m1, m2) * rcpDet;
        }}

",
                m_BaseType, oneStr);
            }
            else if(m_Rows == 4)
            {
                str.AppendFormat("        /// <summary>Returns the {0}4x4 full inverse of a {0}4x4 matrix.</summary>\n", m_BaseType);
                str.AppendFormat("        /// <param name=\"m\">Matrix to invert.</param>\n");
                str.AppendFormat("        /// <returns>The inverted matrix.</returns>\n");
                str.AppendFormat(@"        public static {0}4x4 inverse({0}4x4 m)
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

        public void GenerateFastInverseFunction(StringBuilder str)
        {
            if (m_BaseType != "float" && m_BaseType != "double")
                return;

            string zeroStr = ToTypedLiteral(m_BaseType, 0);
            string oneStr = ToTypedLiteral(m_BaseType, 1);

            if(m_Columns == 4 && m_Rows == 3)
            {
                str.AppendFormat("        /// <summary>Fast matrix inverse for rigid transforms (orthonormal basis and translation)</summary>\n");
                str.AppendFormat("        /// <param name=\"m\">Matrix to invert.</param>\n");
                str.AppendFormat("        /// <returns>The inverted matrix.</returns>\n");
                str.AppendFormat(@"        public static {0}3x4 fastinverse({0}3x4 m)
        {{
            {0}3 c0 = m.c0;
            {0}3 c1 = m.c1;
            {0}3 c2 = m.c2;
            {0}3 pos = m.c3;

            {0}3 r0 = {0}3(c0.x, c1.x, c2.x);
            {0}3 r1 = {0}3(c0.y, c1.y, c2.y);
            {0}3 r2 = {0}3(c0.z, c1.z, c2.z);

            pos = -(r0 * pos.x + r1 * pos.y + r2 * pos.z);

            return {0}3x4(r0, r1, r2, pos);
        }}

",
                    m_BaseType);

            } else if(m_Columns == 4 && m_Rows == 4)
            {
                str.AppendFormat("        /// <summary>Fast matrix inverse for rigid transforms (orthonormal basis and translation)</summary>\n");
                str.AppendFormat("        /// <param name=\"m\">Matrix to invert.</param>\n");
                str.AppendFormat("        /// <returns>The inverted matrix.</returns>\n");
                str.AppendFormat(@"        public static {0}4x4 fastinverse({0}4x4 m)
        {{
            {0}4 c0 = m.c0;
            {0}4 c1 = m.c1;
            {0}4 c2 = m.c2;
            {0}4 pos = m.c3;

            {0}4 zero = {0}4(0);

            {0}4 t0 = unpacklo(c0, c2);
            {0}4 t1 = unpacklo(c1, zero);
            {0}4 t2 = unpackhi(c0, c2);
            {0}4 t3 = unpackhi(c1, zero);

            {0}4 r0 = unpacklo(t0, t1);
            {0}4 r1 = unpackhi(t0, t1);
            {0}4 r2 = unpacklo(t2, t3);

            pos = -(r0 * pos.x + r1 * pos.y + r2 * pos.z);
            pos.w = 1.0f;

            return {0}4x4(r0, r1, r2, pos);
        }}

",
                    m_BaseType, zeroStr, oneStr);
            }

        }


        public void GenerateDeterminantFunction(StringBuilder str)
        {
            if (m_Rows != m_Columns || m_Rows == 1)
                return;

            if (m_BaseType != "float" && m_BaseType != "double" && m_BaseType != "int")
                return;

            str.Append($"\t\t/// <summary>Returns the determinant of a {ToTypeName(m_BaseType, m_Rows, m_Columns)} matrix.</summary>\n");
            str.Append($"\t\t/// <param name=\"m\">Matrix to use when computing determinant.</param>\n");
            str.Append($"\t\t/// <returns>The determinant of the matrix.</returns>\n");

            if (m_Rows == 2)
            {
                str.AppendFormat(@"        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
                str.AppendFormat(@"        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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
                str.AppendFormat(@"        public static {0} determinant({0}4x4 m)
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


        public void GenerateHashFunction(StringBuilder str, bool wide)
        {
            string returnType = wide ? ToTypeName("uint", m_Rows, 1) : "uint";
            string functionName = wide ? "hashwide" : "hash";
            string matrixOrVector = m_Columns > 1 ? "matrix" : "vector";
            string capitalMatrixOrVector = m_Columns > 1 ? "Matrix" : "Vector";

            if(wide)
            {
                str.AppendFormat("\t\t/// <summary>\n" +
                            "\t\t/// Returns a {0} vector hash code of a {1} {2}.\n" +
                            "\t\t/// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash\n" +
                            "\t\t/// that are only reduced to a narrow uint hash at the very end instead of at every step.\n" +
                            "\t\t/// </summary>\n", returnType, m_TypeName, matrixOrVector);
                str.Append($"\t\t/// <param name=\"v\">{capitalMatrixOrVector} value to hash.</param>\n");
            }
            else
            {
                str.AppendFormat("\t\t/// <summary>Returns a uint hash code of a {0} {1}.</summary>\n", m_TypeName, matrixOrVector);
                str.Append($"\t\t/// <param name=\"v\">{capitalMatrixOrVector} value to hash.</param>\n");
            }

            str.Append($"\t\t/// <returns>{returnType} hash of the argument.</returns>\n");
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {0} {1}({2} v)\n", returnType, functionName, m_TypeName);
            str.Append("\t\t{\n");

            str.AppendFormat("\t\t\treturn ");
            str.Append(wide ? "(" : "csum(");

            if (m_BaseType == "bool")
            {
                for (int column = 0; column < m_Columns; column++)
                {
                    if (column > 0)
                        str.Append(wide ? " + \n\t\t\t\t\t" : " + \n\t\t\t\t\t\t");

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
                        str.Append(wide ? " + \n\t\t\t\t\t" : " + \n\t\t\t\t\t\t");
                    string columnName = m_Columns > 1 ? "v.c" + column : "v";
                    if (m_BaseType != "uint")
                    {
                        if(m_BaseType == "double")
                            columnName = "fold_to_uint(" + columnName + ")";
                        else if(m_BaseType == "half")
                        {
                            if (m_Rows == 1)
                                columnName = "v.value";
                            else if(m_Rows == 2)
                                columnName = "uint2(v.x.value, v.y.value)";
                            else if (m_Rows == 3)
                                columnName = "uint3(v.x.value, v.y.value, v.z.value)";
                            else if (m_Rows == 4)
                                columnName = "uint4(v.x.value, v.y.value, v.z.value, v.w.value)";
                        }
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
            if (useFormat)
            {
                str.AppendFormat("\t\t/// <summary>Returns a string representation of the {0} using a specified format and culture-specific format information.</summary>\n", m_TypeName);
                str.AppendFormat("\t\t/// <param name=\"format\">Format string to use during string formatting.</param>\n");
                str.AppendFormat("\t\t/// <param name=\"formatProvider\">Format provider to use during string formatting.</param>\n");
            }
            else
                str.AppendFormat("\t\t/// <summary>Returns a string representation of the {0}.</summary>\n", m_TypeName);

            str.Append("\t\t/// <returns>String representation of the value.</returns>\n");
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

        void GenerateBinaryOperator(int rows, int columns, string op, string resultType, StringBuilder str, string opDesc)
        {
            GenerateBinaryOperator(rows, columns, rows, columns, op, resultType, rows, columns, str, opDesc);
            GenerateBinaryOperator(rows, columns, 1, 1, op, resultType, rows, columns, str, opDesc);
            GenerateBinaryOperator(1, 1, rows, columns, op, resultType, rows, columns, str, opDesc);
            str.Append("\n");
        }

        void GenerateBinaryOperator(int lhsRows, int lhsColumns, int rhsRows, int rhsColumns, string op, string resultType, int resultRows, int resultColumns, StringBuilder str, string opDesc)
        {
            if (lhsRows == rhsRows && lhsColumns == rhsColumns)
                str.AppendFormat("\t\t/// <summary>Returns the result of a componentwise {0} operation on {1}.</summary>\n", opDesc, ToValueDescription(m_BaseType, lhsRows, lhsColumns, 2));
            else
                str.AppendFormat("\t\t/// <summary>Returns the result of a componentwise {0} operation on {1} and {2}.</summary>\n", opDesc, ToValueDescription(m_BaseType, lhsRows, lhsColumns, 1), ToValueDescription(m_BaseType, rhsRows, rhsColumns, 1));

            str.AppendFormat($"\t\t/// <param name=\"lhs\">Left hand side {ToTypeName(m_BaseType, lhsRows, lhsColumns)} to use to compute componentwise {opDesc}.</param>\n");
            str.AppendFormat($"\t\t/// <param name=\"rhs\">Right hand side {ToTypeName(m_BaseType, rhsRows, rhsColumns)} to use to compute componentwise {opDesc}.</param>\n");
            str.AppendFormat($"\t\t/// <returns>{ToTypeName(resultType, resultRows, resultColumns)} result of the componentwise {opDesc}.</returns>\n");
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


            str.Append("); }\n\n");
        }

        enum IndexerMode
        {
            ByValue,
            ByRef
        }

        void GenerateIndexOperator(StringBuilder str, IndexerMode mode)
        {
            int count = m_Columns > 1 ? m_Columns : m_Rows;
            string returnType = ToTypeName(m_BaseType, m_Columns > 1 ? m_Rows : 1, 1);

            var refPrefix = mode == IndexerMode.ByRef ? "ref " : "";

            str.AppendFormat("\t\t/// <summary>Returns the {0} element at a specified index.</summary>\n", returnType);
            str.AppendFormat("\t\tunsafe public {1}{0} this[int index]\n", returnType, refPrefix);
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
            str.AppendFormat("* array = &this) {{ return {0}((", refPrefix);
            str.Append(returnType);
            str.Append("*)array)[index]; }\n");
            str.AppendLine("\t\t\t}");

            if (mode == IndexerMode.ByValue)
            {
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
            }

            str.AppendLine("\t\t}");

        }

        void GenerateEquals(StringBuilder str)
        {
            string[] fields = (m_Columns > 1) ? matrixFields : vectorFields;
            int resultCount = (m_Columns > 1) ? m_Columns : m_Rows;

            str.AppendFormat("\t\t/// <summary>Returns true if the {0} is equal to a given {0}, false otherwise.</summary>\n", m_TypeName);
            str.AppendFormat("\t\t/// <param name=\"rhs\">Right hand side argument to compare equality with.</param>\n");
            str.AppendFormat("\t\t/// <returns>The result of the equality comparison.</returns>\n");
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
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

            str.Append("; }\n\n");

            str.AppendFormat("\t\t/// <summary>Returns true if the {0} is equal to a given {0}, false otherwise.</summary>\n", m_TypeName);
            str.AppendFormat("\t\t/// <param name=\"o\">Right hand side argument to compare equality with.</param>\n");
            str.AppendFormat("\t\t/// <returns>The result of the equality comparison.</returns>\n");
            str.AppendFormat("\t\tpublic override bool Equals(object o) {{ return o is {0} converted && Equals(converted); }}\n\n", m_TypeName);
        }

        void GenerateGetHashCode(StringBuilder str)
        {
            str.AppendFormat("\t\t/// <summary>Returns a hash code for the {0}.</summary>\n", m_TypeName);
            str.AppendFormat("\t\t/// <returns>The computed hash code.</returns>\n");
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.Append("\t\tpublic override int GetHashCode() { return (int)math.hash(this); }\n\n");
        }


        void GenerateShiftOperator(int lhsRows, string op, string resultBaseType, StringBuilder str, string opDesc)
        {
            string[] fields = (m_Columns > 1) ? matrixFields : vectorFields;
            int resultCount = (m_Columns > 1) ? m_Columns : m_Rows;

            string matrixOrVector = m_Columns > 1 ? "matrix" : "vector";
            string resultType = ToTypeName(resultBaseType, resultCount, 1);
            str.AppendFormat("\t\t/// <summary>Returns the result of a componentwise {0} operation on {1} by a number of bits specified by a single int.</summary>\n", opDesc, ToValueDescription(m_BaseType, m_Rows, m_Columns, 1));
            str.AppendFormat($"\t\t/// <param name=\"x\">The {matrixOrVector} to {opDesc}.</param>\n");
            str.AppendFormat($"\t\t/// <param name=\"n\">The number of bits to {opDesc}.</param>\n");
            str.AppendFormat($"\t\t/// <returns>The result of the componentwise {opDesc}.</returns>\n");
            str.Append("\t\t[MethodImpl(MethodImplOptions.AggressiveInlining)]\n");
            str.AppendFormat("\t\tpublic static {0} operator {1} ({0} x, int n)", m_TypeName, op);
            str.Append(" { ");
            str.AppendFormat("return new {0} (", m_TypeName);

            for (int i = 0; i < resultCount; i++)
            {
                if (lhsRows == 1)
                {
                    str.AppendFormat("x {0} n", op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
                else
                {
                    int lhsIndex = i;
                    str.AppendFormat("x.{0} {1} n", fields[lhsIndex], op);
                    if (i != resultCount - 1)
                        str.Append(", ");
                }
            }

            str.Append("); }\n\n");
        }

        void GenerateUnaryOperator(string op, StringBuilder str, string opDesc)
        {
            str.AppendFormat("\t\t/// <summary>Returns the result of a componentwise {0} operation on {1}.</summary>\n", opDesc, ToValueDescription(m_BaseType, m_Rows, m_Columns, 1));
            str.Append($"\t\t/// <param name=\"val\">Value to use when computing the componentwise {opDesc}.</param>\n");
            str.Append($"\t\t/// <returns>{m_TypeName} result of the componentwise {opDesc}.</returns>\n");
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

            str.Append("); }\n\n\n");
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

            str.Append("\t\t/// <summary>Swizzles the vector.</summary>\n");

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
        private void BeginTest(StringBuilder str, string name, bool testCompiler = true)
        {
            if (testCompiler)
            {
                str.Append("\t\t[TestCompiler]\n");
            }
            else
            {
                str.Append("\t\t[TestCase]\n");
            }

            str.AppendFormat("\t\tpublic static void {0}()\n", name);
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

        private void TestStaticFields(StringBuilder str)
        {
            if (m_BaseType == "bool")
                return;

            if (m_Columns == 1)
            {
                BeginTest(str, m_TypeName + "_zero");
                for (int row = 0; row < m_Rows; row++)
                    str.AppendFormat("\t\t\tTestUtils.AreEqual({2}, {0}.zero.{1});\n", m_TypeName, components[row], ToTypedLiteral(m_BaseType, 0));
                EndTest(str);
            }
            else
            {
                BeginTest(str, m_TypeName + "_zero");
                for(int column = 0; column < m_Columns; column++)
                    for (int row = 0; row < m_Rows; row++)
                        str.AppendFormat("\t\t\tTestUtils.AreEqual({3}, {0}.zero.c{1}.{2});\n", m_TypeName, column, components[row], ToTypedLiteral(m_BaseType, 0));
                EndTest(str);

                if(m_Columns == m_Rows)
                {
                    BeginTest(str, m_TypeName + "_identity");
                    for (int column = 0; column < m_Columns; column++)
                        for (int row = 0; row < m_Rows; row++)
                            str.AppendFormat("\t\t\tTestUtils.AreEqual({3}, {0}.identity.c{1}.{2});\n", m_TypeName, column, components[row], ToTypedLiteral(m_BaseType, column == row ? 1 : 0));
                    EndTest(str);
                }
            }
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

                BeginTest(str, m_TypeName + "_" + name);
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
                        str.AppendFormat("\t\t\tTestUtils.AreEqual({1}, a.{0});\n", components[row], value);
                    }
                }
                else
                {
                    string[] values = (from row in Enumerable.Range(0, m_Rows) select m_BaseType == "bool" ? ((row & 1) != 0 ? "true" : "false") : "" + (row + 1)).ToArray();
                    AddParenthesized(str, values);
                    str.Append(";\n");

                    for (int row = 0; row < m_Rows; row++)
                    {
                        str.AppendFormat("\t\t\tTestUtils.AreEqual({1}, a.{0});\n", components[row], values[row]);
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

        static int StableStringHash(string str)
        {
            unsafe
            {
                fixed (char* src = str)
                {
                    int hash1 = (5381 << 16) + 5381;
                    int hash2 = hash1;

                    int* pint = (int*)src;
                    int len = str.Length;
                    while (len > 2)
                    {
                        hash1 = ((hash1 << 5) + hash1 + (hash1 >> 27)) ^ pint[0];
                        hash2 = ((hash2 << 5) + hash2 + (hash2 >> 27)) ^ pint[1];
                        pint += 2;
                        len -= 4;
                    }

                    if (len > 0)
                        hash1 = ((hash1 << 5) + hash1 + (hash1 >> 27)) ^ pint[0];

                    return hash1 + (hash2 * 1566083941);
                }
            }
        }

        private void TestOperator(StringBuilder str, bool lhsWide, bool rhsWide, string lhsType, string rhsType, string returnType, string op, string opName, bool isBinary, bool isPrefix)
        {
            var rnd = new Random(StableStringHash(opName));

            BeginTest(str, m_TypeName + "_operator_" + opName);

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
                            case "!": resultValue = (!bool_a) ? "true" : "false"; break;
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

                    str.AppendFormat("\t\t\tTestUtils.AreEqual(r{1}, a{1} {0} b{1});\n", op, pass);
                }
                else
                {
                    str.AppendFormat("\t\t\t{0} r{1} = {0}", returnType, pass);
                    AddParenthesized(str, resultValues);
                    str.Append(";\n");

                    if (isPrefix)
                        str.AppendFormat("\t\t\tTestUtils.AreEqual(r{1}, {0}a{1});\n", op, pass);
                    else
                        str.AppendFormat("\t\t\tTestUtils.AreEqual(r{1}, a{1}{0});\n", op, pass);
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
                BeginTest(str, m_TypeName + "_shuffle_result_" + resultComponents);

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

                    str.Append("\t\t\tTestUtils.AreEqual(");
                    if (resultComponents > 1)
                        str.Append(resultType);

                    for(int i = 0; i < resultComponents; i++)
                    {
                        int t = shuffleIndices[i];
                        shuffleValues[i] = t >= m_Rows ? b_data[t - m_Rows] : a_data[t];
                    }

                    AddParenthesized(str, shuffleValues);
                    str.Append(", shuffle(a, b");
                    for(int i = 0; i < resultComponents; i++)
                    {
                        int t = shuffleIndices[i];
                        str.AppendFormat(", ShuffleComponent.{0}", shuffleComponents[t >= m_Rows ? (t - m_Rows + 4) : t]);
                    }
                    str.Append("));\n");
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

            if(m_BaseType == "bool")
            {
                TestUnaryOperator(str, m_TypeName, "!", "logical_not", true);
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

        private T[] GetColumn<T>(T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0)).Select(x => matrix[x, columnNumber]).ToArray();
        }
        private string ToLiteral<T>(T value)
        {
            if (typeof(T) == typeof(float))
            {
                float f = (float)(object)value;
                uint uf = AsUInt(f);
                if (float.IsPositiveInfinity(f))
                    return "float.PositiveInfinity";
                else if (float.IsNegativeInfinity(f))
                    return "float.NegativeInfinity";
                else if (f == float.MaxValue)
                    return "float.MaxValue";
                else if (f == float.MinValue)
                    return "float.MinValue";
                else if (float.IsNaN(f))
                    return uf < 0x80000000u ? "TestUtils.UnsignedFloatQNaN()" : "TestUtils.SignedFloatQNaN()";
                else if (uf == 0x80000000u)
                    return "TestUtils.SignedFloatZero()";
                else
                    return ((float)(object)value).ToString("R") + "f";
            }
            else if (typeof(T) == typeof(double))
            {
                double d = (double)(object)value;
                ulong ud = AsULong(d);
                if (double.IsPositiveInfinity(d))
                    return "double.PositiveInfinity";
                else if (double.IsNegativeInfinity(d))
                    return "double.NegativeInfinity";
                else if (d == double.MaxValue)
                    return "double.MaxValue";
                else if (d == double.MinValue)
                    return "double.MinValue";
                else if (double.IsNaN(d))
                    return ud < 0x8000000000000000ul ? "TestUtils.UnsignedDoubleQNaN()" : "TestUtils.SignedDoubleQNaN()";
                else if (ud == 0x8000000000000000ul)
                    return "TestUtils.SignedDoubleZero()";
                else
                {
                    string s = ((double)(object)value).ToString("R");
                    if (s.IndexOfAny("eE.".ToCharArray()) == -1)
                        s += ".0";
                    return s;
                }

            }
            else if (typeof(T) == typeof(uint))
            {
                return "" + value + "u";
            }
            else if(typeof(T) == typeof(long))
            {
                return "" + value + "L";
            }
            else if(typeof(T) == typeof(ulong))
            {
                return "" + value + "UL";
            }
            else if (typeof(T) == typeof(bool))
            {
                return (bool)(object)value ? "true" : "false";
            }
            return "" + value;
        }
        private void GenerateComponentWiseParam<I>(StringBuilder str, string typeName, int numComponents, I[] input, int test)
        {
            int numTests = input.GetLength(0);
            if (numComponents > 1)
                str.Append(typeName + numComponents + "(");
            for (int i = 0; i < numComponents; i++)
            {
                int idx = Math.Min(test + i, numTests - 1);
                I v = input[idx];
                if (i > 0)
                    str.Append(", ");
                str.Append(ToLiteral(v));
            }
            if (numComponents > 1)
                str.Append(")");
        }
        private string GetTypeName(Type t)
        {
            if (t == typeof(float))
                return "float";
            else if (t == typeof(double))
                return "double";
            else if (t == typeof(bool))
                return "bool";
            else if (t == typeof(int))
                return "int";
            else if (t == typeof(uint))
                return "uint";
            else if (t == typeof(long))
                return "long";
            else if (t == typeof(ulong))
                return "ulong";
            return "";
        }
        private void GenerateComponentWiseTest<I, O>(StringBuilder str, string functionName, I[,] input, O[] output, int maxComponents, int maxUps = 0, bool signedZeroEqual = false)
        {
            int numTests = input.GetLength(0);
            int numParams = input.GetLength(1);
            string inputTypeName = GetTypeName(typeof(I));
            string outputTypeName = GetTypeName(typeof(O));
            int inputIndex = input.Length;
            for (int numComponents = 1; numComponents <= maxComponents; numComponents++)
            {
                BeginTest(str, functionName + "_" + inputTypeName + (numComponents > 1 ? ("" + numComponents) : ""));
                for (int test = 0; test < numTests; test += numComponents)
                {
                    str.Append("\t\t\tTestUtils.AreEqual(");
                    GenerateComponentWiseParam<O>(str, outputTypeName, numComponents, output, test);
                    str.Append(", ");
                    str.AppendFormat("{0}(", functionName);
                    for (int param = 0; param < numParams; param++)
                    {
                        if (param > 0)
                            str.Append(", ");
                        GenerateComponentWiseParam<I>(str, inputTypeName, numComponents, GetColumn(input, param), test);
                    }

                    str.Append(")");

                    if((typeof(O) == typeof(float) || typeof(O) == typeof(double)) && maxUps > 0)
                    {
                        str.Append(", " + maxUps + ", " + (signedZeroEqual ? "true" : "false"));
                    }

                    str.Append(");\n");
                }
                EndTest(str);
            }
        }
        private void GenerateComponentWiseTestFloatAndDouble(StringBuilder str, string functionName, double[,] input, double[] output, int floatMaxEps = 0, int doubleMaxEps = 0, bool signedZeroEqual = false)
        {
            float[,] inputFloat = new float[input.GetLength(0), input.GetLength(1)];

            for (int i = 0; i < input.GetLength(0); i++)
                for (int j = 0; j < input.GetLength(1); j++)
                    inputFloat[i, j] = (float)input[i, j];
            float[] outputFloat = new float[output.GetLength(0)];
            for (int i = 0; i < output.GetLength(0); i++)
                outputFloat[i] = (float)output[i];
            GenerateComponentWiseTest(str, functionName, inputFloat, outputFloat, 4, floatMaxEps, signedZeroEqual);
            GenerateComponentWiseTest(str, functionName, input, output, 4, doubleMaxEps, signedZeroEqual);
        }

        static float UnsignedFloatQNaN()
        {
            UIntFloatUnion u;
            u.floatValue = 0.0f;
            u.uintValue = 0x7fc0_0000u;

            return u.floatValue;
        }

        static double UnsignedDoubleQNaN()
        {
            ULongDoubleUnion u;
            u.doubleValue = 0.0;
            u.ulongValue = 0x7ff8_0000_0000_0000ul;

            return u.doubleValue;
        }

        static float SignedFloatQNaN()
        {
            UIntFloatUnion u;
            u.floatValue = 0.0f;
            u.uintValue = 0xffc0_0000u;

            return u.floatValue;
        }

        static double SignedDoubleQNaN()
        {
            ULongDoubleUnion u;
            u.doubleValue = 0.0;
            u.ulongValue = 0xfff8_0000_0000_0000ul;

            return u.doubleValue;
        }

        private void GenerateMathTests(StringBuilder str)
        {
            str.Append("using NUnit.Framework;\n");
            str.Append("using static Unity.Mathematics.math;\n");
            str.Append("using Burst.Compiler.IL.Tests;\n\n");
            str.Append("namespace Unity.Mathematics.Tests\n");
            str.Append("{\n");
            str.Append("\t[TestFixture]\n");
            str.Append("\tpublic partial class TestMath\n");
            str.Append("\t{\n");

            GenerateComponentWiseTest(str, "abs", new int[,] { { 0 }, { -7 }, { 11 }, { -2147483647 }, { -2147483648 } }, new int[] { 0, 7, 11, 2147483647, -2147483648 }, 4);

            GenerateComponentWiseTestFloatAndDouble(str, "abs", new double[,] { { 0.0 }, { -1.1 }, { 2.2 }, { double.NegativeInfinity }, { double.PositiveInfinity } }, new double[] { 0.0, 1.1, 2.2, double.PositiveInfinity, double.PositiveInfinity }, 0, 0, false);

            GenerateComponentWiseTest(str, "isfinite", new float[,] { { SignedFloatQNaN() }, { float.NegativeInfinity }, { float.MinValue }, { -1.0f }, { 0.0f }, { 1.0f }, { float.MaxValue }, { float.PositiveInfinity }, { UnsignedFloatQNaN() } },
                                                                   new bool[] { false, false, true, true, true, true, true, false, false }, 4);
            GenerateComponentWiseTest(str, "isfinite", new double[,] { { SignedDoubleQNaN() }, { double.NegativeInfinity }, { double.MinValue }, { -1.0 }, { 0.0 }, { 1.0 }, { double.MaxValue }, { double.PositiveInfinity }, { UnsignedDoubleQNaN() } },
                                                                   new bool[] { false, false, true, true, true, true, true, false, false }, 4);
            GenerateComponentWiseTest(str, "isinf", new float[,] { { SignedFloatQNaN() }, { float.NegativeInfinity }, { float.MinValue }, { -1.0f }, { 0.0f }, { 1.0f }, { float.MaxValue }, { float.PositiveInfinity }, { UnsignedFloatQNaN() } },
                                                                   new bool[] { false, true, false, false, false, false, false, true, false }, 4);
            GenerateComponentWiseTest(str, "isinf", new double[,] { { SignedDoubleQNaN() }, { double.NegativeInfinity }, { double.MinValue }, { -1.0 }, { 0.0 }, { 1.0 }, { double.MaxValue }, { double.PositiveInfinity }, { UnsignedDoubleQNaN() } },
                                                                   new bool[] { false, true, false, false, false, false, false, true, false }, 4);
            GenerateComponentWiseTest(str, "isnan", new float[,] { { SignedFloatQNaN() }, { float.NegativeInfinity }, { float.MinValue }, { -1.0f }, { 0.0f }, { 1.0f }, { float.MaxValue }, { float.PositiveInfinity }, { UnsignedFloatQNaN() } },
                                                                   new bool[] { true, false, false, false, false, false, false, false, true }, 4);
            GenerateComponentWiseTest(str, "isnan", new double[,] { { SignedDoubleQNaN() }, { double.NegativeInfinity }, { double.MinValue }, { -1.0 }, { 0.0 }, { 1.0 }, { double.MaxValue }, { double.PositiveInfinity }, { UnsignedDoubleQNaN() } },
                                                                   new bool[] { true, false, false, false, false, false, false, false, true }, 4);

            GenerateComponentWiseTestFloatAndDouble(str, "sin", new double[,] { { -1000000.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 1000000.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 0.34999350217129295, -0.93203908596722635, 0.0, 0.93203908596722635, -0.34999350217129295, double.NaN, double.NaN, double.NaN }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "cos", new double[,] { { -1000000.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 1000000.0 },  { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 0.93675212753314479,  0.36235775447667358, 1.0, 0.36235775447667358,  0.93675212753314479, double.NaN, double.NaN, double.NaN }, 8, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "tan", new double[,] { { -1000000.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 1000000.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 0.373624453987599, -2.57215162212632, 0.0, 2.57215162212632, -0.373624453987599, double.NaN, double.NaN, double.NaN }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "atan",new double[,] { { -1000000.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 1000000.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -1.570795326794897, -0.8760580505981934, 0.0, 0.8760580505981934, 1.570795326794897, -1.570796326794897, double.NaN, 1.570796326794897 }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "atan2", new double[,] { { 3.1, 2.4 }, { 3.1, -2.4 }, { -3.1, 2.4 }, { -3.1, -2.4 }, { 0.0, 0.0 },
                                                                { 1.0, double.NegativeInfinity },   { 1.0, double.PositiveInfinity }, { double.NegativeInfinity, 1.0 },   { double.PositiveInfinity, 1.0 },
                                                                // { double.NegativeInfinity, double.PositiveInfinity }, // TODO: fails with burst
                                                                { 1.0, double.NaN }, { double.NaN, 1.0 }, { double.NaN, double.NaN },
                                                                },
                                                                new double[] { 0.91199029067742038, 2.2296023629123729, -0.91199029067742038, -2.2296023629123729, 0.0f,
                                                                Math.PI, 0.0, -Math.PI*0.5, Math.PI*0.5,
                                                                // double.NaN, // TODO: fails with burst
                                                                double.NaN, double.NaN, double.NaN,
                                                                }, 1, 32);


            GenerateComponentWiseTestFloatAndDouble(str, "sinh",new double[,] { { -2.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 2.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -3.626860407847018, -1.509461355412173, 0.0, 1.509461355412173, 3.626860407847018, double.NegativeInfinity, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "cosh",new double[,] { { -2.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 2.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 3.7621956910836314, 1.81065556732437, 1.0, 1.81065556732437, 3.7621956910836314, double.PositiveInfinity, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "tanh",new double[,] { { -2.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { 2.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -0.96402758007581688, -0.83365460701215526, 0.0, 0.83365460701215526, 0.96402758007581688, -1.0, double.NaN, 1.0 }, 1, 32);


            GenerateComponentWiseTestFloatAndDouble(str, "exp", new double[,] { { -10.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 0.00004539992976248485, 0.3011942119122021, 1.0, 3.3201169227365475, 0.0, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "exp2",new double[,] { { -10.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 0.0009765625, 0.435275281648062, 1.0, 2.297396709994070, 0.0, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "exp10",new double[,] { { -10.0 }, { -1.2 }, { 0.0 }, { 1.2 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { 1e-10, 0.063095734448019325, 1.0, 15.8489319246111348520210, 0.0, double.NaN, double.PositiveInfinity }, 32, 32);


            GenerateComponentWiseTestFloatAndDouble(str, "log", new double[,] { { 1.2e-9 }, { 1.0 }, { 1.2e10 }, { -1.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -20.540944280152457, 0.0, 23.20817248673441, double.NaN, double.NaN, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "log2", new double[,] { { 1.2e-9 }, { 1.0 }, { 1.2e10 }, { -1.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -29.634318448152467, 0.0, 33.48231535470742, double.NaN, double.NaN, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "log10", new double[,] { { 1.2e-9 }, { 1.0 }, { 1.2e10 }, { -1.0 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -8.92081875395237517, 0.0, 10.079181246047624, double.NaN, double.NaN, double.NaN, double.PositiveInfinity }, 1, 32);

            GenerateComponentWiseTestFloatAndDouble(str, "radians", new double[,] { { -123.45 }, { 0.0 }, { 123.45 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -2.15460896158699986, 0.0, 2.15460896158699986, double.NegativeInfinity, double.NaN, double.PositiveInfinity }, 1, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "degrees", new double[,] { { -123.45 }, { 0.0 }, { 123.45 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -7073.1639808900125122, 0.0, 7073.1639808900125122, double.NegativeInfinity, double.NaN, double.PositiveInfinity}, 1, 1);

            GenerateComponentWiseTest(str, "sign", new int[,] { { -156 }, { -214748346 }, { 0 }, { 214748346 }, { 1537 }, { 17 }, { -39 }, { 0 }, { -15379 }, { 64583 }, { int.MaxValue }, { int.MinValue } },
                                                   new int[] { -1, -1, 0, 1, 1, 1, -1, 0, -1, 1, 1, -1 }, 4);

            GenerateComponentWiseTestFloatAndDouble(str, "sign",new double[,] { { -123.45 }, { -1e-20 }, { 0.0 }, { 1e-10 }, { 123.45 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -1.0, -1.0, 0.0, 1.0, 1.0, -1.0, 0.0, 1.0 });

            GenerateComponentWiseTestFloatAndDouble(str, "sqrt", new double[,] { { -1.0}, { 0.0 }, { 1e-10 }, { 123.45 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { double.NaN, 0.0, 1e-5, 11.11080555135405, double.NaN, double.NaN, double.PositiveInfinity, }, 1, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "rsqrt", new double[,] { { -1.0 }, { 0.0 }, { 1e10 }, { 123.45 }, { double.NegativeInfinity }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { double.NaN, double.PositiveInfinity, 1e-5, 0.0900024751020984295, double.NaN, double.NaN, 0.0, }, 1, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "rcp", new double[,] { { -123.45 }, { 0.0 }, { 123.45 }, { double.NaN }, { double.PositiveInfinity } },
                                                                new double[] { -0.0081004455245038477, double.PositiveInfinity, 0.0081004455245038477, double.NaN, 0.0, }, 1, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "floor", new double[,] { { double.NegativeInfinity },  { -100.51 }, { -100.5 }, { -100.49 }, { 0.0 }, { 100.49 }, { 100.50 }, { 100.51 }, { double.PositiveInfinity }, { double.NaN } },
                                                                new double[] { double.NegativeInfinity, -101.0, -101.0, -101.0, 0.0, 100.0, 100.0, 100.0, double.PositiveInfinity, double.NaN } );

            GenerateComponentWiseTestFloatAndDouble(str, "ceil", new double[,] { { double.NegativeInfinity }, { -100.51 }, { -100.5 }, { -100.49 }, { 0.0 }, { 100.49 }, { 100.50 }, { 100.51 }, { double.PositiveInfinity }, { double.NaN } },
                                                                new double[] { double.NegativeInfinity, -100.0, -100.0, -100.0, 0.0, 101.0, 101.0, 101.0, double.PositiveInfinity, double.NaN });

            GenerateComponentWiseTestFloatAndDouble(str, "round", new double[,] { { double.NegativeInfinity }, { -100.51 }, { -100.5 }, { -100.49 }, { 0.0 }, { 100.49 }, { 100.50 }, { 100.51 }, { 101.50 }, { double.PositiveInfinity }, { double.NaN } },
                                                                new double[] { double.NegativeInfinity, -101.0, -100.0, -100.0, 0.0, 100.0, 100.0, 101.0, 102.0, double.PositiveInfinity, double.NaN });

            GenerateComponentWiseTestFloatAndDouble(str, "trunc", new double[,] { { double.NegativeInfinity }, { -100.51 }, { -100.5 }, { -100.49 }, { 0.0 }, { 100.49 }, { 100.50 }, { 100.51 }, { 101.50 }, { double.PositiveInfinity }, { double.NaN } },
                                                                new double[] { double.NegativeInfinity, -100.0, -100.0, -100.0, 0.0, 100.0, 100.0, 100.0, 101.0, double.PositiveInfinity, double.NaN });

            GenerateComponentWiseTestFloatAndDouble(str, "frac", new double[,] { { double.NegativeInfinity }, { -1e20 }, { -100.3 }, { 0.0 }, { 100.8 }, { double.PositiveInfinity }, { double.NaN } },
                                                                new double[] { double.NaN, 0.0, 0.7, 0.0, 0.8, double.NaN, double.NaN }, 64, 64);

            GenerateComponentWiseTestFloatAndDouble(str, "lerp", new double[,] { { -123.45, 439.43, -1.5 }, { -123.45, 439.43, 0.5 }, { -123.45, 439.43, 5.5 }, { -123.45, 439.43, double.NaN } },
                                                                new double[] { -967.77, 157.99, 2972.39, double.NaN }, 1, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "unlerp", new double[,] {  { -123.45, 439.43, -254.3}, { -123.45, 439.43, 0.0 }, { -123.45, 439.43, 632.1 },
                                                                                    { 123.4, 123.4, -430.0 }, { 123.4, 123.4, 430.0 },
                                                                                    { 439.43, -123.45, -254.3}, { 439.43, -123.45, 0.0 }, { 439.43, -123.45, 632.1 } },
                                                                new double[] { -0.23246517907902217, 0.21931850483229107, 1.3422932063672541,
                                                                                double.NegativeInfinity, double.PositiveInfinity,
                                                                                1.2324651790790221, 0.78068149516770893, -0.34229320636725412}, 4, 4);

            GenerateComponentWiseTestFloatAndDouble(str, "remap", new double[,] { { -123.45, 439.43, 541.3, 631.5, -200.0 }, { -123.45, 439.43, 541.3, 631.5, -100.0 }, { -123.45, 439.43, 541.3, 631.5, 500.0 },
                                                                                  { 439.43, -123.45, 541.3, 631.5, -200.0 }, { 439.43, -123.45, 541.3, 631.5, -100.0 }, { 439.43, -123.45, 541.3, 631.5, 500.0 },
                                                                                  { -123.45, 439.43, 631.5, 541.3, -200.0 }, { -123.45, 439.43, 631.5, 541.3,-100.0 }, { -123.45,  439.43, 631.5, 541.3, 500.0 },
                                                                                  { -123.45,-123.45, 541.3, 631.5, -200.0 }, { -123.45,-123.45, 541.3, 631.5, -100.0 }, },
                                                                new double[] {  529.03306921546333, 545.05779917566799, 641.20617893689596,
                                                                                643.76693078453667, 627.74220082433201, 531.59382106310404,
                                                                                643.76693078453667, 627.74220082433201, 531.59382106310404,
                                                                                double.NegativeInfinity, double.PositiveInfinity,
                                                                }, 4, 4);


            GenerateComponentWiseTest(str, "clamp", new int[,] {    { int.MinValue, -123, 439},
                                                                    { -254, -123, 439}, { 246, -123, 439 }, { 632, -123, 439 },
                                                                    { -254,  439,-123}, { 246,  439,-123 }, { 632,  439,-123 },
                                                                    { int.MaxValue, -123, 439},
                                                                },
                                                    new int[] { -123, -123, 246, 439, 439, 439, 439, 439 }, 4);

            GenerateComponentWiseTest(str, "clamp", new uint[,] {   { 0, 123, 439},
                                                                    { 54, 123, 439}, { 246, 123, 439 }, { 632, 123, 439 },
                                                                    { 54, 439, 123}, { 246, 439, 123 }, { 632, 439, 123 },
                                                                    { uint.MaxValue, 123, 439},
                                                                },
                                                    new uint[] { 123, 123, 246, 439, 439, 439, 439, 439 }, 4);

            GenerateComponentWiseTest(str, "clamp", new long[,] {   { long.MinValue, -123, 439},
                                                                    { -254, -123, 439}, { 246, -123, 439 }, { 632, -123, 439 },
                                                                    { -254,  439,-123}, { 246,  439,-123 }, { 632,  439,-123 },
                                                                    { long.MaxValue, -123, 439},
                                                                },
                                                    new long[] { -123, -123, 246, 439, 439, 439, 439, 439 }, 1);

            GenerateComponentWiseTest(str, "clamp", new ulong[,] {  { 0, 123, 439},
                                                                    { 54, 123, 439}, { 246, 123, 439 }, { 632, 123, 439 },
                                                                    { 54, 439, 123}, { 246, 439, 123 }, { 632, 439, 123 },
                                                                    { ulong.MaxValue, 123, 439},
                                                                },
                                                    new ulong[] { 123, 123, 246, 439, 439, 439, 439, 439 }, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "clamp", new double[,] {   { double.NegativeInfinity, -123.45, 439.43},
                                                                                    { -254.3, -123.45, 439.43}, { 246.3, -123.45, 439.43 }, { 632.1, -123.45, 439.43 },
                                                                                    { -254.3,  439.43,-123.45}, { 246.3,  439.43,-123.45 }, { 632.1,  439.43,-123.45 },
                                                                                    { double.PositiveInfinity, -123.45, 439.43},
                                                                                    { double.NaN, -123.45, 439.43},
                                                                                    },
                                                    new double[] { -123.45, -123.45, 246.3, 439.43, 439.43, 439.43, 439.43, 439.43, 439.43 });

            GenerateComponentWiseTestFloatAndDouble(str, "saturate", new double[,] { { double.NegativeInfinity }, { -123.45 }, { 0.0 }, { 0.5 }, { 1.0 }, { 123.45 }, { double.PositiveInfinity }, { double.NaN } },
                                                    new double[] { 0.0, 0.0, 0.0, 0.5, 1.0, 1.0, 1.0, 1.0 });

            GenerateComponentWiseTestFloatAndDouble(str, "step", new double[,] { { -123.45, double.NegativeInfinity }, { -123.45, -200.0 }, { -123.45, 200.0 }, { -123.45, double.PositiveInfinity }, { -123.45, double.NaN },
                                                                                 { 123.45, double.NegativeInfinity }, { 123.45, -200.0 }, { 123.45, 200.0 }, { 123.45, double.PositiveInfinity }, { 123.45, double.NaN },
                                                                                 { double.NegativeInfinity, double.NegativeInfinity }, { double.NegativeInfinity, -200.0 }, { double.NegativeInfinity, 200.0 }, { double.NegativeInfinity, double.PositiveInfinity }, { double.NegativeInfinity, double.NaN },
                                                                                 { double.PositiveInfinity, double.NegativeInfinity }, { double.PositiveInfinity, -200.0 }, { double.PositiveInfinity, 200.0 }, { double.PositiveInfinity, double.PositiveInfinity }, { double.PositiveInfinity, double.NaN },
                                                                                 { double.NaN, double.NegativeInfinity }, { double.NaN, -200.0 }, { double.NaN, 200.0 }, { double.NaN, double.PositiveInfinity }, { double.NaN, double.NaN }},
                                                                 new double[] {  0.0, 0.0, 1.0, 1.0, 0.0,
                                                                                 0.0, 0.0, 1.0, 1.0, 0.0,
                                                                                 1.0, 1.0, 1.0, 1.0, 0.0,
                                                                                 0.0, 0.0, 0.0, 1.0, 0.0,
                                                                                 0.0, 0.0, 0.0, 0.0, 0.0});


            GenerateComponentWiseTest(str, "min", new int[,] { { int.MinValue, int.MinValue }, { int.MinValue, -1 }, { -1, int.MinValue },
                                                                                { -1234, -3456 }, { -3456, -1234 }, { -1234, 3456 }, { 3456, -1234 }, { 1234, 3456 }, { 3456, 1234 },
                                                                                { 1, int.MaxValue}, { int.MaxValue, 1 }, { int.MaxValue, int.MinValue }, { int.MaxValue, int.MaxValue} },
                                                  new int[] { int.MinValue, int.MinValue, int.MinValue,
                                                                -3456, -3456, -1234, -1234, 1234, 1234,
                                                                1, 1, int.MinValue, int.MaxValue}, 4);

            GenerateComponentWiseTest(str, "min", new uint[,] { { 1234u, 3456u }, { 3456u, 1234u },
                                                                { 0xFFFFFF00u, 7u}, { 7u, 0xFFFFFF00u},
                                                                { 1u, uint.MaxValue}, { uint.MaxValue, 1u }, { uint.MaxValue, uint.MaxValue} },
                                                  new uint[] { 1234u, 1234u, 7u, 7u, 1u, 1u, uint.MaxValue}, 4);

            GenerateComponentWiseTest(str, "min", new long[,] { { long.MinValue, long.MinValue }, { long.MinValue, -1 }, { -1, long.MinValue },
                                                                                { -1234, -3456 }, { -3456, -1234 }, { -1234, 3456 }, { 3456, -1234 }, { 1234, 3456 }, { 3456, 1234 },
                                                                                { 1, long.MaxValue}, { long.MaxValue, 1 }, { long.MaxValue, long.MinValue }, { long.MaxValue, long.MaxValue} },
                                                  new long[] { long.MinValue, long.MinValue, long.MinValue,
                                                                -3456, -3456, -1234, -1234, 1234, 1234,
                                                                1, 1, long.MinValue, long.MaxValue}, 1);

            GenerateComponentWiseTest(str, "min", new ulong[,] { { 1234u, 3456u }, { 3456u, 1234u },
                                                                { 0xFFFFFFFFFFFFFF00ul, 7u}, { 7u, 0xFFFFFFFFFFFFFF00ul},
                                                                { 1u, ulong.MaxValue}, { ulong.MaxValue, 1u }, { ulong.MaxValue, ulong.MaxValue} },
                                                  new ulong[] { 1234u, 1234u, 7u, 7u, 1u, 1u, ulong.MaxValue }, 1);


            GenerateComponentWiseTestFloatAndDouble(str, "min", new double[,] { { double.NegativeInfinity, double.NegativeInfinity }, { double.NegativeInfinity, -1.0 }, { -1.0, double.NegativeInfinity },
                                                                                { -1234.56, -3456.7 }, { -3456.7, -1234.56 }, { -1234.56, 3456.7 }, { 3456.7, -1234.56 }, { 1234.56, 3456.7 }, { 3456.7, 1234.56 },
                                                                                { 1.0, double.PositiveInfinity}, { double.PositiveInfinity, 1.0 }, { double.PositiveInfinity, double.NegativeInfinity }, { double.PositiveInfinity, double.PositiveInfinity },
                                                                                { double.NaN, 2.3 },    { 2.3, double.NaN }, { double.NaN, double.NaN } },
                                                                new double[] { double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity,
                                                                                -3456.7, -3456.7, -1234.56, -1234.56, 1234.56, 1234.56,
                                                                                1.0, 1.0, double.NegativeInfinity, double.PositiveInfinity,
                                                                                2.3, 2.3, double.NaN});



            GenerateComponentWiseTest(str, "max", new int[,] { { int.MinValue, int.MinValue }, { int.MinValue, -1 }, { -1, int.MinValue },
                                                                                { -1234, -3456 }, { -3456, -1234 }, { -1234, 3456 }, { 3456, -1234 }, { 1234, 3456 }, { 3456, 1234 },
                                                                                { 1, int.MaxValue}, { int.MaxValue, 1 }, { int.MaxValue, int.MinValue }, { int.MaxValue, int.MaxValue} },
                                                  new int[] { int.MinValue, -1, -1,
                                                                -1234, -1234, 3456, 3456, 3456, 3456,
                                                                int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue}, 4);

            GenerateComponentWiseTest(str, "max", new uint[,] { { 1234u, 3456u }, { 3456u, 1234u },
                                                                { 0xFFFFFF00u, 7u}, { 7u, 0xFFFFFF00u},
                                                                { 1u, uint.MaxValue}, { uint.MaxValue, 1u }, { uint.MaxValue, uint.MaxValue} },
                                                  new uint[] { 3456u, 3456u, 0xFFFFFF00u, 0xFFFFFF00u, uint.MaxValue, uint.MaxValue, uint.MaxValue }, 4);

            GenerateComponentWiseTest(str, "max", new long[,] { { long.MinValue, long.MinValue }, { long.MinValue, -1 }, { -1, long.MinValue },
                                                                                { -1234, -3456 }, { -3456, -1234 }, { -1234, 3456 }, { 3456, -1234 }, { 1234, 3456 }, { 3456, 1234 },
                                                                                { 1, long.MaxValue}, { long.MaxValue, 1 }, { long.MaxValue, long.MinValue }, { long.MaxValue, long.MaxValue} },
                                                  new long[] { long.MinValue, -1, -1,
                                                                -1234, -1234, 3456, 3456, 3456, 3456,
                                                                long.MaxValue, long.MaxValue, long.MaxValue, long.MaxValue}, 1);

            GenerateComponentWiseTest(str, "max", new ulong[,] { { 1234u, 3456u }, { 3456u, 1234u },
                                                                { 0xFFFFFFFFFFFFFF00ul, 7u}, { 7u, 0xFFFFFFFFFFFFFF00ul},
                                                                { 1u, ulong.MaxValue}, { ulong.MaxValue, 1u }, { ulong.MaxValue, ulong.MaxValue} },
                                                  new ulong[] { 3456u, 3456u, 0xFFFFFFFFFFFFFF00ul, 0xFFFFFFFFFFFFFF00ul, ulong.MaxValue, ulong.MaxValue, ulong.MaxValue }, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "max", new double[,] { { double.NegativeInfinity, double.NegativeInfinity }, { double.NegativeInfinity, -1.0 }, { -1.0, double.NegativeInfinity },
                                                                                { -1234.56, -3456.7 }, { -3456.7, -1234.56 }, { -1234.56, 3456.7 }, { 3456.7, -1234.56 }, { 1234.56, 3456.7 }, { 3456.7, 1234.56 },
                                                                                { 1.0, double.PositiveInfinity}, { double.PositiveInfinity, 1.0 }, { double.PositiveInfinity, double.NegativeInfinity }, { double.PositiveInfinity, double.PositiveInfinity },
                                                                                { double.NaN, 2.3 },    { 2.3, double.NaN }, { double.NaN, double.NaN } },
                                                                new double[] { double.NegativeInfinity, -1.0, -1.0,
                                                                                -1234.56, -1234.56, 3456.7, 3456.7, 3456.7, 3456.7,
                                                                                double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity,
                                                                                2.3, 2.3, double.NaN});


            GenerateComponentWiseTestFloatAndDouble(str, "smoothstep", new double[,] { { -123.45, 345.6, double.NegativeInfinity}, { -123.45, 345.6, -200.0}, { -123.45, 345.6, -100.0}, { -123.45, 345.6, 400.0}, { -123.45, 345.6, double.PositiveInfinity}, { -123.45, 345.6, double.NaN },
                                                                                        { 345.6, -123.45, double.NegativeInfinity}, { 345.6, -123.45, -200.0}, { 345.6, -123.45, -100.0}, { 345.6, -123.45, 400.0}, { 345.6, -123.45, double.PositiveInfinity}, { 345.6, -123.45, double.NaN }},
                                                                       new double[] { 0.0, 0.0, 0.0072484810488798993, 1.0, 1.0, 1.0,
                                                                                      1.0, 1.0, 0.9927515189511201007, 0.0, 0.0, 1.0}, 8, 8);

            GenerateComponentWiseTest(str, "mad", new int[,] { { 1234, 5678, 91011 }, { 1234, 5678, -91011 }, { 1234, -5678, 91011 }, { 1234, -5678, -91011 },
                                                               {-1234, 5678, 91011 }, {-1234, 5678, -91011 }, {-1234, -5678, 91011 }, {-1234, -5678, -91011 },
                                                               { 98765, 56789, 91011 }, { 98765, 56789,-91011 }, { 98765,-56789, 91011 }, { 98765,-56789,-91011 },
                                                               {-98765, 56789, 91011 }, {-98765, 56789,-91011 }, {-98765,-56789, 91011 }, {-98765,-56789,-91011 }},
                                                  new int[] { 7097663,  6915641, -6915641, -7097663,
                                                             -6915641, -7097663,  7097663,  6915641,
                                                              1313889300, 1313707278, -1313707278, -1313889300,
                                                             -1313707278, -1313889300, 1313889300, 1313707278}, 4);


            GenerateComponentWiseTest(str, "mad", new uint[,] { { 1234u, 5678u, 91011u }, { 98765u, 56789u, 91011u } },
                                                  new uint[] { 7097663u, 1313889300u }, 4);


            GenerateComponentWiseTest(str, "mad", new long[,] { { 1234, 5678, 91011 }, { 1234, 5678, -91011 }, { 1234, -5678, 91011 }, { 1234, -5678, -91011 },
                                                               {-1234, 5678, 91011 }, {-1234, 5678, -91011 }, {-1234, -5678, 91011 }, {-1234, -5678, -91011 },
                                                               { 9876543210, 5678901234, 9101112134 }, { 9876543210, 5678901234,-9101112134 }, { 9876543210,-5678901234, 9101112134 }, { 9876543210,-5678901234,-9101112134 },
                                                               {-9876543210, 5678901234, 9101112134 }, {-9876543210, 5678901234,-9101112134 }, {-9876543210,-5678901234, 9101112134 }, {-9876543210,-5678901234,-9101112134 }},
                                                  new long[] { 7097663,  6915641, -6915641, -7097663,
                                                             -6915641, -7097663,  7097663,  6915641,
                                                              747681210895778426, 747681192693554158, -747681192693554158, -747681210895778426,
                                                              -747681192693554158, -747681210895778426, 747681210895778426, 747681192693554158}, 1);

            GenerateComponentWiseTest(str, "mad", new ulong[,] { { 1234, 5678, 91011 }, { 9876543210, 5678901234, 9101112134 }},
                                                  new long[] { 7097663, 747681210895778426 }, 1);


            GenerateComponentWiseTestFloatAndDouble(str, "mad",         new double[,] { { -123.45, 345.6, 4.321 }, { double.NaN, 345.6, 4.321 }, { -123.45, double.NaN, 4.321 }, { -123.45, 345.6, double.NaN } },
                                                                        new double[] { -42659.999, double.NaN, double.NaN, double.NaN }, 1, 1);


            GenerateComponentWiseTestFloatAndDouble(str, "fmod", new double[,] {    { double.NegativeInfinity, double.NegativeInfinity }, { -323.4, double.NegativeInfinity }, { -0.0, double.NegativeInfinity}, { 0.0, double.NegativeInfinity}, { 323.4, double.NegativeInfinity}, { double.PositiveInfinity, double.NegativeInfinity}, { double.NaN, double.NegativeInfinity},
                                                                                    { double.NegativeInfinity, -123.6}, { -323.4, -123.6}, { -0.0, -123.6}, { 0.0, -123.6}, { 323.4, -123.6}, { double.PositiveInfinity, -123.6}, { double.NaN, -123.6},
                                                                                    { double.NegativeInfinity, -0.0}, { -323.4, -0.0}, { -0.0, -0.0}, { 0.0, -0.0}, { 323.4, -0.0}, { double.PositiveInfinity, -0.0}, { double.NaN, -0.0},
                                                                                    { double.NegativeInfinity, 0.0}, { -323.4, 0.0}, { -0.0, 0.0}, { 0.0, 0.0}, { 323.4, 0.0}, { double.PositiveInfinity, 0.0}, { double.NaN, 0.0},
                                                                                    { double.NegativeInfinity, 123.6}, { -323.4, 123.6}, { -0.0, 123.6}, { 0.0, 123.6}, { 323.4, 123.6}, { double.PositiveInfinity, 123.6}, { double.NaN, 123.6},
                                                                                    { double.NegativeInfinity, double.PositiveInfinity}, { -323.4, double.PositiveInfinity}, { -0.0, double.PositiveInfinity}, { 0.0, double.PositiveInfinity}, { 323.4, double.PositiveInfinity}, { double.PositiveInfinity, double.PositiveInfinity}, { double.NaN, double.PositiveInfinity},
                                                                                    { double.NegativeInfinity, double.NaN}, { -323.4, double.NaN}, { -0.0, double.NaN}, { 0.0, double.NaN}, { 323.4, double.NaN}, { double.PositiveInfinity, double.NaN}, { double.NaN, double.NaN},
                                                                                    },
                                                                 new double[] {     double.NaN, -323.4, -0.0, 0.0, 323.4, double.NaN, double.NaN,
                                                                                    double.NaN, -76.2, -0.0, 0.0, 76.2, double.NaN, double.NaN,
                                                                                    double.NaN, double.NaN,double.NaN,double.NaN,double.NaN,double.NaN,double.NaN,
                                                                                    double.NaN, double.NaN,double.NaN,double.NaN,double.NaN,double.NaN,double.NaN,
                                                                                    double.NaN, -76.2, -0.0, 0.0, 76.2, double.NaN, double.NaN,
                                                                                    double.NaN, -323.4, -0.0, 0.0, 323.4, double.NaN, double.NaN,
                                                                                    double.NaN, double.NaN,double.NaN,double.NaN,double.NaN,double.NaN,double.NaN}, 1, 1);

            GenerateComponentWiseTestFloatAndDouble(str, "pow", new double[,] {     { double.NegativeInfinity, double.NegativeInfinity }, { -3.4, double.NegativeInfinity }, { -0.0, double.NegativeInfinity}, { 0.0, double.NegativeInfinity}, { 3.4, double.NegativeInfinity}, { double.PositiveInfinity, double.NegativeInfinity}, { double.NaN, double.NegativeInfinity},

                                                                                    /*{ double.NegativeInfinity, -2.6} DOTS-1833 */ { -3.4, -2.6}, { -0.0, -2.6}, { 0.0, -2.6}, { 3.4, -2.6}, { double.PositiveInfinity, -2.6}, { double.NaN, -2.6},

                                                                                    { double.NegativeInfinity, -0.0}, { -3.4, -0.0}, { -0.0, -0.0}, { 0.0, -0.0}, { 3.4, -0.0}, { double.PositiveInfinity, -0.0}, // { double.NaN, -0.0}, // TODO: fails with burst
                                                                                    { double.NegativeInfinity, 0.0}, { -3.4, 0.0}, { -0.0, 0.0}, { 0.0, 0.0}, { 3.4, 0.0}, { double.PositiveInfinity, 0.0}, // { double.NaN, 0.0}, // TODO: fails with burst

                                                                                    /*{ double.NegativeInfinity, 2.6}, DOTS-1833 */ { -3.4, 2.6}, { -0.0, 2.6}, { 0.0, 2.6}, { 3.4, 2.6}, { double.PositiveInfinity, 2.6}, { double.NaN, 2.6},
                                                                                    { double.NegativeInfinity, double.PositiveInfinity}, { -3.4, double.PositiveInfinity}, { -0.0, double.PositiveInfinity}, { 0.0, double.PositiveInfinity}, { 3.4, double.PositiveInfinity}, { double.PositiveInfinity, double.PositiveInfinity}, { double.NaN, double.PositiveInfinity},
                                                                                    { double.NegativeInfinity, double.NaN}, { -3.4, double.NaN}, { -0.0, double.NaN}, { 0.0, double.NaN}, { 3.4, double.NaN}, { double.PositiveInfinity, double.NaN}, { double.NaN, double.NaN},

                                                                                    },
                                                                 new double[]       {
                                                                                      0.0, 0.0, double.PositiveInfinity, double.PositiveInfinity, 0.0, 0.0, double.NaN,
                                                                                      /*0.0, DOTS-1833 */ double.NaN, double.PositiveInfinity, double.PositiveInfinity, 0.041510199028461224, 0.0, double.NaN,
                                                                                      1.0, 1.0, 1.0, 1.0, 1.0, 1.0, // double.NaN, // TODO: fails with burst
                                                                                      1.0, 1.0, 1.0, 1.0, 1.0, 1.0, // double.NaN, // TODO: fails with burst

                                                                                      /*double.PositiveInfinity, DOTS-1833 */ double.NaN, 0.0, 0.0, 24.090465076169736, double.PositiveInfinity, double.NaN,

                                                                                      double.PositiveInfinity, double.PositiveInfinity, 0.0, 0.0, double.PositiveInfinity, double.PositiveInfinity, double.NaN,
                                                                                      double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN, double.NaN,
                                                                                    }, 1, 1);


            GenerateComponentWiseTest(str, "ceilpow2", new int[,] { { 0 }, { 1 }, { 2 }, { 3 }, { 1019642234 }, { 1823423423 }, { -2147483647 } },
                                                       new int[] { 0, 1, 2, 4, 1073741824, -2147483648, 0 }, 4);

            GenerateComponentWiseTest(str, "ceilpow2", new uint[,] { { 0u }, { 1u }, { 2u }, { 3u }, { 1019642234u }, { 1823423423u }, { 4294967295u } },
                                                       new uint[] { 0u, 1u, 2u, 4u, 1073741824u, 2147483648u, 0u }, 4);


            GenerateComponentWiseTest(str, "ceilpow2", new long[,] { { 0L }, { 1L }, { 2L }, { 3L }, { 1019642234L }, { 1823423423L }, { 2147483648L }, { 4294967295L }, { 4294967296L }, { 7227372236554874814L }, { -100L } },
                                                       new long[] { 0L, 1L, 2L, 4L, 1073741824L, 2147483648L, 2147483648L, 4294967296L, 4294967296L, -9223372036854775808L, 0L }, 1);


            GenerateComponentWiseTest(str, "ceilpow2", new ulong[,] { { 0UL }, { 1UL }, { 2UL }, { 3UL }, { 1019642234UL }, { 1823423423UL }, { 2147483648UL }, { 4294967295UL }, { 4294967296UL }, { 7227372236554874814UL }, { 10223372036854775808UL } },
                                                       new ulong[] { 0UL, 1UL, 2UL, 4UL, 1073741824UL, 2147483648UL, 2147483648UL, 4294967296UL, 4294967296UL, 9223372036854775808UL, 0L }, 1);
            GenerateComponentWiseTest(str, "floorlog2", new int[,] { { 1 }, { 2 }, { 3 }, { 4 }, { 5 }, { (1 << 15) - 1 }, { 1 << 15 }, { (1 << 15) + 1 }, { Int32.MaxValue } }, new int[] { 0, 1, 1, 2, 2, 14, 15, 15, 30 }, 4);
            GenerateComponentWiseTest(str, "floorlog2", new uint[,] { { 1 }, { 2 }, { 3 }, { 4 }, { 5 }, { (1 << 15) - 1 }, { 1 << 15 }, { (1 << 15) + 1 }, { Int32.MaxValue } }, new int[] { 0, 1, 1, 2, 2, 14, 15, 15, 30 }, 4);


            GenerateComponentWiseTest(str, "ceillog2", new int[,] { { 1 }, { 2 }, { 3 }, { 4 }, { 5 }, { 63 }, { 64 }, { 65 }, { (1 << 24) - 1 }, { 1 << 24 }, { (1 << 24) + 1 }, { 2147483646 }, { 2147483647 } }, new int[] { 0, 1, 2, 2, 3, 6, 6, 7, 24, 24, 25, 31, 31 }, 4);
            GenerateComponentWiseTest(str, "ceillog2", new uint[,] { { 1u }, { 2u }, { 3u }, { 4u }, { 5u }, { 63u }, { 64u }, { 65u }, { (1u << 24) - 1u }, { 1u << 24 }, { (1u << 24) + 1u }, { 4294967294u }, { 4294967295u } }, new int[] { 0, 1, 2, 2, 3, 6, 6, 7, 24, 24 ,25, 32, 32 }, 4);
            GenerateComponentWiseTest(str, "ispow2", new int[,] { { -3 }, { -2 }, { -1 }, { 0 }, { 1 }, { 2 }, { 3 }, { 4 }, { (1 << 15) - 1}, { 1 << 15 }, { (1 << 15) + 1}, { (1 << 21) - 1}, { 1 << 21 }, { 268431360 }  }, new bool[] { false, false, false, false, true, true, false, true, false, true, false, false, true, false, false }, 4);
            GenerateComponentWiseTest(str, "ispow2", new uint[,] { { 0u }, { 1u }, { 2u }, { 3u }, { 4u }, { (1u << 15) - 1}, { 1u << 15 }, { (1u << 15) + 1 }, { (1u << 21) - 1}, { 1u << 21 }, { (1u << 21) + 1 }, { 268431360u } }, new bool[] { false, true, true, false, true, false, true, false, false, true, false, false }, 4);

            str.Append("\n\t}");
            str.Append("\n}\n");
        }

        void TestEqualsObjectOverride(StringBuilder str)
        {
            BeginTest(str, m_TypeName + "_EqualsObjectOverride", false);
            str.Append($"\t\t\tTestUtils.IsFalse(new {m_TypeName}().Equals((object)new int()));\n");
            str.Append($"\t\t\tTestUtils.IsTrue(new {m_TypeName}().Equals((object)new {m_TypeName}()));\n");
            EndTest(str);
        }

        private void GenerateTypeTests(StringBuilder str)
        {
            StringBuilder mathStr = new StringBuilder();

            str.Append("using NUnit.Framework;\n");
            str.Append("using static Unity.Mathematics.math;\n");
            str.Append("using Burst.Compiler.IL.Tests;\n\n");
            str.Append("namespace Unity.Mathematics.Tests\n");
            str.Append("{\n");
            str.Append("\t[TestFixture]\n");
            str.AppendFormat("\tpublic class Test{0}\n", UpperCaseFirstLetter(m_TypeName));
            str.Append("\t{\n");

            TestStaticFields(str);
            TestConstructors(str);
            TestOperators(str);
            TestEqualsObjectOverride(str);

            str.Append("\n\t}");
            str.Append("\n}\n");
        }

        void BeginPerformanceTestCodeGen(StringBuilder str, string testSuiteName)
        {
            str.AppendFormat("using System;\n");
            str.AppendFormat("using NUnit.Framework;\n");
            str.AppendFormat("using Unity.Collections;\n");
            str.AppendFormat("using Unity.Collections.LowLevel.Unsafe;\n");
            str.AppendFormat("using Unity.PerformanceTesting;\n");
            str.AppendFormat("using Unity.Mathematics.Geometry;\n");
            str.AppendFormat("using Unity.Burst;\n\n");
            str.AppendFormat("namespace Unity.Mathematics.PerformanceTests\n");
            str.AppendFormat("{{\n");
            str.AppendFormat("\tpartial class {0}\n", testSuiteName);
            str.AppendFormat("\t{{\n");
        }

        void EndPerformanceTestCodeGen(StringBuilder str)
        {
            str.AppendFormat("\t}}\n");
            str.AppendFormat("}}\n");
        }

        void GenerateMulPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestMul");

            GeneratePerformanceTest(str, "float4x4_float4x4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m1", m_ElementInitializer = "float4x4.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m2", m_ElementInitializer = "float4x4.identity" },
            }, "args.m1[i] = math.mul(args.m1[i], args.m2[i]);", 10000);
            GeneratePerformanceTest(str, "float4x4_float4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m1", m_ElementInitializer = "float4x4.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "m2", m_ElementInitializer = "new float4(1.0f, 0.0f, 0.0f, 1.0f)" },
            }, "args.m2[i] = math.mul(args.m1[i], args.m2[i]);", 10000);
            GeneratePerformanceTest(str, "quaternion_quaternion", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q1", m_ElementInitializer = "quaternion.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q2", m_ElementInitializer = "quaternion.identity" },
            }, "args.q2[i] = math.mul(args.q1[i], args.q2[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_float3x3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m1", m_ElementInitializer = "float3x3.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m2", m_ElementInitializer = "float3x3.identity" },
            }, "args.m2[i] = math.mul(args.m1[i], args.m2[i]);", 10000);
            GeneratePerformanceTest(str, "float2x2_float2x2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "m1", m_ElementInitializer = "float2x2.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "m2", m_ElementInitializer = "float2x2.identity" },
            }, "args.m2[i] = math.mul(args.m1[i], args.m2[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_float3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m1", m_ElementInitializer = "float3x3.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "m2", m_ElementInitializer = "new float3(1.0f, 0.0f, 0.0f)" },
            }, "args.m2[i] = math.mul(args.m1[i], args.m2[i]);", 10000);
            GeneratePerformanceTest(str, "float2x2_float2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "m1", m_ElementInitializer = "float2x2.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "m2", m_ElementInitializer = "new float2(1.0f, 0.0f)" },
            }, "args.m2[i] = math.mul(args.m1[i], args.m2[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateInversePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestInverse");

            GeneratePerformanceTest(str, "float4x4_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m1", m_ElementInitializer = "float4x4.identity" },
            }, "args.m1[i] = math.inverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m1", m_ElementInitializer = "float3x3.identity" },
            }, "args.m1[i] = math.inverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "float2x2_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "m1", m_ElementInitializer = "float2x2.identity" },
            }, "args.m1[i] = math.inverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "double4x4_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double4x4", m_MemberName = "m1", m_ElementInitializer = "double4x4.identity" },
            }, "args.m1[i] = math.inverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "double3x3_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double3x3", m_MemberName = "m1", m_ElementInitializer = "double3x3.identity" },
            }, "args.m1[i] = math.inverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "double2x2_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double2x2", m_MemberName = "m1", m_ElementInitializer = "double2x2.identity" },
            }, "args.m1[i] = math.inverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "quaternion_inverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q", m_ElementInitializer = "quaternion.identity" },
            }, "args.q[i] = math.inverse(args.q[i]);", 10000);
            GeneratePerformanceTest(str, "pseudoinverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m", m_ElementInitializer = "new float3x3(0.054824f, 0.462398f, 0.050136f, 0.054824f, 0.462398f, 0.050136f, 0.938166f, 0.542226f, 0.106844f)" },
            }, "args.m[i] = math.pseudoinverse(args.m[i]);", 1000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateFastInversePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestFastInverse");

            GeneratePerformanceTest(str, "float4x4_fastinverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m1", m_ElementInitializer = "float4x4.identity" },
            }, "args.m1[i] = math.fastinverse(args.m1[i]);", 10000);
            GeneratePerformanceTest(str, "double4x4_fastinverse", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double4x4", m_MemberName = "m1", m_ElementInitializer = "double4x4.identity" },
            }, "args.m1[i] = math.fastinverse(args.m1[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateConversionPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestConversions");

            // Most of these tests will need to write to an output array to ensure
            // burst doesn't optimize away to just one loop iteration.
            GeneratePerformanceTest(str, "quaternion_to_float3x3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q", m_ElementInitializer = "quaternion.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "f3x3", m_ElementInitializer = "float3x3.identity" },
            }, "args.f3x3[i] = new float3x3(args.q[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_to_quaternion", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q", m_ElementInitializer = "quaternion.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "f3x3", m_ElementInitializer = "float3x3.identity" },
            }, "args.q[i] = new quaternion(args.f3x3[i]);", 10000);
            GeneratePerformanceTest(str, "float4_to_half4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "f4", m_ElementInitializer = "new float4(1.0f, 2.0f, 3.0f, 4.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "half4", m_MemberName = "h4", m_ElementInitializer = "new half4(new float4(-1.0f, -2.0f, -3.0f, -4.0f))" },
            }, "args.h4[i] = new half4(args.f4[i]);", 10000);
            GeneratePerformanceTest(str, "half4_to_float4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "f4", m_ElementInitializer = "new float4(1.0f, 2.0f, 3.0f, 4.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "half4", m_MemberName = "h4", m_ElementInitializer = "new half4(new float4(-1.0f, -2.0f, -3.0f, -4.0f))" },
            }, "args.f4[i] = new float4(args.h4[i]);", 10000);
            GeneratePerformanceTest(str, "quaternion_to_RigidTransform", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q", m_ElementInitializer = "quaternion.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "RigidTransform", m_MemberName = "rt", m_ElementInitializer = "RigidTransform.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "pos", m_ElementInitializer = "new float3()" },
            }, "args.rt[i] = new RigidTransform(args.q[i], args.pos[i]);", 10000);
            GeneratePerformanceTest(str, "quaternion_to_float4x4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q", m_ElementInitializer = "quaternion.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "f4x4", m_ElementInitializer = "float4x4.identity" },
            }, "args.q[i] = new quaternion(args.f4x4[i]);", 10000);
            GeneratePerformanceTest(str, "float4x4_to_quaternion", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q", m_ElementInitializer = "quaternion.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "f4x4", m_ElementInitializer = "float4x4.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "f3", m_ElementInitializer = "new float3()" },
            }, "args.f4x4[i] = new float4x4(args.q[i], args.f3[i]);", 10000);
            GeneratePerformanceTest(str, "float4_to_uint4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "f4", m_ElementInitializer = "new float4(1.0f, 2.0f, 3.0f, 4.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "u4", m_ElementInitializer = "new uint4(100, 101, 102, 103)" },
            }, "args.u4[i] = new uint4(args.f4[i]);", 10000);
            GeneratePerformanceTest(str, "uint4_to_float4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "f4", m_ElementInitializer = "new float4(1.0f, 2.0f, 3.0f, 4.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "u4", m_ElementInitializer = "new uint4(100, 101, 102, 103)" },
            }, "args.f4[i] = new float4(args.u4[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateRandomPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestRandom");

            GeneratePerformanceTest(str, "Random_NextUint", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "u", m_ElementInitializer = "0" },
            }, "args.u[i] = args.rng.NextUInt();", 10000);
            GeneratePerformanceTest(str, "Random_NextUint2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "u", m_ElementInitializer = "0" },
            }, "args.u[i] = args.rng.NextUInt2();", 10000);
            GeneratePerformanceTest(str, "Random_NextUint3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "uint3", m_MemberName = "u", m_ElementInitializer = "0" },
            }, "args.u[i] = args.rng.NextUInt3();", 10000);
            GeneratePerformanceTest(str, "Random_NextUint4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "u", m_ElementInitializer = "0" },
            }, "args.u[i] = args.rng.NextUInt4();", 10000);

            GeneratePerformanceTest(str, "Random_NextFloat", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "f", m_ElementInitializer = "0.0f" },
            }, "args.f[i] = args.rng.NextFloat();", 10000);
            GeneratePerformanceTest(str, "Random_NextFloat2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "f", m_ElementInitializer = "new float2(0.0f)" },
            }, "args.f[i] = args.rng.NextFloat2();", 10000);
            GeneratePerformanceTest(str, "Random_NextFloat3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "f", m_ElementInitializer = "new float3(0.0f)" },
            }, "args.f[i] = args.rng.NextFloat3();", 10000);
            GeneratePerformanceTest(str, "Random_NextFloat4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "f", m_ElementInitializer = "new float4(0.0f)" },
            }, "args.f[i] = args.rng.NextFloat4();", 10000);

            GeneratePerformanceTest(str, "Random_NextDouble", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double", m_MemberName = "f", m_ElementInitializer = "0.0" },
            }, "args.f[i] = args.rng.NextDouble();", 10000);
            GeneratePerformanceTest(str, "Random_NextDouble2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double2", m_MemberName = "f", m_ElementInitializer = "new double2(0.0)" },
            }, "args.f[i] = args.rng.NextDouble2();", 10000);
            GeneratePerformanceTest(str, "Random_NextDouble3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "f", m_ElementInitializer = "new double3(0.0)" },
            }, "args.f[i] = args.rng.NextDouble3();", 10000);
            GeneratePerformanceTest(str, "Random_NextDouble4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double4", m_MemberName = "f", m_ElementInitializer = "new double4(0.0)" },
            }, "args.f[i] = args.rng.NextDouble4();", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateTrigPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestTrig");

            GeneratePerformanceTest(str, "float_sincos", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "sin", m_ElementInitializer = "0.0f" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "cos", m_ElementInitializer = "1.0f" },
            }, "math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);", 10000);
            GeneratePerformanceTest(str, "float2_sincos", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "sin", m_ElementInitializer = "new float2(0.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "cos", m_ElementInitializer = "new float2(1.0f)" },
            }, "math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);", 10000);
            GeneratePerformanceTest(str, "float3_sincos", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "sin", m_ElementInitializer = "new float3(0.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "cos", m_ElementInitializer = "new float3(1.0f)" },
            }, "math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);", 10000);
            GeneratePerformanceTest(str, "float4_sincos", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "sin", m_ElementInitializer = "new float4(0.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "cos", m_ElementInitializer = "new float4(1.0f)" },
            }, "math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateNoisePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestNoise");

            GeneratePerformanceTest(str, "snoise2D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i].x = noise.snoise(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "snoise3D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3()" },
            }, "args.v[i].x = noise.snoise(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "snoise4D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "new float4()" },
            }, "args.v[i].x = noise.snoise(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "snoise3Dgrad", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3()" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "gradient", m_ElementInitializer = "new float3()" },
            }, "args.v[i].x = noise.snoise(args.v[i], out args.gradient[i]);", 10000);
            GeneratePerformanceTest(str, "cnoise2D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i].x = noise.cnoise(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "cnoise3D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3()" },
            }, "args.v[i].x = noise.cnoise(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "cnoise4D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "new float4()" },
            }, "args.v[i].x = noise.cnoise(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "pnoise2D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i].x = noise.pnoise(args.v[i], args.v[i]);", 10000);
            GeneratePerformanceTest(str, "pnoise3D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3()" },
            }, "args.v[i].x = noise.pnoise(args.v[i], args.v[i]);", 10000);
            GeneratePerformanceTest(str, "pnoise4D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "new float4()" },
            }, "args.v[i].x = noise.pnoise(args.v[i], args.v[i]);", 10000);
            GeneratePerformanceTest(str, "cellular2D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i] = noise.cellular(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "cellular3D", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3()" },
            }, "args.v[i].xy = noise.cellular(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "cellular2x2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i] = noise.cellular2x2(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "cellular2x2x2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3()" },
            }, "args.v[i].xy = noise.cellular2x2x2(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "psrdnoise", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i] = noise.psrdnoise(args.v[i], args.v[i], args.v[i].y).xy;", 10000);
            GeneratePerformanceTest(str, "psrnoise", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i].x = noise.psrnoise(args.v[i], args.v[i], args.v[i].y);", 10000);
            GeneratePerformanceTest(str, "srdnoise", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i] = noise.srdnoise(args.v[i], args.v[i].y).xy;", 10000);
            GeneratePerformanceTest(str, "srnoise", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2()" },
            }, "args.v[i].x = noise.srnoise(args.v[i], args.v[i].y);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateTransposePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestTranspose");

            GeneratePerformanceTest(str, "transpose_float4x4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m", m_ElementInitializer = "float4x4.identity" },
            }, "args.m[i] = math.transpose(args.m[i]);", 10000);
            GeneratePerformanceTest(str, "transpose_float3x3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m", m_ElementInitializer = "float3x3.identity" },
            }, "args.m[i] = math.transpose(args.m[i]);", 10000);
            GeneratePerformanceTest(str, "transpose_float2x2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "m", m_ElementInitializer = "float2x2.identity" },
            }, "args.m[i] = math.transpose(args.m[i]);", 10000);
            GeneratePerformanceTest(str, "transpose_double4x4", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double4x4", m_MemberName = "m", m_ElementInitializer = "double4x4.identity" },
            }, "args.m[i] = math.transpose(args.m[i]);", 10000);
            GeneratePerformanceTest(str, "transpose_double3x3", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double3x3", m_MemberName = "m", m_ElementInitializer = "double3x3.identity" },
            }, "args.m[i] = math.transpose(args.m[i]);", 10000);
            GeneratePerformanceTest(str, "transpose_double2x2", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double2x2", m_MemberName = "m", m_ElementInitializer = "double2x2.identity" },
            }, "args.m[i] = math.transpose(args.m[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateNormalizePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestNormalize");

            GeneratePerformanceTest(str, "float4_normalize", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "new float4(1.0f)" },
            }, "args.v[i] = math.normalize(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "float3_normalize", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3(1.0f)" },
            }, "args.v[i] = math.normalize(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "float2_normalize", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2(1.0f)" },
            }, "args.v[i] = math.normalize(args.v[i]);", 10000);

            GeneratePerformanceTest(str, "double4_normalize", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double4", m_MemberName = "v", m_ElementInitializer = "new double4(1.0f)" },
            }, "args.v[i] = math.normalize(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "double3_normalize", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "v", m_ElementInitializer = "new double3(1.0f)" },
            }, "args.v[i] = math.normalize(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "double2_normalize", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double2", m_MemberName = "v", m_ElementInitializer = "new double2(1.0f)" },
            }, "args.v[i] = math.normalize(args.v[i]);", 10000);

            GeneratePerformanceTest(str, "float4_normalizesafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "new float4(1.0f)" },
            }, "args.v[i] = math.normalizesafe(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "float3_normalizesafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3(1.0f)" },
            }, "args.v[i] = math.normalizesafe(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "float2_normalizesafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2(1.0f)" },
            }, "args.v[i] = math.normalizesafe(args.v[i]);", 10000);

            GeneratePerformanceTest(str, "double4_normalizesafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double4", m_MemberName = "v", m_ElementInitializer = "new double4(1.0f)" },
            }, "args.v[i] = math.normalizesafe(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "double3_normalizesafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "v", m_ElementInitializer = "new double3(1.0f)" },
            }, "args.v[i] = math.normalizesafe(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "double2_normalizesafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "double2", m_MemberName = "v", m_ElementInitializer = "new double2(1.0f)" },
            }, "args.v[i] = math.normalizesafe(args.v[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateRotationPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestRotation");

            GeneratePerformanceTest(str, "float4x4_EulerXYZ", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m", m_ElementInitializer = "float4x4.identity" },
            }, "args.m[i] = float4x4.EulerXYZ(args.v[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_EulerXYZ", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m", m_ElementInitializer = "float3x3.identity" },
            }, "args.m[i] = float3x3.EulerXYZ(args.v[i]);", 10000);

            GeneratePerformanceTest(str, "float4x4_AxisAngle", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "math.normalize(new float3(1.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m", m_ElementInitializer = "float4x4.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "angle", m_ElementInitializer = "1.0f" },
            }, "args.m[i] = float4x4.AxisAngle(args.v[i], args.angle[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_AxisAngle", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "math.normalize(new float3(1.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m", m_ElementInitializer = "float3x3.identity" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "angle", m_ElementInitializer = "1.0f" },
            }, "args.m[i] = float3x3.AxisAngle(args.v[i], args.angle[i]);", 10000);

            GeneratePerformanceTest(str, "float3x3_LookRotation", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "forward", m_ElementInitializer = "math.normalize(new float3(1.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "up", m_ElementInitializer = "math.normalize(new float3(0.0f, 1.0f, 0.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m", m_ElementInitializer = "float3x3.identity" },
            }, "args.m[i] = float3x3.LookRotation(args.forward[i], args.up[i]);", 10000);
            GeneratePerformanceTest(str, "float3x3_LookRotationSafe", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "forward", m_ElementInitializer = "math.normalize(new float3(1.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "up", m_ElementInitializer = "math.normalize(new float3(0.0f, 1.0f, 0.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "m", m_ElementInitializer = "float3x3.identity" },
            }, "args.m[i] = float3x3.LookRotationSafe(args.forward[i], args.up[i]);", 10000);
            GeneratePerformanceTest(str, "float4x4_LookAt", new PerformanceTestArrayArgument[] {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "eye", m_ElementInitializer = "math.normalize(new float3(1.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "target", m_ElementInitializer = "math.normalize(new float3(0.0f, 1.0f, 0.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "up", m_ElementInitializer = "math.normalize(new float3(-5.0f, 2.0f, 3.0f))" },
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "m", m_ElementInitializer = "float4x4.identity" },
            }, "args.m[i] = float4x4.LookAt(args.eye[i], args.target[i], args.up[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateShufflePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestShuffle");

            GeneratePerformanceTest(str, "float2_shuffle", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v1", m_ElementInitializer = "new float2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v2", m_ElementInitializer = "new float2(2.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "result", m_ElementInitializer = "new float2(1.0f)" },
            }, "args.result[i] = math.shuffle(args.v1[i], args.v2[i], math.ShuffleComponent.RightX, math.ShuffleComponent.LeftY);", 100000);

            GeneratePerformanceTest(str, "float3_shuffle", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v1", m_ElementInitializer = "new float3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v2", m_ElementInitializer = "new float3(2.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "result", m_ElementInitializer = "new float3(1.0f)" },
            }, "args.result[i] = math.shuffle(args.v1[i], args.v2[i], math.ShuffleComponent.RightX, math.ShuffleComponent.LeftZ, math.ShuffleComponent.LeftX);", 100000);

            GeneratePerformanceTest(str, "float4_shuffle", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v1", m_ElementInitializer = "new float4(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v2", m_ElementInitializer = "new float4(2.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "result", m_ElementInitializer = "new float4(1.0f)" },
            }, "args.result[i] = math.shuffle(args.v1[i], args.v2[i], math.ShuffleComponent.RightX, math.ShuffleComponent.LeftZ, math.ShuffleComponent.LeftX, math.ShuffleComponent.RightY);", 100000);

            EndPerformanceTestCodeGen(str);
        }

        void GenerateHashPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestHash");

            GeneratePerformanceTest(str, "float2_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "float3_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "new float3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "float4_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "new float4(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);

            GeneratePerformanceTest(str, "double2_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "double2", m_MemberName = "v", m_ElementInitializer = "new double2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "double3_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "v", m_ElementInitializer = "new double3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "double4_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "double4", m_MemberName = "v", m_ElementInitializer = "new double4(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);

            GeneratePerformanceTest(str, "float2x2_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "v", m_ElementInitializer = "new float2x2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "float3x3_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "v", m_ElementInitializer = "new float3x3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "float4x4_hash", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "v", m_ElementInitializer = "new float4x4(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hash(args.v[i]);", 100000);

            GeneratePerformanceTest(str, "float2x2_hashwide", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2x2", m_MemberName = "v", m_ElementInitializer = "new float2x2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hashwide(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "float3x3_hashwide", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3x3", m_MemberName = "v", m_ElementInitializer = "new float3x3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint3", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hashwide(args.v[i]);", 100000);
            GeneratePerformanceTest(str, "float4x4_hashwide", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4x4", m_MemberName = "v", m_ElementInitializer = "new float4x4(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "hash", m_ElementInitializer = "0" },
            }, "args.hash[i] = math.hashwide(args.v[i]);", 100000);

            GeneratePerformanceTest(str, "float2_hashwide", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "new float2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "hash", m_ElementInitializer = "new uint2()" },
            }, "args.hash[i] = math.hashwide(args.v[i]);", 100000);

            EndPerformanceTestCodeGen(str);
        }

        void GeneratePlanePerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestPlane");

            GeneratePerformanceTest(str, "Normalize_Plane", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "Plane", m_MemberName = "p", m_ElementInitializer = "new Plane { NormalAndDistance = new float4(1.0f) }" },
            }, "args.p[i] = Plane.Normalize(args.p[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        public void GenerateMinMaxAabbPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestMinMaxAABB");

            GeneratePerformanceTest(str, "Transform_float4x4", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "Geometry.MinMaxAABB", m_MemberName = "a", m_ElementInitializer = "new Geometry.MinMaxAABB()" },
            }, "args.a[i] = Geometry.Math.Transform(float4x4.identity, args.a[i]);", 100000);
            GeneratePerformanceTest(str, "Transform_float3x3", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "Geometry.MinMaxAABB", m_MemberName = "a", m_ElementInitializer = "new Geometry.MinMaxAABB()" },
            }, "args.a[i] = Geometry.Math.Transform(float3x3.identity, args.a[i]);", 100000);

            EndPerformanceTestCodeGen(str);
        }

        public void GenerateMathPerformanceTests(StringBuilder str)
        {
            BeginPerformanceTestCodeGen(str, "TestMath");

            GeneratePerformanceTest(str, "orthonormal_basis_float", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v1", m_ElementInitializer = "rng.NextFloat3Direction()" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v2", m_ElementInitializer = "new float3()" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v3", m_ElementInitializer = "new float3()" },
            }, "math.orthonormal_basis(args.v1[i], out args.v2[i], out args.v3[i]);", 1000000);

            GeneratePerformanceTest(str, "orthonormal_basis_double", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "v1", m_ElementInitializer = "rng.NextDouble3Direction()" },
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "v2", m_ElementInitializer = "new double()" },
                new PerformanceTestArrayArgument { m_ElementType = "double3", m_MemberName = "v3", m_ElementInitializer = "new double()" },
            }, "math.orthonormal_basis(args.v1[i], out args.v2[i], out args.v3[i]);", 1000000);

            GeneratePerformanceTest(str, "asuint_float", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "result", m_ElementInitializer = "new uint()" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_float2", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "result", m_ElementInitializer = "new uint2()" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat2(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_float3", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint3", m_MemberName = "result", m_ElementInitializer = "new uint3()" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat3(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_float4", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "result", m_ElementInitializer = "new uint4()" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat4(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_float", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int", m_MemberName = "result", m_ElementInitializer = "new int()" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_float2", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int2", m_MemberName = "result", m_ElementInitializer = "new int2()" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat2(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_float3", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int3", m_MemberName = "result", m_ElementInitializer = "new int3()" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat3(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_float4", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int4", m_MemberName = "result", m_ElementInitializer = "new int4()" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "v", m_ElementInitializer = "rng.NextFloat4(-1.0f, 1.0f)" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_uint", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "result", m_ElementInitializer = "new uint()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_uint2", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "result", m_ElementInitializer = "new uint2()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt2()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_uint3", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "result", m_ElementInitializer = "new uint3()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint3", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt3()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_uint4", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "result", m_ElementInitializer = "new uint4()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt4()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_int", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "result", m_ElementInitializer = "new int()" },
                new PerformanceTestArrayArgument { m_ElementType = "int", m_MemberName = "v", m_ElementInitializer = "rng.NextInt()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_int2", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "result", m_ElementInitializer = "new int2()" },
                new PerformanceTestArrayArgument { m_ElementType = "int2", m_MemberName = "v", m_ElementInitializer = "rng.NextInt2()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_int3", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "result", m_ElementInitializer = "new int3()" },
                new PerformanceTestArrayArgument { m_ElementType = "int3", m_MemberName = "v", m_ElementInitializer = "rng.NextInt3()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asfloat_int4", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "result", m_ElementInitializer = "new int4()" },
                new PerformanceTestArrayArgument { m_ElementType = "int4", m_MemberName = "v", m_ElementInitializer = "rng.NextInt4()" },
            }, "args.result[i] = math.asfloat(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asdouble_ulong", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "double", m_MemberName = "result", m_ElementInitializer = "new double()" },
                new PerformanceTestArrayArgument { m_ElementType = "ulong", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt()" },
            }, "args.result[i] = math.asdouble(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asdouble_long", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "double", m_MemberName = "result", m_ElementInitializer = "new double()" },
                new PerformanceTestArrayArgument { m_ElementType = "long", m_MemberName = "v", m_ElementInitializer = "rng.NextInt()" },
            }, "args.result[i] = math.asdouble(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "aslong_double", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "long", m_MemberName = "result", m_ElementInitializer = "new long()" },
                new PerformanceTestArrayArgument { m_ElementType = "double", m_MemberName = "v", m_ElementInitializer = "rng.NextDouble(-1.0, 1.0)" },
            }, "args.result[i] = math.aslong(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asulong_double", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "ulong", m_MemberName = "result", m_ElementInitializer = "new ulong()" },
                new PerformanceTestArrayArgument { m_ElementType = "double", m_MemberName = "v", m_ElementInitializer = "rng.NextDouble(-1.0, 1.0)" },
            }, "args.result[i] = math.asulong(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_int", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "result", m_ElementInitializer = "new uint()" },
                new PerformanceTestArrayArgument { m_ElementType = "int", m_MemberName = "v", m_ElementInitializer = "rng.NextInt()" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_int2", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "result", m_ElementInitializer = "new uint2()" },
                new PerformanceTestArrayArgument { m_ElementType = "int2", m_MemberName = "v", m_ElementInitializer = "rng.NextInt2()" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_int3", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint3", m_MemberName = "result", m_ElementInitializer = "new uint3()" },
                new PerformanceTestArrayArgument { m_ElementType = "int3", m_MemberName = "v", m_ElementInitializer = "rng.NextInt3()" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asuint_int4", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "result", m_ElementInitializer = "new uint4()" },
                new PerformanceTestArrayArgument { m_ElementType = "int4", m_MemberName = "v", m_ElementInitializer = "rng.NextInt4()" },
            }, "args.result[i] = math.asuint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_uint", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int", m_MemberName = "result", m_ElementInitializer = "new int()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt()" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_uint2", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int2", m_MemberName = "result", m_ElementInitializer = "new int2()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint2", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt2()" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_uint3", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int3", m_MemberName = "result", m_ElementInitializer = "new int3()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint3", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt3()" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "asint_uint4", new[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "int4", m_MemberName = "result", m_ElementInitializer = "new int4()" },
                new PerformanceTestArrayArgument { m_ElementType = "uint4", m_MemberName = "v", m_ElementInitializer = "rng.NextUInt4()" },
            }, "args.result[i] = math.asint(args.v[i]);", 400000);

            GeneratePerformanceTest(str, "chgsign_float", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "f", m_ElementInitializer = "1.0f" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "sign", m_ElementInitializer = "rng.NextFloat(-1.0f, 1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "result", m_ElementInitializer = "0.0f" },
            }, "args.result[i] = math.chgsign(args.f[i], args.sign[i]);", 100000);

            GeneratePerformanceTest(str, "chgsign_float2", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "f", m_ElementInitializer = "new float2(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "sign", m_ElementInitializer = "rng.NextFloat2(-1.0f, 1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float2", m_MemberName = "result", m_ElementInitializer = "new float2()" },
            }, "args.result[i] = math.chgsign(args.f[i], args.sign[i]);", 100000);

            GeneratePerformanceTest(str, "chgsign_float3", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "f", m_ElementInitializer = "new float3(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "sign", m_ElementInitializer = "rng.NextFloat3(-1.0f, 1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float3", m_MemberName = "result", m_ElementInitializer = "new float3()" },
            }, "args.result[i] = math.chgsign(args.f[i], args.sign[i]);", 100000);

            GeneratePerformanceTest(str, "chgsign_float4", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "f", m_ElementInitializer = "new float4(1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "sign", m_ElementInitializer = "rng.NextFloat4(-1.0f, 1.0f)" },
                new PerformanceTestArrayArgument { m_ElementType = "float4", m_MemberName = "result", m_ElementInitializer = "new float4()" },
            }, "args.result[i] = math.chgsign(args.f[i], args.sign[i]);", 100000);

            GeneratePerformanceTest(str, "angle_quaternion_quaternion", new PerformanceTestArrayArgument[]
            {
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q1", m_ElementInitializer = "rng.NextQuaternionRotation()" },
                new PerformanceTestArrayArgument { m_ElementType = "quaternion", m_MemberName = "q2", m_ElementInitializer = "rng.NextQuaternionRotation()" },
                new PerformanceTestArrayArgument { m_ElementType = "float", m_MemberName = "result", m_ElementInitializer = "new float()" },
            }, "args.result[i] = math.angle(args.q1[i], args.q2[i]);", 10000);

            EndPerformanceTestCodeGen(str);
        }

        public struct PerformanceTestArrayArgument
        {
            public string m_ElementType;
            public string m_MemberName;
            public string m_ElementInitializer;
        }

        void GeneratePerformanceTest(StringBuilder str, string testName, PerformanceTestArrayArgument[] testArguments, string loopBody, int loopIterations, uint rngSeed = 1u)
        {
            str.AppendFormat("\t\t[BurstCompile(CompileSynchronously = true)]\n");
            str.AppendFormat("\t\tpublic unsafe class {0}\n", testName);
            str.AppendFormat("\t\t{{\n");
            str.AppendFormat("\t\t\tpublic const int iterations = {0};\n\n", loopIterations);
            str.AppendFormat("\t\t\tpublic struct Arguments : IDisposable\n");
            str.AppendFormat("\t\t\t{{\n");
            str.AppendFormat("\t\t\t\tpublic Random rng;\n");

            foreach (var argument in testArguments)
            {
                str.AppendFormat("\t\t\t\tpublic {0}* {1};\n", argument.m_ElementType, argument.m_MemberName);
            }

            str.AppendFormat("\n");
            str.AppendFormat("\t\t\t\tpublic void Init()\n");
            str.AppendFormat("\t\t\t\t{{\n");
            str.AppendFormat("\t\t\t\t\trng = new Random({0});\n", rngSeed);

            foreach (var argument in testArguments)
            {
                str.AppendFormat("\t\t\t\t\t{0} = ({1}*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<{1}>() * iterations, UnsafeUtility.AlignOf<{1}>(), Allocator.Persistent);\n", argument.m_MemberName, argument.m_ElementType);
                str.AppendFormat("\t\t\t\t\tfor (int i = 0; i < iterations; ++i)\n");
                str.AppendFormat("\t\t\t\t\t{{\n");
                str.AppendFormat("\t\t\t\t\t    {0}[i] = {1};\n", argument.m_MemberName, argument.m_ElementInitializer);
                str.AppendFormat("\t\t\t\t\t}}\n\n");
            }

            str.AppendFormat("\t\t\t\t}}\n\n");
            str.AppendFormat("\t\t\t\tpublic void Dispose()\n");
            str.AppendFormat("\t\t\t\t{{\n");

            foreach (var argument in testArguments)
            {
                str.AppendFormat("\t\t\t\t\tUnsafeUtility.Free({0}, Allocator.Persistent);\n", argument.m_MemberName);
            }

            str.AppendFormat("\t\t\t\t}}\n");
            str.AppendFormat("\t\t\t}}\n");
            str.AppendFormat("\n");

            str.AppendFormat("\t\t\tpublic static void CommonTestFunction(ref Arguments args)\n");
            str.AppendFormat("\t\t\t{{\n");
            str.AppendFormat("\t\t\t\tfor (int i = 0; i < iterations; ++i)\n");
            str.AppendFormat("\t\t\t\t{{\n");
            str.AppendFormat("\t\t\t\t\t{0}\n", loopBody);
            str.AppendFormat("\t\t\t\t}}\n");
            str.AppendFormat("\t\t\t}}\n\n");
            str.AppendFormat("\t\t\tpublic static void MonoTestFunction(ref Arguments args)\n");
            str.AppendFormat("\t\t\t{{\n");
            str.AppendFormat("\t\t\t\tCommonTestFunction(ref args);\n");
            str.AppendFormat("\t\t\t}}\n\n");
            str.AppendFormat("\t\t\t[BurstCompile(CompileSynchronously = true)]\n");
            str.AppendFormat("\t\t\tpublic static void BurstTestFunction(ref Arguments args)\n");
            str.AppendFormat("\t\t\t{{\n");
            str.AppendFormat("\t\t\t\tCommonTestFunction(ref args);\n");
            str.AppendFormat("\t\t\t}}\n\n");
            str.AppendFormat("\t\t\tpublic delegate void TestFunction(ref Arguments args);\n");
            str.AppendFormat("\t\t}}\n\n");
            str.AppendFormat("\t\t[Test, Performance]\n");
            str.AppendFormat("\t\tpublic void {0}_mono()\n", testName);
            str.AppendFormat("\t\t{{\n");
            str.AppendFormat("\t\t\t{0}.TestFunction testFunction = {0}.MonoTestFunction;\n", testName);
            str.AppendFormat("\t\t\tvar args = new {0}.Arguments();\n", testName);
            str.AppendFormat("\t\t\targs.Init();\n");
            str.AppendFormat("\n");
            str.AppendFormat("\t\t\tvar monoSampleGroup = new SampleGroup(\"Mono\", SampleUnit.Microsecond);");
            str.AppendFormat("\t\t\tMeasure.Method(() =>\n");
            str.AppendFormat("\t\t\t{{\n");
            str.AppendFormat("\t\t\t\ttestFunction.Invoke(ref args);\n");
            str.AppendFormat("\t\t\t}})\n");
            str.AppendFormat("\t\t\t.SampleGroup(monoSampleGroup)\n");
            str.AppendFormat("\t\t\t.WarmupCount(1)\n");
            str.AppendFormat("\t\t\t.MeasurementCount(10)\n");
            str.AppendFormat("\t\t\t.Run();\n");
            str.AppendFormat("\t\t\targs.Dispose();\n");
            str.AppendFormat("\t\t}}\n\n");
            str.AppendFormat("\t\t[Test, Performance]\n");
            str.AppendFormat("\t\tpublic void {0}_burst()\n", testName);
            str.AppendFormat("\t\t{{\n");
            str.AppendFormat("\t\t\tFunctionPointer<{0}.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<{0}.TestFunction>({0}.BurstTestFunction);\n", testName);
            str.AppendFormat("\t\t\tvar args = new {0}.Arguments();\n", testName);
            str.AppendFormat("\t\t\targs.Init();\n");
            str.AppendFormat("\n");
            str.AppendFormat("\t\t\tvar burstSampleGroup = new SampleGroup(\"Burst\", SampleUnit.Microsecond);");
            str.AppendFormat("\t\t\tMeasure.Method(() =>\n");
            str.AppendFormat("\t\t\t{{\n");
            str.AppendFormat("\t\t\t    testFunction.Invoke(ref args);\n");
            str.AppendFormat("\t\t\t}})\n");
            str.AppendFormat("\t\t\t.SampleGroup(burstSampleGroup)\n");
            str.AppendFormat("\t\t\t.WarmupCount(1)\n");
            str.AppendFormat("\t\t\t.MeasurementCount(10)\n");
            str.AppendFormat("\t\t\t.Run();\n");
            str.AppendFormat("\t\t\targs.Dispose();\n");
            str.AppendFormat("\t\t}}\n");
        }

        void WritePerformanceTests()
        {
            StringBuilder testMulStr = new StringBuilder();
            GenerateMulPerformanceTests(testMulStr);
            WriteFile(m_PerformanceTestDirectory + "/TestMul.gen.cs", testMulStr.ToString());

            StringBuilder inverseStr = new StringBuilder();
            GenerateInversePerformanceTests(inverseStr);
            WriteFile(m_PerformanceTestDirectory + "/TestInverse.gen.cs", inverseStr.ToString());

            StringBuilder fastInverseStr = new StringBuilder();
            GenerateFastInversePerformanceTests(fastInverseStr);
            WriteFile(m_PerformanceTestDirectory + "/TestFastInverse.gen.cs", fastInverseStr.ToString());

            StringBuilder conversionStr = new StringBuilder();
            GenerateConversionPerformanceTests(conversionStr);
            WriteFile(m_PerformanceTestDirectory + "/TestConversions.gen.cs", conversionStr.ToString());

            StringBuilder randomStr = new StringBuilder();
            GenerateRandomPerformanceTests(randomStr);
            WriteFile(m_PerformanceTestDirectory + "/TestRandom.gen.cs", randomStr.ToString());

            StringBuilder trigStr = new StringBuilder();
            GenerateTrigPerformanceTests(trigStr);
            WriteFile(m_PerformanceTestDirectory + "/TestTrig.gen.cs", trigStr.ToString());

            StringBuilder noiseStr = new StringBuilder();
            GenerateNoisePerformanceTests(noiseStr);
            WriteFile(m_PerformanceTestDirectory + "/TestNoise.gen.cs", noiseStr.ToString());

            StringBuilder transposeStr = new StringBuilder();
            GenerateTransposePerformanceTests(transposeStr);
            WriteFile(m_PerformanceTestDirectory + "/TestTranspose.gen.cs", transposeStr.ToString());

            StringBuilder normalizeStr = new StringBuilder();
            GenerateNormalizePerformanceTests(normalizeStr);
            WriteFile(m_PerformanceTestDirectory + "/TestNormalize.gen.cs", normalizeStr.ToString());

            StringBuilder rotationStr = new StringBuilder();
            GenerateRotationPerformanceTests(rotationStr);
            WriteFile(m_PerformanceTestDirectory + "/TestRotation.gen.cs", rotationStr.ToString());

            StringBuilder shuffleStr = new StringBuilder();
            GenerateShufflePerformanceTests(shuffleStr);
            WriteFile(m_PerformanceTestDirectory + "/TestShuffle.gen.cs", shuffleStr.ToString());

            StringBuilder hashStr = new StringBuilder();
            GenerateHashPerformanceTests(hashStr);
            WriteFile(m_PerformanceTestDirectory + "/TestHash.gen.cs", hashStr.ToString());

            StringBuilder planeStr = new StringBuilder();
            GeneratePlanePerformanceTests(planeStr);
            WriteFile(m_PerformanceTestDirectory + "/TestPlane.gen.cs", planeStr.ToString());

            StringBuilder minMaxAabbStr = new StringBuilder();
            GenerateMinMaxAabbPerformanceTests(minMaxAabbStr);
            WriteFile(m_PerformanceTestDirectory + "/TestMinMaxAABB.gen.cs", minMaxAabbStr.ToString());

            StringBuilder mathStr = new StringBuilder();
            GenerateMathPerformanceTests(mathStr);
            WriteFile(m_PerformanceTestDirectory + "/TestMath.gen.cs", mathStr.ToString());
        }
    }
}
