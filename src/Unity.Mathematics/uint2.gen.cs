// GENERATED CODE
using System.Runtime.CompilerServices;
#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct uint2 : System.IEquatable<uint2>
    {
        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint x, uint y)
        { 
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x * rhs.x, lhs.y * rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint2 lhs, uint rhs) { return new uint2 (lhs.x * rhs, lhs.y * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint lhs, uint2 rhs) { return new uint2 (lhs * rhs.x, lhs * rhs.y); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x + rhs.x, lhs.y + rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 lhs, uint rhs) { return new uint2 (lhs.x + rhs, lhs.y + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint lhs, uint2 rhs) { return new uint2 (lhs + rhs.x, lhs + rhs.y); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x - rhs.x, lhs.y - rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 lhs, uint rhs) { return new uint2 (lhs.x - rhs, lhs.y - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint lhs, uint2 rhs) { return new uint2 (lhs - rhs.x, lhs - rhs.y); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x / rhs.x, lhs.y / rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint2 lhs, uint rhs) { return new uint2 (lhs.x / rhs, lhs.y / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint lhs, uint2 rhs) { return new uint2 (lhs / rhs.x, lhs / rhs.y); }

        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint2 lhs, uint rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint lhs, uint2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint2 lhs, uint rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint lhs, uint2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint2 lhs, uint rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint lhs, uint2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint2 lhs, uint rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint lhs, uint2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }

        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator << (uint2 lhs, int rhs) { return new uint2 (lhs.x << rhs, lhs.y << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator >> (uint2 lhs, int rhs) { return new uint2 (lhs.x >> rhs, lhs.y >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint2 lhs, uint rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint lhs, uint2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint2 lhs, uint rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint lhs, uint2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }

        // Equals 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(uint2 rhs)  { return x == rhs.x && y == rhs.y; }

        // [int index] 
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint2* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x & rhs.x, lhs.y & rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint2 lhs, uint rhs) { return new uint2 (lhs.x & rhs, lhs.y & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint lhs, uint2 rhs) { return new uint2 (lhs & rhs.x, lhs & rhs.y); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x | rhs.x, lhs.y | rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint2 lhs, uint rhs) { return new uint2 (lhs.x | rhs, lhs.y | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint lhs, uint2 rhs) { return new uint2 (lhs | rhs.x, lhs | rhs.y); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint2 lhs, uint rhs) { return new uint2 (lhs.x ^ rhs, lhs.y ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint lhs, uint2 rhs) { return new uint2 (lhs ^ rhs.x, lhs ^ rhs.y); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ~ (uint2 val) { return new uint2 (~val.x, ~val.y); }        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(y, y); }
        }


    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint x, uint y) { return uint2(x, y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint2 xy) { return uint2(xy); }

    }
}
