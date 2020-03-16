﻿using System.Runtime.InteropServices;
using System.Text;

namespace Rofl.UI.Main
{
    internal static class NativeMethods
    {
        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode)]
        internal static extern long StrFormatByteSizeW(long qdw, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszBuf, int cchBuf);
    }
}
