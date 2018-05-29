// GENERATED CODE
using System.Runtime.CompilerServices;
#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct int3 : System.IEquatable<int3>
    {
        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int x, int y, int z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int x, int2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int2 xy, int z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator * (int3 lhs, int3 rhs) { return new int3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator * (int3 lhs, int rhs) { return new int3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator * (int lhs, int3 rhs) { return new int3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int3 lhs, int3 rhs) { return new int3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int3 lhs, int rhs) { return new int3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int lhs, int3 rhs) { return new int3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int3 lhs, int3 rhs) { return new int3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int3 lhs, int rhs) { return new int3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int lhs, int3 rhs) { return new int3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator / (int3 lhs, int3 rhs) { return new int3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator / (int3 lhs, int rhs) { return new int3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator / (int lhs, int3 rhs) { return new int3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }

        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (int3 lhs, int3 rhs) { return new bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (int3 lhs, int rhs) { return new bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator < (int lhs, int3 rhs) { return new bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (int3 lhs, int3 rhs) { return new bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (int3 lhs, int rhs) { return new bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <= (int lhs, int3 rhs) { return new bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (int3 lhs, int3 rhs) { return new bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (int3 lhs, int rhs) { return new bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator > (int lhs, int3 rhs) { return new bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (int3 lhs, int3 rhs) { return new bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (int3 lhs, int rhs) { return new bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >= (int lhs, int3 rhs) { return new bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator - (int3 val) { return new int3 (-val.x, -val.y, -val.z); }
        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator + (int3 val) { return new int3 (+val.x, +val.y, +val.z); }
        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator << (int3 lhs, int rhs) { return new int3 (lhs.x << rhs, lhs.y << rhs, lhs.z << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator >> (int3 lhs, int rhs) { return new int3 (lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int3 lhs, int3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int3 lhs, int rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (int lhs, int3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int3 lhs, int3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int3 lhs, int rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (int lhs, int3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }

        // Equals 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(int3 rhs)  { return x == rhs.x && y == rhs.y && z == rhs.z; }

        // [int index] 
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int3* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int3 lhs, int3 rhs) { return new int3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int3 lhs, int rhs) { return new int3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator & (int lhs, int3 rhs) { return new int3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int3 lhs, int3 rhs) { return new int3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int3 lhs, int rhs) { return new int3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator | (int lhs, int3 rhs) { return new int3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int3 lhs, int3 rhs) { return new int3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int3 lhs, int rhs) { return new int3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ^ (int lhs, int3 rhs) { return new int3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 operator ~ (int3 val) { return new int3 (~val.x, ~val.y, ~val.z); }        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
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
        public int4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, z); }
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
        public int4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, z, z); }
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
        public int4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, z); }
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
        public int4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, z, z, z); }
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
        public int4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, z); }
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
        public int4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, z, z); }
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
        public int4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, z); }
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
        public int4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(z, z, z, z); }
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
        public int3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, z); }
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
        public int3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, z, z); }
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
        public int3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
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
        public int3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(z, z, z); }
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
        public int2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
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


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(z, z); }
        }


    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int x, int y, int z) { return int3(x, y, z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int x, int2 yz) { return int3(x, yz); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int2 xy, int z) { return int3(xy, z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 int3(int3 xyz) { return int3(xyz); }

    }
}
