﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(1303,9)
using System;
using System.Runtime.InteropServices;
using D3DKMT_HANDLE = System.UInt32;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDI_MAKERESIDENT
    {
        public uint hPagingQueue;
        public uint NumAllocations;
        public IntPtr AllocationList;
        public IntPtr PriorityList;
        public D3DDDI_MAKERESIDENT_FLAGS Flags;
        public ulong PagingFenceValue;
        public ulong NumBytesToTrim;
    }
}
