﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(189,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DRECT__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public int x1 => InteropRuntime.GetInt32Bits(__bits, 0, 32);
        public int lX1 => InteropRuntime.GetInt32Bits(__bits, 0, 32);
    }
}