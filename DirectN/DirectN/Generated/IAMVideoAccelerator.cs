﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\videoacc.h(230,5)
using System;
using System.Runtime.InteropServices;
using AMVABeginFrameInfo = DirectN._tag_AMVABeginFrameInfo;
using AMVABUFFERINFO = DirectN._tag_AMVABUFFERINFO;
using AMVAEndFrameInfo = DirectN._tag_AMVAEndFrameInfo;
using AMVAUncompDataInfo = DirectN._tag_AMVAUncompDataInfo;
using LPAMVACompBufferInfo = DirectN._tag_AMVACompBufferInfo;
using LPAMVAInternalMemInfo = DirectN._tag_AMVAInternalMemInfo;

namespace DirectN
{
    [Guid("256a6a22-fbad-11d1-82bf-00a0c9696c8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMVideoAccelerator
    {
        [PreserveSig]
        HRESULT GetVideoAcceleratorGUIDs(/* [annotation][out][in] _Inout_ */ ref uint pdwNumGuidsSupported, /* [annotation][out][in] _Out_writes_to_opt_(*pdwNumGuidsSupported, *pdwNumGuidsSupported) */ out Guid pGuidsSupported);
        
        [PreserveSig]
        HRESULT GetUncompFormatsSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [annotation][out][in] _Inout_ */ ref uint pdwNumFormatsSupported, /* [annotation][out][in] _Out_writes_to_opt_(*pdwNumFormatsSupported, *pdwNumFormatsSupported) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _DDPIXELFORMAT[] pFormatsSupported);
        
        [PreserveSig]
        HRESULT GetInternalMemInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [in] */ ref AMVAUncompDataInfo pamvaUncompDataInfo, /* [annotation][out][in] _Inout_ */ ref LPAMVAInternalMemInfo pamvaInternalMemInfo);
        
        [PreserveSig]
        HRESULT GetCompBufferInfo(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pGuid, /* [in] */ ref AMVAUncompDataInfo pamvaUncompDataInfo, /* [annotation][out][in] _Inout_ */ ref uint pdwNumTypesCompBuffers, /* [annotation][out] _Out_writes_to_opt_(*pdwNumTypesCompBuffers, *pdwNumTypesCompBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] LPAMVACompBufferInfo[] pamvaCompBufferInfo);
        
        [PreserveSig]
        HRESULT GetInternalCompBufferInfo(/* [annotation][out][in] _Inout_ */ ref uint pdwNumTypesCompBuffers, /* [annotation][out] _Out_writes_to_opt_(*pdwNumTypesCompBuffers, *pdwNumTypesCompBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] LPAMVACompBufferInfo[] pamvaCompBufferInfo);
        
        [PreserveSig]
        HRESULT BeginFrame(/* [in] */ ref AMVABeginFrameInfo amvaBeginFrameInfo);
        
        [PreserveSig]
        HRESULT EndFrame(/* [in] */ ref AMVAEndFrameInfo pEndFrameInfo);
        
        [PreserveSig]
        HRESULT GetBuffer(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex, /* [in] */ bool bReadOnly, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppBuffer, /* [annotation][out] _Out_ */ out int lpStride);
        
        [PreserveSig]
        HRESULT ReleaseBuffer(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex);
        
        [PreserveSig]
        HRESULT Execute(/* [in] */ uint dwFunction, /* [in] */ IntPtr lpPrivateInputData, /* [in] */ uint cbPrivateInputData, /* [in] */ IntPtr lpPrivateOutputDat, /* [in] */ uint cbPrivateOutputData, /* [in] */ uint dwNumBuffers, /* [annotation][in] _In_reads_(dwNumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] AMVABUFFERINFO[] pamvaBufferInfo);
        
        [PreserveSig]
        HRESULT QueryRenderStatus(/* [in] */ uint dwTypeIndex, /* [in] */ uint dwBufferIndex, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT DisplayFrame(/* [in] */ uint dwFlipToIndex, /* [in] */ ref int pMediaSample);
    }
}
