﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(2845,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSNODEPROPERTY_AUDIO_CHANNEL
    {
        public KSNODEPROPERTY NodeProperty;
        public int Channel;
        public uint Reserved;
    }
}