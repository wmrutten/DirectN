﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2612,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_TEXTURE_COPY_LOCATION__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public byte[] __bits;
        public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint => InteropRuntime.GetBits<D3D12_PLACED_SUBRESOURCE_FOOTPRINT>(__bits, 0, 224);
        public uint SubresourceIndex => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
    }
}
