﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(498,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_ARG_PRESENTSURFACE
    {
        public ulong hSurface;
        public uint SubResourceIndex;
    }
}
