using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;

namespace MemoryTools
{
    public class Mem
    {
        #region Fields

        private int _ProcessHwnd;
        private int _ProcessId;

        #endregion Fields

        #region Constructors

        public Mem(int ProcessId)
        {
            _ProcessId = ProcessId;
            _ProcessHwnd = Open(_ProcessId);
        }

        public Mem()
        {
        }

        public void setup(int ProcessId)
        {
            _ProcessId = ProcessId;
            _ProcessHwnd = Open(_ProcessId);
        }

        #endregion Constructors

        #region Properties

        public int ProcessHwnd
        {
            get { return _ProcessHwnd; }
        }

        public int ProcessId
        {
            get { return _ProcessId; }
        }

        #endregion Properties

        #region Methods

        public static Int32 GetModule(Int32 IdProcess, string ModuleName)
        {
            ProcessModuleCollection modules = Process.GetProcessById(IdProcess).Modules;
            for (int i = 0; i < modules.Count; i++)
            {
                if (modules[i].ModuleName.ToLower() == ModuleName.ToLower())
                {
                    return (int)modules[i].BaseAddress;
                }
            }
            return 0;
        }

        public static Process[] ListeProcessIdByName(string Process_Name)
        {
            Process[] processesByNameList = Process.GetProcessesByName(Process_Name);
            return processesByNameList;
        }

        public byte[] ReadBytes(int MemoryAddress, uint NbByte)
        {
            return ReadProcessMemory((IntPtr)MemoryAddress, NbByte);
        }

        public float ReadFloat(int MemoryAddress)
        {
            return BitConverter.ToSingle(ReadProcessMemory((IntPtr)MemoryAddress, 4), 0);
        }

        public int ReadInt(int MemoryAddress)
        {
            return BitConverter.ToInt32(ReadProcessMemory((IntPtr)MemoryAddress, 4), 0);
        }

        public short ReadInt16(int MemoryAddress)
        {
            return BitConverter.ToInt16(ReadProcessMemory((IntPtr)MemoryAddress, 2), 0);
        }

        public int ReadInt32(int MemoryAddress)
        {
            return BitConverter.ToInt32(ReadProcessMemory((IntPtr)MemoryAddress, 4), 0);
        }

        public long ReadInt64(int MemoryAddress)
        {
            return BitConverter.ToInt64(ReadProcessMemory((IntPtr)MemoryAddress, 8), 0);
        }

        public long ReadLong(int MemoryAddress)
        {
            return BitConverter.ToInt64(ReadProcessMemory((IntPtr)MemoryAddress, 8), 0);
        }

        public byte[] ReadProcessMemory(IntPtr MemoryAddress, UInt32 bytesToRead)
        {
            try
            {
                if (bytesToRead > 0 && MemoryAddress != null)
                {
                    byte[] buffer = new byte[bytesToRead];
                    IntPtr ptr;
                    ReadProcessMemory((IntPtr)_ProcessHwnd, MemoryAddress, buffer, bytesToRead, out ptr);
                    return buffer;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.Write("Error :\n" + e.ToString(), "Alerte");
                return null;
            }
        }

        public byte[] ReadRaw(int MemoryAddress, UInt32 Len)
        {
            return ReadProcessMemory((IntPtr)MemoryAddress, Len);
        }

        public string ReadString(int MemoryAddress)
        {
            string str = "";
            byte[] Buf = new Byte[1 - 1];
            Buf = ReadProcessMemory((IntPtr)MemoryAddress, 1);
            while (Buf[0] != 0)
            {
                str = str + Convert.ToChar(Buf[0]);
                MemoryAddress = MemoryAddress + 1;
                Buf = ReadProcessMemory((IntPtr)MemoryAddress, 1);
            }
            return str;
        }

        public string ReadString(int MemoryAddress, UInt32 Len)
        {
            string str = "";
            byte[] buffer = ReadProcessMemory((IntPtr)MemoryAddress, Len);
            str = BitConverter.ToString(buffer, 0);
            return str;
        }

        public UInt32 ReadUInt(int MemoryAddress)
        {
            return BitConverter.ToUInt32(ReadProcessMemory((IntPtr)MemoryAddress, 4), 0);
        }

        public UInt32 ReadUInt32(int MemoryAddress)
        {
            return BitConverter.ToUInt32(ReadProcessMemory((IntPtr)MemoryAddress, 4), 0);
        }

        public UInt64 ReadUInt64(int MemoryAddress)
        {
            return BitConverter.ToUInt64(ReadProcessMemory((IntPtr)MemoryAddress, 8), 0);
        }

        public UInt64 ReadULong(int MemoryAddress)
        {
            return BitConverter.ToUInt64(ReadProcessMemory((IntPtr)MemoryAddress, 8), 0);
        }

        public int WriteDouble(int MemoryAddress, double Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteFloat(int MemoryAddress, float Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteInt(int MemoryAddress, int Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteInt32(int MemoryAddress, int Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteInt64(int MemoryAddress, long Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteLong(int MemoryAddress, long Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteProcessMemory(IntPtr MemoryAddress, byte[] buffer)
        {
            try
            {
                IntPtr ptr;
                UInt32 length = (UInt32)buffer.Length;
                return WriteProcessMemory((IntPtr)_ProcessHwnd, MemoryAddress, buffer, length, out ptr);
            }
            catch (Exception e)
            {
                Console.Write("Error :\n" + e.ToString(), "Alerte");
                return 0;
            }
        }

        public int WriteString(int MemoryAddress, string Data)
        {
            byte[] buffer = new byte[Data.Length];
            int index = 0;

            foreach (char ch in Data)
            {
                buffer[index] = (byte)ch;
                index++;
            }
            return WriteProcessMemory((IntPtr)MemoryAddress, buffer);
        }

        public int WriteUInt(int MemoryAddress, UInt32 Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteUInt32(int MemoryAddress, UInt32 Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteUInt64(int MemoryAddress, UInt64 Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        public int WriteULong(int MemoryAddress, UInt64 Data)
        {
            return WriteProcessMemory((IntPtr)MemoryAddress, BitConverter.GetBytes(Data));
        }

        [DllImport("kernel32")]
        private static extern IntPtr OpenProcess(UInt32 dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern Int32 ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        private static extern Int32 WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In, Out] byte[] buffer, UInt32 size, out IntPtr lpNumberOfBytesWritten);

        private int Open(int ProcessId)
        {
            try
            {
                int ProcessOpen;

                if (ProcessId == 0)
                {
                    throw new Exception("Process not Select.");
                }

                System.Diagnostics.Process.EnterDebugMode();

                ProcessOpen = OpenProcessAllMode(ProcessId);

                return ProcessOpen;
            }
            catch (Exception e)
            {
                Console.Write("Error :\n" + e.ToString(), "Alerte");
                return 0;
            }
        }

        private int OpenProcessAllMode(int IdProcess)
        {
            try
            {
                return (int)OpenProcess(0x1F0FFF, false, IdProcess);
            }
            catch (Exception e)
            {
                Console.Write("Error :\n" + e.ToString(), "Alerte");
                return 0;
            }
        }

        #endregion Methods
    }
}
