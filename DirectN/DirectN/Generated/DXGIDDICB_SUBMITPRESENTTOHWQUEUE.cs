﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(926,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGIDDICB_SUBMITPRESENTTOHWQUEUE
    {
        public IntPtr pDXGIContext;
        public IntPtr BroadcastSrcAllocations;
        public IntPtr BroadcastDstAllocations;
        public IntPtr hHwQueues;
        public uint BroadcastHwQueueCount;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
    }
}
