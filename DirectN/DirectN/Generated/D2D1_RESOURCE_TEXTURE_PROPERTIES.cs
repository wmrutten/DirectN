﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(276,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_RESOURCE_TEXTURE_PROPERTIES
    {
        public IntPtr extents;
        public uint dimensions;
        public D2D1_BUFFER_PRECISION bufferPrecision;
        public D2D1_CHANNEL_DEPTH channelDepth;
        public D2D1_FILTER filter;
        public IntPtr extendModes;
    }
}
