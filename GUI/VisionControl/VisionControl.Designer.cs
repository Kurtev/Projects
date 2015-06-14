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
            this.cogToolPropertyProvider0 = new Cognex.VisionPro.CogToolPropertyProvider();
            this.cogToolPropertyProvider1 = new Cognex.VisionPro.CogToolPropertyProvider();
            this.cogToolPropertyProvider2 = new Cognex.VisionPro.CogToolPropertyProvider();
            this.tabPage_Job0_BagInspection1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Seals = new System.Windows.Forms.GroupBox();
            this.textBox_Job0_hiMm_1 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_hiMm_1 = new System.Windows.Forms.Label();
            this.label_Job0_hiMm = new System.Windows.Forms.Label();
            this.textBox_Job0_hiMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.textBox_Job0_GlandPositionXMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_GlandPositionXMm = new System.Windows.Forms.Label();
            this.label_Job0_lowMm = new System.Windows.Forms.Label();
            this.label_Job0_hiMm_2 = new System.Windows.Forms.Label();
            this.textBox_Job0_lowMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.textBox_Job0_hiMm_2 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_lowMm_2 = new System.Windows.Forms.Label();
            this.textBox_Job0_lowMm_2 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_hiMm_3 = new System.Windows.Forms.Label();
            this.textBox_Job0_hiMm_3 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_lowMm_3 = new System.Windows.Forms.Label();
            this.textBox_Job0_lowMm_3 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_hiMm_4 = new System.Windows.Forms.Label();
            this.textBox_Job0_hiMm_4 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_lowMm_4 = new System.Windows.Forms.Label();
            this.textBox_Job0_lowMm_4 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.groupBox_Gland = new System.Windows.Forms.GroupBox();
            this.textBox_Job2_GlandHighMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.textBox_Job1_RightVerticalSealMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job2_GlandHighMm = new System.Windows.Forms.Label();
            this.label_Job1_RightVerticalSealMm = new System.Windows.Forms.Label();
            this.textBox_Job0_LeftVerticalSealMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.textBox_Job0_HorisontalSeal2Mm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.textBox_Job0_GlandSealRadiusMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_lowMm_1 = new System.Windows.Forms.Label();
            this.label_Job0_LeftVerticalSealMm = new System.Windows.Forms.Label();
            this.textBox_Job0_HorisontalSeal1Mm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job0_HorisontalSeal2Mm = new System.Windows.Forms.Label();
            this.label_Job0_HorisontalSeal1Mm = new System.Windows.Forms.Label();
            this.label_Job0_GlandSealRadiusMm = new System.Windows.Forms.Label();
            this.textBox_Job0_lowMm_1 = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.tabPage_Job1_BagInspection2 = new System.Windows.Forms.TabPage();
            this.groupBox_Seals_1 = new System.Windows.Forms.GroupBox();
            this.label_Job1_hiMm = new System.Windows.Forms.Label();
            this.textBox_Job1_hiMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job1_lowMm = new System.Windows.Forms.Label();
            this.textBox_Job1_lowMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.tabPage_Job2_BagInspection3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox_Gland_1 = new System.Windows.Forms.GroupBox();
            this.label_Job2_hiMm = new System.Windows.Forms.Label();
            this.textBox_Job2_hiMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_Job2_lowMm = new System.Windows.Forms.Label();
            this.textBox_Job2_lowMm = new Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox();
            this.label_AcquisitionResults_Overruns = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAcquisitionErrors = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalAcquisitionOverruns = new System.Windows.Forms.TextBox();
            this.groupBox_AcquisitionResults = new System.Windows.Forms.GroupBox();
            this.label_AcquisitionResults_Errors = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAcquisitions = new System.Windows.Forms.TextBox();
            this.label_AcquisitionResults_TotalAcquisitions = new System.Windows.Forms.Label();
            this.label_JobThroughput_persec = new System.Windows.Forms.Label();
            this.groupBox_JobThroughput = new System.Windows.Forms.GroupBox();
            this.textBox_JobN_MaxThroughput = new System.Windows.Forms.TextBox();
            this.textBox_JobN_MinThroughput = new System.Windows.Forms.TextBox();
            this.label_JobThroughput_Max = new System.Windows.Forms.Label();
            this.label_JobThroughput_Min = new System.Windows.Forms.Label();
            this.label_JobResults_Error = new System.Windows.Forms.Label();
            this.textBox_JobN_Throughput = new System.Windows.Forms.TextBox();
            this.label_JobThroughput_TotalThroughput = new System.Windows.Forms.Label();
            this.button_ResetStatisticsForAllJobs = new System.Windows.Forms.Button();
            this.button_ResetStatistics = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cogRecordsDisplay1 = new Cognex.VisionPro.CogRecordsDisplay();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl_JobTabs = new System.Windows.Forms.TabControl();
            this.tabPage_JobN_JobStatistics = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_JobResults = new System.Windows.Forms.GroupBox();
            this.label_JobResults_Percent = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAccept_Percent = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalWarning = new System.Windows.Forms.TextBox();
            this.textBox_JobN_TotalError = new System.Windows.Forms.TextBox();
            this.label_JobResults_Warning = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalReject = new System.Windows.Forms.TextBox();
            this.label_JobResults_Reject = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalAccept = new System.Windows.Forms.TextBox();
            this.label_JobResults_Accept = new System.Windows.Forms.Label();
            this.textBox_JobN_TotalIterations = new System.Windows.Forms.TextBox();
            this.label_JobResults_TotalIterations = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.label_controlErrorMessage = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_ResultBar = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.button_SaveSettings = new System.Windows.Forms.Button();
            this.checkBox_LiveDisplay = new System.Windows.Forms.CheckBox();
            this.button_About = new System.Windows.Forms.Button();
            this.groupBox_DividerLine = new System.Windows.Forms.GroupBox();
            this.label_Online = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cogJobResultHistoryCollectionEdit1 = new Cognex.VisionPro.QuickBuild.CogJobResultHistoryCollectionEdit();
            this.label_Login = new System.Windows.Forms.Label();
            this.button_Configuration = new System.Windows.Forms.Button();
            this.applicationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRunCont = new System.Windows.Forms.Button();
            this.tabPage_Job0_BagInspection1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Seals.SuspendLayout();
            this.groupBox_Gland.SuspendLayout();
            this.tabPage_Job1_BagInspection2.SuspendLayout();
            this.groupBox_Seals_1.SuspendLayout();
            this.tabPage_Job2_BagInspection3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_Gland_1.SuspendLayout();
            this.groupBox_AcquisitionResults.SuspendLayout();
            this.groupBox_JobThroughput.SuspendLayout();
            this.panel5.SuspendLayout();
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
            // cogToolPropertyProvider0
            // 
            this.cogToolPropertyProvider0.ElectricProvider = null;
            this.cogToolPropertyProvider0.EnableDelegateQueuing = false;
            this.cogToolPropertyProvider0.ErrorProvider = null;
            this.cogToolPropertyProvider0.Subject = null;
            this.cogToolPropertyProvider0.SubjectInUse = false;
            // 
            // cogToolPropertyProvider1
            // 
            this.cogToolPropertyProvider1.ElectricProvider = null;
            this.cogToolPropertyProvider1.EnableDelegateQueuing = false;
            this.cogToolPropertyProvider1.ErrorProvider = null;
            this.cogToolPropertyProvider1.Subject = null;
            this.cogToolPropertyProvider1.SubjectInUse = false;
            // 
            // cogToolPropertyProvider2
            // 
            this.cogToolPropertyProvider2.ElectricProvider = null;
            this.cogToolPropertyProvider2.EnableDelegateQueuing = false;
            this.cogToolPropertyProvider2.ErrorProvider = null;
            this.cogToolPropertyProvider2.Subject = null;
            this.cogToolPropertyProvider2.SubjectInUse = false;
            // 
            // tabPage_Job0_BagInspection1
            // 
            this.tabPage_Job0_BagInspection1.AutoScroll = true;
            this.tabPage_Job0_BagInspection1.Controls.Add(this.groupBox1);
            this.tabPage_Job0_BagInspection1.Controls.Add(this.groupBox_Seals);
            this.tabPage_Job0_BagInspection1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job0_BagInspection1.Name = "tabPage_Job0_BagInspection1";
            this.tabPage_Job0_BagInspection1.Size = new System.Drawing.Size(342, 353);
            this.tabPage_Job0_BagInspection1.TabIndex = 0;
            this.tabPage_Job0_BagInspection1.Text = "Bag Specification";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 300);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Bag";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(221, 206);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(70, 20);
            this.textBox10.TabIndex = 21;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(45, 206);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(70, 20);
            this.textBox9.TabIndex = 20;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(221, 167);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(70, 20);
            this.textBox8.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(45, 167);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(70, 20);
            this.textBox7.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(221, 128);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(70, 20);
            this.textBox6.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(45, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(70, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(221, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(221, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bag Capacity";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Bag Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Outer Foil Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bag Lenght";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Insert Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bag Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tap Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tap Depth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tap Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tap Direction";
            // 
            // groupBox_Seals
            // 
            this.groupBox_Seals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_hiMm_1);
            this.groupBox_Seals.Controls.Add(this.label_Job0_hiMm_1);
            this.groupBox_Seals.Controls.Add(this.label_Job0_hiMm);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_hiMm);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_GlandPositionXMm);
            this.groupBox_Seals.Controls.Add(this.label_Job0_GlandPositionXMm);
            this.groupBox_Seals.Controls.Add(this.label_Job0_lowMm);
            this.groupBox_Seals.Controls.Add(this.label_Job0_hiMm_2);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_lowMm);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_hiMm_2);
            this.groupBox_Seals.Controls.Add(this.label_Job0_lowMm_2);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_lowMm_2);
            this.groupBox_Seals.Controls.Add(this.label_Job0_hiMm_3);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_hiMm_3);
            this.groupBox_Seals.Controls.Add(this.label_Job0_lowMm_3);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_lowMm_3);
            this.groupBox_Seals.Controls.Add(this.label_Job0_hiMm_4);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_hiMm_4);
            this.groupBox_Seals.Controls.Add(this.label_Job0_lowMm_4);
            this.groupBox_Seals.Controls.Add(this.textBox_Job0_lowMm_4);
            this.groupBox_Seals.Location = new System.Drawing.Point(6, 348);
            this.groupBox_Seals.Name = "groupBox_Seals";
            this.groupBox_Seals.Size = new System.Drawing.Size(0, 137);
            this.groupBox_Seals.TabIndex = 1;
            this.groupBox_Seals.TabStop = false;
            this.groupBox_Seals.Text = "Seals";
            this.groupBox_Seals.Visible = false;
            // 
            // textBox_Job0_hiMm_1
            // 
            this.textBox_Job0_hiMm_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_hiMm_1.Location = new System.Drawing.Point(-187, 19);
            this.textBox_Job0_hiMm_1.Name = "textBox_Job0_hiMm_1";
            this.textBox_Job0_hiMm_1.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_hiMm_1.TabIndex = 9;
            this.textBox_Job0_hiMm_1.Text = "-1";
            this.textBox_Job0_hiMm_1.Visible = false;
            // 
            // label_Job0_hiMm_1
            // 
            this.label_Job0_hiMm_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_hiMm_1.Location = new System.Drawing.Point(83, 15);
            this.label_Job0_hiMm_1.Name = "label_Job0_hiMm_1";
            this.label_Job0_hiMm_1.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_hiMm_1.TabIndex = 8;
            this.label_Job0_hiMm_1.Text = "hi /mm";
            this.label_Job0_hiMm_1.Visible = false;
            // 
            // label_Job0_hiMm
            // 
            this.label_Job0_hiMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_hiMm.Location = new System.Drawing.Point(27, 19);
            this.label_Job0_hiMm.Name = "label_Job0_hiMm";
            this.label_Job0_hiMm.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_hiMm.TabIndex = 2;
            this.label_Job0_hiMm.Text = "hi /mm";
            this.label_Job0_hiMm.Visible = false;
            // 
            // textBox_Job0_hiMm
            // 
            this.textBox_Job0_hiMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_hiMm.Location = new System.Drawing.Point(-145, 28);
            this.textBox_Job0_hiMm.Name = "textBox_Job0_hiMm";
            this.textBox_Job0_hiMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_hiMm.TabIndex = 3;
            this.textBox_Job0_hiMm.Text = "-1";
            this.textBox_Job0_hiMm.Visible = false;
            // 
            // textBox_Job0_GlandPositionXMm
            // 
            this.textBox_Job0_GlandPositionXMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_GlandPositionXMm.Location = new System.Drawing.Point(-199, 19);
            this.textBox_Job0_GlandPositionXMm.Name = "textBox_Job0_GlandPositionXMm";
            this.textBox_Job0_GlandPositionXMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_GlandPositionXMm.TabIndex = 7;
            this.textBox_Job0_GlandPositionXMm.Text = "-1";
            this.textBox_Job0_GlandPositionXMm.WordWrap = false;
            // 
            // label_Job0_GlandPositionXMm
            // 
            this.label_Job0_GlandPositionXMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_GlandPositionXMm.Location = new System.Drawing.Point(18, 12);
            this.label_Job0_GlandPositionXMm.Name = "label_Job0_GlandPositionXMm";
            this.label_Job0_GlandPositionXMm.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_GlandPositionXMm.TabIndex = 6;
            this.label_Job0_GlandPositionXMm.Text = "Gland Position X /mm";
            this.label_Job0_GlandPositionXMm.Visible = false;
            // 
            // label_Job0_lowMm
            // 
            this.label_Job0_lowMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_lowMm.Location = new System.Drawing.Point(83, 22);
            this.label_Job0_lowMm.Name = "label_Job0_lowMm";
            this.label_Job0_lowMm.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_lowMm.TabIndex = 4;
            this.label_Job0_lowMm.Text = "low /mm";
            this.label_Job0_lowMm.Visible = false;
            // 
            // label_Job0_hiMm_2
            // 
            this.label_Job0_hiMm_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_hiMm_2.Location = new System.Drawing.Point(18, 54);
            this.label_Job0_hiMm_2.Name = "label_Job0_hiMm_2";
            this.label_Job0_hiMm_2.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_hiMm_2.TabIndex = 2;
            this.label_Job0_hiMm_2.Text = "hi /mm";
            // 
            // textBox_Job0_lowMm
            // 
            this.textBox_Job0_lowMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_lowMm.Location = new System.Drawing.Point(-146, 2);
            this.textBox_Job0_lowMm.Name = "textBox_Job0_lowMm";
            this.textBox_Job0_lowMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_lowMm.TabIndex = 5;
            this.textBox_Job0_lowMm.Text = "-1";
            this.textBox_Job0_lowMm.Visible = false;
            // 
            // textBox_Job0_hiMm_2
            // 
            this.textBox_Job0_hiMm_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_hiMm_2.Location = new System.Drawing.Point(-144, 54);
            this.textBox_Job0_hiMm_2.Name = "textBox_Job0_hiMm_2";
            this.textBox_Job0_hiMm_2.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_hiMm_2.TabIndex = 3;
            this.textBox_Job0_hiMm_2.Text = "-1";
            // 
            // label_Job0_lowMm_2
            // 
            this.label_Job0_lowMm_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_lowMm_2.Location = new System.Drawing.Point(18, 84);
            this.label_Job0_lowMm_2.Name = "label_Job0_lowMm_2";
            this.label_Job0_lowMm_2.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_lowMm_2.TabIndex = 4;
            this.label_Job0_lowMm_2.Text = "low /mm";
            // 
            // textBox_Job0_lowMm_2
            // 
            this.textBox_Job0_lowMm_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_lowMm_2.Location = new System.Drawing.Point(-144, 81);
            this.textBox_Job0_lowMm_2.Name = "textBox_Job0_lowMm_2";
            this.textBox_Job0_lowMm_2.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_lowMm_2.TabIndex = 5;
            this.textBox_Job0_lowMm_2.Text = "-1";
            // 
            // label_Job0_hiMm_3
            // 
            this.label_Job0_hiMm_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_hiMm_3.Location = new System.Drawing.Point(18, 144);
            this.label_Job0_hiMm_3.Name = "label_Job0_hiMm_3";
            this.label_Job0_hiMm_3.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_hiMm_3.TabIndex = 8;
            this.label_Job0_hiMm_3.Text = "hi /mm";
            // 
            // textBox_Job0_hiMm_3
            // 
            this.textBox_Job0_hiMm_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_hiMm_3.Location = new System.Drawing.Point(-144, 144);
            this.textBox_Job0_hiMm_3.Name = "textBox_Job0_hiMm_3";
            this.textBox_Job0_hiMm_3.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_hiMm_3.TabIndex = 9;
            this.textBox_Job0_hiMm_3.Text = "-1";
            // 
            // label_Job0_lowMm_3
            // 
            this.label_Job0_lowMm_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_lowMm_3.Location = new System.Drawing.Point(18, 174);
            this.label_Job0_lowMm_3.Name = "label_Job0_lowMm_3";
            this.label_Job0_lowMm_3.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_lowMm_3.TabIndex = 10;
            this.label_Job0_lowMm_3.Text = "low /mm";
            // 
            // textBox_Job0_lowMm_3
            // 
            this.textBox_Job0_lowMm_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_lowMm_3.Location = new System.Drawing.Point(-144, 171);
            this.textBox_Job0_lowMm_3.Name = "textBox_Job0_lowMm_3";
            this.textBox_Job0_lowMm_3.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_lowMm_3.TabIndex = 11;
            this.textBox_Job0_lowMm_3.Text = "-1";
            // 
            // label_Job0_hiMm_4
            // 
            this.label_Job0_hiMm_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_hiMm_4.Location = new System.Drawing.Point(18, 234);
            this.label_Job0_hiMm_4.Name = "label_Job0_hiMm_4";
            this.label_Job0_hiMm_4.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_hiMm_4.TabIndex = 14;
            this.label_Job0_hiMm_4.Text = "hi /mm";
            // 
            // textBox_Job0_hiMm_4
            // 
            this.textBox_Job0_hiMm_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_hiMm_4.Location = new System.Drawing.Point(-145, 234);
            this.textBox_Job0_hiMm_4.Name = "textBox_Job0_hiMm_4";
            this.textBox_Job0_hiMm_4.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_hiMm_4.TabIndex = 15;
            this.textBox_Job0_hiMm_4.Text = "-1";
            // 
            // label_Job0_lowMm_4
            // 
            this.label_Job0_lowMm_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_lowMm_4.Location = new System.Drawing.Point(18, 264);
            this.label_Job0_lowMm_4.Name = "label_Job0_lowMm_4";
            this.label_Job0_lowMm_4.Size = new System.Drawing.Size(0, 23);
            this.label_Job0_lowMm_4.TabIndex = 16;
            this.label_Job0_lowMm_4.Text = "low /mm";
            // 
            // textBox_Job0_lowMm_4
            // 
            this.textBox_Job0_lowMm_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_lowMm_4.Location = new System.Drawing.Point(-144, 261);
            this.textBox_Job0_lowMm_4.Name = "textBox_Job0_lowMm_4";
            this.textBox_Job0_lowMm_4.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_lowMm_4.TabIndex = 17;
            this.textBox_Job0_lowMm_4.Text = "-1";
            // 
            // groupBox_Gland
            // 
            this.groupBox_Gland.Controls.Add(this.textBox_Job2_GlandHighMm);
            this.groupBox_Gland.Controls.Add(this.textBox_Job1_RightVerticalSealMm);
            this.groupBox_Gland.Controls.Add(this.label_Job2_GlandHighMm);
            this.groupBox_Gland.Controls.Add(this.label_Job1_RightVerticalSealMm);
            this.groupBox_Gland.Controls.Add(this.textBox_Job0_LeftVerticalSealMm);
            this.groupBox_Gland.Controls.Add(this.textBox_Job0_HorisontalSeal2Mm);
            this.groupBox_Gland.Controls.Add(this.textBox_Job0_GlandSealRadiusMm);
            this.groupBox_Gland.Controls.Add(this.label_Job0_lowMm_1);
            this.groupBox_Gland.Controls.Add(this.label_Job0_LeftVerticalSealMm);
            this.groupBox_Gland.Controls.Add(this.textBox_Job0_HorisontalSeal1Mm);
            this.groupBox_Gland.Controls.Add(this.label_Job0_HorisontalSeal2Mm);
            this.groupBox_Gland.Controls.Add(this.label_Job0_HorisontalSeal1Mm);
            this.groupBox_Gland.Controls.Add(this.label_Job0_GlandSealRadiusMm);
            this.groupBox_Gland.Controls.Add(this.textBox_Job0_lowMm_1);
            this.groupBox_Gland.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Gland.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Gland.Name = "groupBox_Gland";
            this.groupBox_Gland.Size = new System.Drawing.Size(342, 166);
            this.groupBox_Gland.TabIndex = 0;
            this.groupBox_Gland.TabStop = false;
            this.groupBox_Gland.Text = "Inspection Results";
            // 
            // textBox_Job2_GlandHighMm
            // 
            this.textBox_Job2_GlandHighMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job2_GlandHighMm.Location = new System.Drawing.Point(212, 128);
            this.textBox_Job2_GlandHighMm.Name = "textBox_Job2_GlandHighMm";
            this.textBox_Job2_GlandHighMm.Size = new System.Drawing.Size(104, 20);
            this.textBox_Job2_GlandHighMm.TabIndex = 1;
            this.textBox_Job2_GlandHighMm.Text = "0";
            // 
            // textBox_Job1_RightVerticalSealMm
            // 
            this.textBox_Job1_RightVerticalSealMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job1_RightVerticalSealMm.Location = new System.Drawing.Point(51, 77);
            this.textBox_Job1_RightVerticalSealMm.Name = "textBox_Job1_RightVerticalSealMm";
            this.textBox_Job1_RightVerticalSealMm.Size = new System.Drawing.Size(104, 20);
            this.textBox_Job1_RightVerticalSealMm.TabIndex = 1;
            this.textBox_Job1_RightVerticalSealMm.Text = "0";
            // 
            // label_Job2_GlandHighMm
            // 
            this.label_Job2_GlandHighMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job2_GlandHighMm.Location = new System.Drawing.Point(175, 100);
            this.label_Job2_GlandHighMm.Name = "label_Job2_GlandHighMm";
            this.label_Job2_GlandHighMm.Size = new System.Drawing.Size(123, 23);
            this.label_Job2_GlandHighMm.TabIndex = 0;
            this.label_Job2_GlandHighMm.Text = "Gland High  I/O";
            // 
            // label_Job1_RightVerticalSealMm
            // 
            this.label_Job1_RightVerticalSealMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job1_RightVerticalSealMm.Location = new System.Drawing.Point(14, 55);
            this.label_Job1_RightVerticalSealMm.Name = "label_Job1_RightVerticalSealMm";
            this.label_Job1_RightVerticalSealMm.Size = new System.Drawing.Size(157, 23);
            this.label_Job1_RightVerticalSealMm.TabIndex = 0;
            this.label_Job1_RightVerticalSealMm.Text = "Right Vertical Seal  I/O";
            // 
            // textBox_Job0_LeftVerticalSealMm
            // 
            this.textBox_Job0_LeftVerticalSealMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_LeftVerticalSealMm.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_Job0_LeftVerticalSealMm.Location = new System.Drawing.Point(212, 77);
            this.textBox_Job0_LeftVerticalSealMm.Name = "textBox_Job0_LeftVerticalSealMm";
            this.textBox_Job0_LeftVerticalSealMm.Size = new System.Drawing.Size(104, 20);
            this.textBox_Job0_LeftVerticalSealMm.TabIndex = 13;
            this.textBox_Job0_LeftVerticalSealMm.Text = "0";
            // 
            // textBox_Job0_HorisontalSeal2Mm
            // 
            this.textBox_Job0_HorisontalSeal2Mm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_HorisontalSeal2Mm.Location = new System.Drawing.Point(51, 32);
            this.textBox_Job0_HorisontalSeal2Mm.Name = "textBox_Job0_HorisontalSeal2Mm";
            this.textBox_Job0_HorisontalSeal2Mm.Size = new System.Drawing.Size(104, 20);
            this.textBox_Job0_HorisontalSeal2Mm.TabIndex = 1;
            this.textBox_Job0_HorisontalSeal2Mm.Text = "0";
            // 
            // textBox_Job0_GlandSealRadiusMm
            // 
            this.textBox_Job0_GlandSealRadiusMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_GlandSealRadiusMm.Location = new System.Drawing.Point(51, 126);
            this.textBox_Job0_GlandSealRadiusMm.Name = "textBox_Job0_GlandSealRadiusMm";
            this.textBox_Job0_GlandSealRadiusMm.Size = new System.Drawing.Size(104, 20);
            this.textBox_Job0_GlandSealRadiusMm.TabIndex = 1;
            this.textBox_Job0_GlandSealRadiusMm.Text = "0";
            // 
            // label_Job0_lowMm_1
            // 
            this.label_Job0_lowMm_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_lowMm_1.Location = new System.Drawing.Point(18, 174);
            this.label_Job0_lowMm_1.Name = "label_Job0_lowMm_1";
            this.label_Job0_lowMm_1.Size = new System.Drawing.Size(174, 23);
            this.label_Job0_lowMm_1.TabIndex = 10;
            this.label_Job0_lowMm_1.Text = "low /mm";
            this.label_Job0_lowMm_1.Visible = false;
            // 
            // label_Job0_LeftVerticalSealMm
            // 
            this.label_Job0_LeftVerticalSealMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_LeftVerticalSealMm.Location = new System.Drawing.Point(175, 55);
            this.label_Job0_LeftVerticalSealMm.Name = "label_Job0_LeftVerticalSealMm";
            this.label_Job0_LeftVerticalSealMm.Size = new System.Drawing.Size(156, 23);
            this.label_Job0_LeftVerticalSealMm.TabIndex = 12;
            this.label_Job0_LeftVerticalSealMm.Text = "Left Vertical Seal  I/O";
            // 
            // textBox_Job0_HorisontalSeal1Mm
            // 
            this.textBox_Job0_HorisontalSeal1Mm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_HorisontalSeal1Mm.Location = new System.Drawing.Point(212, 32);
            this.textBox_Job0_HorisontalSeal1Mm.Name = "textBox_Job0_HorisontalSeal1Mm";
            this.textBox_Job0_HorisontalSeal1Mm.Size = new System.Drawing.Size(104, 20);
            this.textBox_Job0_HorisontalSeal1Mm.TabIndex = 7;
            this.textBox_Job0_HorisontalSeal1Mm.Text = "0";
            // 
            // label_Job0_HorisontalSeal2Mm
            // 
            this.label_Job0_HorisontalSeal2Mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_HorisontalSeal2Mm.Location = new System.Drawing.Point(14, 16);
            this.label_Job0_HorisontalSeal2Mm.Name = "label_Job0_HorisontalSeal2Mm";
            this.label_Job0_HorisontalSeal2Mm.Size = new System.Drawing.Size(152, 23);
            this.label_Job0_HorisontalSeal2Mm.TabIndex = 0;
            this.label_Job0_HorisontalSeal2Mm.Text = "Horisontal seal2  I/O";
            // 
            // label_Job0_HorisontalSeal1Mm
            // 
            this.label_Job0_HorisontalSeal1Mm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_HorisontalSeal1Mm.Location = new System.Drawing.Point(173, 16);
            this.label_Job0_HorisontalSeal1Mm.Name = "label_Job0_HorisontalSeal1Mm";
            this.label_Job0_HorisontalSeal1Mm.Size = new System.Drawing.Size(156, 23);
            this.label_Job0_HorisontalSeal1Mm.TabIndex = 6;
            this.label_Job0_HorisontalSeal1Mm.Text = "Horisontal Seal1  I/O";
            // 
            // label_Job0_GlandSealRadiusMm
            // 
            this.label_Job0_GlandSealRadiusMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job0_GlandSealRadiusMm.Location = new System.Drawing.Point(11, 100);
            this.label_Job0_GlandSealRadiusMm.Name = "label_Job0_GlandSealRadiusMm";
            this.label_Job0_GlandSealRadiusMm.Size = new System.Drawing.Size(156, 23);
            this.label_Job0_GlandSealRadiusMm.TabIndex = 0;
            this.label_Job0_GlandSealRadiusMm.Text = "Gland Seal Radius I/O";
            // 
            // textBox_Job0_lowMm_1
            // 
            this.textBox_Job0_lowMm_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job0_lowMm_1.Location = new System.Drawing.Point(192, 171);
            this.textBox_Job0_lowMm_1.Name = "textBox_Job0_lowMm_1";
            this.textBox_Job0_lowMm_1.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job0_lowMm_1.TabIndex = 11;
            this.textBox_Job0_lowMm_1.Text = "-1";
            this.textBox_Job0_lowMm_1.Visible = false;
            // 
            // tabPage_Job1_BagInspection2
            // 
            this.tabPage_Job1_BagInspection2.AutoScroll = true;
            this.tabPage_Job1_BagInspection2.Controls.Add(this.groupBox_Gland);
            this.tabPage_Job1_BagInspection2.Controls.Add(this.groupBox_Seals_1);
            this.tabPage_Job1_BagInspection2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job1_BagInspection2.Name = "tabPage_Job1_BagInspection2";
            this.tabPage_Job1_BagInspection2.Size = new System.Drawing.Size(342, 353);
            this.tabPage_Job1_BagInspection2.TabIndex = 0;
            this.tabPage_Job1_BagInspection2.Text = "Inspection Statistic";
            // 
            // groupBox_Seals_1
            // 
            this.groupBox_Seals_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Seals_1.Controls.Add(this.label_Job1_hiMm);
            this.groupBox_Seals_1.Controls.Add(this.textBox_Job1_hiMm);
            this.groupBox_Seals_1.Controls.Add(this.label_Job1_lowMm);
            this.groupBox_Seals_1.Controls.Add(this.textBox_Job1_lowMm);
            this.groupBox_Seals_1.Location = new System.Drawing.Point(14, 20);
            this.groupBox_Seals_1.Name = "groupBox_Seals_1";
            this.groupBox_Seals_1.Size = new System.Drawing.Size(325, 120);
            this.groupBox_Seals_1.TabIndex = 0;
            this.groupBox_Seals_1.TabStop = false;
            this.groupBox_Seals_1.Text = "Seals";
            this.groupBox_Seals_1.Visible = false;
            // 
            // label_Job1_hiMm
            // 
            this.label_Job1_hiMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job1_hiMm.Location = new System.Drawing.Point(18, 54);
            this.label_Job1_hiMm.Name = "label_Job1_hiMm";
            this.label_Job1_hiMm.Size = new System.Drawing.Size(123, 23);
            this.label_Job1_hiMm.TabIndex = 2;
            this.label_Job1_hiMm.Text = "hi /mm";
            this.label_Job1_hiMm.Visible = false;
            // 
            // textBox_Job1_hiMm
            // 
            this.textBox_Job1_hiMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job1_hiMm.Location = new System.Drawing.Point(163, 52);
            this.textBox_Job1_hiMm.Name = "textBox_Job1_hiMm";
            this.textBox_Job1_hiMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job1_hiMm.TabIndex = 3;
            this.textBox_Job1_hiMm.Text = "-1";
            this.textBox_Job1_hiMm.Visible = false;
            // 
            // label_Job1_lowMm
            // 
            this.label_Job1_lowMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job1_lowMm.Location = new System.Drawing.Point(18, 84);
            this.label_Job1_lowMm.Name = "label_Job1_lowMm";
            this.label_Job1_lowMm.Size = new System.Drawing.Size(123, 23);
            this.label_Job1_lowMm.TabIndex = 4;
            this.label_Job1_lowMm.Text = "low /mm";
            this.label_Job1_lowMm.Visible = false;
            // 
            // textBox_Job1_lowMm
            // 
            this.textBox_Job1_lowMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job1_lowMm.Location = new System.Drawing.Point(163, 82);
            this.textBox_Job1_lowMm.Name = "textBox_Job1_lowMm";
            this.textBox_Job1_lowMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job1_lowMm.TabIndex = 5;
            this.textBox_Job1_lowMm.Text = "-1";
            this.textBox_Job1_lowMm.Visible = false;
            // 
            // tabPage_Job2_BagInspection3
            // 
            this.tabPage_Job2_BagInspection3.AutoScroll = true;
            this.tabPage_Job2_BagInspection3.Controls.Add(this.groupBox2);
            this.tabPage_Job2_BagInspection3.Controls.Add(this.groupBox_Gland_1);
            this.tabPage_Job2_BagInspection3.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Job2_BagInspection3.Name = "tabPage_Job2_BagInspection3";
            this.tabPage_Job2_BagInspection3.Size = new System.Drawing.Size(342, 353);
            this.tabPage_Job2_BagInspection3.TabIndex = 0;
            this.tabPage_Job2_BagInspection3.Text = "Supervisor Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox21);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.textBox22);
            this.groupBox2.Controls.Add(this.textBox20);
            this.groupBox2.Controls.Add(this.textBox19);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox18);
            this.groupBox2.Controls.Add(this.textBox17);
            this.groupBox2.Controls.Add(this.textBox16);
            this.groupBox2.Controls.Add(this.textBox15);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.textBox13);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 326);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seal Controls";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(30, 294);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 22;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(182, 278);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(27, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Size";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(182, 134);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(27, 13);
            this.label26.TabIndex = 26;
            this.label26.Text = "Size";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(30, 132);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 13);
            this.label25.TabIndex = 25;
            this.label25.Text = "Size";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 278);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Size";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(181, 294);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 23;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(181, 148);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 21;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(30, 148);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(178, 239);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 13);
            this.label23.TabIndex = 19;
            this.label23.Text = "Pixel Deviation";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(30, 239);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Pixel Deviation";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(178, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Pixel Deviation";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 16;
            this.label20.Text = "Pixel Deviation";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(178, 200);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Treshold";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 200);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Treshold";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Treshold";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Treshold";
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(181, 255);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 11;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(33, 255);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 10;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(181, 216);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 9;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(33, 216);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 8;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(181, 111);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 7;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(30, 109);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 6;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(181, 72);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 5;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(30, 72);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(203, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Gland Seal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(178, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Right Vertical Seal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(30, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Horizontal Seals";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(30, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Left Vertical Seal";
            // 
            // groupBox_Gland_1
            // 
            this.groupBox_Gland_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Gland_1.Controls.Add(this.label_Job2_hiMm);
            this.groupBox_Gland_1.Controls.Add(this.textBox_Job2_hiMm);
            this.groupBox_Gland_1.Controls.Add(this.label_Job2_lowMm);
            this.groupBox_Gland_1.Controls.Add(this.textBox_Job2_lowMm);
            this.groupBox_Gland_1.Location = new System.Drawing.Point(9, 332);
            this.groupBox_Gland_1.Name = "groupBox_Gland_1";
            this.groupBox_Gland_1.Size = new System.Drawing.Size(206, 120);
            this.groupBox_Gland_1.TabIndex = 0;
            this.groupBox_Gland_1.TabStop = false;
            this.groupBox_Gland_1.Text = "Gland";
            this.groupBox_Gland_1.Visible = false;
            // 
            // label_Job2_hiMm
            // 
            this.label_Job2_hiMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job2_hiMm.Location = new System.Drawing.Point(18, 54);
            this.label_Job2_hiMm.Name = "label_Job2_hiMm";
            this.label_Job2_hiMm.Size = new System.Drawing.Size(21, 23);
            this.label_Job2_hiMm.TabIndex = 2;
            this.label_Job2_hiMm.Text = "hi /mm";
            this.label_Job2_hiMm.Visible = false;
            // 
            // textBox_Job2_hiMm
            // 
            this.textBox_Job2_hiMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job2_hiMm.Location = new System.Drawing.Point(61, 52);
            this.textBox_Job2_hiMm.Name = "textBox_Job2_hiMm";
            this.textBox_Job2_hiMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job2_hiMm.TabIndex = 3;
            this.textBox_Job2_hiMm.Text = "-1";
            this.textBox_Job2_hiMm.Visible = false;
            // 
            // label_Job2_lowMm
            // 
            this.label_Job2_lowMm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Job2_lowMm.Location = new System.Drawing.Point(18, 84);
            this.label_Job2_lowMm.Name = "label_Job2_lowMm";
            this.label_Job2_lowMm.Size = new System.Drawing.Size(21, 23);
            this.label_Job2_lowMm.TabIndex = 4;
            this.label_Job2_lowMm.Text = "low /mm";
            this.label_Job2_lowMm.Visible = false;
            // 
            // textBox_Job2_lowMm
            // 
            this.textBox_Job2_lowMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Job2_lowMm.Location = new System.Drawing.Point(61, 82);
            this.textBox_Job2_lowMm.Name = "textBox_Job2_lowMm";
            this.textBox_Job2_lowMm.Size = new System.Drawing.Size(150, 20);
            this.textBox_Job2_lowMm.TabIndex = 5;
            this.textBox_Job2_lowMm.Text = "-1";
            this.textBox_Job2_lowMm.Visible = false;
            // 
            // label_AcquisitionResults_Overruns
            // 
            this.label_AcquisitionResults_Overruns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_Overruns.Location = new System.Drawing.Point(54, 74);
            this.label_AcquisitionResults_Overruns.Name = "label_AcquisitionResults_Overruns";
            this.label_AcquisitionResults_Overruns.Size = new System.Drawing.Size(0, 16);
            this.label_AcquisitionResults_Overruns.TabIndex = 32;
            this.label_AcquisitionResults_Overruns.Text = "Overruns:";
            this.label_AcquisitionResults_Overruns.Visible = false;
            // 
            // textBox_JobN_TotalAcquisitionErrors
            // 
            this.textBox_JobN_TotalAcquisitionErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitionErrors.Location = new System.Drawing.Point(-210, 48);
            this.textBox_JobN_TotalAcquisitionErrors.Name = "textBox_JobN_TotalAcquisitionErrors";
            this.textBox_JobN_TotalAcquisitionErrors.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitionErrors.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAcquisitionErrors.TabIndex = 31;
            this.textBox_JobN_TotalAcquisitionErrors.Text = "textBox1";
            this.textBox_JobN_TotalAcquisitionErrors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalAcquisitionErrors.Visible = false;
            // 
            // textBox_JobN_TotalAcquisitionOverruns
            // 
            this.textBox_JobN_TotalAcquisitionOverruns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitionOverruns.Location = new System.Drawing.Point(-210, 72);
            this.textBox_JobN_TotalAcquisitionOverruns.Name = "textBox_JobN_TotalAcquisitionOverruns";
            this.textBox_JobN_TotalAcquisitionOverruns.ReadOnly = true;
            this.textBox_JobN_TotalAcquisitionOverruns.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAcquisitionOverruns.TabIndex = 33;
            this.textBox_JobN_TotalAcquisitionOverruns.Text = "textBox2";
            this.textBox_JobN_TotalAcquisitionOverruns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalAcquisitionOverruns.Visible = false;
            // 
            // groupBox_AcquisitionResults
            // 
            this.groupBox_AcquisitionResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitionOverruns);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_Overruns);
            this.groupBox_AcquisitionResults.Controls.Add(this.textBox_JobN_TotalAcquisitionErrors);
            this.groupBox_AcquisitionResults.Controls.Add(this.label_AcquisitionResults_Errors);
            this.groupBox_AcquisitionResults.Location = new System.Drawing.Point(3, 333);
            this.groupBox_AcquisitionResults.Name = "groupBox_AcquisitionResults";
            this.groupBox_AcquisitionResults.Size = new System.Drawing.Size(0, 96);
            this.groupBox_AcquisitionResults.TabIndex = 39;
            this.groupBox_AcquisitionResults.TabStop = false;
            this.groupBox_AcquisitionResults.Text = "Acquisition Results";
            this.groupBox_AcquisitionResults.Visible = false;
            // 
            // label_AcquisitionResults_Errors
            // 
            this.label_AcquisitionResults_Errors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_AcquisitionResults_Errors.Location = new System.Drawing.Point(54, 50);
            this.label_AcquisitionResults_Errors.Name = "label_AcquisitionResults_Errors";
            this.label_AcquisitionResults_Errors.Size = new System.Drawing.Size(0, 16);
            this.label_AcquisitionResults_Errors.TabIndex = 30;
            this.label_AcquisitionResults_Errors.Text = "Errors:";
            this.label_AcquisitionResults_Errors.Visible = false;
            // 
            // textBox_JobN_TotalAcquisitions
            // 
            this.textBox_JobN_TotalAcquisitions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAcquisitions.Location = new System.Drawing.Point(115, 120);
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
            this.label_AcquisitionResults_TotalAcquisitions.Location = new System.Drawing.Point(6, 119);
            this.label_AcquisitionResults_TotalAcquisitions.Name = "label_AcquisitionResults_TotalAcquisitions";
            this.label_AcquisitionResults_TotalAcquisitions.Size = new System.Drawing.Size(113, 16);
            this.label_AcquisitionResults_TotalAcquisitions.TabIndex = 27;
            this.label_AcquisitionResults_TotalAcquisitions.Text = "Total Acquisitions:";
            // 
            // label_JobThroughput_persec
            // 
            this.label_JobThroughput_persec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_persec.Location = new System.Drawing.Point(-98, 26);
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
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_MaxThroughput);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_MinThroughput);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_Max);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_Min);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobResults_Error);
            this.groupBox_JobThroughput.Controls.Add(this.textBox_JobN_Throughput);
            this.groupBox_JobThroughput.Controls.Add(this.label_JobThroughput_TotalThroughput);
            this.groupBox_JobThroughput.Location = new System.Drawing.Point(3, 333);
            this.groupBox_JobThroughput.Name = "groupBox_JobThroughput";
            this.groupBox_JobThroughput.Size = new System.Drawing.Size(0, 96);
            this.groupBox_JobThroughput.TabIndex = 38;
            this.groupBox_JobThroughput.TabStop = false;
            this.groupBox_JobThroughput.Text = "Job Throughput";
            this.groupBox_JobThroughput.Visible = false;
            // 
            // textBox_JobN_MaxThroughput
            // 
            this.textBox_JobN_MaxThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_MaxThroughput.Location = new System.Drawing.Point(-210, 72);
            this.textBox_JobN_MaxThroughput.Name = "textBox_JobN_MaxThroughput";
            this.textBox_JobN_MaxThroughput.ReadOnly = true;
            this.textBox_JobN_MaxThroughput.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_MaxThroughput.TabIndex = 28;
            this.textBox_JobN_MaxThroughput.Text = "textBox1";
            this.textBox_JobN_MaxThroughput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_JobN_MinThroughput
            // 
            this.textBox_JobN_MinThroughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_MinThroughput.Location = new System.Drawing.Point(-210, 48);
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
            this.label_JobThroughput_Max.Location = new System.Drawing.Point(54, 74);
            this.label_JobThroughput_Max.Name = "label_JobThroughput_Max";
            this.label_JobThroughput_Max.Size = new System.Drawing.Size(0, 16);
            this.label_JobThroughput_Max.TabIndex = 26;
            this.label_JobThroughput_Max.Text = "Max:";
            // 
            // label_JobThroughput_Min
            // 
            this.label_JobThroughput_Min.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobThroughput_Min.Location = new System.Drawing.Point(54, 50);
            this.label_JobThroughput_Min.Name = "label_JobThroughput_Min";
            this.label_JobThroughput_Min.Size = new System.Drawing.Size(0, 16);
            this.label_JobThroughput_Min.TabIndex = 25;
            this.label_JobThroughput_Min.Text = "Min:";
            // 
            // label_JobResults_Error
            // 
            this.label_JobResults_Error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Error.Location = new System.Drawing.Point(-3, 50);
            this.label_JobResults_Error.Name = "label_JobResults_Error";
            this.label_JobResults_Error.Size = new System.Drawing.Size(0, 16);
            this.label_JobResults_Error.TabIndex = 35;
            this.label_JobResults_Error.Text = "Error:";
            this.label_JobResults_Error.Visible = false;
            // 
            // textBox_JobN_Throughput
            // 
            this.textBox_JobN_Throughput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_Throughput.Location = new System.Drawing.Point(-210, 24);
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
            this.label_JobThroughput_TotalThroughput.Location = new System.Drawing.Point(24, 26);
            this.label_JobThroughput_TotalThroughput.Name = "label_JobThroughput_TotalThroughput";
            this.label_JobThroughput_TotalThroughput.Size = new System.Drawing.Size(0, 16);
            this.label_JobThroughput_TotalThroughput.TabIndex = 23;
            this.label_JobThroughput_TotalThroughput.Text = "Total Throughput:";
            // 
            // button_ResetStatisticsForAllJobs
            // 
            this.button_ResetStatisticsForAllJobs.Location = new System.Drawing.Point(163, 186);
            this.button_ResetStatisticsForAllJobs.Name = "button_ResetStatisticsForAllJobs";
            this.button_ResetStatisticsForAllJobs.Size = new System.Drawing.Size(168, 23);
            this.button_ResetStatisticsForAllJobs.TabIndex = 40;
            this.button_ResetStatisticsForAllJobs.Text = "Reset Statistics For All Jobs";
            this.button_ResetStatisticsForAllJobs.Click += new System.EventHandler(this.button_ResetStatisticsForAllJobs_Click);
            // 
            // button_ResetStatistics
            // 
            this.button_ResetStatistics.Location = new System.Drawing.Point(10, 186);
            this.button_ResetStatistics.Name = "button_ResetStatistics";
            this.button_ResetStatistics.Size = new System.Drawing.Size(133, 23);
            this.button_ResetStatistics.TabIndex = 41;
            this.button_ResetStatistics.Text = "Reset Statistics";
            this.button_ResetStatistics.Click += new System.EventHandler(this.button_ResetStatistics_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cogRecordsDisplay1);
            this.panel5.Controls.Add(this.splitter2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label_controlErrorMessage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 34);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(794, 413);
            this.panel5.TabIndex = 26;
            // 
            // cogRecordsDisplay1
            // 
            this.cogRecordsDisplay1.Location = new System.Drawing.Point(3, 3);
            this.cogRecordsDisplay1.Name = "cogRecordsDisplay1";
            this.cogRecordsDisplay1.SelectedRecordKey = null;
            this.cogRecordsDisplay1.ShowRecordsDropDown = true;
            this.cogRecordsDisplay1.Size = new System.Drawing.Size(433, 397);
            this.cogRecordsDisplay1.Subject = null;
            this.cogRecordsDisplay1.TabIndex = 29;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(306, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(10, 407);
            this.splitter2.TabIndex = 28;
            this.splitter2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tabControl_JobTabs);
            this.panel6.Controls.Add(this.pictureBox_Logo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(316, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 407);
            this.panel6.TabIndex = 27;
            // 
            // tabControl_JobTabs
            // 
            this.tabControl_JobTabs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl_JobTabs.Controls.Add(this.tabPage_JobN_JobStatistics);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job0_BagInspection1);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job1_BagInspection2);
            this.tabControl_JobTabs.Controls.Add(this.tabPage_Job2_BagInspection3);
            this.tabControl_JobTabs.Location = new System.Drawing.Point(122, 4);
            this.tabControl_JobTabs.Name = "tabControl_JobTabs";
            this.tabControl_JobTabs.SelectedIndex = 0;
            this.tabControl_JobTabs.Size = new System.Drawing.Size(350, 379);
            this.tabControl_JobTabs.TabIndex = 28;
            this.tabControl_JobTabs.Tag = "";
            // 
            // tabPage_JobN_JobStatistics
            // 
            this.tabPage_JobN_JobStatistics.AutoScroll = true;
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button4);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.textBox24);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.textBox23);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button3);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button2);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button_ResetStatisticsForAllJobs);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_AcquisitionResults);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_JobThroughput);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.groupBox_JobResults);
            this.tabPage_JobN_JobStatistics.Controls.Add(this.button_ResetStatistics);
            this.tabPage_JobN_JobStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_JobN_JobStatistics.Name = "tabPage_JobN_JobStatistics";
            this.tabPage_JobN_JobStatistics.Size = new System.Drawing.Size(342, 353);
            this.tabPage_JobN_JobStatistics.TabIndex = 0;
            this.tabPage_JobN_JobStatistics.Text = "Job Statistics";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 46;
            this.button4.Text = "Mail Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(163, 278);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(134, 20);
            this.textBox24.TabIndex = 45;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(10, 278);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(133, 20);
            this.textBox23.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(183, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Stop Event";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Start Event";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox_JobResults
            // 
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Percent);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalAccept_Percent);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalWarning);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalError);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalAcquisitions);
            this.groupBox_JobResults.Controls.Add(this.label_AcquisitionResults_TotalAcquisitions);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Warning);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalReject);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Reject);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalAccept);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_Accept);
            this.groupBox_JobResults.Controls.Add(this.textBox_JobN_TotalIterations);
            this.groupBox_JobResults.Controls.Add(this.label_JobResults_TotalIterations);
            this.groupBox_JobResults.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_JobResults.Location = new System.Drawing.Point(0, 0);
            this.groupBox_JobResults.Name = "groupBox_JobResults";
            this.groupBox_JobResults.Size = new System.Drawing.Size(331, 146);
            this.groupBox_JobResults.TabIndex = 37;
            this.groupBox_JobResults.TabStop = false;
            this.groupBox_JobResults.Text = "Job Results";
            // 
            // label_JobResults_Percent
            // 
            this.label_JobResults_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Percent.Location = new System.Drawing.Point(283, 51);
            this.label_JobResults_Percent.Name = "label_JobResults_Percent";
            this.label_JobResults_Percent.Size = new System.Drawing.Size(34, 16);
            this.label_JobResults_Percent.TabIndex = 40;
            this.label_JobResults_Percent.Text = "%";
            this.label_JobResults_Percent.Visible = false;
            // 
            // textBox_JobN_TotalAccept_Percent
            // 
            this.textBox_JobN_TotalAccept_Percent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAccept_Percent.Location = new System.Drawing.Point(231, 48);
            this.textBox_JobN_TotalAccept_Percent.Name = "textBox_JobN_TotalAccept_Percent";
            this.textBox_JobN_TotalAccept_Percent.ReadOnly = true;
            this.textBox_JobN_TotalAccept_Percent.Size = new System.Drawing.Size(52, 20);
            this.textBox_JobN_TotalAccept_Percent.TabIndex = 39;
            this.textBox_JobN_TotalAccept_Percent.Text = "textBox1";
            this.textBox_JobN_TotalAccept_Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalAccept_Percent.Visible = false;
            // 
            // textBox_JobN_TotalWarning
            // 
            this.textBox_JobN_TotalWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalWarning.Location = new System.Drawing.Point(225, 98);
            this.textBox_JobN_TotalWarning.Name = "textBox_JobN_TotalWarning";
            this.textBox_JobN_TotalWarning.ReadOnly = true;
            this.textBox_JobN_TotalWarning.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalWarning.TabIndex = 38;
            this.textBox_JobN_TotalWarning.Text = "textBox4";
            this.textBox_JobN_TotalWarning.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalWarning.Visible = false;
            // 
            // textBox_JobN_TotalError
            // 
            this.textBox_JobN_TotalError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalError.Location = new System.Drawing.Point(225, 120);
            this.textBox_JobN_TotalError.Name = "textBox_JobN_TotalError";
            this.textBox_JobN_TotalError.ReadOnly = true;
            this.textBox_JobN_TotalError.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalError.TabIndex = 36;
            this.textBox_JobN_TotalError.Text = "textBox3";
            this.textBox_JobN_TotalError.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalError.Visible = false;
            // 
            // label_JobResults_Warning
            // 
            this.label_JobResults_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Warning.Location = new System.Drawing.Point(54, 98);
            this.label_JobResults_Warning.Name = "label_JobResults_Warning";
            this.label_JobResults_Warning.Size = new System.Drawing.Size(102, 16);
            this.label_JobResults_Warning.TabIndex = 34;
            this.label_JobResults_Warning.Text = "Warning:";
            this.label_JobResults_Warning.Visible = false;
            // 
            // textBox_JobN_TotalReject
            // 
            this.textBox_JobN_TotalReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalReject.Location = new System.Drawing.Point(115, 72);
            this.textBox_JobN_TotalReject.Name = "textBox_JobN_TotalReject";
            this.textBox_JobN_TotalReject.ReadOnly = true;
            this.textBox_JobN_TotalReject.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalReject.TabIndex = 33;
            this.textBox_JobN_TotalReject.Text = "textBox2";
            this.textBox_JobN_TotalReject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Reject
            // 
            this.label_JobResults_Reject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Reject.Location = new System.Drawing.Point(54, 74);
            this.label_JobResults_Reject.Name = "label_JobResults_Reject";
            this.label_JobResults_Reject.Size = new System.Drawing.Size(102, 16);
            this.label_JobResults_Reject.TabIndex = 31;
            this.label_JobResults_Reject.Text = "Reject:";
            // 
            // textBox_JobN_TotalAccept
            // 
            this.textBox_JobN_TotalAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalAccept.Location = new System.Drawing.Point(115, 27);
            this.textBox_JobN_TotalAccept.Name = "textBox_JobN_TotalAccept";
            this.textBox_JobN_TotalAccept.ReadOnly = true;
            this.textBox_JobN_TotalAccept.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalAccept.TabIndex = 29;
            this.textBox_JobN_TotalAccept.Text = "textBox1";
            this.textBox_JobN_TotalAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_JobResults_Accept
            // 
            this.label_JobResults_Accept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_Accept.Location = new System.Drawing.Point(54, 50);
            this.label_JobResults_Accept.Name = "label_JobResults_Accept";
            this.label_JobResults_Accept.Size = new System.Drawing.Size(102, 16);
            this.label_JobResults_Accept.TabIndex = 28;
            this.label_JobResults_Accept.Text = "Accept:";
            this.label_JobResults_Accept.Visible = false;
            // 
            // textBox_JobN_TotalIterations
            // 
            this.textBox_JobN_TotalIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_JobN_TotalIterations.Location = new System.Drawing.Point(225, 27);
            this.textBox_JobN_TotalIterations.Name = "textBox_JobN_TotalIterations";
            this.textBox_JobN_TotalIterations.ReadOnly = true;
            this.textBox_JobN_TotalIterations.Size = new System.Drawing.Size(100, 20);
            this.textBox_JobN_TotalIterations.TabIndex = 26;
            this.textBox_JobN_TotalIterations.Text = "textBox1";
            this.textBox_JobN_TotalIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_JobN_TotalIterations.Visible = false;
            this.textBox_JobN_TotalIterations.TextChanged += new System.EventHandler(this.textBox_JobN_TotalIterations_TextChanged_1);
            // 
            // label_JobResults_TotalIterations
            // 
            this.label_JobResults_TotalIterations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_JobResults_TotalIterations.Location = new System.Drawing.Point(54, 27);
            this.label_JobResults_TotalIterations.Name = "label_JobResults_TotalIterations";
            this.label_JobResults_TotalIterations.Size = new System.Drawing.Size(102, 16);
            this.label_JobResults_TotalIterations.TabIndex = 25;
            this.label_JobResults_TotalIterations.Text = "Accept:";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Logo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_Logo.Location = new System.Drawing.Point(0, 389);
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
            this.label_controlErrorMessage.Size = new System.Drawing.Size(788, 407);
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
            this.panel4.Size = new System.Drawing.Size(800, 450);
            this.panel4.TabIndex = 0;
            // 
            // label_ResultBar
            // 
            this.label_ResultBar.BackColor = System.Drawing.SystemColors.Control;
            this.label_ResultBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_ResultBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ResultBar.Location = new System.Drawing.Point(3, 5);
            this.label_ResultBar.Name = "label_ResultBar";
            this.label_ResultBar.Size = new System.Drawing.Size(794, 29);
            this.label_ResultBar.TabIndex = 25;
            this.label_ResultBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(660, 62);
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
            this.splitter1.Size = new System.Drawing.Size(800, 5);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 37;
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Login.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Login.Location = new System.Drawing.Point(512, 120);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.Size = new System.Drawing.Size(132, 24);
            this.comboBox_Login.TabIndex = 41;
            this.comboBox_Login.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Login_SelectionChangeCommitted);
            // 
            // button_SaveSettings
            // 
            this.button_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveSettings.Location = new System.Drawing.Point(541, 65);
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
            this.checkBox_LiveDisplay.Location = new System.Drawing.Point(675, 116);
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
            this.button_About.Location = new System.Drawing.Point(675, 116);
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
            this.groupBox_DividerLine.Location = new System.Drawing.Point(651, 10);
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
            this.label_Online.Location = new System.Drawing.Point(672, 124);
            this.label_Online.Name = "label_Online";
            this.label_Online.Size = new System.Drawing.Size(119, 15);
            this.label_Online.TabIndex = 51;
            this.label_Online.Text = "System online status";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cogJobResultHistoryCollectionEdit1);
            this.panel2.Location = new System.Drawing.Point(6, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 102);
            this.panel2.TabIndex = 50;
            // 
            // cogJobResultHistoryCollectionEdit1
            // 
            this.cogJobResultHistoryCollectionEdit1.AllowDrop = true;
            this.cogJobResultHistoryCollectionEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cogJobResultHistoryCollectionEdit1.AutoScroll = true;
            this.cogJobResultHistoryCollectionEdit1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.cogJobResultHistoryCollectionEdit1.Location = new System.Drawing.Point(-5, 3);
            this.cogJobResultHistoryCollectionEdit1.Name = "cogJobResultHistoryCollectionEdit1";
            this.cogJobResultHistoryCollectionEdit1.Padding = new System.Windows.Forms.Padding(4);
            this.cogJobResultHistoryCollectionEdit1.SelectedIndex = -1;
            this.cogJobResultHistoryCollectionEdit1.SelectorControlHeight = 29;
            this.cogJobResultHistoryCollectionEdit1.Size = new System.Drawing.Size(788, 96);
            this.cogJobResultHistoryCollectionEdit1.Subject = null;
            this.cogJobResultHistoryCollectionEdit1.TabIndex = 43;
            this.cogJobResultHistoryCollectionEdit1.SelectedIndexChanged += new System.EventHandler(this.cogJobResultHistoryCollectionEdit1_SelectedJobIndexChanged);
            // 
            // label_Login
            // 
            this.label_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(406, 124);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(106, 21);
            this.label_Login.TabIndex = 49;
            this.label_Login.Text = "Current login:";
            // 
            // button_Configuration
            // 
            this.button_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Configuration.Location = new System.Drawing.Point(541, 26);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_Online);
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
            this.panel1.Size = new System.Drawing.Size(800, 160);
            this.panel1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 55;
            this.button1.Text = "Check Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 54;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Bag Type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::VisionControl.strings.checkin_logo;
            this.pictureBox1.Location = new System.Drawing.Point(174, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 102);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnRunCont
            // 
            this.btnRunCont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunCont.Location = new System.Drawing.Point(659, 16);
            this.btnRunCont.Name = "btnRunCont";
            this.btnRunCont.Size = new System.Drawing.Size(130, 40);
            this.btnRunCont.TabIndex = 42;
            this.btnRunCont.Text = "Run Continuously";
            this.btnRunCont.Click += new System.EventHandler(this.btnRunCont_Click);
            // 
            // VisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 610);
            this.MinimumSize = new System.Drawing.Size(800, 610);
            this.Name = "VisionControl";
            this.Size = new System.Drawing.Size(800, 610);
            this.Load += new System.EventHandler(this.VisionControl_Load);
            this.tabPage_Job0_BagInspection1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Seals.ResumeLayout(false);
            this.groupBox_Seals.PerformLayout();
            this.groupBox_Gland.ResumeLayout(false);
            this.groupBox_Gland.PerformLayout();
            this.tabPage_Job1_BagInspection2.ResumeLayout(false);
            this.groupBox_Seals_1.ResumeLayout(false);
            this.groupBox_Seals_1.PerformLayout();
            this.tabPage_Job2_BagInspection3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_Gland_1.ResumeLayout(false);
            this.groupBox_Gland_1.PerformLayout();
            this.groupBox_AcquisitionResults.ResumeLayout(false);
            this.groupBox_AcquisitionResults.PerformLayout();
            this.groupBox_JobThroughput.ResumeLayout(false);
            this.groupBox_JobThroughput.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tabControl_JobTabs.ResumeLayout(false);
            this.tabPage_JobN_JobStatistics.ResumeLayout(false);
            this.tabPage_JobN_JobStatistics.PerformLayout();
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
    private Cognex.VisionPro.CogToolPropertyProvider cogToolPropertyProvider0;
    private Cognex.VisionPro.CogToolPropertyProvider cogToolPropertyProvider1;
    private Cognex.VisionPro.CogToolPropertyProvider cogToolPropertyProvider2;
    private TabPage tabPage_Job0_BagInspection1;
    private GroupBox groupBox_Gland;
    private Label label_Job0_GlandSealRadiusMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_GlandSealRadiusMm;
    private Label label_Job0_hiMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_hiMm;
    private Label label_Job0_lowMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_lowMm;
    private Label label_Job0_GlandPositionXMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_GlandPositionXMm;
    private Label label_Job0_hiMm_1;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_hiMm_1;
    private Label label_Job0_lowMm_1;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_lowMm_1;
    private GroupBox groupBox_Seals;
    private Label label_Job0_HorisontalSeal2Mm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_HorisontalSeal2Mm;
    private Label label_Job0_hiMm_2;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_hiMm_2;
    private Label label_Job0_lowMm_2;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_lowMm_2;
    private Label label_Job0_HorisontalSeal1Mm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_HorisontalSeal1Mm;
    private Label label_Job0_hiMm_3;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_hiMm_3;
    private Label label_Job0_lowMm_3;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_lowMm_3;
    private Label label_Job0_LeftVerticalSealMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_LeftVerticalSealMm;
    private Label label_Job0_hiMm_4;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_hiMm_4;
    private Label label_Job0_lowMm_4;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job0_lowMm_4;
    private TabPage tabPage_Job1_BagInspection2;
    private GroupBox groupBox_Seals_1;
    private Label label_Job1_RightVerticalSealMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job1_RightVerticalSealMm;
    private Label label_Job1_hiMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job1_hiMm;
    private Label label_Job1_lowMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job1_lowMm;
    private TabPage tabPage_Job2_BagInspection3;
    private GroupBox groupBox_Gland_1;
    private Label label_Job2_GlandHighMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job2_GlandHighMm;
    private Label label_Job2_hiMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job2_hiMm;
    private Label label_Job2_lowMm;
    private Cognex.VisionPro.QuickBuild.Implementation.Internal.CogApplicationWizardNumberBox textBox_Job2_lowMm;
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
    private System.Windows.Forms.TextBox textBox_JobN_TotalAccept_Percent;
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
    private Cognex.VisionPro.CogRecordsDisplay cogRecordsDisplay1;
    private Cognex.VisionPro.QuickBuild.CogJobResultHistoryCollectionEdit cogJobResultHistoryCollectionEdit1;
    private System.Windows.Forms.Label label_controlErrorMessage;
    private PictureBox pictureBox1;
    private ComboBox comboBox1;
    private Label label1;
    private Button button1;
    private GroupBox groupBox1;
    private TextBox textBox10;
    private TextBox textBox9;
    private TextBox textBox8;
    private TextBox textBox7;
    private TextBox textBox6;
    private TextBox textBox5;
    private TextBox textBox4;
    private TextBox textBox3;
    private TextBox textBox2;
    private TextBox textBox1;
    private Label label2;
    private Label label11;
    private Label label3;
    private Label label10;
    private Label label4;
    private Label label9;
    private Label label5;
    private Label label8;
    private Label label6;
    private Label label7;
    private GroupBox groupBox2;
    private Label label23;
    private Label label22;
    private Label label21;
    private Label label20;
    private Label label19;
    private Label label18;
    private Label label17;
    private Label label16;
    private TextBox textBox18;
    private TextBox textBox17;
    private TextBox textBox16;
    private TextBox textBox15;
    private TextBox textBox14;
    private TextBox textBox13;
    private TextBox textBox12;
    private TextBox textBox11;
    private Label label15;
    private Label label14;
    private Label label13;
    private Label label12;
    private TextBox textBox21;
    private Label label27;
    private Label label26;
    private Label label25;
    private Label label24;
    private TextBox textBox22;
    private TextBox textBox20;
    private TextBox textBox19;
    private TextBox textBox24;
    private TextBox textBox23;
    private Button button3;
    private Button button2;
    private Button button4;
    private Button btnRunCont;
  }
}
