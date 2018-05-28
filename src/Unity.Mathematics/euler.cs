using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics.Experimental;

namespace Unity.Mathematics
{
    public static partial class math
    {
        public enum EulerOrder
        {
            XYZ,
            XZY,
            YZX,
            YXZ,
            ZXY,
            ZYX
        };

        private static readonly float4[] kRotationOrderLUT =
        {
            new float4(1.0f, 1.0f, 1.0f, 1.0f), new float4(-1.0f, 1.0f, -1.0f, 1.0f), //XYZ
            new float4(1.0f, 1.0f, 1.0f, 1.0f), new float4(1.0f, 1.0f, -1.0f, -1.0f), //XZY
            new float4(1.0f, -1.0f, 1.0f, 1.0f), new float4(-1.0f, 1.0f, 1.0f, 1.0f), //YZX
            new float4(1.0f, 1.0f, 1.0f, 1.0f), new float4(-1.0f, 1.0f, 1.0f, -1.0f), //YXZ
            new float4(1.0f, -1.0f, 1.0f, 1.0f), new float4(1.0f, 1.0f, -1.0f, 1.0f), //ZXY
            new float4(1.0f, -1.0f, 1.0f, 1.0f), new float4(1.0f, 1.0f, 1.0f, -1.0f) //ZYX 
        };

        public static float3 eulerReorder(float3 euler, EulerOrder order)
        {
            switch (order)
            {
                case EulerOrder.XYZ: 
                    return euler;
                case EulerOrder.XZY:
                    return euler.xzy;
                case EulerOrder.YZX:
                    return euler.yzx;
                case EulerOrder.YXZ:
                    return euler.yxz;
                case EulerOrder.ZXY:
                    return euler.zxy;
                case EulerOrder.ZYX:
                    return euler.zyx;
                default:
                    return euler; 
            }
        }

        public static float3 eulerReorderBack(float3 euler, EulerOrder order)
        {
            switch (order)
            {
                case EulerOrder.XYZ:
                    return euler;
                case EulerOrder.XZY:
                    return euler.xzy;
                case EulerOrder.YZX:
                    return euler.zxy;
                case EulerOrder.YXZ:
                    return euler.yxz;
                case EulerOrder.ZXY:
                    return euler.yzx;
                case EulerOrder.ZYX:
                    return euler.zyx;
                default:
                    return euler;
            }
        }    
        
        private static float3 alternateEuler(float3 euler, EulerOrder order)
        {
            var eulerAlt = eulerReorder(euler, order);
            eulerAlt += new float3(pi);
            eulerAlt = chgsign(eulerAlt, new float3(1, -1, 1));
            return eulerReorderBack(eulerAlt, order);
        }

        private static float3 syncEuler(float3 euler, float3 eulerHint)
        {
            var twopi = new float3(2.0f*pi);
            return euler + round((eulerHint - euler) / twopi) * twopi;
        }

        public static float3 closestEuler(float3 euler, float3 eulerHint, EulerOrder order)
        {
            var eulerSynced = syncEuler(euler, eulerHint);
            var altEulerSynced = syncEuler(alternateEuler(euler, order), eulerHint);

            var diff = eulerSynced - eulerHint;
            var altDiff = altEulerSynced - eulerHint;

            return select(altEulerSynced, eulerSynced, dot(diff, diff) < dot(altDiff, altDiff));
        }
        
        public static quaternion eulerToQuat(float3 euler, EulerOrder order = EulerOrder.XYZ)
        {
            var halfEuler = 0.5f * euler;
            var s = sin(halfEuler);
            var c = cos(halfEuler);

            var t = new float4(s.x * c.z, s.x * s.z, c.x * s.z, c.x * c.z);

            return new quaternion(c.y * t * kRotationOrderLUT[2 * (int) order] +
                                  s.y * kRotationOrderLUT[2 * (int) order + 1] * t.zwxy);
        }
        
