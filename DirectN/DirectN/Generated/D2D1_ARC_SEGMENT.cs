﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(628,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_ARC_SEGMENT
    {
        public D2D_POINT_2F point;
        public D2D_SIZE_F size;
        public float rotationAngle;
        public D2D1_SWEEP_DIRECTION sweepDirection;
        public D2D1_ARC_SIZE arcSize;
    }
}
