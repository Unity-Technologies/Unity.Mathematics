using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Mathematics.PerformanceTests
{
    public struct TypedUnsafeList<T> : IDisposable where T : struct
    {
        UnsafeList m_List;

        public TypedUnsafeList(int initialCount, Allocator allocator)
        {
            m_List = new UnsafeList(UnsafeUtility.SizeOf<T>(), UnsafeUtility.AlignOf<T>(), initialCount, allocator, NativeArrayOptions.ClearMemory);
        }

        unsafe public T this[int index]
        {
            get { return UnsafeUtility.ReadArrayElement<T>(m_List.Ptr, index); }
            set { UnsafeUtility.WriteArrayElement(m_List.Ptr, index, value); }
        }

        public void Dispose()
        {
            m_List.Dispose();
        }
    }
}