﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(5774,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_CAMERACONTROL_REGION_OF_INTEREST_S
    {
        public tagRECT FocusRect;
        public bool AutoFocusLock;
        public bool AutoExposureLock;
        public bool AutoWhitebalanceLock;
        public __struct_ksmedia_716__union_0 __union_4;
    }
}
