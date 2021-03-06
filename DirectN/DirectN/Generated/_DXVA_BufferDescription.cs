﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva9typ.h(70,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_BufferDescription
    {
        public uint dwTypeIndex;
        public uint dwBufferIndex;
        public uint dwDataOffset;
        public uint dwDataSize;
        public uint dwFirstMBaddress;
        public uint dwNumMBsInBuffer;
        public uint dwWidth;
        public uint dwHeight;
        public uint dwStride;
        public uint dwReservedBits;
    }
}
