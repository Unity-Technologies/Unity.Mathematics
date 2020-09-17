using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
    [Il2CppEagerStaticClassConstruction]
    public static partial class Mathf
    {
        public static volatile float FloatMinNormal = 1.17549435E-38f;
        public static volatile float FloatMinDenormal = Single.Epsilon;

#if PLATFORM_IOS || PLATFORM_TVOS || PLATFORM_XBOXONE || PLATFORM_PS4 || PLATFORM_GAMECORE
        // Note that the tests below don't work on XboxOne/PS4 ( due to optimizations using integer instructions ) and we will always run with FlushToZero enabled so force it
        public static bool IsFlushToZeroEnabled = true;
#elif ENABLE_IL2CPP
#pragma warning disable 0420
        public static bool IsFlushToZeroEnabled = Interlocked.CompareExchange(ref FloatMinDenormal, FloatMinDenormal, 0f) == 0f;
#pragma warning restore 0420
#else
        public static bool IsFlushToZeroEnabled = (FloatMinDenormal == 0);
#endif

        // Returns the sine of angle /f/ in radians.
        public static float Sin(float f) { return math.sin(f); }

        // Returns the cosine of angle /f/ in radians.
        public static float Cos(float f) { return math.cos(f); }

        // Returns the tangent of angle /f/ in radians.
        public static float Tan(float f) { return math.tan(f); }

        // Returns the arc-sine of /f/ - the angle in radians whose sine is /f/.
        public static float Asin(float f) { return math.asin(f); }

        // Returns the arc-cosine of /f/ - the angle in radians whose cosine is /f/.
        public static float Acos(float f) { return math.acos(f); }

        // Returns the arc-tangent of /f/ - the angle in radians whose tangent is /f/.
        public static float Atan(float f) { return math.atan(f); }

        // Returns the angle in radians whose ::ref::Tan is @@y/x@@.
        public static float Atan2(float y, float x) { return math.atan2(y, x); }

        // Returns square root of /f/.
        public static float Sqrt(float f) { return math.sqrt(f); }

        // Returns the absolute value of /f/.
        public static float Abs(float f) { return math.abs(f); }

        // Returns the absolute value of /value/.
        public static int Abs(int value) { return math.abs(value); }

        // Returns smallest of two or more values.
        public static float Min(float a, float b) { return math.min(a, b); }
        public static float Min(float a, float b, float c) { return math.min(math.min(a, b), c); }
        public static float Min(float a, float b, float c, float d) { return math.min(math.min(a, b), math.min(c, d)); }

        // Returns the smallest of two or more values.
        public static int Min(int a, int b) { return math.min(a, b); }
        public static int Min(int a, int b, int c) { return math.min(math.min(a, b), c); }
        public static int Min(int a, int b, int c, int d) { return math.min(math.min(a, b), math.min(c, d)); }

        // Returns largest of two or more values.
        public static float Max(float a, float b) { return math.max(a,b); }
        public static float Max(float a, float b, float c) { return math.max(math.max(a, b), c); }
        public static float Max(float a, float b, float c, float d) { return math.max(math.max(a, b), math.max(c,d)); }

        // Returns the largest of two or more values.
        public static int Max(int a, int b) { return math.max(a,b); }
        public static int Max(int a, int b, int c) { return math.max(math.max(a, b), c); }
        public static int Max(int a, int b, int c, int d) { return math.max(math.max(a, b), math.max(c,d)); }

        // Returns /f/ raised to power /p/.
        public static float Pow(float f, float p) { return math.pow(f, p); }

        // Returns e raised to the specified power.
        public static float Exp(float power) { return math.exp(power); }

        // Returns the logarithm of a specified number in a specified base.
        public static float Log(float f, float p) { return (float)Math.Log(f, p); }

        // Returns the natural (base e) logarithm of a specified number.
        public static float Log(float f) { return math.log(f); }

        // Returns the base 10 logarithm of a specified number.
        public static float Log10(float f) { return math.log10(f); }

        // Returns the smallest integer greater to or equal to /f/.
        public static float Ceil(float f) { return math.ceil(f); }

        // Returns the largest integer smaller to or equal to /f/.
        public static float Floor(float f) { return math.floor(f); }

        // Returns /f/ rounded to the nearest integer.
        public static float Round(float f) { return math.round(f); }

        // Returns the smallest integer greater to or equal to /f/.
        public static int CeilToInt(float f) { return (int)math.ceil(f); }

        // Returns the largest integer smaller to or equal to /f/.
        public static int FloorToInt(float f) { return (int)math.floor(f); }

        // Returns /f/ rounded to the nearest integer.
        public static int RoundToInt(float f) { return (int)math.round(f); }

        // Returns the sign of /f/.
        public static float Sign(float f) { return f >= 0F ? 1F : -1F; }

        // The infamous ''3.14159265358979...'' value (RO).
        public const float PI = (float)Math.PI;

        // A representation of positive infinity (RO).
        public const float Infinity = math.INFINITY;

        // A representation of negative infinity (RO).
        public const float NegativeInfinity = -math.INFINITY;

        // Degrees-to-radians conversion constant (RO).
        public const float Deg2Rad = PI * 2F / 360F;

        // Radians-to-degrees conversion constant (RO).
        public const float Rad2Deg = 1F / Deg2Rad;

        // A tiny floating point value (RO).
        public static readonly float Epsilon =
            IsFlushToZeroEnabled ? FloatMinNormal
            : FloatMinDenormal;

        // Clamps a value between a minimum float and maximum float value.
        public static float Clamp(float value, float min, float max)
        {
            return math.clamp(value, min, max);
        }

        // Clamps value between min and max and returns value.
        // Set the position of the transform to be that of the time
        // but never less than 1 or more than 3
        //
        public static int Clamp(int value, int min, int max)
        {
            return math.clamp(value, min, max);
        }

        // Clamps value between 0 and 1 and returns value
        public static float Clamp01(float value)
        {
            return math.saturate(value);
        }

        // Interpolates between /a/ and /b/ by /t/. /t/ is clamped between 0 and 1.
        public static float Lerp(float a, float b, float t)
        {
            return math.lerp(a, b, math.saturate(t));
        }

        // Interpolates between /a/ and /b/ by /t/ without clamping the interpolant.
        public static float LerpUnclamped(float a, float b, float t)
        {
            return math.lerp(a, b, t);
        }

        // Same as ::ref::Lerp but makes sure the values interpolate correctly when they wrap around 360 degrees.
        public static float LerpAngle(float a, float b, float t)
        {
            float delta = Repeat((b - a), 360);
            if (delta > 180)
                delta -= 360;
            return a + delta * Clamp01(t);
        }

        // Moves a value /current/ towards /target/.
        static public float MoveTowards(float current, float target, float maxDelta)
        {
            if (math.abs(target - current) <= maxDelta)
                return target;
            return current + math.sign(target - current) * maxDelta;
        }

        // Same as ::ref::MoveTowards but makes sure the values interpolate correctly when they wrap around 360 degrees.
        static public float MoveTowardsAngle(float current, float target, float maxDelta)
        {
            float deltaAngle = DeltaAngle(current, target);
            if (-maxDelta < deltaAngle && deltaAngle < maxDelta)
                return target;
            target = current + deltaAngle;
            return MoveTowards(current, target, maxDelta);
        }

        // Interpolates between /min/ and /max/ with smoothing at the limits.
        public static float SmoothStep(float from, float to, float t)
        {
            t = math.saturate(t);
            t = -2.0F * t * t * t + 3.0F * t * t;
            return to * t + from * (1F - t);
        }

        //*undocumented
        public static float Gamma(float value, float absmax, float gamma)
        {
            bool negative = value < 0F;
            float absval = math.abs(value);
            if (absval > absmax)
                return negative ? -absval : absval;

            float result = math.pow(absval / absmax, gamma) * absmax;
            return negative ? -result : result;
        }

        // Compares two floating point values if they are similar.
        public static bool Approximately(float a, float b)
        {
            // If a or b is zero, compare that the other is less or equal to epsilon.
            // If neither a or b are 0, then find an epsilon that is good for
            // comparing numbers at the maximum magnitude of a and b.
            // Floating points have about 7 significant digits, so
            // 1.000001f can be represented while 1.0000001f is rounded to zero,
            // thus we could use an epsilon of 0.000001f for comparing values close to 1.
            // We multiply this epsilon by the biggest magnitude of a and b.
            return math.abs(b - a) < math.max(0.000001f * math.max(math.abs(a), math.abs(b)), Epsilon * 8);
        }

        // Gradually changes a value towards a desired goal over time.
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            // Based on Game Programming Gems 4 Chapter 1.10
            smoothTime = math.max(0.0001F, smoothTime);
            float omega = 2F / smoothTime;

            float x = omega * deltaTime;
            float exp = 1F / (1F + x + 0.48F * x * x + 0.235F * x * x * x);
            float change = current - target;
            float originalTo = target;

            // Clamp maximum speed
            float maxChange = maxSpeed * smoothTime;
            change = math.clamp(change, -maxChange, maxChange);
            target = current - change;

            float temp = (currentVelocity + omega * change) * deltaTime;
            currentVelocity = (currentVelocity - omega * temp) * exp;
            float output = target + (change + temp) * exp;

            // Prevent overshooting
            if (originalTo - current > 0.0F == output > originalTo)
            {
                output = originalTo;
                currentVelocity = (output - originalTo) / deltaTime;
            }

            return output;
        }

        // Gradually changes an angle given in degrees towards a desired goal angle over time.
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
        {
            target = current + DeltaAngle(current, target);
            return SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
        }

        // Loops the value t, so that it is never larger than length and never smaller than 0.
        public static float Repeat(float t, float length)
        {
            return math.clamp(t - math.floor(t / length) * length, 0.0f, length);
        }

        // PingPongs the value t, so that it is never larger than length and never smaller than 0.
        public static float PingPong(float t, float length)
        {
            t = Repeat(t, length * 2F);
            return length - math.abs(t - length);
        }

        // Calculates the ::ref::Lerp parameter between of two values.
        public static float InverseLerp(float a, float b, float value)
        {
            if (a != b)
                return math.saturate((value - a) / (b - a));
            else
                return 0.0f;
        }

        // Calculates the shortest difference between two given angles.
        public static float DeltaAngle(float current, float target)
        {
            float delta = Mathf.Repeat((target - current), 360.0F);
            if (delta > 180.0F)
                delta -= 360.0F;
            return delta;
        }

        // Infinite Line Intersection (line1 is p1-p2 and line2 is p3-p4)
        internal static bool LineIntersection(float2 p1, float2 p2, float2 p3, float2 p4, ref float2 result)
        {
            float bx = p2.x - p1.x;
            float by = p2.y - p1.y;
            float dx = p4.x - p3.x;
            float dy = p4.y - p3.y;
            float bDotDPerp = bx * dy - by * dx;
            if (bDotDPerp == 0)
            {
                return false;
            }
            float cx = p3.x - p1.x;
            float cy = p3.y - p1.y;
            float t = (cx * dy - cy * dx) / bDotDPerp;

            result.x = p1.x + t * bx;
            result.y = p1.y + t * by;
            return true;
        }

        // Line Segment Intersection (line1 is p1-p2 and line2 is p3-p4)
        internal static bool LineSegmentIntersection(float2 p1, float2 p2, float2 p3, float2 p4, ref float2 result)
        {
            float bx = p2.x - p1.x;
            float by = p2.y - p1.y;
            float dx = p4.x - p3.x;
            float dy = p4.y - p3.y;
            float bDotDPerp = bx * dy - by * dx;
            if (bDotDPerp == 0)
            {
                return false;
            }
            float cx = p3.x - p1.x;
            float cy = p3.y - p1.y;
            float t = (cx * dy - cy * dx) / bDotDPerp;
            if (t < 0 || t > 1)
            {
                return false;
            }
            float u = (cx * by - cy * bx) / bDotDPerp;
            if (u < 0 || u > 1)
            {
                return false;
            }

            result.x = p1.x + t * bx;
            result.y = p1.y + t * by;
            return true;
        }

        static internal long RandomToLong(ref Random r)
        {
            var temp = r.NextUInt2();
            long result = temp.y;
            result <<= 32;
            result |= temp.x;
            return result & Int64.MaxValue;
        }
    }
}
