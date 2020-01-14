﻿namespace SimioHelper
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDllHelper = new System.Windows.Forms.TabPage();
            this.panelDll = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkSimioOnly = new System.Windows.Forms.CheckBox();
            this.labelSelectSimioLocation = new System.Windows.Forms.Label();
            this.textAssemblyLoadInfo = new System.Windows.Forms.TextBox();
            this.comboDllFile = new System.Windows.Forms.ComboBox();
            this.buttonLoadAssembly = new System.Windows.Forms.Button();
            this.labelDLLFiles = new System.Windows.Forms.Label();
            this.textExceptions = new System.Windows.Forms.TextBox();
            this.comboSimioLocation = new System.Windows.Forms.ComboBox();
            this.labelExceptions = new System.Windows.Forms.Label();
            this.textAssemblyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNetVersions = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHwCpuSpeed = new System.Windows.Forms.Label();
            this.labelHwCpuMaker = new System.Windows.Forms.Label();
            this.labelHwPhysicalMemory = new System.Windows.Forms.Label();
            this.labelHwComputerName = new System.Windows.Forms.Label();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.textDotNetVersions = new System.Windows.Forms.TextBox();
            this.labelInstalledDotNet = new System.Windows.Forms.Label();
            this.labelCurrentDotNet = new System.Windows.Forms.Label();
            this.tabFindUserExtensions = new System.Windows.Forms.TabPage();
            this.panelFindSteps = new System.Windows.Forms.Panel();
            this.textStepsAndAddIns = new System.Windows.Forms.TextBox();
            this.buttonFindUserExtensions = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboFindSimioExtensionLocations = new System.Windows.Forms.ComboBox();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.textLogs = new System.Windows.Forms.TextBox();
            this.tabHeadless = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbHeadlessSaveModelAfterRun = new System.Windows.Forms.CheckBox();
            this.cbHeadlessPublishPlanAfterRun = new System.Windows.Forms.CheckBox();
            this.cbHeadlessRunRiskAnalysis = new System.Windows.Forms.CheckBox();
            this.buttonHeadlessRun = new System.Windows.Forms.Button();
            this.textHeadlessModelFile = new System.Windows.Forms.TextBox();
            this.buttonHeadlessSelectModel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timerLogs = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textExperimentName = new System.Windows.Forms.TextBox();
            this.textModelName = new System.Windows.Forms.TextBox();
            this.buttonRunExperiment = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.labelStatus.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDllHelper.SuspendLayout();
            this.panelDll.SuspendLayout();
            this.tabNetVersions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabFindUserExtensions.SuspendLayout();
            this.panelFindSteps.SuspendLayout();
            this.tabLogs.SuspendLayout();
            this.tabHeadless.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.createIconToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1280, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // createIconToolStripMenuItem
            // 
            this.createIconToolStripMenuItem.Name = "createIconToolStripMenuItem";
            this.createIconToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.createIconToolStripMenuItem.Text = "Create Icon...";
            this.createIconToolStripMenuItem.Click += new System.EventHandler(this.createIconToolStripMenuItem_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.labelStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.labelStatus.Location = new System.Drawing.Point(0, 723);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.labelStatus.Size = new System.Drawing.Size(1280, 25);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(18, 20);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDllHelper);
            this.tabControl1.Controls.Add(this.tabNetVersions);
            this.tabControl1.Controls.Add(this.tabFindUserExtensions);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Controls.Add(this.tabHeadless);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 695);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDllHelper
            // 
            this.tabDllHelper.Controls.Add(this.panelDll);
            this.tabDllHelper.Location = new System.Drawing.Point(4, 29);
            this.tabDllHelper.Name = "tabDllHelper";
            this.tabDllHelper.Padding = new System.Windows.Forms.Padding(3);
            this.tabDllHelper.Size = new System.Drawing.Size(1272, 662);
            this.tabDllHelper.TabIndex = 0;
            this.tabDllHelper.Text = "DLL Helper";
            this.tabDllHelper.UseVisualStyleBackColor = true;
            // 
            // panelDll
            // 
            this.panelDll.Controls.Add(this.label2);
            this.panelDll.Controls.Add(this.checkSimioOnly);
            this.panelDll.Controls.Add(this.labelSelectSimioLocation);
            this.panelDll.Controls.Add(this.textAssemblyLoadInfo);
            this.panelDll.Controls.Add(this.comboDllFile);
            this.panelDll.Controls.Add(this.buttonLoadAssembly);
            this.panelDll.Controls.Add(this.labelDLLFiles);
            this.panelDll.Controls.Add(this.textExceptions);
            this.panelDll.Controls.Add(this.comboSimioLocation);
            this.panelDll.Controls.Add(this.labelExceptions);
            this.panelDll.Controls.Add(this.textAssemblyName);
            this.panelDll.Controls.Add(this.label1);
            this.panelDll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDll.Location = new System.Drawing.Point(3, 3);
            this.panelDll.Name = "panelDll";
            this.panelDll.Size = new System.Drawing.Size(1266, 656);
            this.panelDll.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(828, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a Simio Location, which will fetch the DLL files there. Then select a DLL " +
    "file to get information about it.";
            // 
            // checkSimioOnly
            // 
            this.checkSimioOnly.AutoSize = true;
            this.checkSimioOnly.Checked = true;
            this.checkSimioOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkSimioOnly.Location = new System.Drawing.Point(25, 447);
            this.checkSimioOnly.Name = "checkSimioOnly";
            this.checkSimioOnly.Size = new System.Drawing.Size(112, 24);
            this.checkSimioOnly.TabIndex = 12;
            this.checkSimioOnly.Text = "Simio Only";
            this.checkSimioOnly.UseVisualStyleBackColor = true;
            // 
            // labelSelectSimioLocation
            // 
            this.labelSelectSimioLocation.AutoSize = true;
            this.labelSelectSimioLocation.Location = new System.Drawing.Point(21, 85);
            this.labelSelectSimioLocation.Name = "labelSelectSimioLocation";
            this.labelSelectSimioLocation.Size = new System.Drawing.Size(172, 20);
            this.labelSelectSimioLocation.TabIndex = 0;
            this.labelSelectSimioLocation.Text = "Select Simio Location";
            // 
            // textAssemblyLoadInfo
            // 
            this.textAssemblyLoadInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAssemblyLoadInfo.Location = new System.Drawing.Point(282, 377);
            this.textAssemblyLoadInfo.Multiline = true;
            this.textAssemblyLoadInfo.Name = "textAssemblyLoadInfo";
            this.textAssemblyLoadInfo.ReadOnly = true;
            this.textAssemblyLoadInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAssemblyLoadInfo.Size = new System.Drawing.Size(967, 156);
            this.textAssemblyLoadInfo.TabIndex = 11;
            // 
            // comboDllFile
            // 
            this.comboDllFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDllFile.FormattingEnabled = true;
            this.comboDllFile.Location = new System.Drawing.Point(282, 155);
            this.comboDllFile.Name = "comboDllFile";
            this.comboDllFile.Size = new System.Drawing.Size(967, 28);
            this.comboDllFile.TabIndex = 2;
            this.comboDllFile.SelectedIndexChanged += new System.EventHandler(this.comboDllFile_SelectedIndexChanged);
            // 
            // buttonLoadAssembly
            // 
            this.buttonLoadAssembly.Location = new System.Drawing.Point(25, 377);
            this.buttonLoadAssembly.Name = "buttonLoadAssembly";
            this.buttonLoadAssembly.Size = new System.Drawing.Size(200, 50);
            this.buttonLoadAssembly.TabIndex = 10;
            this.buttonLoadAssembly.Text = "Load Assembly";
            this.buttonLoadAssembly.UseVisualStyleBackColor = true;
            this.buttonLoadAssembly.Click += new System.EventHandler(this.buttonLoadAssembly_Click);
            // 
            // labelDLLFiles
            // 
            this.labelDLLFiles.AutoSize = true;
            this.labelDLLFiles.Location = new System.Drawing.Point(21, 158);
            this.labelDLLFiles.Name = "labelDLLFiles";
            this.labelDLLFiles.Size = new System.Drawing.Size(126, 20);
            this.labelDLLFiles.TabIndex = 3;
            this.labelDLLFiles.Text = "Select DLL File";
            // 
            // textExceptions
            // 
            this.textExceptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textExceptions.Location = new System.Drawing.Point(282, 551);
            this.textExceptions.Multiline = true;
            this.textExceptions.Name = "textExceptions";
            this.textExceptions.ReadOnly = true;
            this.textExceptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textExceptions.Size = new System.Drawing.Size(967, 87);
            this.textExceptions.TabIndex = 9;
            // 
            // comboSimioLocation
            // 
            this.comboSimioLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSimioLocation.FormattingEnabled = true;
            this.comboSimioLocation.Location = new System.Drawing.Point(282, 85);
            this.comboSimioLocation.Name = "comboSimioLocation";
            this.comboSimioLocation.Size = new System.Drawing.Size(967, 28);
            this.comboSimioLocation.TabIndex = 4;
            this.comboSimioLocation.SelectedValueChanged += new System.EventHandler(this.comboSimioLocation_SelectedValueChanged);
            // 
            // labelExceptions
            // 
            this.labelExceptions.AutoSize = true;
            this.labelExceptions.Location = new System.Drawing.Point(23, 572);
            this.labelExceptions.Name = "labelExceptions";
            this.labelExceptions.Size = new System.Drawing.Size(215, 20);
            this.labelExceptions.TabIndex = 8;
            this.labelExceptions.Text = "Exceptions (hopefully none)";
            // 
            // textAssemblyName
            // 
            this.textAssemblyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAssemblyName.Location = new System.Drawing.Point(282, 218);
            this.textAssemblyName.Multiline = true;
            this.textAssemblyName.Name = "textAssemblyName";
            this.textAssemblyName.ReadOnly = true;
            this.textAssemblyName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textAssemblyName.Size = new System.Drawing.Size(967, 151);
            this.textAssemblyName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assembly Info";
            // 
            // tabNetVersions
            // 
            this.tabNetVersions.Controls.Add(this.panel1);
            this.tabNetVersions.Location = new System.Drawing.Point(4, 29);
            this.tabNetVersions.Name = "tabNetVersions";
            this.tabNetVersions.Size = new System.Drawing.Size(1272, 662);
            this.tabNetVersions.TabIndex = 3;
            this.tabNetVersions.Text = ".NET Versions";
            this.tabNetVersions.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelHwCpuSpeed);
            this.panel1.Controls.Add(this.labelHwCpuMaker);
            this.panel1.Controls.Add(this.labelHwPhysicalMemory);
            this.panel1.Controls.Add(this.labelHwComputerName);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.textDotNetVersions);
            this.panel1.Controls.Add(this.labelInstalledDotNet);
            this.panel1.Controls.Add(this.labelCurrentDotNet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1272, 662);
            this.panel1.TabIndex = 20;
            // 
            // labelHwCpuSpeed
            // 
            this.labelHwCpuSpeed.AutoSize = true;
            this.labelHwCpuSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHwCpuSpeed.Location = new System.Drawing.Point(416, 111);
            this.labelHwCpuSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHwCpuSpeed.Name = "labelHwCpuSpeed";
            this.labelHwCpuSpeed.Size = new System.Drawing.Size(106, 20);
            this.labelHwCpuSpeed.TabIndex = 24;
            this.labelHwCpuSpeed.Text = "CPU Speed: ";
            // 
            // labelHwCpuMaker
            // 
            this.labelHwCpuMaker.AutoSize = true;
            this.labelHwCpuMaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHwCpuMaker.Location = new System.Drawing.Point(416, 81);
            this.labelHwCpuMaker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHwCpuMaker.Name = "labelHwCpuMaker";
            this.labelHwCpuMaker.Size = new System.Drawing.Size(105, 20);
            this.labelHwCpuMaker.TabIndex = 23;
            this.labelHwCpuMaker.Text = "CPU Maker: ";
            // 
            // labelHwPhysicalMemory
            // 
            this.labelHwPhysicalMemory.AutoSize = true;
            this.labelHwPhysicalMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHwPhysicalMemory.Location = new System.Drawing.Point(416, 51);
            this.labelHwPhysicalMemory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHwPhysicalMemory.Name = "labelHwPhysicalMemory";
            this.labelHwPhysicalMemory.Size = new System.Drawing.Size(147, 20);
            this.labelHwPhysicalMemory.TabIndex = 22;
            this.labelHwPhysicalMemory.Text = "Physical Memory: ";
            // 
            // labelHwComputerName
            // 
            this.labelHwComputerName.AutoSize = true;
            this.labelHwComputerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHwComputerName.Location = new System.Drawing.Point(416, 21);
            this.labelHwComputerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHwComputerName.Name = "labelHwComputerName";
            this.labelHwComputerName.Size = new System.Drawing.Size(141, 20);
            this.labelHwComputerName.TabIndex = 21;
            this.labelHwComputerName.Text = "Computer Name: ";
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(27, 21);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(200, 50);
            this.buttonDashboard.TabIndex = 20;
            this.buttonDashboard.Text = "Refresh";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // textDotNetVersions
            // 
            this.textDotNetVersions.Location = new System.Drawing.Point(27, 285);
            this.textDotNetVersions.Multiline = true;
            this.textDotNetVersions.Name = "textDotNetVersions";
            this.textDotNetVersions.ReadOnly = true;
            this.textDotNetVersions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDotNetVersions.Size = new System.Drawing.Size(899, 366);
            this.textDotNetVersions.TabIndex = 19;
            // 
            // labelInstalledDotNet
            // 
            this.labelInstalledDotNet.AutoSize = true;
            this.labelInstalledDotNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstalledDotNet.Location = new System.Drawing.Point(23, 253);
            this.labelInstalledDotNet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstalledDotNet.Name = "labelInstalledDotNet";
            this.labelInstalledDotNet.Size = new System.Drawing.Size(182, 20);
            this.labelInstalledDotNet.TabIndex = 18;
            this.labelInstalledDotNet.Text = "Installed .Net Versions:";
            // 
            // labelCurrentDotNet
            // 
            this.labelCurrentDotNet.AutoSize = true;
            this.labelCurrentDotNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDotNet.Location = new System.Drawing.Point(23, 169);
            this.labelCurrentDotNet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDotNet.Name = "labelCurrentDotNet";
            this.labelCurrentDotNet.Size = new System.Drawing.Size(174, 20);
            this.labelCurrentDotNet.TabIndex = 17;
            this.labelCurrentDotNet.Text = "Current .NET Version:";
            // 
            // tabFindUserExtensions
            // 
            this.tabFindUserExtensions.Controls.Add(this.panelFindSteps);
            this.tabFindUserExtensions.Location = new System.Drawing.Point(4, 29);
            this.tabFindUserExtensions.Name = "tabFindUserExtensions";
            this.tabFindUserExtensions.Size = new System.Drawing.Size(1272, 662);
            this.tabFindUserExtensions.TabIndex = 2;
            this.tabFindUserExtensions.Text = "Find UserExtensions";
            this.tabFindUserExtensions.UseVisualStyleBackColor = true;
            // 
            // panelFindSteps
            // 
            this.panelFindSteps.Controls.Add(this.textStepsAndAddIns);
            this.panelFindSteps.Controls.Add(this.buttonFindUserExtensions);
            this.panelFindSteps.Controls.Add(this.label3);
            this.panelFindSteps.Controls.Add(this.label4);
            this.panelFindSteps.Controls.Add(this.comboFindSimioExtensionLocations);
            this.panelFindSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFindSteps.Location = new System.Drawing.Point(0, 0);
            this.panelFindSteps.Name = "panelFindSteps";
            this.panelFindSteps.Size = new System.Drawing.Size(1272, 662);
            this.panelFindSteps.TabIndex = 11;
            // 
            // textStepsAndAddIns
            // 
            this.textStepsAndAddIns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textStepsAndAddIns.Location = new System.Drawing.Point(19, 194);
            this.textStepsAndAddIns.Multiline = true;
            this.textStepsAndAddIns.Name = "textStepsAndAddIns";
            this.textStepsAndAddIns.ReadOnly = true;
            this.textStepsAndAddIns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textStepsAndAddIns.Size = new System.Drawing.Size(1223, 454);
            this.textStepsAndAddIns.TabIndex = 12;
            // 
            // buttonFindUserExtensions
            // 
            this.buttonFindUserExtensions.Location = new System.Drawing.Point(230, 120);
            this.buttonFindUserExtensions.Name = "buttonFindUserExtensions";
            this.buttonFindUserExtensions.Size = new System.Drawing.Size(200, 50);
            this.buttonFindUserExtensions.TabIndex = 11;
            this.buttonFindUserExtensions.Text = "Find UserExtensions";
            this.buttonFindUserExtensions.UseVisualStyleBackColor = true;
            this.buttonFindUserExtensions.Click += new System.EventHandler(this.buttonFindStepsAndAddIns_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(828, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select a Simio Location, which will fetch the DLL files there. Then select a DLL " +
    "file to get information about it.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Simio Location";
            // 
            // comboFindSimioExtensionLocations
            // 
            this.comboFindSimioExtensionLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFindSimioExtensionLocations.FormattingEnabled = true;
            this.comboFindSimioExtensionLocations.Location = new System.Drawing.Point(230, 68);
            this.comboFindSimioExtensionLocations.Name = "comboFindSimioExtensionLocations";
            this.comboFindSimioExtensionLocations.Size = new System.Drawing.Size(1012, 28);
            this.comboFindSimioExtensionLocations.TabIndex = 9;
            this.comboFindSimioExtensionLocations.SelectedIndexChanged += new System.EventHandler(this.comboFindSimioExtensionLocations_SelectedIndexChanged);
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.textLogs);
            this.tabLogs.Location = new System.Drawing.Point(4, 29);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(1272, 662);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // textLogs
            // 
            this.textLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLogs.Location = new System.Drawing.Point(3, 3);
            this.textLogs.Multiline = true;
            this.textLogs.Name = "textLogs";
            this.textLogs.ReadOnly = true;
            this.textLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textLogs.Size = new System.Drawing.Size(1266, 656);
            this.textLogs.TabIndex = 0;
            this.textLogs.Text = "(no logs yet...)";
            // 
            // tabHeadless
            // 
            this.tabHeadless.Controls.Add(this.panel2);
            this.tabHeadless.Location = new System.Drawing.Point(4, 29);
            this.tabHeadless.Name = "tabHeadless";
            this.tabHeadless.Size = new System.Drawing.Size(1272, 662);
            this.tabHeadless.TabIndex = 4;
            this.tabHeadless.Text = "Headless Run";
            this.tabHeadless.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRunExperiment);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textExperimentName);
            this.panel2.Controls.Add(this.textModelName);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.buttonHeadlessRun);
            this.panel2.Controls.Add(this.textHeadlessModelFile);
            this.panel2.Controls.Add(this.buttonHeadlessSelectModel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 662);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbHeadlessSaveModelAfterRun);
            this.groupBox1.Controls.Add(this.cbHeadlessPublishPlanAfterRun);
            this.groupBox1.Controls.Add(this.cbHeadlessRunRiskAnalysis);
            this.groupBox1.Location = new System.Drawing.Point(63, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 155);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Post-Run Actions";
            // 
            // cbHeadlessSaveModelAfterRun
            // 
            this.cbHeadlessSaveModelAfterRun.AutoSize = true;
            this.cbHeadlessSaveModelAfterRun.Checked = true;
            this.cbHeadlessSaveModelAfterRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHeadlessSaveModelAfterRun.Location = new System.Drawing.Point(19, 37);
            this.cbHeadlessSaveModelAfterRun.Name = "cbHeadlessSaveModelAfterRun";
            this.cbHeadlessSaveModelAfterRun.Size = new System.Drawing.Size(194, 24);
            this.cbHeadlessSaveModelAfterRun.TabIndex = 15;
            this.cbHeadlessSaveModelAfterRun.Text = "Save Model After Run";
            this.cbHeadlessSaveModelAfterRun.UseVisualStyleBackColor = true;
            // 
            // cbHeadlessPublishPlanAfterRun
            // 
            this.cbHeadlessPublishPlanAfterRun.AutoSize = true;
            this.cbHeadlessPublishPlanAfterRun.Location = new System.Drawing.Point(19, 97);
            this.cbHeadlessPublishPlanAfterRun.Name = "cbHeadlessPublishPlanAfterRun";
            this.cbHeadlessPublishPlanAfterRun.Size = new System.Drawing.Size(200, 24);
            this.cbHeadlessPublishPlanAfterRun.TabIndex = 17;
            this.cbHeadlessPublishPlanAfterRun.Text = "Publish Plan After Run";
            this.cbHeadlessPublishPlanAfterRun.UseVisualStyleBackColor = true;
            // 
            // cbHeadlessRunRiskAnalysis
            // 
            this.cbHeadlessRunRiskAnalysis.AutoSize = true;
            this.cbHeadlessRunRiskAnalysis.Location = new System.Drawing.Point(19, 67);
            this.cbHeadlessRunRiskAnalysis.Name = "cbHeadlessRunRiskAnalysis";
            this.cbHeadlessRunRiskAnalysis.Size = new System.Drawing.Size(167, 24);
            this.cbHeadlessRunRiskAnalysis.TabIndex = 16;
            this.cbHeadlessRunRiskAnalysis.Text = "Run Risk Analysis";
            this.cbHeadlessRunRiskAnalysis.UseVisualStyleBackColor = true;
            // 
            // buttonHeadlessRun
            // 
            this.buttonHeadlessRun.Location = new System.Drawing.Point(1061, 278);
            this.buttonHeadlessRun.Name = "buttonHeadlessRun";
            this.buttonHeadlessRun.Size = new System.Drawing.Size(165, 46);
            this.buttonHeadlessRun.TabIndex = 14;
            this.buttonHeadlessRun.Text = "Run Model...";
            this.toolTip1.SetToolTip(this.buttonHeadlessRun, "Run the model and the post-run actions according to the checkboxes");
            this.buttonHeadlessRun.UseVisualStyleBackColor = true;
            this.buttonHeadlessRun.Click += new System.EventHandler(this.buttonHeadlessRun_Click);
            // 
            // textHeadlessModelFile
            // 
            this.textHeadlessModelFile.Location = new System.Drawing.Point(63, 97);
            this.textHeadlessModelFile.Name = "textHeadlessModelFile";
            this.textHeadlessModelFile.Size = new System.Drawing.Size(971, 27);
            this.textHeadlessModelFile.TabIndex = 13;
            // 
            // buttonHeadlessSelectModel
            // 
            this.buttonHeadlessSelectModel.Location = new System.Drawing.Point(1061, 97);
            this.buttonHeadlessSelectModel.Name = "buttonHeadlessSelectModel";
            this.buttonHeadlessSelectModel.Size = new System.Drawing.Size(165, 50);
            this.buttonHeadlessSelectModel.TabIndex = 12;
            this.buttonHeadlessSelectModel.Text = "Select Project";
            this.toolTip1.SetToolTip(this.buttonHeadlessSelectModel, "Select a Simio SPFX project file for loading");
            this.buttonHeadlessSelectModel.UseVisualStyleBackColor = true;
            this.buttonHeadlessSelectModel.Click += new System.EventHandler(this.buttonHeadlessSelectModel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Run a model \'headless\' by using the IModel API";
            // 
            // timerLogs
            // 
            this.timerLogs.Interval = 1000;
            this.timerLogs.Tick += new System.EventHandler(this.timerLogs_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Experiment Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Model Name: ";
            // 
            // textExperimentName
            // 
            this.textExperimentName.Location = new System.Drawing.Point(247, 189);
            this.textExperimentName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textExperimentName.Name = "textExperimentName";
            this.textExperimentName.Size = new System.Drawing.Size(158, 27);
            this.textExperimentName.TabIndex = 20;
            this.textExperimentName.Text = "Experiment1";
            // 
            // textModelName
            // 
            this.textModelName.Location = new System.Drawing.Point(247, 278);
            this.textModelName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textModelName.Name = "textModelName";
            this.textModelName.Size = new System.Drawing.Size(210, 27);
            this.textModelName.TabIndex = 19;
            this.textModelName.Text = "Model";
            // 
            // buttonRunExperiment
            // 
            this.buttonRunExperiment.Location = new System.Drawing.Point(1061, 189);
            this.buttonRunExperiment.Name = "buttonRunExperiment";
            this.buttonRunExperiment.Size = new System.Drawing.Size(165, 46);
            this.buttonRunExperiment.TabIndex = 23;
            this.buttonRunExperiment.Text = "Run Experiment";
            this.toolTip1.SetToolTip(this.buttonRunExperiment, "Run the model and the post-run actions according to the checkboxes");
            this.buttonRunExperiment.UseVisualStyleBackColor = true;
            this.buttonRunExperiment.Click += new System.EventHandler(this.buttonRunExperiment_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 748);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Simio API Helper";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.labelStatus.ResumeLayout(false);
            this.labelStatus.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDllHelper.ResumeLayout(false);
            this.panelDll.ResumeLayout(false);
            this.panelDll.PerformLayout();
            this.tabNetVersions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFindUserExtensions.ResumeLayout(false);
            this.panelFindSteps.ResumeLayout(false);
            this.panelFindSteps.PerformLayout();
            this.tabLogs.ResumeLayout(false);
            this.tabLogs.PerformLayout();
            this.tabHeadless.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip labelStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDllHelper;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label labelSelectSimioLocation;
        private System.Windows.Forms.Label labelDLLFiles;
        private System.Windows.Forms.ComboBox comboDllFile;
        private System.Windows.Forms.ComboBox comboSimioLocation;
        private System.Windows.Forms.TextBox textAssemblyLoadInfo;
        private System.Windows.Forms.Button buttonLoadAssembly;
        private System.Windows.Forms.TextBox textExceptions;
        private System.Windows.Forms.Label labelExceptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textAssemblyName;
        private System.Windows.Forms.CheckBox checkSimioOnly;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIconToolStripMenuItem;
        private System.Windows.Forms.Panel panelDll;
        private System.Windows.Forms.TabPage tabFindUserExtensions;
        private System.Windows.Forms.Panel panelFindSteps;
        private System.Windows.Forms.Button buttonFindUserExtensions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboFindSimioExtensionLocations;
        private System.Windows.Forms.TextBox textStepsAndAddIns;
        private System.Windows.Forms.TabPage tabNetVersions;
        private System.Windows.Forms.TextBox textLogs;
        private System.Windows.Forms.Timer timerLogs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHwCpuSpeed;
        private System.Windows.Forms.Label labelHwCpuMaker;
        private System.Windows.Forms.Label labelHwPhysicalMemory;
        private System.Windows.Forms.Label labelHwComputerName;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.TextBox textDotNetVersions;
        private System.Windows.Forms.Label labelInstalledDotNet;
        private System.Windows.Forms.Label labelCurrentDotNet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabHeadless;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textHeadlessModelFile;
        private System.Windows.Forms.Button buttonHeadlessSelectModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonHeadlessRun;
        private System.Windows.Forms.CheckBox cbHeadlessSaveModelAfterRun;
        private System.Windows.Forms.CheckBox cbHeadlessPublishPlanAfterRun;
        private System.Windows.Forms.CheckBox cbHeadlessRunRiskAnalysis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonRunExperiment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textExperimentName;
        private System.Windows.Forms.TextBox textModelName;
    }
}
