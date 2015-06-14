using System.Windows.Forms;

namespace VisionControl
{
  partial class VisionControl
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
        if (mJM != null)
          mJM.Shutdown();
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    // cognex.wizard.initializecomponent
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisionControl));
            this.tabPage_Job0_MailSettings = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage_Job0_AddRemoveTeamMember = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.label50 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.tabPage_Job0_SupervisorControls = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label_AcquisitionResults_Overruns = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAcquisitionErrors = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalAcquisitionOverruns = new System.Windows.Forms.TextBox();
            this.groupBox_AcquisitionResults = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalError = new System.Windows.Forms.TextBox();
            this.textBox_JobN_MaxThroughput = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalWarning = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_AcquisitionResults_Errors = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAcquisitions = new System.Windows.Forms.TextBox();
            this.label_AcquisitionResults_TotalAcquisitions = new System.Windows.Forms.Label();
            this.label_JobThroughput_persec = new System.Windows.Forms.Label();
            this.groupBox_JobThroughput = new System.Windows.Forms.GroupBox();
            this.textBox_JobN_MinThroughput = new System.Windows.Forms.TextBox();
            this.label_JobThroughput_Max = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_JobResults_Warning = new System.Windows.Forms.Label();
            this.label_JobResults_Error = new System.Windows.Forms.Label();
            this.label_JobThroughput_Min = new System.Windows.Forms.Label();
            this.textBox_JobN_Throughput = new System.Windows.Forms.TextBox();
            this.label_JobThroughput_TotalThroughput = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ivanIvanovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoqnIvanovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleksandurDimitrovToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cogRecordsDisplay1 = new Cognex.VisionPro.CogRecordsDisplay();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl_JobTabs = new System.Windows.Forms.TabControl();
            this.tabPage_JobN_JobStatistics = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox_JobResults = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_JobResults_Percent = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalReject = new System.Windows.Forms.TextBox();
            this.label_JobResults_Reject = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAccept = new System.Windows.Forms.TextBox();
            this.label_JobResults_Accept = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalIterations = new System.Windows.Forms.TextBox();
            this.label_JobResults_TotalIterations = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ResetStatistics = new System.Windows.Forms.Button();
            this.button_ResetStatisticsForAllJobs = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_controlErrorMessage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_ResultBar = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRunCont = new System.Windows.Forms.Button();
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.button_SaveSettings = new System.Windows.Forms.Button();
            this.checkBox_LiveDisplay = new System.Windows.Forms.CheckBox();
            this.button_About = new System.Windows.Forms.Button();
            this.groupBox_DividerLine = new System.Windows.Forms.GroupBox();
            this.label_Online = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cogJobResultHistoryCollectionEdit1 = new Cognex.VisionPro.QuickBuild.CogJobResultHistoryCollectionEdit();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.button_Configuration = new System.Windows.Forms.Button();
            this.applicationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage_Job0_MailSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage_Job0_AddRemoveTeamMember.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.tabPage_Job0_SupervisorControls.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_AcquisitionResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_JobThroughput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabControl_JobTabs.SuspendLayout();
            this.tabPage_JobN_JobStatistics.SuspendLayout();
            this.groupBox_JobResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage_Job0_MailSettings
            // 
            this.tabPage_Job0_MailSettings.AutoScroll = true;
            this.tabPage_Job0_MailSettings.Controls.Add(this.groupBox4);
            this.tabPage_Job0_MailSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job0_MailSettings.Name = "tabPage_Job0_MailSettings";
            this.tabPage_Job0_MailSettings.Size = new System.Drawing.Size(467, 450);
            this.tabPage_Job0_MailSettings.TabIndex = 0;
            this.tabPage_Job0_MailSettings.Text = "Mail Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(13, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 176);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set Scheduler";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 47);
            this.button3.TabIndex = 0;
            this.button3.Text = "Email Scheduler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage_Job0_AddRemoveTeamMember
            // 
            this.tabPage_Job0_AddRemoveTeamMember.AutoScroll = true;
            this.tabPage_Job0_AddRemoveTeamMember.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_Job0_AddRemoveTeamMember.Controls.Add(this.groupBox12);
            this.tabPage_Job0_AddRemoveTeamMember.Controls.Add(this.groupBox13);
            this.tabPage_Job0_AddRemoveTeamMember.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job0_AddRemoveTeamMember.Name = "tabPage_Job0_AddRemoveTeamMember";
            this.tabPage_Job0_AddRemoveTeamMember.Size = new System.Drawing.Size(467, 450);
            this.tabPage_Job0_AddRemoveTeamMember.TabIndex = 0;
            this.tabPage_Job0_AddRemoveTeamMember.Text = "Team Settings";
            // 
            // groupBox12
            // 
            this.groupBox12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox12.BackgroundImage")));
            this.groupBox12.Controls.Add(this.comboBox6);
            this.groupBox12.Controls.Add(this.label70);
            this.groupBox12.Controls.Add(this.button11);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox12.ForeColor = System.Drawing.Color.Black;
            this.groupBox12.Location = new System.Drawing.Point(38, 261);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(409, 189);
            this.groupBox12.TabIndex = 102;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Del Member";
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(151, 28);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(95, 21);
            this.comboBox6.TabIndex = 94;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label70.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label70.Location = new System.Drawing.Point(93, 29);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(43, 16);
            this.label70.TabIndex = 93;
            this.label70.Text = "Fitter";
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(262, 16);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(95, 43);
            this.button11.TabIndex = 92;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox13.BackgroundImage")));
            this.groupBox13.Controls.Add(this.label50);
            this.groupBox13.Controls.Add(this.button12);
            this.groupBox13.Controls.Add(this.textBox66);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox13.Location = new System.Drawing.Point(38, 37);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(409, 207);
            this.groupBox13.TabIndex = 101;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Add Team Member";
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label50.Location = new System.Drawing.Point(22, 36);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(137, 20);
            this.label50.TabIndex = 99;
            this.label50.Text = "Add New Fitter";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(273, 24);
            this.button12.Name = "button12";
            this.button12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button12.Size = new System.Drawing.Size(100, 42);
            this.button12.TabIndex = 98;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.SystemColors.Control;
            this.textBox66.Location = new System.Drawing.Point(167, 36);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(100, 20);
            this.textBox66.TabIndex = 89;
            // 
            // tabPage_Job0_SupervisorControls
            // 
            this.tabPage_Job0_SupervisorControls.AutoScroll = true;
            this.tabPage_Job0_SupervisorControls.Controls.Add(this.groupBox3);
            this.tabPage_Job0_SupervisorControls.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job0_SupervisorControls.Name = "tabPage_Job0_SupervisorControls";
            this.tabPage_Job0_SupervisorControls.Size = new System.Drawing.Size(467, 450);
            this.tabPage_Job0_SupervisorControls.TabIndex = 0;
            this.tabPage_Job0_SupervisorControls.Text = "Preview Defect Images";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 187);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Defect Images";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 40);
            this.button6.TabIndex = 2;
            this.button6.Text = "Инспекция3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(172, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 73);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Инспекция1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // label_AcquisitionResults_Overruns
            // 
            this.label_AcquisitionResults_Overruns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_Overruns.Location = new System.Drawing.Point(37, 66);
            this.label_AcquisitionResults_Overruns.Name = "label_AcquisitionResults_Overruns";
            this.label_AcquisitionResults_Overruns.Size = new System.Drawing.Size(48, 16);
            this.label_AcquisitionResults_Overruns.TabIndex = 32;
            this.label_AcquisitionResults_Overruns.Text = "Overruns:";
            // 
            // textBox_JobN_TotalAcquisitionErrors
            // 
            this.textBox_JobN_TotalAcquisitionErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitionErrors.Location = new System.Drawing.Point(261, 19);
            this.textBox_JobN_TotalAcquisitionErrors.Name = "textBox_JobN_TotalAcquisitionErrors";
            this.textBox_JobN_TotalAcquisitionErrors.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitionErrors.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAcquisitionErrors.TabIndex = 31;
            this.textBox_JobN_TotalAcquisitionErrors.Text = "textBox1";
            this.textBox_JobN_TotalAcquisitionErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_TotalAcquisitionOverruns
            // 
            this.textBox_JobN_TotalAcquisitionOverruns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitionOverruns.Location = new System.Drawing.Point(119, 47);
            this.textBox_JobN_TotalAcquisitionOverruns.Name = "textBox_JobN_TotalAcquisitionOverruns";
            this.textBox_JobN_TotalAcquisitionOverruns.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitionOverruns.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAcquisitionOverruns.TabIndex = 33;
            this.textBox_JobN_TotalAcquisitionOverruns.Text = "textBox2";
            this.textBox_JobN_TotalAcquisitionOverruns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox_AcquisitionResults
            // 
            this.groupBox_AcquisitionResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitionOverruns);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_Overruns);
            this.groupBox_AcquisitionResults.Controls.Add(this.groupBox1);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_Errors);
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitions);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_TotalAcquisitions);
            this.groupBox_AcquisitionResults.Location = new System.Drawing.Point(17, 14);
            this.groupBox_AcquisitionResults.Name = "groupBox_AcquisitionResults";
            this.groupBox_AcquisitionResults.Size = new System.Drawing.Size(366, 103);
            this.groupBox_AcquisitionResults.TabIndex = 39;
            this.groupBox_AcquisitionResults.TabStop = false;
            this.groupBox_AcquisitionResults.Text = "Acquisition Results";
            this.groupBox_AcquisitionResults.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox_JobN_TotalError);
            this.groupBox1.Controls.Add(this.textBox_JobN_TotalAcquisitionErrors);
            this.groupBox1.Controls.Add(this.textBox_JobN_MaxThroughput);
            this.groupBox1.Controls.Add(this.textBox_JobN_TotalWarning);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(197, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 129);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Резултати Инспекция 2";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(323, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "%";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(235, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(52, 20);
            this.textBox5.TabIndex = 39;
            this.textBox5.Text = "0";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_TotalError
            // 
            this.textBox_JobN_TotalError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalError.Location = new System.Drawing.Point(163, 93);
            this.textBox_JobN_TotalError.Name = "textBox_JobN_TotalError";
            this.textBox_JobN_TotalError.ReadOnly = true;
            this.textBox_JobN_TotalError.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalError.TabIndex = 36;
            this.textBox_JobN_TotalError.Text = "textBox3";
            this.textBox_JobN_TotalError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_MaxThroughput
            // 
            this.textBox_JobN_MaxThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_MaxThroughput.Location = new System.Drawing.Point(-138, 61);
            this.textBox_JobN_MaxThroughput.Name = "textBox_JobN_MaxThroughput";
            this.textBox_JobN_MaxThroughput.ReadOnly = true;
            this.textBox_JobN_MaxThroughput.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_MaxThroughput.TabIndex = 28;
            this.textBox_JobN_MaxThroughput.Text = "textBox1";
            this.textBox_JobN_MaxThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_TotalWarning
            // 
            this.textBox_JobN_TotalWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalWarning.Location = new System.Drawing.Point(-115, 19);
            this.textBox_JobN_TotalWarning.Name = "textBox_JobN_TotalWarning";
            this.textBox_JobN_TotalWarning.ReadOnly = true;
            this.textBox_JobN_TotalWarning.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalWarning.TabIndex = 38;
            this.textBox_JobN_TotalWarning.Text = "textBox4";
            this.textBox_JobN_TotalWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(271, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(155, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(54, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Отхвърлени:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(155, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "0";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(54, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Приети:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(155, 24);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Тотал:";
            // 
            // label_AcquisitionResults_Errors
            // 
            this.label_AcquisitionResults_Errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_Errors.Location = new System.Drawing.Point(54, 50);
            this.label_AcquisitionResults_Errors.Name = "label_AcquisitionResults_Errors";
            this.label_AcquisitionResults_Errors.Size = new System.Drawing.Size(59, 16);
            this.label_AcquisitionResults_Errors.TabIndex = 30;
            this.label_AcquisitionResults_Errors.Text = "Errors:";
            // 
            // textBox_JobN_TotalAcquisitions
            // 
            this.textBox_JobN_TotalAcquisitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitions.Location = new System.Drawing.Point(114, 26);
            this.textBox_JobN_TotalAcquisitions.Name = "textBox_JobN_TotalAcquisitions";
            this.textBox_JobN_TotalAcquisitions.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitions.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAcquisitions.TabIndex = 28;
            this.textBox_JobN_TotalAcquisitions.Text = "textBox1";
            this.textBox_JobN_TotalAcquisitions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_AcquisitionResults_TotalAcquisitions
            // 
            this.label_AcquisitionResults_TotalAcquisitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_TotalAcquisitions.Location = new System.Drawing.Point(24, 26);
            this.label_AcquisitionResults_TotalAcquisitions.Name = "label_AcquisitionResults_TotalAcquisitions";
            this.label_AcquisitionResults_TotalAcquisitions.Size = new System.Drawing.Size(61, 16);
            this.label_AcquisitionResults_TotalAcquisitions.TabIndex = 27;
            this.label_AcquisitionResults_TotalAcquisitions.Text = "Total Acquisitions:";
            // 
            // label_JobThroughput_persec
            // 
            this.label_JobThroughput_persec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_persec.Location = new System.Drawing.Point(457, 36);
            this.label_JobThroughput_persec.Name = "label_JobThroughput_persec";
            this.label_JobThroughput_persec.Size = new System.Drawing.Size(96, 16);
            this.label_JobThroughput_persec.TabIndex = 29;
            this.label_JobThroughput_persec.Text = "per sec";
            // 
            // groupBox_JobThroughput
            // 
            this.groupBox_JobThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_persec);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_MinThroughput);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_Max);
            this.groupBox_JobThroughput.Controls.Add(this.groupBox2);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobResults_Warning);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobResults_Error);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_Min);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_Throughput);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_TotalThroughput);
            this.groupBox_JobThroughput.Location = new System.Drawing.Point(443, 341);
            this.groupBox_JobThroughput.Name = "groupBox_JobThroughput";
            this.groupBox_JobThroughput.Size = new System.Drawing.Size(141, 137);
            this.groupBox_JobThroughput.TabIndex = 38;
            this.groupBox_JobThroughput.TabStop = false;
            this.groupBox_JobThroughput.Text = "Job Throughput";
            this.groupBox_JobThroughput.Visible = false;
            // 
            // textBox_JobN_MinThroughput
            // 
            this.textBox_JobN_MinThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_MinThroughput.Location = new System.Drawing.Point(282, 60);
            this.textBox_JobN_MinThroughput.Name = "textBox_JobN_MinThroughput";
            this.textBox_JobN_MinThroughput.ReadOnly = true;
            this.textBox_JobN_MinThroughput.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_MinThroughput.TabIndex = 27;
            this.textBox_JobN_MinThroughput.Text = "textBox1";
            this.textBox_JobN_MinThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobThroughput_Max
            // 
            this.label_JobThroughput_Max.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_Max.Location = new System.Drawing.Point(46, 139);
            this.label_JobThroughput_Max.Name = "label_JobThroughput_Max";
            this.label_JobThroughput_Max.Size = new System.Drawing.Size(243, 16);
            this.label_JobThroughput_Max.TabIndex = 26;
            this.label_JobThroughput_Max.Text = "Max:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox_AcquisitionResults);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(224, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 111);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Резултати Инспекция 3";
            this.groupBox2.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(447, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "%";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(279, 72);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 33;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(54, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Отхвърлени:";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(279, 48);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 29;
            this.textBox7.Text = "0";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(54, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(329, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Приети:";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(279, 24);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(24, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Тотал:";
            // 
            // label_JobResults_Warning
            // 
            this.label_JobResults_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Warning.AutoSize = true;
            this.label_JobResults_Warning.Location = new System.Drawing.Point(24, 73);
            this.label_JobResults_Warning.Name = "label_JobResults_Warning";
            this.label_JobResults_Warning.Size = new System.Drawing.Size(50, 13);
            this.label_JobResults_Warning.TabIndex = 34;
            this.label_JobResults_Warning.Text = "Warning:";
            // 
            // label_JobResults_Error
            // 
            this.label_JobResults_Error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Error.AutoSize = true;
            this.label_JobResults_Error.Location = new System.Drawing.Point(33, 57);
            this.label_JobResults_Error.Name = "label_JobResults_Error";
            this.label_JobResults_Error.Size = new System.Drawing.Size(32, 13);
            this.label_JobResults_Error.TabIndex = 35;
            this.label_JobResults_Error.Text = "Error:";
            // 
            // label_JobThroughput_Min
            // 
            this.label_JobThroughput_Min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_Min.Location = new System.Drawing.Point(45, 114);
            this.label_JobThroughput_Min.Name = "label_JobThroughput_Min";
            this.label_JobThroughput_Min.Size = new System.Drawing.Size(243, 16);
            this.label_JobThroughput_Min.TabIndex = 25;
            this.label_JobThroughput_Min.Text = "Min:";
            // 
            // textBox_JobN_Throughput
            // 
            this.textBox_JobN_Throughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_Throughput.Location = new System.Drawing.Point(282, 36);
            this.textBox_JobN_Throughput.Name = "textBox_JobN_Throughput";
            this.textBox_JobN_Throughput.ReadOnly = true;
            this.textBox_JobN_Throughput.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_Throughput.TabIndex = 24;
            this.textBox_JobN_Throughput.Text = "textBox1";
            this.textBox_JobN_Throughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobThroughput_TotalThroughput
            // 
            this.label_JobThroughput_TotalThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_TotalThroughput.AutoSize = true;
            this.label_JobThroughput_TotalThroughput.Location = new System.Drawing.Point(24, 31);
            this.label_JobThroughput_TotalThroughput.Name = "label_JobThroughput_TotalThroughput";
            this.label_JobThroughput_TotalThroughput.Size = new System.Drawing.Size(92, 13);
            this.label_JobThroughput_TotalThroughput.TabIndex = 23;
            this.label_JobThroughput_TotalThroughput.Text = "Total Throughput:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl1);
            this.panel5.Controls.Add(this.splitter2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label_controlErrorMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 34);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(907, 500);
            this.panel5.TabIndex = 26;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 494);
            this.tabControl1.TabIndex = 31;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fitterToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // fitterToolStripMenuItem
            // 
            this.fitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ivanIvanovToolStripMenuItem,
            this.stoqnIvanovToolStripMenuItem,
            this.aleksandurDimitrovToolStripMenuItem});
            this.fitterToolStripMenuItem.Name = "fitterToolStripMenuItem";
            this.fitterToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.fitterToolStripMenuItem.Text = "Fitter";
            // 
            // ivanIvanovToolStripMenuItem
            // 
            this.ivanIvanovToolStripMenuItem.Name = "ivanIvanovToolStripMenuItem";
            this.ivanIvanovToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ivanIvanovToolStripMenuItem.Text = "Ivan Ivanov";
            this.ivanIvanovToolStripMenuItem.Click += new System.EventHandler(this.ivanIvanovToolStripMenuItem_Click);
            // 
            // stoqnIvanovToolStripMenuItem
            // 
            this.stoqnIvanovToolStripMenuItem.Name = "stoqnIvanovToolStripMenuItem";
            this.stoqnIvanovToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.stoqnIvanovToolStripMenuItem.Text = "Stoqn Ivanov";
            this.stoqnIvanovToolStripMenuItem.Click += new System.EventHandler(this.stoqnIvanovToolStripMenuItem_Click);
            // 
            // aleksandurDimitrovToolStripMenuItem
            // 
            this.aleksandurDimitrovToolStripMenuItem.Name = "aleksandurDimitrovToolStripMenuItem";
            this.aleksandurDimitrovToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.aleksandurDimitrovToolStripMenuItem.Text = "Aleksandur Dimitrov";
            this.aleksandurDimitrovToolStripMenuItem.Click += new System.EventHandler(this.aleksandurDimitrovToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cogRecordsDisplay1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "1 Display";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cogRecordsDisplay1
            // 
            this.cogRecordsDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordsDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordsDisplay1.Name = "cogRecordsDisplay1";
            this.cogRecordsDisplay1.SelectedRecordKey = null;
            this.cogRecordsDisplay1.ShowRecordsDropDown = true;
            this.cogRecordsDisplay1.Size = new System.Drawing.Size(406, 462);
            this.cogRecordsDisplay1.Subject = null;
            this.cogRecordsDisplay1.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(423, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(6, 494);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl_JobTabs);
            this.panel6.Controls.Add(this.pictureBox_Logo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(429, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 494);
            this.panel6.TabIndex = 27;
            // 
            // tabControl_JobTabs
            // 
            this.tabControl_JobTabs.Controls.Add(this.tabPage_JobN_JobStatistics);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job0_MailSettings);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job0_AddRemoveTeamMember);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job0_SupervisorControls);
            this.tabControl_JobTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_JobTabs.Location = new System.Drawing.Point(0, 0);
            this.tabControl_JobTabs.Name = "tabControl_JobTabs";
            this.tabControl_JobTabs.SelectedIndex = 0;
            this.tabControl_JobTabs.Size = new System.Drawing.Size(475, 476);
            this.tabControl_JobTabs.TabIndex = 28;
            this.tabControl_JobTabs.Tag = "";
            // 
            // tabPage_JobN_JobStatistics
            // 
            this.tabPage_JobN_JobStatistics.AutoScroll = true;
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_JobResults);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_JobThroughput);
            this.tabPage_JobN_JobStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_JobN_JobStatistics.Name = "tabPage_JobN_JobStatistics";
            this.tabPage_JobN_JobStatistics.Size = new System.Drawing.Size(467, 450);
            this.tabPage_JobN_JobStatistics.TabIndex = 0;
            this.tabPage_JobN_JobStatistics.Text = "Statistics";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(311, 143);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(133, 23);
            this.button9.TabIndex = 46;
            this.button9.Text = "Show Summary Defects\r\n\r\n";
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(197, 143);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 23);
            this.button8.TabIndex = 45;
            this.button8.Text = "Show Defect List\r\n";
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox_JobResults
            // 
            this.groupBox_JobResults.Controls.Add(this.button9);
            this.groupBox_JobResults.Controls.Add(this.textBox9);
            this.groupBox_JobResults.Controls.Add(this.button_ResetStatistics);
            this.groupBox_JobResults.Controls.Add(this.label9);
            this.groupBox_JobResults.Controls.Add(this.button8);
            this.groupBox_JobResults.Controls.Add(this.button1);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Percent);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalReject);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Reject);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalAccept);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Accept);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalIterations);
            this.groupBox_JobResults.Controls.Add(this.button_ResetStatisticsForAllJobs);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_TotalIterations);
            this.groupBox_JobResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_JobResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_JobResults.Location = new System.Drawing.Point(0, 0);
            this.groupBox_JobResults.Name = "groupBox_JobResults";
            this.groupBox_JobResults.Size = new System.Drawing.Size(450, 295);
            this.groupBox_JobResults.TabIndex = 37;
            this.groupBox_JobResults.TabStop = false;
            this.groupBox_JobResults.Text = "Job Results Inspection1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 47;
            this.label9.Visible = false;
            // 
            // label_JobResults_Percent
            // 
            this.label_JobResults_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Percent.Location = new System.Drawing.Point(432, 55);
            this.label_JobResults_Percent.Name = "label_JobResults_Percent";
            this.label_JobResults_Percent.Size = new System.Drawing.Size(34, 16);
            this.label_JobResults_Percent.TabIndex = 40;
            this.label_JobResults_Percent.Text = "%";
            this.label_JobResults_Percent.Visible = false;
            // 
            // textBox_JobN_TotalReject
            // 
            this.textBox_JobN_TotalReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalReject.Location = new System.Drawing.Point(117, 92);
            this.textBox_JobN_TotalReject.Name = "textBox_JobN_TotalReject";
            this.textBox_JobN_TotalReject.ReadOnly = true;
            this.textBox_JobN_TotalReject.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalReject.TabIndex = 33;
            this.textBox_JobN_TotalReject.Text = "0";
            this.textBox_JobN_TotalReject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Reject
            // 
            this.label_JobResults_Reject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Reject.AutoSize = true;
            this.label_JobResults_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_JobResults_Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_JobResults_Reject.Location = new System.Drawing.Point(54, 96);
            this.label_JobResults_Reject.Name = "label_JobResults_Reject";
            this.label_JobResults_Reject.Size = new System.Drawing.Size(52, 13);
            this.label_JobResults_Reject.TabIndex = 31;
            this.label_JobResults_Reject.Text = "Reject :";
            // 
            // textBox_JobN_TotalAccept
            // 
            this.textBox_JobN_TotalAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAccept.Location = new System.Drawing.Point(117, 68);
            this.textBox_JobN_TotalAccept.Name = "textBox_JobN_TotalAccept";
            this.textBox_JobN_TotalAccept.ReadOnly = true;
            this.textBox_JobN_TotalAccept.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAccept.TabIndex = 29;
            this.textBox_JobN_TotalAccept.Text = "0";
            this.textBox_JobN_TotalAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Accept
            // 
            this.label_JobResults_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Accept.AutoSize = true;
            this.label_JobResults_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_JobResults_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_JobResults_Accept.Location = new System.Drawing.Point(55, 72);
            this.label_JobResults_Accept.Name = "label_JobResults_Accept";
            this.label_JobResults_Accept.Size = new System.Drawing.Size(55, 13);
            this.label_JobResults_Accept.TabIndex = 28;
            this.label_JobResults_Accept.Text = "Accept :";
            // 
            // textBox_JobN_TotalIterations
            // 
            this.textBox_JobN_TotalIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalIterations.Location = new System.Drawing.Point(117, 44);
            this.textBox_JobN_TotalIterations.Name = "textBox_JobN_TotalIterations";
            this.textBox_JobN_TotalIterations.ReadOnly = true;
            this.textBox_JobN_TotalIterations.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalIterations.TabIndex = 26;
            this.textBox_JobN_TotalIterations.Text = "0";
            this.textBox_JobN_TotalIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalIterations.TextChanged += new System.EventHandler(this.textBox_JobN_TotalIterations_TextChanged);
            // 
            // label_JobResults_TotalIterations
            // 
            this.label_JobResults_TotalIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_TotalIterations.AutoSize = true;
            this.label_JobResults_TotalIterations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_JobResults_TotalIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_JobResults_TotalIterations.Location = new System.Drawing.Point(4, 47);
            this.label_JobResults_TotalIterations.Name = "label_JobResults_TotalIterations";
            this.label_JobResults_TotalIterations.Size = new System.Drawing.Size(101, 13);
            this.label_JobResults_TotalIterations.TabIndex = 25;
            this.label_JobResults_TotalIterations.Text = "Total Iterations :";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(196, 198);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(168, 20);
            this.textBox9.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Изпрати Email до:";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ResetStatistics
            // 
            this.button_ResetStatistics.Location = new System.Drawing.Point(197, 266);
            this.button_ResetStatistics.Name = "button_ResetStatistics";
            this.button_ResetStatistics.Size = new System.Drawing.Size(108, 23);
            this.button_ResetStatistics.TabIndex = 41;
            this.button_ResetStatistics.Text = "Reset Statistics";
            this.button_ResetStatistics.Visible = false;
            this.button_ResetStatistics.Click += new System.EventHandler(this.button_ResetStatistics_Click);
            // 
            // button_ResetStatisticsForAllJobs
            // 
            this.button_ResetStatisticsForAllJobs.Location = new System.Drawing.Point(22, 143);
            this.button_ResetStatisticsForAllJobs.Name = "button_ResetStatisticsForAllJobs";
            this.button_ResetStatisticsForAllJobs.Size = new System.Drawing.Size(168, 23);
            this.button_ResetStatisticsForAllJobs.TabIndex = 40;
            this.button_ResetStatisticsForAllJobs.Text = "Reset Statistics For All Jobs";
            this.button_ResetStatisticsForAllJobs.Click += new System.EventHandler(this.button_ResetStatisticsForAllJobs_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 476);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(475, 18);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Logo.TabIndex = 27;
            this.pictureBox_Logo.TabStop = false;
            // 
            // label_controlErrorMessage
            // 
            this.label_controlErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_controlErrorMessage.Location = new System.Drawing.Point(3, 3);
            this.label_controlErrorMessage.Name = "label_controlErrorMessage";
            this.label_controlErrorMessage.Size = new System.Drawing.Size(901, 494);
            this.label_controlErrorMessage.TabIndex = 30;
            this.label_controlErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label_ResultBar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel4.Size = new System.Drawing.Size(913, 537);
            this.panel4.TabIndex = 0;
            // 
            // label_ResultBar
            // 
            this.label_ResultBar.BackColor = System.Drawing.SystemColors.Control;
            this.label_ResultBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ResultBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultBar.Location = new System.Drawing.Point(3, 5);
            this.label_ResultBar.Name = "label_ResultBar";
            this.label_ResultBar.Size = new System.Drawing.Size(907, 29);
            this.label_ResultBar.TabIndex = 25;
            this.label_ResultBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(773, 62);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(130, 38);
            this.btnRun.TabIndex = 43;
            this.btnRun.Text = "Run Once";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 160);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(913, 5);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(913, 537);
            this.panel3.TabIndex = 37;
            // 
            // btnRunCont
            // 
            this.btnRunCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCont.Location = new System.Drawing.Point(772, 16);
            this.btnRunCont.Name = "btnRunCont";
            this.btnRunCont.Size = new System.Drawing.Size(130, 40);
            this.btnRunCont.TabIndex = 42;
            this.btnRunCont.Text = "Run Continuously";
            this.btnRunCont.Click += new System.EventHandler(this.btnRunCont_Click);
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Login.Location = new System.Drawing.Point(773, 116);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.Size = new System.Drawing.Size(129, 24);
            this.comboBox_Login.TabIndex = 41;
            this.comboBox_Login.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Login_SelectionChangeCommitted);
            // 
            // button_SaveSettings
            // 
            this.button_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveSettings.Location = new System.Drawing.Point(641, 65);
            this.button_SaveSettings.Name = "button_SaveSettings";
            this.button_SaveSettings.Size = new System.Drawing.Size(104, 30);
            this.button_SaveSettings.TabIndex = 47;
            this.button_SaveSettings.Text = "Save Settings...";
            this.button_SaveSettings.Click += new System.EventHandler(this.button_SaveSettings_Click);
            // 
            // checkBox_LiveDisplay
            // 
            this.checkBox_LiveDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_LiveDisplay.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_LiveDisplay.Location = new System.Drawing.Point(529, 65);
            this.checkBox_LiveDisplay.Name = "checkBox_LiveDisplay";
            this.checkBox_LiveDisplay.Size = new System.Drawing.Size(104, 30);
            this.checkBox_LiveDisplay.TabIndex = 46;
            this.checkBox_LiveDisplay.Text = "Live Image";
            this.checkBox_LiveDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_LiveDisplay.Visible = false;
            this.checkBox_LiveDisplay.CheckedChanged += new System.EventHandler(this.checkBox_LiveDisplay_CheckedChanged);
            // 
            // button_About
            // 
            this.button_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_About.Location = new System.Drawing.Point(529, 26);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(104, 30);
            this.button_About.TabIndex = 44;
            this.button_About.Text = "About...";
            this.button_About.Visible = false;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // groupBox_DividerLine
            // 
            this.groupBox_DividerLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_DividerLine.Location = new System.Drawing.Point(757, 10);
            this.groupBox_DividerLine.Name = "groupBox_DividerLine";
            this.groupBox_DividerLine.Size = new System.Drawing.Size(3, 95);
            this.groupBox_DividerLine.TabIndex = 48;
            this.groupBox_DividerLine.TabStop = false;
            // 
            // label_Online
            // 
            this.label_Online.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Online.AutoSize = true;
            this.label_Online.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Online.Location = new System.Drawing.Point(784, 103);
            this.label_Online.Name = "label_Online";
            this.label_Online.Size = new System.Drawing.Size(119, 15);
            this.label_Online.TabIndex = 51;
            this.label_Online.Text = "System online status";
            this.label_Online.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cogJobResultHistoryCollectionEdit1);
            this.panel2.Location = new System.Drawing.Point(9, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 145);
            this.panel2.TabIndex = 50;
            // 
            // cogJobResultHistoryCollectionEdit1
            // 
            this.cogJobResultHistoryCollectionEdit1.AutoScroll = true;
            this.cogJobResultHistoryCollectionEdit1.Location = new System.Drawing.Point(-8, 0);
            this.cogJobResultHistoryCollectionEdit1.Name = "cogJobResultHistoryCollectionEdit1";
            this.cogJobResultHistoryCollectionEdit1.Padding = new System.Windows.Forms.Padding(4);
            this.cogJobResultHistoryCollectionEdit1.SelectedIndex = -1;
            this.cogJobResultHistoryCollectionEdit1.SelectorControlHeight = 29;
            this.cogJobResultHistoryCollectionEdit1.Size = new System.Drawing.Size(805, 39);
            this.cogJobResultHistoryCollectionEdit1.Subject = null;
            this.cogJobResultHistoryCollectionEdit1.TabIndex = 43;
            this.cogJobResultHistoryCollectionEdit1.SelectedIndexChanged += new System.EventHandler(this.cogJobResultHistoryCollectionEdit1_SelectedJobIndexChanged);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(529, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 27);
            this.button7.TabIndex = 46;
            this.button7.Text = "Team";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(529, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 26);
            this.button2.TabIndex = 45;
            this.button2.Text = "Keyboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Login
            // 
            this.label_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(654, 118);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(106, 21);
            this.label_Login.TabIndex = 49;
            this.label_Login.Text = "Current login:";
            // 
            // button_Configuration
            // 
            this.button_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Configuration.Location = new System.Drawing.Point(641, 26);
            this.button_Configuration.Name = "button_Configuration";
            this.button_Configuration.Size = new System.Drawing.Size(104, 30);
            this.button_Configuration.TabIndex = 45;
            this.button_Configuration.Text = "Configuration...";
            this.button_Configuration.Click += new System.EventHandler(this.button_Configuration_Click);
            // 
            // applicationErrorProvider
            // 
            this.applicationErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.label_Online);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Login);
            this.panel1.Controls.Add(this.comboBox_Login);
            this.panel1.Controls.Add(this.button_SaveSettings);
            this.panel1.Controls.Add(this.checkBox_LiveDisplay);
            this.panel1.Controls.Add(this.button_About);
            this.panel1.Controls.Add(this.groupBox_DividerLine);
            this.panel1.Controls.Add(this.button_Configuration);
            this.panel1.Controls.Add(this.btnRunCont);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 160);
            this.panel1.TabIndex = 36;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(529, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 30);
            this.checkBox1.TabIndex = 53;
            this.checkBox1.Text = "Main Menu";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_time.Location = new System.Drawing.Point(531, 23);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(104, 33);
            this.label_time.TabIndex = 52;
            this.label_time.Text = "TIME";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisionControl.strings.checkin_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // VisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "VisionControl";
            this.Size = new System.Drawing.Size(913, 697);
            this.Load += new System.EventHandler(this.VisionControl_Load);
            this.tabPage_Job0_MailSettings.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage_Job0_AddRemoveTeamMember.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.tabPage_Job0_SupervisorControls.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox_AcquisitionResults.ResumeLayout(false);
            this.groupBox_AcquisitionResults.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_JobThroughput.ResumeLayout(false);
            this.groupBox_JobThroughput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControl_JobTabs.ResumeLayout(false);
            this.tabPage_JobN_JobStatistics.ResumeLayout(false);
            this.groupBox_JobResults.ResumeLayout(false);
            this.groupBox_JobResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    ///////////////////////// START WIZARD GENERATED
    // cognex.wizard.controldeclarations.begin
    private TabPage tabPage_Job0_MailSettings;
    private TabPage tabPage_Job0_AddRemoveTeamMember;
    private TabPage tabPage_Job0_SupervisorControls;
    // cognex.wizard.controldeclarations.end
    ///////////////////////// END WIZARD GENERATED

    private System.Windows.Forms.Label label_AcquisitionResults_Overruns;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAcquisitionErrors;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAcquisitionOverruns;
    private System.Windows.Forms.GroupBox groupBox_AcquisitionResults;
    private System.Windows.Forms.Label label_AcquisitionResults_Errors;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAcquisitions;
    private System.Windows.Forms.Label label_AcquisitionResults_TotalAcquisitions;
    private System.Windows.Forms.Label label_JobThroughput_persec;
    private System.Windows.Forms.GroupBox groupBox_JobThroughput;
    private System.Windows.Forms.TextBox textBox_JobN_MaxThroughput;
    private System.Windows.Forms.TextBox textBox_JobN_MinThroughput;
    private System.Windows.Forms.Label label_JobThroughput_Max;
    private System.Windows.Forms.Label label_JobThroughput_Min;
    private System.Windows.Forms.TextBox textBox_JobN_Throughput;
    private System.Windows.Forms.Label label_JobThroughput_TotalThroughput;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Splitter splitter2;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TabControl tabControl_JobTabs;
    private System.Windows.Forms.TabPage tabPage_JobN_JobStatistics;
    private System.Windows.Forms.Button button_ResetStatistics;
    private System.Windows.Forms.Button button_ResetStatisticsForAllJobs;
    private System.Windows.Forms.GroupBox groupBox_JobResults;
    private System.Windows.Forms.Label label_JobResults_Percent;
    private System.Windows.Forms.TextBox textBox_JobN_TotalWarning;
    private System.Windows.Forms.TextBox textBox_JobN_TotalError;
    private System.Windows.Forms.Label label_JobResults_Error;
    private System.Windows.Forms.Label label_JobResults_Warning;
    private System.Windows.Forms.TextBox textBox_JobN_TotalReject;
    private System.Windows.Forms.Label label_JobResults_Reject;
    private System.Windows.Forms.TextBox textBox_JobN_TotalAccept;
    private System.Windows.Forms.Label label_JobResults_Accept;
    private System.Windows.Forms.TextBox textBox_JobN_TotalIterations;
    private System.Windows.Forms.Label label_JobResults_TotalIterations;

    private System.Windows.Forms.PictureBox pictureBox_Logo;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label_ResultBar;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btnRunCont;
    private System.Windows.Forms.ComboBox comboBox_Login;
    private System.Windows.Forms.Button button_SaveSettings;
    private System.Windows.Forms.CheckBox checkBox_LiveDisplay;
    private System.Windows.Forms.Button button_About;
    private System.Windows.Forms.GroupBox groupBox_DividerLine;
    private System.Windows.Forms.Label label_Online;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label_Login;
    private System.Windows.Forms.Button button_Configuration;
    private System.Windows.Forms.ErrorProvider applicationErrorProvider;
    private System.Windows.Forms.Panel panel1;
    private Cognex.VisionPro.QuickBuild.CogJobResultHistoryCollectionEdit cogJobResultHistoryCollectionEdit1;
    private System.Windows.Forms.Label label_controlErrorMessage;
    private Label label_time;
    private Timer timer1;
    private TabControl tabControl1;
    private TabPage tabPage2;
    private GroupBox groupBox2;
    private Label label5;
    private TextBox textBox5;
    private TextBox textBox6;
    private Label label6;
    private TextBox textBox7;
    private Label label7;
    private TextBox textBox8;
    private Label label8;
    private GroupBox groupBox1;
    private Label label1;
    private TextBox textBox1;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox3;
    private Label label3;
    private TextBox textBox4;
    private Label label4;
    private CheckBox checkBox1;
    private TextBox textBox9;
    private Button button1;
    private Button button2;
    private Button button3;
    private GroupBox groupBox3;
    private Button button6;
    private Button button5;
    private Button button4;
    private GroupBox groupBox4;
    private Button button7;
    private ContextMenuStrip contextMenuStrip1;
    private GroupBox groupBox12;
    private ComboBox comboBox6;
    private Label label70;
    private Button button11;
    private GroupBox groupBox13;
    private Label label50;
    private Button button12;
    private TextBox textBox66;
    private Label label9;
    private ToolStripMenuItem fitterToolStripMenuItem;
    private ToolStripMenuItem ivanIvanovToolStripMenuItem;
    private ToolStripMenuItem stoqnIvanovToolStripMenuItem;
    private ToolStripMenuItem aleksandurDimitrovToolStripMenuItem;
    private Cognex.VisionPro.CogRecordsDisplay cogRecordsDisplay1;
    private Button button8;
    private Button button9;
    private PictureBox pictureBox1;
  }
}
