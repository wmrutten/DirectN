﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(781,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOVERLAYFX__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public uint dwAlphaSrcConst => InteropRuntime.GetUInt32Bits(__bits, 0, 32);
        public IntPtr lpDDSAlphaSrc => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}