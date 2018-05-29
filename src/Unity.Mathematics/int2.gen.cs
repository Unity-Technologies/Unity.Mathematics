// GENERATED CODE
using System.Runtime.CompilerServices;
#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct int2 : System.IEquatable<int2>
    {
        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int x, int y)
        { 
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int2 lhs, int2 rhs) { return new int2 (lhs.x * rhs.x, lhs.y * rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int2 lhs, int rhs) { return new int2 (lhs.x * rhs, lhs.y * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int lhs, int2 rhs) { return new int2 (lhs * rhs.x, lhs * rhs.y); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 lhs, int2 rhs) { return new int2 (lhs.x + rhs.x, lhs.y + rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 lhs, int rhs) { return new int2 (lhs.x + rhs, lhs.y + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int lhs, int2 rhs) { return new int2 (lhs + rhs.x, lhs + rhs.y); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 lhs, int2 rhs) { return new int2 (lhs.x - rhs.x, lhs.y - rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 lhs, int rhs) { return new int2 (lhs.x - rhs, lhs.y - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int lhs, int2 rhs) { return new int2 (lhs - rhs.x, lhs - rhs.y); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int2 lhs, int2 rhs) { return new int2 (lhs.x / rhs.x, lhs.y / rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int2 lhs, int rhs) { return new int2 (lhs.x / rhs, lhs.y / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int lhs, int2 rhs) { return new int2 (lhs / rhs.x, lhs / rhs.y); }

        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int2 lhs, int2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int2 lhs, int rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int lhs, int2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int2 lhs, int2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int2 lhs, int rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int lhs, int2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int2 lhs, int2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int2 lhs, int rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int lhs, int2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int2 lhs, int2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int2 lhs, int rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int lhs, int2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 val) { return new int2 (-val.x, -val.y); }
        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 val) { return new int2 (+val.x, +val.y); }
        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator << (int2 lhs, int rhs) { return new int2 (lhs.x << rhs, lhs.y << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator >> (int2 lhs, int rhs) { return new int2 (lhs.x >> rhs, lhs.y >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int2 lhs, int2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int2 lhs, int rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int lhs, int2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int2 lhs, int2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int2 lhs, int rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int lhs, int2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }

        // Equals 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int2 rhs)  { return x == rhs.x && y == rhs.y; }

        // [int index] 
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int2* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int2 lhs, int2 rhs) { return new int2 (lhs.x & rhs.x, lhs.y & rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int2 lhs, int rhs) { return new int2 (lhs.x & rhs, lhs.y & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int lhs, int2 rhs) { return new int2 (lhs & rhs.x, lhs & rhs.y); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int2 lhs, int2 rhs) { return new int2 (lhs.x | rhs.x, lhs.y | rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int2 lhs, int rhs) { return new int2 (lhs.x | rhs, lhs.y | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int lhs, int2 rhs) { return new int2 (lhs | rhs.x, lhs | rhs.y); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int2 lhs, int2 rhs) { return new int2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int2 lhs, int rhs) { return new int2 (lhs.x ^ rhs, lhs.y ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int lhs, int2 rhs) { return new int2 (lhs ^ rhs.x, lhs ^ rhs.y); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ~ (int2 val) { return new int2 (~val.x, ~val.y); }        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, y); }
        }


    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int x, int y) { return int2(x, y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int2 xy) { return int2(xy); }

    }
}
