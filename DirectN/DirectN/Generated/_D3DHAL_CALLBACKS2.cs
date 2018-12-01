﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dhal.h(799,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_CALLBACKS2
    {
        public uint dwSize;
        public uint dwFlags;
        public IntPtr SetRenderTarget;
        public IntPtr Clear;
        public IntPtr DrawOnePrimitive;
        public IntPtr DrawOneIndexedPrimitive;
        public IntPtr DrawPrimitives;
    }
}