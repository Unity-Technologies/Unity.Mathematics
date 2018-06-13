// GENERATED CODE
using System.Runtime.CompilerServices;
#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct bool3 : System.IEquatable<bool3>
    {
        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3(bool x, bool y, bool z)
        { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3(bool x, bool2 yz)
        { 
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3(bool2 xy, bool z)
        { 
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3(bool3 xyz)
        { 
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (bool3 lhs, bool3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (bool3 lhs, bool rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (bool lhs, bool3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (bool3 lhs, bool3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (bool3 lhs, bool rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (bool lhs, bool3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }

        // Equals 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool3 rhs)  { return x == rhs.x && y == rhs.y && z == rhs.z; }

        // [int index] 
        unsafe public bool this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool3* array = &this) { return ((bool*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool* array = &x) { array[index] = value; }
            }
        }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator & (bool3 lhs, bool3 rhs) { return new bool3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator & (bool3 lhs, bool rhs) { return new bool3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator & (bool lhs, bool3 rhs) { return new bool3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator | (bool3 lhs, bool3 rhs) { return new bool3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator | (bool3 lhs, bool rhs) { return new bool3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator | (bool lhs, bool3 rhs) { return new bool3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ^ (bool3 lhs, bool3 rhs) { return new bool3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ^ (bool3 lhs, bool rhs) { return new bool3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator ^ (bool lhs, bool3 rhs) { return new bool3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public bool2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new bool2(z, z); }
        }


    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 bool3(bool x, bool y, bool z) { return new bool3(x, y, z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 bool3(bool x, bool2 yz) { return new bool3(x, yz); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 bool3(bool2 xy, bool z) { return new bool3(xy, z); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 bool3(bool3 xyz) { return new bool3(xyz); }

    }
}
