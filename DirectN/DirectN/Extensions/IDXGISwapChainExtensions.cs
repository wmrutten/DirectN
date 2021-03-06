﻿using System;

namespace DirectN
{
    public static class IDXGISwapChainExtensions
    {
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this ComObject<IDXGISwapChain1> obj) => GetDesc1(obj?.Object);
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this IDXGISwapChain1 obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            obj.GetDesc1(out var value);
            return value;
        }

        public static ComObject<T> GetBuffer<T>(this ComObject<IDXGISwapChain> swapChain, uint index) => GetBuffer<T>(swapChain?.Object, index);
        public static ComObject<T> GetBuffer<T>(this ComObject<IDXGISwapChain1> swapChain, uint index) => GetBuffer<T>(swapChain?.Object, index);
        public static ComObject<T> GetBuffer<T>(this IDXGISwapChain swapChain, uint index)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.GetBuffer(index, typeof(T).GUID, out var dc).ThrowOnError();
            return new ComObject<T>((T)dc);
        }
    }
}
