using static Unity.Mathematics.math;

namespace Unity.Mathematics
{

    public class Util
    {
        public static float4x4 PassThrough(float4x4 a)
        {
            return a;
        }

    }
    public class Playground
    {
        /*
        public static void Main(ref float4 res, ref float4 a, ref float4 b)
        {
            res = a + b;
        }
        */

        public static void Main(ref float4x4 res, ref float4x4 x)
        {
            res = inverse(x);
            //res = float4x4.eulerXYZ(angle_x, angle_y, angle_z);
            //sincos(a, out sina, out cosa);
            //sina = sin(a);
            //cosa = cos(a);
        }

    }
}