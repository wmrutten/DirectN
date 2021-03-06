﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dcommon.h(62,1)
using System;

namespace DirectN
{
    [Flags]
    public enum DWRITE_GLYPH_IMAGE_FORMATS
    {
        DWRITE_GLYPH_IMAGE_FORMATS_NONE = 0x00000000,
        DWRITE_GLYPH_IMAGE_FORMATS_TRUETYPE = 0x00000001,
        DWRITE_GLYPH_IMAGE_FORMATS_CFF = 0x00000002,
        DWRITE_GLYPH_IMAGE_FORMATS_COLR = 0x00000004,
        DWRITE_GLYPH_IMAGE_FORMATS_SVG = 0x00000008,
        DWRITE_GLYPH_IMAGE_FORMATS_PNG = 0x00000010,
        DWRITE_GLYPH_IMAGE_FORMATS_JPEG = 0x00000020,
        DWRITE_GLYPH_IMAGE_FORMATS_TIFF = 0x00000040,
        DWRITE_GLYPH_IMAGE_FORMATS_PREMULTIPLIED_B8G8R8A8 = 0x00000080,
    }
}
