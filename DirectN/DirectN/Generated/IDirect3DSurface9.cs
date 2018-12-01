﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9.h(194,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0cfbaf3a-9ff6-429a-99b3-a2796af8b89b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DSurface9 : IDirect3DResource9
    {
        // IDirect3DResource9
        [PreserveSig]
        new HRESULT QueryInterface([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppvObj);
        
        [PreserveSig]
        new uint AddRef();
        
        [PreserveSig]
        new uint Release();
        
        [PreserveSig]
        new HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, ref IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, ref IntPtr pData, ref uint pSizeOfData);
        
        [PreserveSig]
        new HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        new uint SetPriority(uint PriorityNew);
        
        [PreserveSig]
        new uint GetPriority();
        
        [PreserveSig]
        new void PreLoad();
        
        [PreserveSig]
        new _D3DRESOURCETYPE GetType();
        
        // IDirect3DSurface9
        [PreserveSig]
        HRESULT GetDevice(IDirect3DDevice9 ppDevice);
        
        [PreserveSig]
        HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, ref IntPtr pData, uint SizeOfData, uint Flags);
        
        [PreserveSig]
        HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid, ref IntPtr pData, ref uint pSizeOfData);
        
        [PreserveSig]
        HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid refguid);
        
        [PreserveSig]
        uint SetPriority(uint PriorityNew);
        
        [PreserveSig]
        uint GetPriority();
        
        [PreserveSig]
        void PreLoad();
        
        [PreserveSig]
        _D3DRESOURCETYPE GetType();
        
        [PreserveSig]
        HRESULT GetContainer([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] object ppContainer);
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3DSURFACE_DESC pDesc);
        
        [PreserveSig]
        HRESULT LockRect(ref _D3DLOCKED_RECT pLockedRect, ref tagRECT pRect, uint Flags);
        
        [PreserveSig]
        HRESULT UnlockRect();
        
        [PreserveSig]
        HRESULT GetDC(ref IntPtr phdc);
        
        [PreserveSig]
        HRESULT ReleaseDC(IntPtr hdc);
    }
}