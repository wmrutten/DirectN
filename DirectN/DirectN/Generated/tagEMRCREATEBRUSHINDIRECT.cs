﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(5986,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRCREATEBRUSHINDIRECT
    {
        public tagEMR emr;
        public uint ihBrush;
        public tagLOGBRUSH32 lb;
    }
}
