using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    partial class math
    {
        // Unity left-handed coordinate system
        // Y up, Z facing and X left
        
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float3 left()
        {
            return new float3(1.0f, 0.0f, 0.0f);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float3 up()
        {
            return new float3(0.0f, 1.0f, 0.0f);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float3 forward()
        {
            return new float3(0.0f, 0.0f, 1.0f);
        }
        
        public static float3 left(quaternion q)
        {
            return mul(q, left());
        }
        
        public static float3 forward(quaternion q)
        {
            return mul(q, forward());
        }
        
        public static float3 up(quaternion q)
        {
            return mul(q, up());
        }        
        
        public const EulerOrder UnityDefaultEulerOrder = EulerOrder.ZXY;
    }
}
     
