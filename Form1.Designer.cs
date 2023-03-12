namespace FirstWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.buttonOpenFIle = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.textBoxRegister = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAlarmL = new System.Windows.Forms.Label();
            this.labelAlarmH = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.textBoxAlarmL = new System.Windows.Forms.TextBox();
            this.textBoxAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonRegisterNew = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelMeasureType = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.listBoxOptions = new System.Windows.Forms.ListBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.dateTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxReg = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxSerialNum = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSensorName = new System.Windows.Forms.TextBox();
            this.labelRegDate = new System.Windows.Forms.Label();
            this.labelRegistered = new System.Windows.Forms.Label();
            this.labelSerialNum = new System.Windows.Forms.Label();
            this.labelSignalType = new System.Windows.Forms.Label();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.labelSensorName = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonWriteConf = new System.Windows.Forms.Button();
            this.buttonReadScaled = new System.Windows.Forms.Button();
            this.buttonReadStatus = new System.Windows.Forms.Button();
            this.buttonReadConf = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelComPort = new System.Windows.Forms.Label();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.checkBoxStayConnected = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxInputIPAddress = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonTimerStop = new System.Windows.Forms.Button();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerGraph = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1092, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItemClose,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItemClose
            // 
            this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
            this.toolStripMenuItemClose.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItemClose.Text = "C&lose";
            this.toolStripMenuItemClose.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuItem1.Text = "Help";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 502);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSummary);
            this.tabPage1.Controls.Add(this.textBoxSummary);
            this.tabPage1.Controls.Add(this.buttonOpenFIle);
            this.tabPage1.Controls.Add(this.buttonSaveFile);
            this.tabPage1.Controls.Add(this.textBoxRegister);
            this.tabPage1.Controls.Add(this.buttonClear);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.buttonSaveChanges);
            this.tabPage1.Controls.Add(this.buttonRegisterNew);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.labelMeasureType);
            this.tabPage1.Controls.Add(this.textBoxComment);
            this.tabPage1.Controls.Add(this.labelComment);
            this.tabPage1.Controls.Add(this.listBoxOptions);
            this.tabPage1.Controls.Add(this.labelOptions);
            this.tabPage1.Controls.Add(this.dateTimePickerRegDate);
            this.tabPage1.Controls.Add(this.checkBoxReg);
            this.tabPage1.Controls.Add(this.maskedTextBoxSerialNum);
            this.tabPage1.Controls.Add(this.textBoxSensorName);
            this.tabPage1.Controls.Add(this.labelRegDate);
            this.tabPage1.Controls.Add(this.labelRegistered);
            this.tabPage1.Controls.Add(this.labelSerialNum);
            this.tabPage1.Controls.Add(this.labelSignalType);
            this.tabPage1.Controls.Add(this.comboBoxSignalType);
            this.tabPage1.Controls.Add(this.labelSensorName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sensor Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSummary
            // 
            this.buttonSummary.BackColor = System.Drawing.Color.LightGray;
            this.buttonSummary.Location = new System.Drawing.Point(843, 407);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(208, 50);
            this.buttonSummary.TabIndex = 23;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = false;
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(843, 20);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(208, 372);
            this.textBoxSummary.TabIndex = 22;
            // 
            // buttonOpenFIle
            // 
            this.buttonOpenFIle.BackColor = System.Drawing.Color.LightGray;
            this.buttonOpenFIle.Location = new System.Drawing.Point(618, 407);
            this.buttonOpenFIle.Name = "buttonOpenFIle";
            this.buttonOpenFIle.Size = new System.Drawing.Size(208, 50);
            this.buttonOpenFIle.TabIndex = 21;
            this.buttonOpenFIle.Text = " Open File";
            this.buttonOpenFIle.UseVisualStyleBackColor = false;
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.LightGray;
            this.buttonSaveFile.Location = new System.Drawing.Point(618, 342);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(208, 50);
            this.buttonSaveFile.TabIndex = 20;
            this.buttonSaveFile.Text = "Save to File";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            // 
            // textBoxRegister
            // 
            this.textBoxRegister.Location = new System.Drawing.Point(618, 19);
            this.textBoxRegister.Multiline = true;
            this.textBoxRegister.Name = "textBoxRegister";
            this.textBoxRegister.Size = new System.Drawing.Size(208, 314);
            this.textBoxRegister.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightGray;
            this.buttonClear.Location = new System.Drawing.Point(429, 407);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(127, 50);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelAlarmL);
            this.panel1.Controls.Add(this.labelAlarmH);
            this.panel1.Controls.Add(this.labelUnit);
            this.panel1.Controls.Add(this.labelURV);
            this.panel1.Controls.Add(this.labelLRV);
            this.panel1.Controls.Add(this.textBoxAlarmL);
            this.panel1.Controls.Add(this.textBoxAlarmH);
            this.panel1.Controls.Add(this.textBoxUnit);
            this.panel1.Controls.Add(this.textBoxURV);
            this.panel1.Controls.Add(this.textBoxLRV);
            this.panel1.Location = new System.Drawing.Point(382, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 372);
            this.panel1.TabIndex = 17;
            // 
            // labelAlarmL
            // 
            this.labelAlarmL.AutoSize = true;
            this.labelAlarmL.Location = new System.Drawing.Point(10, 213);
            this.labelAlarmL.Name = "labelAlarmL";
            this.labelAlarmL.Size = new System.Drawing.Size(60, 20);
            this.labelAlarmL.TabIndex = 9;
            this.labelAlarmL.Text = "Alarm L";
            // 
            // labelAlarmH
            // 
            this.labelAlarmH.AutoSize = true;
            this.labelAlarmH.Location = new System.Drawing.Point(10, 168);
            this.labelAlarmH.Name = "labelAlarmH";
            this.labelAlarmH.Size = new System.Drawing.Size(64, 20);
            this.labelAlarmH.TabIndex = 8;
            this.labelAlarmH.Text = "Alarm H";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(14, 123);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(36, 20);
            this.labelUnit.TabIndex = 7;
            this.labelUnit.Text = "Unit";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Location = new System.Drawing.Point(14, 78);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(37, 20);
            this.labelURV.TabIndex = 6;
            this.labelURV.Text = "URV";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Location = new System.Drawing.Point(14, 34);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(34, 20);
            this.labelLRV.TabIndex = 5;
            this.labelLRV.Text = "LRV";
            // 
            // textBoxAlarmL
            // 
            this.textBoxAlarmL.Location = new System.Drawing.Point(84, 210);
            this.textBoxAlarmL.Name = "textBoxAlarmL";
            this.textBoxAlarmL.Size = new System.Drawing.Size(125, 27);
            this.textBoxAlarmL.TabIndex = 4;
            // 
            // textBoxAlarmH
            // 
            this.textBoxAlarmH.Location = new System.Drawing.Point(84, 165);
            this.textBoxAlarmH.Name = "textBoxAlarmH";
            this.textBoxAlarmH.Size = new System.Drawing.Size(125, 27);
            this.textBoxAlarmH.TabIndex = 3;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(84, 120);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(125, 27);
            this.textBoxUnit.TabIndex = 2;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Location = new System.Drawing.Point(84, 75);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(125, 27);
            this.textBoxURV.TabIndex = 1;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Location = new System.Drawing.Point(84, 34);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(125, 27);
            this.textBoxLRV.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.BackColor = System.Drawing.Color.LightGray;
            this.buttonSaveChanges.Location = new System.Drawing.Point(240, 407);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(127, 50);
            this.buttonSaveChanges.TabIndex = 16;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = false;
            // 
            // buttonRegisterNew
            // 
            this.buttonRegisterNew.BackColor = System.Drawing.Color.LightGray;
            this.buttonRegisterNew.Location = new System.Drawing.Point(109, 407);
            this.buttonRegisterNew.Name = "buttonRegisterNew";
            this.buttonRegisterNew.Size = new System.Drawing.Size(127, 50);
            this.buttonRegisterNew.TabIndex = 10;
            this.buttonRegisterNew.Text = "Register New";
            this.buttonRegisterNew.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(109, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // labelMeasureType
            // 
            this.labelMeasureType.AutoSize = true;
            this.labelMeasureType.Location = new System.Drawing.Point(6, 192);
            this.labelMeasureType.Name = "labelMeasureType";
            this.labelMeasureType.Size = new System.Drawing.Size(100, 20);
            this.labelMeasureType.TabIndex = 15;
            this.labelMeasureType.Text = "Measure Type";
            // 
            // textBoxComment
            // 
            this.textBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComment.Location = new System.Drawing.Point(109, 311);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(258, 81);
            this.textBoxComment.TabIndex = 8;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(3, 313);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(74, 20);
            this.labelComment.TabIndex = 12;
            this.labelComment.Text = "Comment";
            // 
            // listBoxOptions
            // 
            this.listBoxOptions.FormattingEnabled = true;
            this.listBoxOptions.ItemHeight = 20;
            this.listBoxOptions.Items.AddRange(new object[] {
            "none",
            "Display",
            "HART Protocol"});
            this.listBoxOptions.Location = new System.Drawing.Point(109, 233);
            this.listBoxOptions.Name = "listBoxOptions";
            this.listBoxOptions.Size = new System.Drawing.Size(258, 64);
            this.listBoxOptions.TabIndex = 7;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(6, 233);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(61, 20);
            this.labelOptions.TabIndex = 10;
            this.labelOptions.Text = "Options";
            // 
            // dateTimePickerRegDate
            // 
            this.dateTimePickerRegDate.Location = new System.Drawing.Point(109, 120);
            this.dateTimePickerRegDate.Name = "dateTimePickerRegDate";
            this.dateTimePickerRegDate.Size = new System.Drawing.Size(258, 27);
            this.dateTimePickerRegDate.TabIndex = 4;
            // 
            // checkBoxReg
            // 
            this.checkBoxReg.AutoSize = true;
            this.checkBoxReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxReg.Location = new System.Drawing.Point(109, 95);
            this.checkBoxReg.Name = "checkBoxReg";
            this.checkBoxReg.Size = new System.Drawing.Size(14, 13);
            this.checkBoxReg.TabIndex = 3;
            this.checkBoxReg.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxSerialNum
            // 
            this.maskedTextBoxSerialNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBoxSerialNum.Location = new System.Drawing.Point(109, 55);
            this.maskedTextBoxSerialNum.Mask = "000-00-0000";
            this.maskedTextBoxSerialNum.Name = "maskedTextBoxSerialNum";
            this.maskedTextBoxSerialNum.Size = new System.Drawing.Size(258, 27);
            this.maskedTextBoxSerialNum.TabIndex = 2;
            // 
            // textBoxSensorName
            // 
            this.textBoxSensorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSensorName.Location = new System.Drawing.Point(109, 20);
            this.textBoxSensorName.Name = "textBoxSensorName";
            this.textBoxSensorName.Size = new System.Drawing.Size(258, 27);
            this.textBoxSensorName.TabIndex = 1;
            // 
            // labelRegDate
            // 
            this.labelRegDate.AutoSize = true;
            this.labelRegDate.Location = new System.Drawing.Point(6, 125);
            this.labelRegDate.Name = "labelRegDate";
            this.labelRegDate.Size = new System.Drawing.Size(71, 20);
            this.labelRegDate.TabIndex = 5;
            this.labelRegDate.Text = "Reg Date";
            // 
            // labelRegistered
            // 
            this.labelRegistered.AutoSize = true;
            this.labelRegistered.Location = new System.Drawing.Point(6, 91);
            this.labelRegistered.Name = "labelRegistered";
            this.labelRegistered.Size = new System.Drawing.Size(80, 20);
            this.labelRegistered.TabIndex = 4;
            this.labelRegistered.Text = "Registered";
            // 
            // labelSerialNum
            // 
            this.labelSerialNum.AutoSize = true;
            this.labelSerialNum.Location = new System.Drawing.Point(6, 58);
            this.labelSerialNum.Name = "labelSerialNum";
            this.labelSerialNum.Size = new System.Drawing.Size(104, 20);
            this.labelSerialNum.TabIndex = 3;
            this.labelSerialNum.Text = "Serial Number";
            // 
            // labelSignalType
            // 
            this.labelSignalType.AutoSize = true;
            this.labelSignalType.Location = new System.Drawing.Point(6, 156);
            this.labelSignalType.Name = "labelSignalType";
            this.labelSignalType.Size = new System.Drawing.Size(85, 20);
            this.labelSignalType.TabIndex = 2;
            this.labelSignalType.Text = "Signal Type";
            // 
            // comboBoxSignalType
            // 
            this.comboBoxSignalType.FormattingEnabled = true;
            this.comboBoxSignalType.Items.AddRange(new object[] {
            "4-20mA",
            "0-10VDC"});
            this.comboBoxSignalType.Location = new System.Drawing.Point(109, 153);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(258, 28);
            this.comboBoxSignalType.TabIndex = 5;
            this.comboBoxSignalType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSignalType_SelectedIndexChanged);
            // 
            // labelSensorName
            // 
            this.labelSensorName.AutoSize = true;
            this.labelSensorName.Location = new System.Drawing.Point(6, 23);
            this.labelSensorName.Name = "labelSensorName";
            this.labelSensorName.Size = new System.Drawing.Size(97, 20);
            this.labelSensorName.TabIndex = 0;
            this.labelSensorName.Text = "Sensor Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonWriteConf);
            this.tabPage2.Controls.Add(this.buttonReadScaled);
            this.tabPage2.Controls.Add(this.buttonReadStatus);
            this.tabPage2.Controls.Add(this.buttonReadConf);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.buttonDisconnect);
            this.tabPage2.Controls.Add(this.buttonConnect);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.labelBaudRate);
            this.tabPage2.Controls.Add(this.labelComPort);
            this.tabPage2.Controls.Add(this.textBoxSend);
            this.tabPage2.Controls.Add(this.buttonSend);
            this.tabPage2.Controls.Add(this.labelPort);
            this.tabPage2.Controls.Add(this.labelIPAddress);
            this.tabPage2.Controls.Add(this.checkBoxStayConnected);
            this.tabPage2.Controls.Add(this.textBoxResult);
            this.tabPage2.Controls.Add(this.textBoxPort);
            this.tabPage2.Controls.Add(this.textBoxInputIPAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonWriteConf
            // 
            this.buttonWriteConf.BackColor = System.Drawing.Color.LightGray;
            this.buttonWriteConf.Location = new System.Drawing.Point(19, 226);
            this.buttonWriteConf.Name = "buttonWriteConf";
            this.buttonWriteConf.Size = new System.Drawing.Size(117, 49);
            this.buttonWriteConf.TabIndex = 34;
            this.buttonWriteConf.Text = "Write conf";
            this.buttonWriteConf.UseVisualStyleBackColor = false;
            this.buttonWriteConf.Click += new System.EventHandler(this.buttonWriteConf_Click);
            // 
            // buttonReadScaled
            // 
            this.buttonReadScaled.BackColor = System.Drawing.Color.LightGray;
            this.buttonReadScaled.Location = new System.Drawing.Point(143, 281);
            this.buttonReadScaled.Name = "buttonReadScaled";
            this.buttonReadScaled.Size = new System.Drawing.Size(117, 49);
            this.buttonReadScaled.TabIndex = 33;
            this.buttonReadScaled.Text = "Read scaled";
            this.buttonReadScaled.UseVisualStyleBackColor = false;
            this.buttonReadScaled.Click += new System.EventHandler(this.buttonReadScaled_Click);
            // 
            // buttonReadStatus
            // 
            this.buttonReadStatus.BackColor = System.Drawing.Color.LightGray;
            this.buttonReadStatus.Location = new System.Drawing.Point(143, 336);
            this.buttonReadStatus.Name = "buttonReadStatus";
            this.buttonReadStatus.Size = new System.Drawing.Size(117, 49);
            this.buttonReadStatus.TabIndex = 32;
            this.buttonReadStatus.Text = "Read status";
            this.buttonReadStatus.UseVisualStyleBackColor = false;
            this.buttonReadStatus.Click += new System.EventHandler(this.buttonReadStatus_Click);
            // 
            // buttonReadConf
            // 
            this.buttonReadConf.BackColor = System.Drawing.Color.LightGray;
            this.buttonReadConf.Location = new System.Drawing.Point(143, 226);
            this.buttonReadConf.Name = "buttonReadConf";
            this.buttonReadConf.Size = new System.Drawing.Size(117, 49);
            this.buttonReadConf.TabIndex = 31;
            this.buttonReadConf.Text = "Read conf";
            this.buttonReadConf.UseVisualStyleBackColor = false;
            this.buttonReadConf.Click += new System.EventHandler(this.buttonReadConf_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(803, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 394);
            this.textBox2.TabIndex = 27;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.LightGray;
            this.buttonDisconnect.Location = new System.Drawing.Point(646, 185);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(151, 51);
            this.buttonDisconnect.TabIndex = 26;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.LightGray;
            this.buttonConnect.Location = new System.Drawing.Point(646, 130);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(151, 49);
            this.buttonConnect.TabIndex = 25;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(646, 70);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(151, 28);
            this.comboBox3.TabIndex = 24;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(646, 34);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 23;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(556, 74);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(77, 20);
            this.labelBaudRate.TabIndex = 22;
            this.labelBaudRate.Text = "Baud Rate";
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(556, 38);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(70, 20);
            this.labelComPort.TabIndex = 21;
            this.labelComPort.Text = "Com Port";
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(19, 152);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(157, 27);
            this.textBoxSend.TabIndex = 20;
            this.textBoxSend.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.LightGray;
            this.buttonSend.Location = new System.Drawing.Point(182, 145);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(78, 41);
            this.buttonSend.TabIndex = 19;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(19, 70);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(35, 20);
            this.labelPort.TabIndex = 6;
            this.labelPort.Text = "Port";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(19, 38);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(78, 20);
            this.labelIPAddress.TabIndex = 5;
            this.labelIPAddress.Text = "IP Address";
            // 
            // checkBoxStayConnected
            // 
            this.checkBoxStayConnected.AutoSize = true;
            this.checkBoxStayConnected.Checked = true;
            this.checkBoxStayConnected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStayConnected.Location = new System.Drawing.Point(104, 100);
            this.checkBoxStayConnected.Name = "checkBoxStayConnected";
            this.checkBoxStayConnected.Size = new System.Drawing.Size(139, 24);
            this.checkBoxStayConnected.TabIndex = 4;
            this.checkBoxStayConnected.Text = "Stay Connectetd";
            this.checkBoxStayConnected.UseVisualStyleBackColor = true;
            this.checkBoxStayConnected.CheckedChanged += new System.EventHandler(this.checkBoxCaseSensitive_CheckedChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(267, 34);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(228, 394);
            this.textBoxResult.TabIndex = 3;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(104, 67);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(157, 27);
            this.textBoxPort.TabIndex = 2;
            // 
            // textBoxInputIPAddress
            // 
            this.textBoxInputIPAddress.Location = new System.Drawing.Point(104, 34);
            this.textBoxInputIPAddress.Name = "textBoxInputIPAddress";
            this.textBoxInputIPAddress.Size = new System.Drawing.Size(157, 27);
            this.textBoxInputIPAddress.TabIndex = 1;
            this.textBoxInputIPAddress.TextChanged += new System.EventHandler(this.textBoxInput1_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonTimerStop);
            this.tabPage3.Controls.Add(this.buttonTimerStart);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1063, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonTimerStop
            // 
            this.buttonTimerStop.BackColor = System.Drawing.Color.LightGray;
            this.buttonTimerStop.Location = new System.Drawing.Point(889, 325);
            this.buttonTimerStop.Name = "buttonTimerStop";
            this.buttonTimerStop.Size = new System.Drawing.Size(127, 40);
            this.buttonTimerStop.TabIndex = 27;
            this.buttonTimerStop.Text = "Stop";
            this.buttonTimerStop.UseVisualStyleBackColor = false;
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.BackColor = System.Drawing.Color.LightGray;
            this.buttonTimerStart.Location = new System.Drawing.Point(889, 279);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(127, 40);
            this.buttonTimerStart.TabIndex = 26;
            this.buttonTimerStart.Text = "Start";
            this.buttonTimerStart.UseVisualStyleBackColor = false;
            this.buttonTimerStart.Click += new System.EventHandler(this.buttonTimerStart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1020, 422);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timerGraph
            // 
            this.timerGraph.Interval = 5000;
            this.timerGraph.Tick += new System.EventHandler(this.timerGraph_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1092, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBoxComment;
        private Label labelComment;
        private ListBox listBoxOptions;
        private Label labelOptions;
        private DateTimePicker dateTimePickerRegDate;
        private CheckBox checkBoxReg;
        private MaskedTextBox maskedTextBoxSerialNum;
        private TextBox textBoxSensorName;
        private Label labelRegDate;
        private Label labelRegistered;
        private Label labelSerialNum;
        private Label labelSignalType;
        private ComboBox comboBoxSignalType;
        private Label labelSensorName;
        private TabPage tabPage2;
        private Button buttonRegisterNew;
        private TextBox textBoxResult;
        private TextBox textBoxPort;
        private TextBox textBoxInputIPAddress;
        private Label labelMeasureType;
        private ComboBox comboBox1;
        private ToolStripMenuItem toolStripMenuItemClose;
        private CheckBox checkBoxStayConnected;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Label labelLRV;
        private TextBox textBoxAlarmL;
        private TextBox textBoxAlarmH;
        private TextBox textBoxUnit;
        private TextBox textBoxURV;
        private TextBox textBoxLRV;
        private Button buttonSaveChanges;
        private Label labelAlarmL;
        private Label labelAlarmH;
        private Label labelUnit;
        private Label labelURV;
        private Button buttonSummary;
        private TextBox textBoxSummary;
        private Button buttonOpenFIle;
        private Button buttonSaveFile;
        private TextBox textBoxRegister;
        private Button buttonClear;
        private Label labelPort;
        private Label labelIPAddress;
        private TextBox textBox2;
        private Button buttonDisconnect;
        private Button buttonConnect;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label labelBaudRate;
        private Label labelComPort;
        private TextBox textBoxSend;
        private Button buttonSend;
        private TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonWriteConf;
        private Button buttonReadScaled;
        private Button buttonReadStatus;
        private Button buttonReadConf;
        private System.Windows.Forms.Timer timerGraph;
        private Button buttonTimerStop;
        private Button buttonTimerStart;
    }
}