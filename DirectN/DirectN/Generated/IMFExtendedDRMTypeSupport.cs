﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(5677,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("332ec562-3758-468d-a784-e38f23552128"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFExtendedDRMTypeSupport
    {
        [PreserveSig]
        HRESULT IsTypeSupportedEx(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string type, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.BStr)] string keySystem, /* [annotation] _Out_ */ out MF_MEDIA_ENGINE_CANPLAY pAnswer);
    }
}
