﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MemoryTools.BeaSharp
{
    class UnmanagedBuffer
    {
        public readonly IntPtr Ptr = IntPtr.Zero;
        public readonly int Length = 0;

        public UnmanagedBuffer(byte[] data)
        {
            Ptr = Marshal.AllocHGlobal(data.Length);
            Marshal.Copy(data, 0, Ptr, data.Length);
            Length = data.Length;
        }
        ~UnmanagedBuffer()
        {
            if (Ptr != IntPtr.Zero)
                Marshal.FreeHGlobal(Ptr);
        }
    }
}
