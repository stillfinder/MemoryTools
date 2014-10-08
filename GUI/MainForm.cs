using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MemoryTools.Processes;
using System.Threading;
using Memory;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MemoryTools.OffsetFinder;
using MemoryTools.BeaSharp;
using System.IO;
using Bea;

namespace MemoryTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitAll();
        }

        /// <summary>
        /// Класс, содержащий Утилиты для работы с процессами
        /// </summary>
        private ProcTools procTools;
        // Показывает подключены ли сейчас мы к какому-либо процессу
        private bool IsAttached;
        // PID текущего обрабатываемого процесса
        private int currPID;
        //Threads
        Thread attachingThread;

        string oFileName="";

        string currName;

        public int baseAddressModule = 0;

        private OffsetManager oManager;

        /// <summary>
        /// Инициализация начальных переменных приложения
        /// </summary>
        private void InitAll()
        {
            procTools = new ProcTools();
            IsAttached = false;
            oManager = new OffsetManager();
        }        

        /// <summary>
        /// Обновляем список процессов в ComboBox На главной форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbProcesses_Click(object sender, EventArgs e)
        {
            // Очищаем список процессов 
            cbProcesses.Items.Clear();

            // Добавляем процессы в список
            foreach (prc process in procTools.GetProcesses)
            {
                cbProcesses.Items.Add(process.Name + ", pid - " + process.PID);
            }
        }

        /// <summary>
		/// Присоединяет программу к процессу и контроллирует работу с ним.
		/// </summary>
        private void AttachToProcess()
        {
            procTools.Memory.OpenProcessAndThread(currPID);
            procTools.Mems.setup(currPID);           
            baseAddressModule = Mem.GetModule(currPID, currName+".exe");// нужно будет заменить на имя процесса            
            lBaseAdr.Text = Utils.ConvertToHexString((uint)baseAddressModule);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (IsAttached)
            {
                // Detach
                if (attachingThread != null)
                {
                    attachingThread.Abort();
                    Thread.Sleep(200);
                }

                btnAttach.Text = "Attach";
                btnAttachWoW.Enabled = true;
                IsAttached = false;

                btnShowData.Enabled = false;
                chbAutoRefresh.Enabled = false;
                btnDisAsm.Enabled = false;

                cbProcesses.Enabled = true;
            }
            else
            {
                if (currPID != 0)
                {
                    // Attach
                    attachingThread = new Thread(new ThreadStart(AttachToProcess));
                    attachingThread.Start();

                    btnAttach.Text = "Detach";
                    IsAttached = true;

                    btnShowData.Enabled = true;
                    chbAutoRefresh.Enabled = true;
                    btnDisAsm.Enabled = true;

                    cbProcesses.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Select process before attach, please");
                }
            }
        }

        private void cbProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            currPID = procTools.GetProcessPID(cbProcesses.SelectedIndex);
            currName = procTools.GetProcessName(cbProcesses.SelectedIndex);
        }

        public string Encode(string s)
        {
            byte[] l = Encoding.Default.GetBytes(s);
            return Encoding.UTF8.GetString(l);
        }

        private void RefreshWatchingData(uint adr)
        {
            try
            {
                tbWatchByte.Text = procTools.Memory.ReadByte(adr) + "";
                tbWatchDouble.Text = procTools.Memory.ReadDouble(adr) + "";
                tbWatchFloat.Text = procTools.Memory.ReadFloat(adr) + "";
                tbWatchInt.Text = procTools.Memory.ReadInt(adr) + "";
                tbWatchInt64.Text = procTools.Memory.ReadInt64(adr) + "";
                tbWatchSByte.Text = procTools.Memory.ReadSByte(adr) + "";
                tbWatchShort.Text = procTools.Memory.ReadShort(adr) + "";
                tbWatchUInt.Text = procTools.Memory.ReadUInt(adr) + "";
                tbWatchUInt64.Text = procTools.Memory.ReadUInt64(adr) + "";
                tbWatchUShort.Text = procTools.Memory.ReadUShort(adr) + "";
                tbWatchASCIIstring.Text = procTools.Memory.ReadASCIIString(adr, 60);
                tbWatchUnicodeString.Text = procTools.Memory.ReadUnicodeString(adr, 60);
                tbEncoded.Text = Encode(procTools.Memory.ReadASCIIString(adr, 60));

                tssLabelStatus.Text = "";
            }
            catch (Exception ex)
            {
                tssLabelStatus.Text = "Cannot read memory at " + Utils.ConvertToHexString(adr);
            }
        }

        

        private void btnShowData_Click(object sender, EventArgs e)
        {
            //if ((tbAddressToWatch.Text != "") && (IsAttached))
            if(IsAttached)
            {
                uint address = 0;
                if (rbAdr.Checked)
                {
                    try
                    {
                        address = Convert.ToUInt32(tbAddressToWatch.Text, 16);
                    }
                    catch
                    {
                        return;
                    }
                }
                else
                {
                    try 
                    {
                        address = Convert.ToUInt32(tbOffsetToWatch.Text, 16);
                        address += (uint)baseAddressModule;
                    }
                    catch { return; }
                }

                RefreshWatchingData(address);
                RefreshHexDump(address);
            }
        }

        

        private void RefreshHexDump(uint adr)
        {
            rtbHexDump.Clear();
            try
            {
                rtbHexDump.AppendText(Utils.HexDump(procTools.Memory.ReadBytes(adr, 176)));
            }
            catch
            {
            }
        }

        private void tbAddressToWatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ts = e.KeyChar;
            if ("\bxabcdefABCDEF0123456789".IndexOf(e.KeyChar) == -1)
            {                
                e.Handled = true;                
            }
        }

        private void tpMemoryWatcher_Click(object sender, EventArgs e)
        {

        }

        private void chbAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutoRefresh.Checked)
            {
                nudAutoRefreshTime.Enabled = true;
                tWatchRefresh.Enabled = true;
                btnShowData.Enabled = false;
            }
            else
            {
                nudAutoRefreshTime.Enabled = false;
                tWatchRefresh.Enabled = false;
                btnShowData.Enabled = true;
            }
        }

        private void tWatchRefresh_Tick(object sender, EventArgs e)
        {
            if (((tbAddressToWatch.Text != "")||(tbOffsetToWatch.Text!="")) && (IsAttached))
            {
                uint address = 0;
                if (rbAdr.Checked)
                {
                    try
                    {
                        address = Convert.ToUInt32(tbAddressToWatch.Text, 16);
                    }
                    catch
                    {
                        return;
                    }
                }
                else
                {
                    try
                    {
                        address = Convert.ToUInt32(tbOffsetToWatch.Text, 16);
                        address += (uint)baseAddressModule;
                    }
                    catch { return; }
                }
                RefreshWatchingData(address);
                RefreshHexDump(address);
            }
        }

        private void nudAutoRefreshTime_ValueChanged(object sender, EventArgs e)
        {
            tWatchRefresh.Interval = (int)nudAutoRefreshTime.Value;
        }

        private void tbAddressToWatch_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    tbOffsetToWatch.Text = Utils.ConvertToHexString((uint)(Convert.ToUInt32(tbAddressToWatch.Text, 16) - baseAddressModule));
            //}
            //catch { }
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        

        private void tbOffsetToWatch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ts = e.KeyChar;
            if ("\bxabcdefABCDEF0123456789".IndexOf(e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void tbOffsetToWatch_TextChanged(object sender, EventArgs e)
        {

        }

        [DllImport("kernel32")]
        public extern static int LoadLibrary(string librayName);

        [DllImport("kernel32", CharSet = CharSet.Ansi)]
        public extern static int GetProcAddress(int hwnd, string procedureName);

        private void btnInjectApi_Click(object sender, EventArgs e)
        {
            //load the library user32
            int hwnd = LoadLibrary("Kernel32");
            //get the proc address of messageboxW
            int addr = GetProcAddress(hwnd, "WriteProcessMemory");

            //uint codeCave = mv.AllocateMemory(0x2048);
            //mv.Asm.Clear();
            //mv.Asm.AddLine("push {0}", 0);
            //mv.Asm.AddLine("mov eax, {0}", codeCave + 0x1024);
            //mv.Asm.AddLine("push eax");
            //mv.Asm.AddLine("push eax");
            //mv.Asm.AddLine("call {0}", (uint)MyObjectManager.baseAddressModule + WoWOffsets.Instance.LuaDoString);
            //mv.Asm.AddLine("add esp, 0xC");
            //mv.Asm.AddLine("retn");
            //mv.Asm.InjectAndExecute(codeCave);
            //mv.FreeMemory(codeCave);

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void tsbSearchOffsets_Click(object sender, EventArgs e)
        {
            if ((!IsAttached)||(oManager==null)) return;

            //oManager = OffsetManager.GetOffsetsFromXML(System.IO.Directory.GetCurrentDirectory() + "\\" + "oManager.xml");
            oManager.SearchOffsets(procTools.Memory);
            rtbHexDump.Clear();

            foreach (Offset resOffset in oManager.Offsets)
            {
                foreach (uint adr in resOffset.Adresses)
                {
                    //rtbHexDump.AppendText("Name: " + resOffset.Name + " Offset: " + Utils.ConvertToHexString(adr - (uint)baseAddressModule) + " Adress: " + Utils.ConvertToHexString(adr) + "\r\n");
                    //rtbHexDump.AppendText("Name: " + resOffset.Name + " Adress: " + Utils.ConvertToHexString(adr) + "\r\n");
                    rtbHexDump.AppendText(resOffset.Name + ": " + Utils.ConvertToHexString(adr - (uint)baseAddressModule) + "\r\n");
                }
            }
            return;

            //Offset tempOffset = new Offset("LuaDoString", "55 8B EC 51 83 05 00 00 00 00 01 A1", "xxxxxx????xx", false, 0);
            //oManager.ClearOffsets();
            //oManager.AddOffset(tempOffset);
            //oManager.SearchOffsets(procTools.Memory);
            //rtbHexDump.Clear();
            //foreach (Offset resOffset in oManager.Offsets)
            //{
            //    foreach (uint adr in resOffset.Adresses)
            //    {
            //        rtbHexDump.AppendText("Name: " + resOffset.Name + " Offset: " + Utils.ConvertToHexString(adr - (uint)baseAddressModule) + " Adress: " + Utils.ConvertToHexString(adr) + "\r\n");
            //        //rtbHexDump.AppendText("Name: " + resOffset.Name + " Adress: " + Utils.ConvertToHexString(adr) + "\r\n");
            //    }
            //}
            //oManager.SaveOffsetsToXML(System.IO.Directory.GetCurrentDirectory()+"\\"+"oManager.xml");
        }

        private void btnPasteAdres_Click(object sender, EventArgs e)
        {
            tbAddressToWatch.Text = Clipboard.GetText().Trim();
            try
            {
                tbOffsetToWatch.Text = Utils.ConvertToHexString((uint)(Convert.ToUInt32(tbAddressToWatch.Text, 16) - baseAddressModule));
            }
            catch { }
        }

        private void btnPasteOffset_Click(object sender, EventArgs e)
        {
            tbOffsetToWatch.Text = Clipboard.GetText().Trim();
            try
            {
                tbAddressToWatch.Text = Utils.ConvertToHexString((uint)(Convert.ToUInt32(tbOffsetToWatch.Text, 16) + baseAddressModule));
            }
            catch { }
        }

        private void tsbOpenOffsetsFile_Click(object sender, EventArgs e)
        {
            if ((ofdOpenOffsetFile.ShowDialog() == DialogResult.OK)&&(ofdOpenOffsetFile.FileName!=""))
            {
                oFileName = ofdOpenOffsetFile.FileName;
                oManager = OffsetManager.GetOffsetsFromXML(oFileName);
                if (oManager != null)
                {
                    FillOffsetsToGrid();
                }
            }
        }

        private void tsbSaveOffsetsFile_Click(object sender, EventArgs e)
        {
            if ((svdSaveOffsetFile.ShowDialog() == DialogResult.OK) && (svdSaveOffsetFile.FileName != ""))
            {
                oManager.ClearOffsets();
                foreach (DataGridViewRow row in dgOffsets.Rows)
                {
                    try
                    {
                        string oName;
                        string oPatern;
                        string oMask;
                        bool oPointer;
                        int oDislocation;

                        try { oPointer = (bool)row.Cells[3].Value; }
                        catch { oPointer=false;}

                        try { oDislocation = int.Parse(row.Cells[4].Value.ToString()); }
                        catch { oDislocation = 0; }                        

                        Offset tempOffset = new Offset(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), oPointer, oDislocation);
                        oManager.AddOffset(tempOffset);
                    }
                    catch 
                    { 
                        
                    }
                }
                oManager.SaveOffsetsToXML(svdSaveOffsetFile.FileName);
            }
        }

        private void FillOffsetsToGrid()
        {
            dgOffsets.Rows.Clear();
            foreach (Offset o in oManager.Offsets)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewCell celName = new DataGridViewTextBoxCell();
                DataGridViewCell celPatern = new DataGridViewTextBoxCell();
                DataGridViewCell celMask = new DataGridViewTextBoxCell();
                DataGridViewCell celPointer = new DataGridViewCheckBoxCell();
                DataGridViewCell celDislocation = new DataGridViewTextBoxCell();
                
                celName.Value= o.Name;
                celPatern.Value = o.Pattern;
                celMask.Value = o.Mask;
                celPointer.Value = o.IsPointer;
                celDislocation.Value = o.Dislocation;

                row.Cells.Add(celName);
                row.Cells.Add(celPatern);
                row.Cells.Add(celMask);
                row.Cells.Add(celPointer);
                row.Cells.Add(celDislocation);
                
                dgOffsets.Rows.Add(row);
            }
        }

        private void tsbNewOffsetsFile_Click(object sender, EventArgs e)
        {
            oFileName = "";
            oManager = new OffsetManager();
            dgOffsets.Rows.Clear();
        }

        private void btnDisAsm_Click(object sender, EventArgs e)
        {
            rtbHexDump.Clear();

            //Console.WriteLine("Version: " + BeaEngine.Version);
            //Console.WriteLine("Revision: " + BeaEngine.Revision);

            //UnmanagedBuffer buffer = new UnmanagedBuffer(File.ReadAllBytes("BeaEngine.dll"));

            uint address = Convert.ToUInt32(tbOffsetToWatch.Text, 16);
            uint naddress = address+(uint)baseAddressModule;

            UnmanagedBuffer buffer = new UnmanagedBuffer(procTools.Memory.ReadBytes(naddress, 1120));

            var disasm = new Disasm();
            //disasm.EIP = new IntPtr(buffer.Ptr.ToInt64() + 0x400);
            disasm.EIP = new IntPtr(buffer.Ptr.ToInt64());            

            for (int counter = 0; counter < 100; ++counter)
            {
                int result = BeaEngine.Disasm(disasm);

                if (result == (int)BeaConstants.SpecialInfo.UNKNOWN_OPCODE)
                    break;

                //rtbHexDump.AppendText("0x" + disasm.EIP.ToString("X") + " " + disasm.CompleteInstr+"\r\n");
                rtbHexDump.AppendText("0x" + address.ToString("X") + "\t" + disasm.CompleteInstr + "\r\n");
                disasm.EIP = new IntPtr(disasm.EIP.ToInt64() + result);
                address += (uint)result;
            }
        }

        private void btnAttachWoW_Click(object sender, EventArgs e)
        {
            Process wow = Process.GetProcessesByName("Wow")[0];
            currPID = wow.Id;
            currName = wow.ProcessName;
            if (currPID != 0)
            {
                btnAttachWoW.Enabled = false;
                btnAttach_Click(sender, e);
            }
        }

        
    }
}
