﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1850,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSAUDIO_POSITIONEX
    {
        public long TimerFrequency;
        public long TimeStamp1;
        public KSAUDIO_POSITION Position;
        public long TimeStamp2;
    }
}
