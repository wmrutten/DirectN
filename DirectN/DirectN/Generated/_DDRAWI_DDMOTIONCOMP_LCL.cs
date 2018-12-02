﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(1981,9)
using System;
using System.Runtime.InteropServices;
using DDPIXELFORMAT = DirectN._DDPIXELFORMAT;
using LPDDRAWI_DIRECTDRAW_LCL = DirectN._DDRAWI_DIRECTDRAW_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDMOTIONCOMP_LCL
    {
        public IntPtr lpDD;
        public Guid guid;
        public uint dwUncompWidth;
        public uint dwUncompHeight;
        public DDPIXELFORMAT ddUncompPixelFormat;
        public uint dwInternalFlags;
        public uint dwRefCnt;
        public uint dwProcessId;
        public IntPtr hMoComp;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
        public IntPtr lpDriverReserved1;
        public IntPtr lpDriverReserved2;
        public IntPtr lpDriverReserved3;
    }
}