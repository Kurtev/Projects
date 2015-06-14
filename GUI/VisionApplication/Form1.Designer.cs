namespace VisionApplication
{
  partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.visionControl1 = new VisionControl.VisionControl();
            this.SuspendLayout();
            // 
            // visionControl1
            // 
            this.visionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visionControl1.Location = new System.Drawing.Point(0, 0);
            this.visionControl1.MaximumSize = new System.Drawing.Size(800, 600);
            this.visionControl1.MinimumSize = new System.Drawing.Size(800, 600);
            this.visionControl1.Name = "visionControl1";
            this.visionControl1.Size = new System.Drawing.Size(800, 600);
            this.visionControl1.TabIndex = 0;
            this.visionControl1.Load += new System.EventHandler(this.visionControl1_Load);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(792, 576);
            this.Controls.Add(this.visionControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private VisionControl.VisionControl visionControl1;

  }
}

