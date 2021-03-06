﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(22198,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("86303d6d-1c4a-4087-ab42-f711167048ef"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdState
    {
        [PreserveSig]
        HRESULT GetDiscID(/* [annotation][out] _Out_ */ out ulong pullUniqueID);
        
        [PreserveSig]
        HRESULT GetParentalLevel(/* [annotation][out] _Out_ */ out uint pulParentalLevel);
    }
}
