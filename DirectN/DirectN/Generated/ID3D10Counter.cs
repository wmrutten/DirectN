﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(4675,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b7e4c11-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Counter : ID3D10Asynchronous
    {
        // ID3D10DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Out_ */ out ID3D10Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_(*pDataSize) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_(DataSize) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D10Asynchronous
        [PreserveSig]
        new void Begin();
        
        [PreserveSig]
        new void End();
        
        [PreserveSig]
        new HRESULT GetData(/* [annotation] _Out_writes_bytes_opt_(DataSize) */ out IntPtr pData, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ uint GetDataFlags);
        
        [PreserveSig]
        new uint GetDataSize();
        
        // ID3D10Counter
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D10_COUNTER_DESC pDesc);
    }
}