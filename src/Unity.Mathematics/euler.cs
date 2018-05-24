using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics.Experimental;

namespace Unity.Mathematics
{
    public static partial class math
    {
        private static readonly float4[] kRotationOrderLUT =
        {
            new float4(1.0f, 1.0f, 1.0f, 1.0f), new float4(-1.0f, 1.0f, -1.0f, 1.0f), //XYZ
            new float4(1.0f, 1.0f, 1.0f, 1.0f), new float4(1.0f, 1.0f, -1.0f, -1.0f), //XZY
            new float4(1.0f, -1.0f, 1.0f, 1.0f), new float4(-1.0f, 1.0f, 1.0f, 1.0f), //YZX
            new float4(1.0f, 1.0f, 1.0f, 1.0f), new float4(-1.0f, 1.0f, 1.0f, -1.0f), //YXZ
            new float4(1.0f, -1.0f, 1.0f, 1.0f), new float4(1.0f, 1.0f, -1.0f, 1.0f), //ZXY
            new float4(1.0f, -1.0f, 1.0f, 1.0f), new float4(1.0f, 1.0f, 1.0f, -1.0f) //ZYX
        };

        public enum EulerOrder
        {
            XYZ,
            XZY,
            YZX,
            YXZ,
            ZXY,
            ZYX
        };

        public const EulerOrder UnityDefaultEulerOrder = EulerOrder.ZXY;

        public static quaternion eulerToQuat(float3 euler, EulerOrder order = EulerOrder.XYZ)
        {
            var halfEuler = 0.5f * euler;
            var s = sin(halfEuler);
            var c = cos(halfEuler);

            var t = new float4(s.x * c.z, s.x * s.z, c.x * s.z, c.x * c.z);

            return new quaternion(c.y * t * kRotationOrderLUT[2 * (int) order] +
                                  s.y * kRotationOrderLUT[2 * (int) order + 1] * t.zwxy);
        }
    }
}
