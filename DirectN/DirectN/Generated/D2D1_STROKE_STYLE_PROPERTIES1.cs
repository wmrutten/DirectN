﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(518,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_STROKE_STYLE_PROPERTIES1
    {
        public D2D1_CAP_STYLE startCap;
        public D2D1_CAP_STYLE endCap;
        public D2D1_CAP_STYLE dashCap;
        public D2D1_LINE_JOIN lineJoin;
        public float miterLimit;
        public D2D1_DASH_STYLE dashStyle;
        public float dashOffset;
        public D2D1_STROKE_TRANSFORM_TYPE transformType;
    }
}
