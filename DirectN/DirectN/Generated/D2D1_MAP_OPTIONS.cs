﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(209,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D2D1_MAP_OPTIONS
    {
        D2D1_MAP_OPTIONS_NONE = 0x00000000,
        D2D1_MAP_OPTIONS_READ = 0x00000001,
        D2D1_MAP_OPTIONS_WRITE = 0x00000002,
        D2D1_MAP_OPTIONS_DISCARD = 0x00000004,
        D2D1_MAP_OPTIONS_FORCE_DWORD = unchecked((int)0xFFFFFFFF),
    }
}
