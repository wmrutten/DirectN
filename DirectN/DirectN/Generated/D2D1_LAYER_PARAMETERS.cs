﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1.h(718,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D2D1_LAYER_PARAMETERS
    {
        public D2D_RECT_F contentBounds;
        public IntPtr geometricMask;
        public D2D1_ANTIALIAS_MODE maskAntialiasMode;
        public D2D_MATRIX_3X2_F maskTransform;
        public float opacity;
        public IntPtr opacityBrush;
        public D2D1_LAYER_OPTIONS layerOptions;
    }
}
