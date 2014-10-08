namespace MemoryTools
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpMemoryWatcher = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEncoded = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisAsm = new System.Windows.Forms.Button();
            this.btnPasteOffset = new System.Windows.Forms.Button();
            this.btnPasteAdres = new System.Windows.Forms.Button();
            this.tbOffsetToWatch = new System.Windows.Forms.TextBox();
            this.rbOffset = new System.Windows.Forms.RadioButton();
            this.rbAdr = new System.Windows.Forms.RadioButton();
            this.nudAutoRefreshTime = new System.Windows.Forms.NumericUpDown();
            this.chbAutoRefresh = new System.Windows.Forms.CheckBox();
            this.tbAddressToWatch = new System.Windows.Forms.TextBox();
            this.btnShowData = new System.Windows.Forms.Button();
            this.tbWatchFloat = new System.Windows.Forms.TextBox();
            this.lWatchFloat = new System.Windows.Forms.Label();
            this.tbWatchInt = new System.Windows.Forms.TextBox();
            this.lWatchInt = new System.Windows.Forms.Label();
            this.tbWatchASCIIstring = new System.Windows.Forms.TextBox();
            this.lWatchUnicodeString = new System.Windows.Forms.Label();
            this.tbWatchUnicodeString = new System.Windows.Forms.TextBox();
            this.lWatchASCIIstring = new System.Windows.Forms.Label();
            this.tbWatchUShort = new System.Windows.Forms.TextBox();
            this.lWatchUShort = new System.Windows.Forms.Label();
            this.tbWatchUInt64 = new System.Windows.Forms.TextBox();
            this.lWatchUInt64 = new System.Windows.Forms.Label();
            this.tbWatchUInt = new System.Windows.Forms.TextBox();
            this.lWatchUInt = new System.Windows.Forms.Label();
            this.tbWatchShort = new System.Windows.Forms.TextBox();
            this.lWatchShort = new System.Windows.Forms.Label();
            this.tbWatchSByte = new System.Windows.Forms.TextBox();
            this.lWatchSByte = new System.Windows.Forms.Label();
            this.tbWatchInt64 = new System.Windows.Forms.TextBox();
            this.lWatchInt64 = new System.Windows.Forms.Label();
            this.tbWatchDouble = new System.Windows.Forms.TextBox();
            this.lWatchDouble = new System.Windows.Forms.Label();
            this.tbWatchByte = new System.Windows.Forms.TextBox();
            this.lWatchByte = new System.Windows.Forms.Label();
            this.tpOffsetFinder = new System.Windows.Forms.TabPage();
            this.dgOffsets = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPointer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CDislocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsOffsetFinderButtons = new System.Windows.Forms.ToolStrip();
            this.tsbNewOffsetsFile = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenOffsetsFile = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveOffsetsFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearchOffsets = new System.Windows.Forms.ToolStripButton();
            this.rtbHexDump = new System.Windows.Forms.RichTextBox();
            this.cbProcesses = new System.Windows.Forms.ComboBox();
            this.lProcesses = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.tWatchRefresh = new System.Windows.Forms.Timer(this.components);
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.lBaseAdr = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdOpenOffsetFile = new System.Windows.Forms.OpenFileDialog();
            this.svdSaveOffsetFile = new System.Windows.Forms.SaveFileDialog();
            this.btnAttachWoW = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpMemoryWatcher.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoRefreshTime)).BeginInit();
            this.tpOffsetFinder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOffsets)).BeginInit();
            this.tsOffsetFinderButtons.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpMemoryWatcher);
            this.tcMain.Controls.Add(this.tpOffsetFinder);
            this.tcMain.Location = new System.Drawing.Point(0, 33);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(526, 283);
            this.tcMain.TabIndex = 0;
            // 
            // tpMemoryWatcher
            // 
            this.tpMemoryWatcher.Controls.Add(this.label1);
            this.tpMemoryWatcher.Controls.Add(this.tbEncoded);
            this.tpMemoryWatcher.Controls.Add(this.panel1);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchFloat);
            this.tpMemoryWatcher.Controls.Add(this.lWatchFloat);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchInt);
            this.tpMemoryWatcher.Controls.Add(this.lWatchInt);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchASCIIstring);
            this.tpMemoryWatcher.Controls.Add(this.lWatchUnicodeString);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchUnicodeString);
            this.tpMemoryWatcher.Controls.Add(this.lWatchASCIIstring);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchUShort);
            this.tpMemoryWatcher.Controls.Add(this.lWatchUShort);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchUInt64);
            this.tpMemoryWatcher.Controls.Add(this.lWatchUInt64);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchUInt);
            this.tpMemoryWatcher.Controls.Add(this.lWatchUInt);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchShort);
            this.tpMemoryWatcher.Controls.Add(this.lWatchShort);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchSByte);
            this.tpMemoryWatcher.Controls.Add(this.lWatchSByte);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchInt64);
            this.tpMemoryWatcher.Controls.Add(this.lWatchInt64);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchDouble);
            this.tpMemoryWatcher.Controls.Add(this.lWatchDouble);
            this.tpMemoryWatcher.Controls.Add(this.tbWatchByte);
            this.tpMemoryWatcher.Controls.Add(this.lWatchByte);
            this.tpMemoryWatcher.Location = new System.Drawing.Point(4, 22);
            this.tpMemoryWatcher.Name = "tpMemoryWatcher";
            this.tpMemoryWatcher.Padding = new System.Windows.Forms.Padding(3);
            this.tpMemoryWatcher.Size = new System.Drawing.Size(518, 257);
            this.tpMemoryWatcher.TabIndex = 0;
            this.tpMemoryWatcher.Text = "Memory Watcher";
            this.tpMemoryWatcher.UseVisualStyleBackColor = true;
            this.tpMemoryWatcher.Click += new System.EventHandler(this.tpMemoryWatcher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Encoded";
            // 
            // tbEncoded
            // 
            this.tbEncoded.Location = new System.Drawing.Point(58, 222);
            this.tbEncoded.Name = "tbEncoded";
            this.tbEncoded.ReadOnly = true;
            this.tbEncoded.Size = new System.Drawing.Size(288, 20);
            this.tbEncoded.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDisAsm);
            this.panel1.Controls.Add(this.btnPasteOffset);
            this.panel1.Controls.Add(this.btnPasteAdres);
            this.panel1.Controls.Add(this.tbOffsetToWatch);
            this.panel1.Controls.Add(this.rbOffset);
            this.panel1.Controls.Add(this.rbAdr);
            this.panel1.Controls.Add(this.nudAutoRefreshTime);
            this.panel1.Controls.Add(this.chbAutoRefresh);
            this.panel1.Controls.Add(this.tbAddressToWatch);
            this.panel1.Controls.Add(this.btnShowData);
            this.panel1.Location = new System.Drawing.Point(352, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 232);
            this.panel1.TabIndex = 28;
            // 
            // btnDisAsm
            // 
            this.btnDisAsm.Enabled = false;
            this.btnDisAsm.Location = new System.Drawing.Point(7, 206);
            this.btnDisAsm.Name = "btnDisAsm";
            this.btnDisAsm.Size = new System.Drawing.Size(72, 23);
            this.btnDisAsm.TabIndex = 11;
            this.btnDisAsm.Text = "DisAsm";
            this.btnDisAsm.UseVisualStyleBackColor = true;
            this.btnDisAsm.Click += new System.EventHandler(this.btnDisAsm_Click);
            // 
            // btnPasteOffset
            // 
            this.btnPasteOffset.Image = global::MemoryTools.Properties.Resources.ArrowLeft;
            this.btnPasteOffset.Location = new System.Drawing.Point(129, 38);
            this.btnPasteOffset.Name = "btnPasteOffset";
            this.btnPasteOffset.Size = new System.Drawing.Size(28, 21);
            this.btnPasteOffset.TabIndex = 10;
            this.btnPasteOffset.UseVisualStyleBackColor = true;
            this.btnPasteOffset.Click += new System.EventHandler(this.btnPasteOffset_Click);
            // 
            // btnPasteAdres
            // 
            this.btnPasteAdres.Image = global::MemoryTools.Properties.Resources.ArrowLeft;
            this.btnPasteAdres.Location = new System.Drawing.Point(129, 11);
            this.btnPasteAdres.Name = "btnPasteAdres";
            this.btnPasteAdres.Size = new System.Drawing.Size(28, 21);
            this.btnPasteAdres.TabIndex = 9;
            this.btnPasteAdres.UseVisualStyleBackColor = true;
            this.btnPasteAdres.Click += new System.EventHandler(this.btnPasteAdres_Click);
            // 
            // tbOffsetToWatch
            // 
            this.tbOffsetToWatch.Location = new System.Drawing.Point(55, 37);
            this.tbOffsetToWatch.Name = "tbOffsetToWatch";
            this.tbOffsetToWatch.Size = new System.Drawing.Size(70, 20);
            this.tbOffsetToWatch.TabIndex = 8;
            this.tbOffsetToWatch.TextChanged += new System.EventHandler(this.tbOffsetToWatch_TextChanged);
            this.tbOffsetToWatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOffsetToWatch_KeyPress);
            // 
            // rbOffset
            // 
            this.rbOffset.AutoSize = true;
            this.rbOffset.Location = new System.Drawing.Point(6, 40);
            this.rbOffset.Name = "rbOffset";
            this.rbOffset.Size = new System.Drawing.Size(53, 17);
            this.rbOffset.TabIndex = 7;
            this.rbOffset.TabStop = true;
            this.rbOffset.Text = "Offset";
            this.rbOffset.UseVisualStyleBackColor = true;
            // 
            // rbAdr
            // 
            this.rbAdr.AutoSize = true;
            this.rbAdr.Checked = true;
            this.rbAdr.Location = new System.Drawing.Point(6, 14);
            this.rbAdr.Name = "rbAdr";
            this.rbAdr.Size = new System.Drawing.Size(41, 17);
            this.rbAdr.TabIndex = 6;
            this.rbAdr.TabStop = true;
            this.rbAdr.Text = "Adr";
            this.rbAdr.UseVisualStyleBackColor = true;
            // 
            // nudAutoRefreshTime
            // 
            this.nudAutoRefreshTime.Enabled = false;
            this.nudAutoRefreshTime.Location = new System.Drawing.Point(108, 182);
            this.nudAutoRefreshTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAutoRefreshTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAutoRefreshTime.Name = "nudAutoRefreshTime";
            this.nudAutoRefreshTime.Size = new System.Drawing.Size(52, 20);
            this.nudAutoRefreshTime.TabIndex = 5;
            this.nudAutoRefreshTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAutoRefreshTime.ValueChanged += new System.EventHandler(this.nudAutoRefreshTime_ValueChanged);
            // 
            // chbAutoRefresh
            // 
            this.chbAutoRefresh.AutoSize = true;
            this.chbAutoRefresh.Enabled = false;
            this.chbAutoRefresh.Location = new System.Drawing.Point(6, 183);
            this.chbAutoRefresh.Name = "chbAutoRefresh";
            this.chbAutoRefresh.Size = new System.Drawing.Size(104, 17);
            this.chbAutoRefresh.TabIndex = 4;
            this.chbAutoRefresh.Text = "AutoRefresh(ms)";
            this.chbAutoRefresh.UseVisualStyleBackColor = true;
            this.chbAutoRefresh.CheckedChanged += new System.EventHandler(this.chbAutoRefresh_CheckedChanged);
            // 
            // tbAddressToWatch
            // 
            this.tbAddressToWatch.Location = new System.Drawing.Point(53, 12);
            this.tbAddressToWatch.Name = "tbAddressToWatch";
            this.tbAddressToWatch.Size = new System.Drawing.Size(70, 20);
            this.tbAddressToWatch.TabIndex = 1;
            this.tbAddressToWatch.TextChanged += new System.EventHandler(this.tbAddressToWatch_TextChanged);
            this.tbAddressToWatch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddressToWatch_KeyPress);
            // 
            // btnShowData
            // 
            this.btnShowData.Enabled = false;
            this.btnShowData.Location = new System.Drawing.Point(85, 206);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(72, 23);
            this.btnShowData.TabIndex = 3;
            this.btnShowData.Text = "Show";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // tbWatchFloat
            // 
            this.tbWatchFloat.Location = new System.Drawing.Point(58, 72);
            this.tbWatchFloat.Name = "tbWatchFloat";
            this.tbWatchFloat.ReadOnly = true;
            this.tbWatchFloat.Size = new System.Drawing.Size(100, 20);
            this.tbWatchFloat.TabIndex = 27;
            // 
            // lWatchFloat
            // 
            this.lWatchFloat.AutoSize = true;
            this.lWatchFloat.Location = new System.Drawing.Point(6, 77);
            this.lWatchFloat.Name = "lWatchFloat";
            this.lWatchFloat.Size = new System.Drawing.Size(30, 13);
            this.lWatchFloat.TabIndex = 26;
            this.lWatchFloat.Text = "Float";
            // 
            // tbWatchInt
            // 
            this.tbWatchInt.Location = new System.Drawing.Point(58, 103);
            this.tbWatchInt.Name = "tbWatchInt";
            this.tbWatchInt.ReadOnly = true;
            this.tbWatchInt.Size = new System.Drawing.Size(100, 20);
            this.tbWatchInt.TabIndex = 25;
            // 
            // lWatchInt
            // 
            this.lWatchInt.AutoSize = true;
            this.lWatchInt.Location = new System.Drawing.Point(6, 107);
            this.lWatchInt.Name = "lWatchInt";
            this.lWatchInt.Size = new System.Drawing.Size(19, 13);
            this.lWatchInt.TabIndex = 24;
            this.lWatchInt.Text = "Int";
            // 
            // tbWatchASCIIstring
            // 
            this.tbWatchASCIIstring.Location = new System.Drawing.Point(58, 165);
            this.tbWatchASCIIstring.Name = "tbWatchASCIIstring";
            this.tbWatchASCIIstring.ReadOnly = true;
            this.tbWatchASCIIstring.Size = new System.Drawing.Size(288, 20);
            this.tbWatchASCIIstring.TabIndex = 23;
            // 
            // lWatchUnicodeString
            // 
            this.lWatchUnicodeString.AutoSize = true;
            this.lWatchUnicodeString.Location = new System.Drawing.Point(6, 199);
            this.lWatchUnicodeString.Name = "lWatchUnicodeString";
            this.lWatchUnicodeString.Size = new System.Drawing.Size(47, 13);
            this.lWatchUnicodeString.TabIndex = 22;
            this.lWatchUnicodeString.Text = "Unicode";
            // 
            // tbWatchUnicodeString
            // 
            this.tbWatchUnicodeString.Location = new System.Drawing.Point(58, 196);
            this.tbWatchUnicodeString.Name = "tbWatchUnicodeString";
            this.tbWatchUnicodeString.ReadOnly = true;
            this.tbWatchUnicodeString.Size = new System.Drawing.Size(288, 20);
            this.tbWatchUnicodeString.TabIndex = 21;
            // 
            // lWatchASCIIstring
            // 
            this.lWatchASCIIstring.AutoSize = true;
            this.lWatchASCIIstring.Location = new System.Drawing.Point(6, 169);
            this.lWatchASCIIstring.Name = "lWatchASCIIstring";
            this.lWatchASCIIstring.Size = new System.Drawing.Size(34, 13);
            this.lWatchASCIIstring.TabIndex = 20;
            this.lWatchASCIIstring.Text = "ASCII";
            // 
            // tbWatchUShort
            // 
            this.tbWatchUShort.Location = new System.Drawing.Point(246, 134);
            this.tbWatchUShort.Name = "tbWatchUShort";
            this.tbWatchUShort.ReadOnly = true;
            this.tbWatchUShort.Size = new System.Drawing.Size(100, 20);
            this.tbWatchUShort.TabIndex = 19;
            // 
            // lWatchUShort
            // 
            this.lWatchUShort.AutoSize = true;
            this.lWatchUShort.Location = new System.Drawing.Point(194, 137);
            this.lWatchUShort.Name = "lWatchUShort";
            this.lWatchUShort.Size = new System.Drawing.Size(40, 13);
            this.lWatchUShort.TabIndex = 18;
            this.lWatchUShort.Text = "UShort";
            // 
            // tbWatchUInt64
            // 
            this.tbWatchUInt64.Location = new System.Drawing.Point(246, 103);
            this.tbWatchUInt64.Name = "tbWatchUInt64";
            this.tbWatchUInt64.ReadOnly = true;
            this.tbWatchUInt64.Size = new System.Drawing.Size(100, 20);
            this.tbWatchUInt64.TabIndex = 17;
            // 
            // lWatchUInt64
            // 
            this.lWatchUInt64.AutoSize = true;
            this.lWatchUInt64.Location = new System.Drawing.Point(194, 107);
            this.lWatchUInt64.Name = "lWatchUInt64";
            this.lWatchUInt64.Size = new System.Drawing.Size(39, 13);
            this.lWatchUInt64.TabIndex = 16;
            this.lWatchUInt64.Text = "UInt64";
            // 
            // tbWatchUInt
            // 
            this.tbWatchUInt.Location = new System.Drawing.Point(246, 72);
            this.tbWatchUInt.Name = "tbWatchUInt";
            this.tbWatchUInt.ReadOnly = true;
            this.tbWatchUInt.Size = new System.Drawing.Size(100, 20);
            this.tbWatchUInt.TabIndex = 15;
            // 
            // lWatchUInt
            // 
            this.lWatchUInt.AutoSize = true;
            this.lWatchUInt.Location = new System.Drawing.Point(194, 77);
            this.lWatchUInt.Name = "lWatchUInt";
            this.lWatchUInt.Size = new System.Drawing.Size(27, 13);
            this.lWatchUInt.TabIndex = 14;
            this.lWatchUInt.Text = "UInt";
            // 
            // tbWatchShort
            // 
            this.tbWatchShort.Location = new System.Drawing.Point(246, 41);
            this.tbWatchShort.Name = "tbWatchShort";
            this.tbWatchShort.ReadOnly = true;
            this.tbWatchShort.Size = new System.Drawing.Size(100, 20);
            this.tbWatchShort.TabIndex = 13;
            // 
            // lWatchShort
            // 
            this.lWatchShort.AutoSize = true;
            this.lWatchShort.Location = new System.Drawing.Point(194, 47);
            this.lWatchShort.Name = "lWatchShort";
            this.lWatchShort.Size = new System.Drawing.Size(32, 13);
            this.lWatchShort.TabIndex = 12;
            this.lWatchShort.Text = "Short";
            // 
            // tbWatchSByte
            // 
            this.tbWatchSByte.Location = new System.Drawing.Point(246, 10);
            this.tbWatchSByte.Name = "tbWatchSByte";
            this.tbWatchSByte.ReadOnly = true;
            this.tbWatchSByte.Size = new System.Drawing.Size(100, 20);
            this.tbWatchSByte.TabIndex = 11;
            // 
            // lWatchSByte
            // 
            this.lWatchSByte.AutoSize = true;
            this.lWatchSByte.Location = new System.Drawing.Point(194, 17);
            this.lWatchSByte.Name = "lWatchSByte";
            this.lWatchSByte.Size = new System.Drawing.Size(35, 13);
            this.lWatchSByte.TabIndex = 10;
            this.lWatchSByte.Text = "SByte";
            // 
            // tbWatchInt64
            // 
            this.tbWatchInt64.Location = new System.Drawing.Point(58, 134);
            this.tbWatchInt64.Name = "tbWatchInt64";
            this.tbWatchInt64.ReadOnly = true;
            this.tbWatchInt64.Size = new System.Drawing.Size(100, 20);
            this.tbWatchInt64.TabIndex = 9;
            // 
            // lWatchInt64
            // 
            this.lWatchInt64.AutoSize = true;
            this.lWatchInt64.Location = new System.Drawing.Point(6, 137);
            this.lWatchInt64.Name = "lWatchInt64";
            this.lWatchInt64.Size = new System.Drawing.Size(31, 13);
            this.lWatchInt64.TabIndex = 8;
            this.lWatchInt64.Text = "Int64";
            // 
            // tbWatchDouble
            // 
            this.tbWatchDouble.Location = new System.Drawing.Point(58, 41);
            this.tbWatchDouble.Name = "tbWatchDouble";
            this.tbWatchDouble.ReadOnly = true;
            this.tbWatchDouble.Size = new System.Drawing.Size(100, 20);
            this.tbWatchDouble.TabIndex = 7;
            // 
            // lWatchDouble
            // 
            this.lWatchDouble.AutoSize = true;
            this.lWatchDouble.Location = new System.Drawing.Point(6, 47);
            this.lWatchDouble.Name = "lWatchDouble";
            this.lWatchDouble.Size = new System.Drawing.Size(41, 13);
            this.lWatchDouble.TabIndex = 6;
            this.lWatchDouble.Text = "Double";
            // 
            // tbWatchByte
            // 
            this.tbWatchByte.Location = new System.Drawing.Point(58, 10);
            this.tbWatchByte.Name = "tbWatchByte";
            this.tbWatchByte.ReadOnly = true;
            this.tbWatchByte.Size = new System.Drawing.Size(100, 20);
            this.tbWatchByte.TabIndex = 5;
            // 
            // lWatchByte
            // 
            this.lWatchByte.AutoSize = true;
            this.lWatchByte.Location = new System.Drawing.Point(6, 17);
            this.lWatchByte.Name = "lWatchByte";
            this.lWatchByte.Size = new System.Drawing.Size(28, 13);
            this.lWatchByte.TabIndex = 4;
            this.lWatchByte.Text = "Byte";
            // 
            // tpOffsetFinder
            // 
            this.tpOffsetFinder.Controls.Add(this.dgOffsets);
            this.tpOffsetFinder.Controls.Add(this.tsOffsetFinderButtons);
            this.tpOffsetFinder.Location = new System.Drawing.Point(4, 22);
            this.tpOffsetFinder.Name = "tpOffsetFinder";
            this.tpOffsetFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tpOffsetFinder.Size = new System.Drawing.Size(518, 257);
            this.tpOffsetFinder.TabIndex = 5;
            this.tpOffsetFinder.Text = "OffsetFinder";
            this.tpOffsetFinder.UseVisualStyleBackColor = true;
            // 
            // dgOffsets
            // 
            this.dgOffsets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOffsets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CPattern,
            this.CMask,
            this.CPointer,
            this.CDislocation});
            this.dgOffsets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOffsets.Location = new System.Drawing.Point(3, 28);
            this.dgOffsets.Name = "dgOffsets";
            this.dgOffsets.Size = new System.Drawing.Size(512, 226);
            this.dgOffsets.TabIndex = 7;
            this.dgOffsets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            // 
            // CPattern
            // 
            this.CPattern.HeaderText = "Pattern";
            this.CPattern.Name = "CPattern";
            this.CPattern.Width = 145;
            // 
            // CMask
            // 
            this.CMask.HeaderText = "Mask";
            this.CMask.Name = "CMask";
            this.CMask.Width = 129;
            // 
            // CPointer
            // 
            this.CPointer.HeaderText = "Pointer";
            this.CPointer.Name = "CPointer";
            this.CPointer.Width = 45;
            // 
            // CDislocation
            // 
            this.CDislocation.HeaderText = "location";
            this.CDislocation.Name = "CDislocation";
            this.CDislocation.Width = 50;
            // 
            // tsOffsetFinderButtons
            // 
            this.tsOffsetFinderButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewOffsetsFile,
            this.tsbOpenOffsetsFile,
            this.tsbSaveOffsetsFile,
            this.toolStripSeparator1,
            this.tsbSearchOffsets});
            this.tsOffsetFinderButtons.Location = new System.Drawing.Point(3, 3);
            this.tsOffsetFinderButtons.Name = "tsOffsetFinderButtons";
            this.tsOffsetFinderButtons.Size = new System.Drawing.Size(512, 25);
            this.tsOffsetFinderButtons.TabIndex = 0;
            this.tsOffsetFinderButtons.Text = "toolStrip1";
            // 
            // tsbNewOffsetsFile
            // 
            this.tsbNewOffsetsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewOffsetsFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewOffsetsFile.Image")));
            this.tsbNewOffsetsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewOffsetsFile.Name = "tsbNewOffsetsFile";
            this.tsbNewOffsetsFile.Size = new System.Drawing.Size(23, 22);
            this.tsbNewOffsetsFile.Text = "New Offsets File";
            this.tsbNewOffsetsFile.Click += new System.EventHandler(this.tsbNewOffsetsFile_Click);
            // 
            // tsbOpenOffsetsFile
            // 
            this.tsbOpenOffsetsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenOffsetsFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpenOffsetsFile.Image")));
            this.tsbOpenOffsetsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenOffsetsFile.Name = "tsbOpenOffsetsFile";
            this.tsbOpenOffsetsFile.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenOffsetsFile.Text = "Open Offsets File";
            this.tsbOpenOffsetsFile.Click += new System.EventHandler(this.tsbOpenOffsetsFile_Click);
            // 
            // tsbSaveOffsetsFile
            // 
            this.tsbSaveOffsetsFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveOffsetsFile.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveOffsetsFile.Image")));
            this.tsbSaveOffsetsFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveOffsetsFile.Name = "tsbSaveOffsetsFile";
            this.tsbSaveOffsetsFile.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveOffsetsFile.Text = "Save Offsets File";
            this.tsbSaveOffsetsFile.Click += new System.EventHandler(this.tsbSaveOffsetsFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearchOffsets
            // 
            this.tsbSearchOffsets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearchOffsets.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearchOffsets.Image")));
            this.tsbSearchOffsets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearchOffsets.Name = "tsbSearchOffsets";
            this.tsbSearchOffsets.Size = new System.Drawing.Size(23, 22);
            this.tsbSearchOffsets.Text = "Search Offsets";
            this.tsbSearchOffsets.Click += new System.EventHandler(this.tsbSearchOffsets_Click);
            // 
            // rtbHexDump
            // 
            this.rtbHexDump.Location = new System.Drawing.Point(0, 318);
            this.rtbHexDump.Name = "rtbHexDump";
            this.rtbHexDump.Size = new System.Drawing.Size(522, 167);
            this.rtbHexDump.TabIndex = 29;
            this.rtbHexDump.Text = "";
            // 
            // cbProcesses
            // 
            this.cbProcesses.FormattingEnabled = true;
            this.cbProcesses.Location = new System.Drawing.Point(52, 6);
            this.cbProcesses.Name = "cbProcesses";
            this.cbProcesses.Size = new System.Drawing.Size(298, 21);
            this.cbProcesses.TabIndex = 2;
            this.cbProcesses.SelectedIndexChanged += new System.EventHandler(this.cbProcesses_SelectedIndexChanged);
            this.cbProcesses.Click += new System.EventHandler(this.cbProcesses_Click);
            // 
            // lProcesses
            // 
            this.lProcesses.AutoSize = true;
            this.lProcesses.Location = new System.Drawing.Point(1, 9);
            this.lProcesses.Name = "lProcesses";
            this.lProcesses.Size = new System.Drawing.Size(45, 13);
            this.lProcesses.TabIndex = 3;
            this.lProcesses.Text = "Process";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(356, 4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 4;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // tWatchRefresh
            // 
            this.tWatchRefresh.Interval = 1000;
            this.tWatchRefresh.Tick += new System.EventHandler(this.tWatchRefresh_Tick);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabelStatus,
            this.lBase,
            this.lBaseAdr});
            this.ssMain.Location = new System.Drawing.Point(0, 488);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(525, 22);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // tssLabelStatus
            // 
            this.tssLabelStatus.Name = "tssLabelStatus";
            this.tssLabelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lBase
            // 
            this.lBase.Name = "lBase";
            this.lBase.Size = new System.Drawing.Size(34, 17);
            this.lBase.Text = "Base:";
            // 
            // lBaseAdr
            // 
            this.lBaseAdr.Name = "lBaseAdr";
            this.lBaseAdr.Size = new System.Drawing.Size(0, 17);
            // 
            // ofdOpenOffsetFile
            // 
            this.ofdOpenOffsetFile.Filter = "xml files|*.xml";
            // 
            // btnAttachWoW
            // 
            this.btnAttachWoW.Location = new System.Drawing.Point(437, 4);
            this.btnAttachWoW.Name = "btnAttachWoW";
            this.btnAttachWoW.Size = new System.Drawing.Size(85, 23);
            this.btnAttachWoW.TabIndex = 30;
            this.btnAttachWoW.Text = "AttachWOW";
            this.btnAttachWoW.UseVisualStyleBackColor = true;
            this.btnAttachWoW.Click += new System.EventHandler(this.btnAttachWoW_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 510);
            this.Controls.Add(this.btnAttachWoW);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.rtbHexDump);
            this.Controls.Add(this.lProcesses);
            this.Controls.Add(this.cbProcesses);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "MemoryTools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tcMain.ResumeLayout(false);
            this.tpMemoryWatcher.ResumeLayout(false);
            this.tpMemoryWatcher.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoRefreshTime)).EndInit();
            this.tpOffsetFinder.ResumeLayout(false);
            this.tpOffsetFinder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOffsets)).EndInit();
            this.tsOffsetFinderButtons.ResumeLayout(false);
            this.tsOffsetFinderButtons.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpMemoryWatcher;
        private System.Windows.Forms.ComboBox cbProcesses;
        private System.Windows.Forms.Label lProcesses;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.TextBox tbAddressToWatch;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.TextBox tbWatchByte;
        private System.Windows.Forms.Label lWatchByte;
        private System.Windows.Forms.TextBox tbWatchDouble;
        private System.Windows.Forms.Label lWatchDouble;
        private System.Windows.Forms.TextBox tbWatchFloat;
        private System.Windows.Forms.Label lWatchFloat;
        private System.Windows.Forms.TextBox tbWatchInt;
        private System.Windows.Forms.Label lWatchInt;
        private System.Windows.Forms.TextBox tbWatchASCIIstring;
        private System.Windows.Forms.Label lWatchUnicodeString;
        private System.Windows.Forms.TextBox tbWatchUnicodeString;
        private System.Windows.Forms.Label lWatchASCIIstring;
        private System.Windows.Forms.TextBox tbWatchUShort;
        private System.Windows.Forms.Label lWatchUShort;
        private System.Windows.Forms.TextBox tbWatchUInt64;
        private System.Windows.Forms.Label lWatchUInt64;
        private System.Windows.Forms.TextBox tbWatchUInt;
        private System.Windows.Forms.Label lWatchUInt;
        private System.Windows.Forms.TextBox tbWatchShort;
        private System.Windows.Forms.Label lWatchShort;
        private System.Windows.Forms.TextBox tbWatchSByte;
        private System.Windows.Forms.Label lWatchSByte;
        private System.Windows.Forms.TextBox tbWatchInt64;
        private System.Windows.Forms.Label lWatchInt64;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbAutoRefresh;
        private System.Windows.Forms.NumericUpDown nudAutoRefreshTime;
        private System.Windows.Forms.Timer tWatchRefresh;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelStatus;
        private System.Windows.Forms.RichTextBox rtbHexDump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEncoded;
        private System.Windows.Forms.TextBox tbOffsetToWatch;
        private System.Windows.Forms.RadioButton rbOffset;
        private System.Windows.Forms.RadioButton rbAdr;
        private System.Windows.Forms.ToolStripStatusLabel lBase;
        private System.Windows.Forms.ToolStripStatusLabel lBaseAdr;
        private System.Windows.Forms.TabPage tpOffsetFinder;
        private System.Windows.Forms.ToolStrip tsOffsetFinderButtons;
        private System.Windows.Forms.ToolStripButton tsbNewOffsetsFile;
        private System.Windows.Forms.ToolStripButton tsbOpenOffsetsFile;
        private System.Windows.Forms.ToolStripButton tsbSaveOffsetsFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSearchOffsets;
        private System.Windows.Forms.DataGridView dgOffsets;
        private System.Windows.Forms.Button btnPasteAdres;
        private System.Windows.Forms.Button btnPasteOffset;
        private System.Windows.Forms.OpenFileDialog ofdOpenOffsetFile;
        private System.Windows.Forms.SaveFileDialog svdSaveOffsetFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPattern;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMask;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CPointer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDislocation;
        private System.Windows.Forms.Button btnDisAsm;
        private System.Windows.Forms.Button btnAttachWoW;
    }
}

