﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddkmapi.h(84,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENDIRECTDRAWIN
    {
        public IntPtr dwDirectDrawHandle;
        public IntPtr pfnDirectDrawClose;
        public IntPtr pContext;
    }
}
