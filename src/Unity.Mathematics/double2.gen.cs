// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(double2.DebuggerProxy))]
    [System.Serializable]
    public partial struct double2 : System.IEquatable<double2>, IFormattable
    {
        public double x;
        public double y;

        public static readonly double2 zero = new double2(0.0,   0.0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double x, double y)
        { 
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(double v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(bool v)
        {
            this.x = v ? 1.0 : 0.0;
            this.y = v ? 1.0 : 0.0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(bool2 v)
        {
            this.x = v.x ? 1.0 : 0.0;
            this.y = v.y ? 1.0 : 0.0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(int v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(uint v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(float v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2(float2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(double v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2(bool v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2(bool2 v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(int v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(int2 v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(uint v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(uint2 v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float v) { return new double2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2(float2 v) { return new double2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator * (double2 lhs, double2 rhs) { return new double2 (lhs.x * rhs.x, lhs.y * rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator * (double2 lhs, double rhs) { return new double2 (lhs.x * rhs, lhs.y * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator * (double lhs, double2 rhs) { return new double2 (lhs * rhs.x, lhs * rhs.y); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double2 lhs, double2 rhs) { return new double2 (lhs.x + rhs.x, lhs.y + rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double2 lhs, double rhs) { return new double2 (lhs.x + rhs, lhs.y + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double lhs, double2 rhs) { return new double2 (lhs + rhs.x, lhs + rhs.y); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double2 lhs, double2 rhs) { return new double2 (lhs.x - rhs.x, lhs.y - rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double2 lhs, double rhs) { return new double2 (lhs.x - rhs, lhs.y - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double lhs, double2 rhs) { return new double2 (lhs - rhs.x, lhs - rhs.y); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator / (double2 lhs, double2 rhs) { return new double2 (lhs.x / rhs.x, lhs.y / rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator / (double2 lhs, double rhs) { return new double2 (lhs.x / rhs, lhs.y / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator / (double lhs, double2 rhs) { return new double2 (lhs / rhs.x, lhs / rhs.y); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator % (double2 lhs, double2 rhs) { return new double2 (lhs.x % rhs.x, lhs.y % rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator % (double2 lhs, double rhs) { return new double2 (lhs.x % rhs, lhs.y % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator % (double lhs, double2 rhs) { return new double2 (lhs % rhs.x, lhs % rhs.y); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator ++ (double2 val) { return new double2 (++val.x, ++val.y); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator -- (double2 val) { return new double2 (--val.x, --val.y); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (double2 lhs, double2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (double2 lhs, double rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (double lhs, double2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (double2 lhs, double2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (double2 lhs, double rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (double lhs, double2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (double2 lhs, double2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (double2 lhs, double rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (double lhs, double2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (double2 lhs, double2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (double2 lhs, double rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (double lhs, double2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator - (double2 val) { return new double2 (-val.x, -val.y); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 operator + (double2 val) { return new double2 (+val.x, +val.y); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (double2 lhs, double2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (double2 lhs, double rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (double lhs, double2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (double2 lhs, double2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (double2 lhs, double rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (double lhs, double2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public double2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new double2(y, y); }
        }



        // [int index] 
        unsafe public double this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double2* array = &this) { return ((double*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double* array = &x) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double2 rhs) { return x == rhs.x && y == rhs.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double2({0}, {1})", x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public double x;
            public double y;
            public DebuggerProxy(double2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(double x, double y) { return new double2(x, y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(double2 xy) { return new double2(xy); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(double v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(bool v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(bool2 v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(int v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(int2 v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(uint v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(uint2 v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(float v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 double2(float2 v) { return new double2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double2 v)
        {
            return csum(fold_to_uint(v) * uint2(0xE191B035u, 0x68586FAFu)) + 0xD4DFF6D3u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(double2 v)
        {
            return (fold_to_uint(v) * uint2(0xCB634F4Du, 0x9B13B92Du)) + 0x4ABF0813u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static double select_shuffle_component(double2 a, double2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double shuffle(double2 a, double2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 shuffle(double2 a, double2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return double2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 shuffle(double2 a, double2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return double3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 shuffle(double2 a, double2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return double4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

    }
}
