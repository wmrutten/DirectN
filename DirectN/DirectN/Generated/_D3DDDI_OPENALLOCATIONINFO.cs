﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(352,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_OPENALLOCATIONINFO
    {
        public uint hAllocation;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}