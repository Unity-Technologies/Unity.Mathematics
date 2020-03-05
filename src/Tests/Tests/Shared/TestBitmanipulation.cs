using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestBitmanipulation
    {
        [TestCompiler]
        public static void bitmask_bool4()
        {
            TestUtils.AreEqual(bitmask(new bool4(false, false, false, false)), 0b0000);
            TestUtils.AreEqual(bitmask(new bool4(true, false, false, false)), 0b0001);
            TestUtils.AreEqual(bitmask(new bool4(false, true, false, false)), 0b0010);
            TestUtils.AreEqual(bitmask(new bool4(false, false, true, false)), 0b0100);
            TestUtils.AreEqual(bitmask(new bool4(false, false, false, true)), 0b1000);

            TestUtils.AreEqual(bitmask(new bool4(true, true, true, true)), 0b1111);
            TestUtils.AreEqual(bitmask(new bool4(false, true, true, true)), 0b1110);
            TestUtils.AreEqual(bitmask(new bool4(true, false, true, true)), 0b1101);
            TestUtils.AreEqual(bitmask(new bool4(true, true, false, true)), 0b1011);
            TestUtils.AreEqual(bitmask(new bool4(true, true, true, false)), 0b0111);
        }

        [TestCompiler]
        public static void countbits_int1()
        {
            TestUtils.AreEqual(12, countbits( 0x01234567));
            TestUtils.AreEqual(16, countbits( 0x456789AB));
            TestUtils.AreEqual(21, countbits(-0x01234567));
            TestUtils.AreEqual(17, countbits(-0x456789AB));
            TestUtils.AreEqual(32, countbits(-1));
        }

        [TestCompiler]
        public static void countbits_int2()
        {
            TestUtils.AreEqual(int2(0, 12), countbits(int2(0, 0x01234567)));
            TestUtils.AreEqual(int2(16, 21), countbits(int2(0x456789AB, -0x01234567)));
            TestUtils.AreEqual(int2(17, 32), countbits(int2(-0x456789AB, -1)));
        }

        [TestCompiler]
        public static void countbits_int3()
        {
            TestUtils.AreEqual(int3(0, 12, 16), countbits(int3(0, 0x01234567, 0x456789AB)));
            TestUtils.AreEqual(int3(21, 17, 32), countbits(int3(-0x01234567, -0x456789AB, -1)));
        }

        [TestCompiler]
        public static void countbits_int4()
        {
            TestUtils.AreEqual(int4(0, 12, 16, 21), countbits(int4(0, 0x01234567, 0x456789AB, -0x01234567)));
            TestUtils.AreEqual(int4(17, 32, 30, 29), countbits(int4(-0x456789AB, -1, -7, -15)));
        }

        [TestCompiler]
        public static void countbits_uint()
        {
            TestUtils.AreEqual(0, countbits(0u));
            TestUtils.AreEqual(12, countbits(0x01234567u));
            TestUtils.AreEqual(16, countbits(0x456789ABu));
            TestUtils.AreEqual(20, countbits(0x89ABCDEFu));
            TestUtils.AreEqual(16, countbits(0xCDEF0123u));
            TestUtils.AreEqual(32, countbits(0xFFFFFFFFu));
        }

        [TestCompiler]
        public static void countbits_uint2()
        {
            TestUtils.AreEqual(int2(0, 12), countbits(uint2(0, 0x01234567)));
            TestUtils.AreEqual(int2(16, 20), countbits(uint2(0x456789AB, 0x89ABCDEFu)));
            TestUtils.AreEqual(int2(16, 32), countbits(uint2(0xCDEF0123u, 0xFFFFFFFFu)));
        }

        [TestCompiler]
        public static void countbits_uint3()
        {
            TestUtils.AreEqual(int3(0, 12, 16), countbits(uint3(0, 0x01234567, 0x456789AB)));
            TestUtils.AreEqual(int3(20, 16, 32), countbits(uint3(0x89ABCDEFu, 0xCDEF0123u, 0xFFFFFFFFu)));
        }

        [TestCompiler]
        public static void countbits_uint4()
        {
            TestUtils.AreEqual(int4(0, 12, 16, 20), countbits(uint4(0, 0x01234567, 0x456789AB, 0x89ABCDEFu)));
            TestUtils.AreEqual(int4(16, 32, 30, 29), countbits(uint4(0xCDEF0123u, 0xFFFFFFFFu, 0xFFFFFFF5u, 0xFFFFFFF1u)));
        }

        [TestCompiler]
        public static void countbits_long()
        {
            TestUtils.AreEqual(0, countbits(0L));
            TestUtils.AreEqual(32, countbits(0x0123456789ABCDEFL));
            TestUtils.AreEqual(33, countbits(-0x0123456789ABCDEFL));
            TestUtils.AreEqual(64, countbits(-1L));
        }

        [TestCompiler]
        public static void countbits_ulong()
        {
            TestUtils.AreEqual(0, countbits(0UL));
            TestUtils.AreEqual(32, countbits(0x0123456789ABCDEFUL));
            TestUtils.AreEqual(32, countbits(0x89ABCDEF01234567UL));
            TestUtils.AreEqual(64, countbits(0xFFFFFFFFFFFFFFFFUL));
        }

        [TestCompiler]
        public static void lzcnt_int()
        {
            TestUtils.AreEqual(32, lzcnt(0));
            TestUtils.AreEqual(31, lzcnt(1));
            TestUtils.AreEqual(30, lzcnt(2));
            TestUtils.AreEqual(30, lzcnt(3));
            TestUtils.AreEqual(17, lzcnt(0x5321));
            TestUtils.AreEqual(5, lzcnt(0x04435321));
            TestUtils.AreEqual(0, lzcnt(-1));
            TestUtils.AreEqual(0, lzcnt(-2147483648));
        }

        [TestCompiler]
        public static void lzcnt_int2()
        {
            TestUtils.AreEqual(int2(32, 31), lzcnt(int2(0, 1)));
            TestUtils.AreEqual(int2(30, 30), lzcnt(int2(2, 3)));
            TestUtils.AreEqual(int2(17, 5), lzcnt(int2(0x5321, 0x04435321)));
            TestUtils.AreEqual(int2(0, 0), lzcnt(int2(-1, -2147483648)));
        }

        [TestCompiler]
        public static void lzcnt_int3()
        {
            TestUtils.AreEqual(int3(32, 31, 30), lzcnt(int3(0, 1, 2)));
            TestUtils.AreEqual(int3(30, 17, 5), lzcnt(int3(3, 0x5321, 0x04435321)));
            TestUtils.AreEqual(int3(0, 0, 27), lzcnt(int3(-1, -2147483648, 17)));
        }

        [TestCompiler]
        public static void lzcnt_int4()
        {
            TestUtils.AreEqual(int4(32, 31, 30, 30), lzcnt(int4(0, 1, 2, 3)));
            TestUtils.AreEqual(int4(17, 5, 0, 0), lzcnt(int4(0x5321, 0x04435321, -1, -2147483648)));
        }

        [TestCompiler]
        public static void lzcnt_uint()
        {
            TestUtils.AreEqual(32, lzcnt(0u));
            TestUtils.AreEqual(31, lzcnt(1u));
            TestUtils.AreEqual(30, lzcnt(2u));
            TestUtils.AreEqual(30, lzcnt(3u));
            TestUtils.AreEqual(17, lzcnt(0x5321u));
            TestUtils.AreEqual(5, lzcnt(0x04435321u));
            TestUtils.AreEqual(0, lzcnt(0x84435320u));
            TestUtils.AreEqual(0, lzcnt(0xFFFFFFFFu));
        }

        [TestCompiler]
        public static void lzcnt_uint2()
        {
            TestUtils.AreEqual(int2(32, 31), lzcnt(uint2(0u, 1u)));
            TestUtils.AreEqual(int2(30, 30), lzcnt(uint2(2u, 3u)));
            TestUtils.AreEqual(int2(17, 5), lzcnt(uint2(0x5321u, 0x04435321u)));
            TestUtils.AreEqual(int2(0, 0), lzcnt(uint2(0x84435320u, 0xFFFFFFFFu)));
        }

        [TestCompiler]
        public static void lzcnt_uint3()
        {
            TestUtils.AreEqual(int3(32, 31, 30), lzcnt(uint3(0u, 1u, 2u)));
            TestUtils.AreEqual(int3(30, 17, 5), lzcnt(uint3(3u, 0x5321u, 0x04435321u)));
            TestUtils.AreEqual(int3(0, 0, 27), lzcnt(uint3(0x84435320u, 0xFFFFFFFFu, 17)));
        }

        [TestCompiler]
        public static void lzcnt_uint4()
        {
            TestUtils.AreEqual(int2(32, 31), lzcnt(uint2(0u, 1u)));
            TestUtils.AreEqual(int2(30, 30), lzcnt(uint2(2u, 3u)));
            TestUtils.AreEqual(int2(17, 5), lzcnt(uint2(0x5321u, 0x04435321u)));
            TestUtils.AreEqual(int2(0, 0), lzcnt(uint2(0x84435320u, 0xFFFFFFFFu)));
        }

        [TestCompiler]
        public static void lzcnt_long()
        {
            TestUtils.AreEqual(64, lzcnt(0L));
            TestUtils.AreEqual(63, lzcnt(1L));
            TestUtils.AreEqual(35, lzcnt(0x1FFF1234L));
            TestUtils.AreEqual(31, lzcnt(0x1FFFF1234L));
            TestUtils.AreEqual(19, lzcnt(0x1FFFFFFF1234L));
            TestUtils.AreEqual(0, lzcnt(-1L));
            TestUtils.AreEqual(0, lzcnt(-9223372036854775808L));
        }

        [TestCompiler]
        public static void lzcnt_ulong()
        {
            TestUtils.AreEqual(64, lzcnt(0UL));
            TestUtils.AreEqual(63, lzcnt(1UL));
            TestUtils.AreEqual(35, lzcnt(0x1FFF1234UL));
            TestUtils.AreEqual(31, lzcnt(0x1FFFF1234UL));
            TestUtils.AreEqual(19, lzcnt(0x1FFFFFFF1234UL));
            TestUtils.AreEqual(0, lzcnt(0xFFFFFFFFFFFFFFFFUL));
            TestUtils.AreEqual(0, lzcnt(0x8000000000000000UL));
        }

        [TestCompiler]
        public static void tzcnt_int()
        {
            TestUtils.AreEqual(32, tzcnt(0));
            TestUtils.AreEqual(0, tzcnt(1));
            TestUtils.AreEqual(1, tzcnt(2));
            TestUtils.AreEqual(0, tzcnt(3));
            TestUtils.AreEqual(4, tzcnt(0x53210));
            TestUtils.AreEqual(17, tzcnt(0x44420000));
            TestUtils.AreEqual(1, tzcnt(-2));
            TestUtils.AreEqual(0, tzcnt(-2147483647));
            TestUtils.AreEqual(31, tzcnt(-2147483648));
        }

        [TestCompiler]
        public static void tzcnt_int2()
        {
            TestUtils.AreEqual(int2(32, 0), tzcnt(int2(0, 1)));
            TestUtils.AreEqual(int2(1, 0), tzcnt(int2(2, 3)));
            TestUtils.AreEqual(int2(4, 17), tzcnt(int2(0x53210, 0x44420000)));
            TestUtils.AreEqual(int2(1, 0), tzcnt(int2(-2, -2147483647)));
            TestUtils.AreEqual(int2(31, 2), tzcnt(int2(-2147483648, 20)));
        }

        [TestCompiler]
        public static void tzcnt_int3()
        {
            TestUtils.AreEqual(int3(32, 0, 1), tzcnt(int3(0, 1, 2)));
            TestUtils.AreEqual(int3(0, 4, 17), tzcnt(int3(3, 0x53210, 0x44420000)));
            TestUtils.AreEqual(int3(1, 0, 31), tzcnt(int3(-2, -2147483647, -2147483648)));
        }

        [TestCompiler]
        public static void tzcnt_int4()
        {
            TestUtils.AreEqual(int4(32, 0, 1, 0), tzcnt(int4(0, 1, 2, 3)));
            TestUtils.AreEqual(int4(4, 17, 1, 0), tzcnt(int4(0x53210, 0x44420000, -2, -2147483647)));
            TestUtils.AreEqual(int4(31, 2, 2, 3), tzcnt(int4(-2147483648, 20, 4132, -8)));
        }

        [TestCompiler]
        public static void tzcnt_uint()
        {
            TestUtils.AreEqual(32, tzcnt(0u));
            TestUtils.AreEqual(0, tzcnt(1u));
            TestUtils.AreEqual(1, tzcnt(2u));
            TestUtils.AreEqual(0, tzcnt(3u));
            TestUtils.AreEqual(4, tzcnt(0x53210u));
            TestUtils.AreEqual(17, tzcnt(0x44420000u));
            TestUtils.AreEqual(1, tzcnt(0xFFFFFFFEu));
            TestUtils.AreEqual(0, tzcnt(0x80000001u));
            TestUtils.AreEqual(31, tzcnt(0x80000000u));
        }

        [TestCompiler]
        public static void tzcnt_uint2()
        {
            TestUtils.AreEqual(int2(32, 0), tzcnt(uint2(0u, 1u)));
            TestUtils.AreEqual(int2(1, 0), tzcnt(uint2(2u, 3u)));
            TestUtils.AreEqual(int2(4, 17), tzcnt(uint2(0x53210u, 0x44420000u)));
            TestUtils.AreEqual(int2(1, 0), tzcnt(uint2(0xFFFFFFFEu, 0x80000001u)));
            TestUtils.AreEqual(int2(31, 2), tzcnt(uint2(0x80000000u, 20u)));
        }

        [TestCompiler]
        public static void tzcnt_uint3()
        {
            TestUtils.AreEqual(int3(32, 0, 1), tzcnt(uint3(0u, 1u, 2u)));
            TestUtils.AreEqual(int3(0, 4, 17), tzcnt(uint3(3u, 0x53210u, 0x44420000u)));
            TestUtils.AreEqual(int3(1, 0, 31), tzcnt(uint3(0xFFFFFFFEu, 0x80000001u, 0x80000000u)));
        }

        [TestCompiler]
        public static void tzcnt_uint4()
        {
            TestUtils.AreEqual(int4(32, 0, 1, 0), tzcnt(uint4(0u, 1u, 2u, 3u)));
            TestUtils.AreEqual(int4(4, 17, 1, 0), tzcnt(uint4(0x53210u, 0x44420000u, 0xFFFFFFFE, 0x80000001u)));
            TestUtils.AreEqual(int4(31, 2, 2, 3), tzcnt(uint4(0x80000000u, 20u, 4132u, 0xFFFFFFF8u)));
        }

        [TestCompiler]
        public static void tzcnt_long()
        {
            TestUtils.AreEqual(64, tzcnt(0L));
            TestUtils.AreEqual(0, tzcnt(1L));
            TestUtils.AreEqual(1, tzcnt(2L));
            TestUtils.AreEqual(17, tzcnt(0x44420000L));
            TestUtils.AreEqual(33, tzcnt(0x444200000000L));
            TestUtils.AreEqual(63, tzcnt(-9223372036854775808L));
            TestUtils.AreEqual(0, tzcnt(-9223372036854775807L));
        }

        [TestCompiler]
        public static void tzcnt_ulong()
        {
            TestUtils.AreEqual(64, tzcnt(0UL));
            TestUtils.AreEqual(0, tzcnt(1UL));
            TestUtils.AreEqual(1, tzcnt(2UL));
            TestUtils.AreEqual(17, tzcnt(0x44420000UL));
            TestUtils.AreEqual(33, tzcnt(0x444200000000UL));
            TestUtils.AreEqual(63, tzcnt(0x8000000000000000UL));
            TestUtils.AreEqual(0, tzcnt(0x8000000000000001UL));
        }

        [TestCompiler]
        public static void reversebits_int()
        {
            TestUtils.AreEqual(0x03521609, reversebits(-1872213312));
            TestUtils.AreEqual(0x5f5b0648, reversebits(0x1260dafa));
            TestUtils.AreEqual(0x4bbafd8d, reversebits(-1312858670));
            TestUtils.AreEqual(0x48d9c42e, reversebits(0x74239b12));
        }

        [TestCompiler]
        public static void reversebits_int2()
        {
            TestUtils.AreEqual(int2(0x03521609, 0x5f5b0648), reversebits(int2(-1872213312, 0x1260dafa)));
            TestUtils.AreEqual(int2(0x4bbafd8d, 0x48d9c42e), reversebits(int2(-1312858670, 0x74239b12)));
        }

        [TestCompiler]
        public static void reversebits_int3()
        {
            TestUtils.AreEqual(int3(0x03521609, 0x5f5b0648, 0x4bbafd8d), reversebits(int3(-1872213312, 0x1260dafa, -1312858670)));
            TestUtils.AreEqual(int3(0x48d9c42e, 0, -1), reversebits(int3(0x74239b12, 0, -1)));
        }

        [TestCompiler]
        public static void reversebits_int4()
        {
            TestUtils.AreEqual(int4(0x03521609, 0x5f5b0648, 0x4bbafd8d, 0x48d9c42e), reversebits(int4(-1872213312, 0x1260dafa, -1312858670, 0x74239b12)));
        }

        [TestCompiler]
        public static void reversebits_uint()
        {
            TestUtils.AreEqual(0x03521609u, reversebits(0x90684ac0u));
            TestUtils.AreEqual(0x5f5b0648u, reversebits(0x1260dafau));
            TestUtils.AreEqual(0x4bbafd8du, reversebits(0xb1bf5dd2u));
            TestUtils.AreEqual(0x48d9c42eu, reversebits(0x74239b12u));
        }

        [TestCompiler]
        public static void reversebits_uint2()
        {
            TestUtils.AreEqual(uint2(0x03521609u, 0x5f5b0648u), reversebits(uint2(0x90684ac0u, 0x1260dafau)));
            TestUtils.AreEqual(uint2(0x4bbafd8du, 0x48d9c42eu), reversebits(uint2(0xb1bf5dd2u, 0x74239b12u)));
        }

        [TestCompiler]
        public static void reversebits_uint3()
        {
            TestUtils.AreEqual(uint3(0x03521609u, 0x5f5b0648u, 0x4bbafd8du), reversebits(uint3(0x90684ac0u, 0x1260dafau, 0xb1bf5dd2u)));
            TestUtils.AreEqual(uint3(0x48d9c42eu, 0u, 0xFFFFFFFF), reversebits(uint3(0x74239b12u, 0u, 0xFFFFFFFF)));
        }

        [TestCompiler]
        public static void reversebits_uint4()
        {
            TestUtils.AreEqual(uint4(0x03521609u, 0x5f5b0648u, 0x4bbafd8du, 0x48d9c42eu), reversebits(uint4(0x90684ac0u, 0x1260dafau, 0xb1bf5dd2u, 0x74239b12u)));
        }

        [TestCompiler]
        public static void reversebits_long()
        {
            TestUtils.AreEqual(0x4bbafd8d5f5b0648L, reversebits(0x1260dafab1bf5dd2L));
        }

        [TestCompiler]
        public static void reversebits_ulong()
        {
            TestUtils.AreEqual(0x4bbafd8d5f5b0648ul, reversebits(0x1260dafab1bf5dd2ul));
        }

        [TestCompiler]
        public static void rol_int()
        {
            TestUtils.AreEqual(-1933184920, rol(219257022, 11));
            TestUtils.AreEqual(-2048170741, rol(-1586446996, 11));
            TestUtils.AreEqual(-1152739462, rol(-279484078, 11));
            TestUtils.AreEqual(661621977, rol(-1692078607, 11));
        }

        [TestCompiler]
        public static void rol_int2()
        {
            TestUtils.AreEqual(int2(-1933184920, -2048170741), rol(int2(219257022, -1586446996), 11));
            TestUtils.AreEqual(int2(-1152739462, 661621977), rol(int2(-279484078, -1692078607), 11));
        }

        [TestCompiler]
        public static void rol_int3()
        {
            TestUtils.AreEqual(int3(-1933184920, -2048170741, -1152739462), rol(int3(219257022, -1586446996, -279484078), 11));
        }


        [TestCompiler]
        public static void rol_int4()
        {
            TestUtils.AreEqual(int4(-1933184920, -2048170741, -1152739462, 661621977), rol(int4(219257022, -1586446996, -279484078, -1692078607), 11));
        }

        [TestCompiler]
        public static void rol_uint()
        {
            TestUtils.AreEqual(2361782376u, rol(219257022u, 11));
            TestUtils.AreEqual(2246796555u, rol(2708520300u, 11));
            TestUtils.AreEqual(3142227834u, rol(4015483218u, 11));
            TestUtils.AreEqual(661621977u, rol(2602888689u, 11));
        }

        [TestCompiler]
        public static void rol_uint2()
        {
            TestUtils.AreEqual(uint2(2361782376u, 2246796555u), rol(uint2(219257022u, 2708520300u), 11));
            TestUtils.AreEqual(uint2(3142227834u, 661621977u), rol(uint2(4015483218u, 2602888689u), 11));
        }

        [TestCompiler]
        public static void rol_uint3()
        {
            TestUtils.AreEqual(uint3(2361782376u, 2246796555u, 3142227834u), rol(uint3(219257022u, 2708520300u, 4015483218u), 11));
        }

        [TestCompiler]
        public static void rol_uint4()
        {
            TestUtils.AreEqual(uint4(2361782376u, 2246796555u, 3142227834u, 661621977u), rol(uint4(219257022u, 2708520300u, 4015483218u, 2602888689u), 11));
        }


        [TestCompiler]
        public static void rol_long()
        {
            TestUtils.AreEqual(4769317691753349395L, rol(6894885722123239465L, 37));
            TestUtils.AreEqual(7702732954299909421L, rol(9017875690541231318L, 37));
            TestUtils.AreEqual(4304137451269976409L, rol(-6252342588442027279L, 37));
            TestUtils.AreEqual(-5493728106787075631L, rol(2788577329702376155L, 37));
        }

        [TestCompiler]
        public static void rol_ulong()
        {
            TestUtils.AreEqual(4769317691753349395UL, rol(6894885722123239465UL, 37));
            TestUtils.AreEqual(7702732954299909421UL, rol(9017875690541231318UL, 37));
            TestUtils.AreEqual(4304137451269976409UL, rol(12194401485267524337UL, 37));
            TestUtils.AreEqual(12953015966922475985UL, rol(2788577329702376155UL, 37));
        }


        [TestCompiler]
        public static void ror_int()
        {
            TestUtils.AreEqual(87245360, ror(-1710129111, 11));
            TestUtils.AreEqual(-259445220, ror(1232136068, 11));
            TestUtils.AreEqual(-1697813787, ror(1800875222, 11));
            TestUtils.AreEqual(-232831845, ror(-98246768, 11));
        }

        [TestCompiler]
        public static void ror_int2()
        {
            TestUtils.AreEqual(int2(87245360, -259445220), ror(int2(-1710129111, 1232136068), 11));
            TestUtils.AreEqual(int2(-1697813787, -232831845), ror(int2(1800875222, -98246768), 11));
        }

        [TestCompiler]
        public static void ror_int3()
        {
            TestUtils.AreEqual(int3(87245360, -259445220, -1697813787), ror(int3(-1710129111, 1232136068, 1800875222), 11));
        }

        [TestCompiler]
        public static void ror_int4()
        {
            TestUtils.AreEqual(int4(87245360, -259445220, -1697813787, -232831845), ror(int4(-1710129111, 1232136068, 1800875222, -98246768), 11));
        }


        [TestCompiler]
        public static void ror_uint()
        {
            TestUtils.AreEqual(87245360u, ror(2584838185u, 11));
            TestUtils.AreEqual(4035522076u, ror(1232136068u, 11));
            TestUtils.AreEqual(2597153509u, ror(1800875222u, 11));
            TestUtils.AreEqual(4062135451u, ror(4196720528u, 11));
        }

        [TestCompiler]
        public static void ror_uint2()
        {
            TestUtils.AreEqual(uint2(87245360u, 4035522076u), ror(uint2(2584838185u, 1232136068u), 11));
            TestUtils.AreEqual(uint2(2597153509u, 4062135451u), ror(uint2(1800875222u, 4196720528u), 11));
        }

        [TestCompiler]
        public static void ror_uint3()
        {
            TestUtils.AreEqual(uint3(87245360u, 4035522076u, 2597153509u), ror(uint3(2584838185u, 1232136068u, 1800875222u), 11));
        }

        [TestCompiler]
        public static void ror_uint4()
        {
            TestUtils.AreEqual(uint4(87245360u, 4035522076u, 2597153509u, 4062135451u), ror(uint4(2584838185u, 1232136068u, 1800875222u, 4196720528u), 11));
        }

        [TestCompiler]
        public static void ror_long()
        {
            TestUtils.AreEqual(4958617126915898480L, ror(6894885722123239465L, 37));
            TestUtils.AreEqual(5429856151504760689L, ror(9017875690541231318L, 37));
            TestUtils.AreEqual(6219170745001040316L, ror(-6252342588442027279L, 37));
            TestUtils.AreEqual(8389344736564320290L, ror(2788577329702376155L, 37));
        }

        [TestCompiler]
        public static void ror_ulong()
        {
            TestUtils.AreEqual(4958617126915898480UL, ror(6894885722123239465UL, 37));
            TestUtils.AreEqual(5429856151504760689UL, ror(9017875690541231318UL, 37));
            TestUtils.AreEqual(6219170745001040316UL, ror(12194401485267524337UL, 37));
            TestUtils.AreEqual(8389344736564320290UL, ror(2788577329702376155UL, 37));
        }


    }


    class Assert2
    {
        public static void AreEqual(object a, object b)
        {

        }
    }

}