        public static float3 quatToEuler(quaternion q, EulerOrder order)
        {
            //prepare the data
            var qv = q.value;
            var d1 = qv * qv.wwww * new float4(2.0f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * new float4(2.0f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = new float3(0.0f);

            const float CUTOFF = (1.0f - 2.0f * epsilon) * (1.0f - 2.0f * epsilon);

            switch (order)
            {
                case EulerOrder.ZYX:
                {
                    var y1 = d2.z + d1.y;
                    if (y1 * y1 < CUTOFF)
                    {
                        var x1 = -d2.x + d1.z;
                        var x2 = d3.x + d3.w - d3.y - d3.z;
                        var z1 = -d2.y + d1.x;
                        var z2 = d3.z + d3.w - d3.y - d3.x;
                        euler = new float3(atan2(x1, x2), asin(y1), atan2(z1, z2));
                    }
                    else //zxz
                    {
                        y1 = clamp(y1, -1.0f, 1.0f);
                        var abcd = new float4(d2.z, d1.y, d2.y, d1.x);
                        var x1 = 2.0f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                        var x2 = csum(abcd * abcd * new float4(-1.0f, 1.0f, -1.0f, 1.0f));
                        euler = new float3(atan2(x1, x2), asin(y1), 0.0f);
                    }
                    break;
                }

                case EulerOrder.ZXY:
                {
                    var y1 = d2.y - d1.x;
                    if (y1 * y1 < CUTOFF)
                    {
                        var x1 = d2.x + d1.z;
                        var x2 = d3.y + d3.w - d3.x - d3.z;
                        var z1 = d2.z + d1.y;
                        var z2 = d3.z + d3.w - d3.x - d3.y;
                        euler = new float3(atan2(x1, x2), -asin(y1), atan2(z1, z2));
                    }
                    else //zxz
                    {
                        y1 = clamp(y1, -1.0f, 1.0f);
                        var abcd = new float4(d2.z, d1.y, d2.y, d1.x);
                        var x1 = 2.0f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                        var x2 = csum(abcd * abcd * new float4(-1.0f, 1.0f, -1.0f, 1.0f));
                        euler = new float3(atan2(x1, x2), -asin(y1), 0.0f);
                    }

                    break;
                }
                case EulerOrder.YXZ:
                {
                    var y1 = d2.y + d1.x;
                    if (y1 * y1 < CUTOFF)
                    {
                        var x1 = -d2.z + d1.y;
                        var x2 = d3.z + d3.w - d3.x - d3.y;
                        var z1 = -d2.x + d1.z;
                        var z2 = d3.y + d3.w - d3.z - d3.x;
                        euler = new float3(atan2(x1, x2), asin(y1), atan2(z1, z2));
                    }
                    else //yzy
                    {
                        y1 = clamp(y1, -1.0f, 1.0f);
                        var abcd = new float4(d2.x, d1.z, d2.y, d1.x);
                        var x1 = 2.0f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                        var x2 = csum(abcd * abcd * new float4(-1.0f, 1.0f, -1.0f, 1.0f));
                        euler = new float3(atan2(x1, x2), asin(y1), 0.0f);
                    }

                    break;
                }
                case EulerOrder.YZX:
                {
                    var y1 = d2.x - d1.z;
                    if (y1 * y1 < CUTOFF)
                    {
                        var x1 = d2.z + d1.y;
                        var x2 = d3.x + d3.w - d3.z - d3.y;
                        var z1 = d2.y + d1.x;
                        var z2 = d3.y + d3.w - d3.x - d3.z;
                        euler = new float3(atan2(x1, x2), -asin(y1), atan2(z1, z2));
                    }
                    else //yxy
                    {
                        y1 = clamp(y1, -1.0f, 1.0f);
                        var abcd = new float4(d2.x, d1.z, d2.y, d1.x);
                        var x1 = 2.0f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                        var x2 = csum(abcd * abcd * new float4(-1.0f, 1.0f, -1.0f, 1.0f));
                        euler = new float3(atan2(x1, x2), -asin(y1), 0.0f);
                    }

                    break;
                }

                case EulerOrder.XZY:
                {
                    var y1 = d2.x + d1.z;
                    if (y1 * y1 < CUTOFF)
                    {
                        var x1 = -d2.y + d1.x;
                        var x2 = d3.y + d3.w - d3.z - d3.x;
                        var z1 = -d2.z + d1.y;
                        var z2 = d3.x + d3.w - d3.y - d3.z;
                        euler = new float3(atan2(x1, x2), asin(y1), atan2(z1, z2));
                    }
                    else //xyx
                    {
                        y1 = clamp(y1, -1.0f, 1.0f);
                        var abcd = new float4(d2.x, d1.z, d2.z, d1.y);
                        var x1 = 2.0f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                        var x2 = csum(abcd * abcd * new float4(-1.0f, 1.0f, -1.0f, 1.0f));
                        euler = new float3(atan2(x1, x2), asin(y1), 0.0f);
                    }

                    break;
                }
                case EulerOrder.XYZ:
                {
                    var y1 = d2.z - d1.y;
                    if (y1 * y1 < CUTOFF)
                    {
                        var x1 = d2.y + d1.x;
                        var x2 = d3.z + d3.w - d3.y - d3.x;
                        var z1 = d2.x + d1.z;
                        var z2 = d3.x + d3.w - d3.y - d3.z;
                        euler = new float3(atan2(x1, x2), -asin(y1), atan2(z1, z2));
                    }
                    else //xzx
                    {
                        y1 = clamp(y1, -1.0f, 1.0f);
                        var abcd = new float4(d2.z, d1.y, d2.x, d1.z);
                        var x1 = 2.0f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                        var x2 = csum(abcd * abcd * new float4(-1.0f, 1.0f, -1.0f, 1.0f));
                        euler = new float3(atan2(x1, x2), -asin(y1), 0.0f);
                    }

                    break;
                }
            }

            return eulerReorderBack(euler, order);
        }
    }
}
