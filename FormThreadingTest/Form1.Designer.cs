namespace FormThreadingTest
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
      this.lblRecordsProcessed = new System.Windows.Forms.Label();
      this.txtEndTime = new System.Windows.Forms.TextBox();
      this.txtStartTime = new System.Windows.Forms.TextBox();
      this.btnStartProcess = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblRecordsProcessed
      // 
      this.lblRecordsProcessed.AutoSize = true;
      this.lblRecordsProcessed.Location = new System.Drawing.Point(190, 77);
      this.lblRecordsProcessed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblRecordsProcessed.Name = "lblRecordsProcessed";
      this.lblRecordsProcessed.Size = new System.Drawing.Size(138, 17);
      this.lblRecordsProcessed.TabIndex = 4;
      this.lblRecordsProcessed.Text = "0 records processed";
      // 
      // txtEndTime
      // 
      this.txtEndTime.Enabled = false;
      this.txtEndTime.Location = new System.Drawing.Point(194, 122);
      this.txtEndTime.Margin = new System.Windows.Forms.Padding(4);
      this.txtEndTime.Name = "txtEndTime";
      this.txtEndTime.Size = new System.Drawing.Size(185, 22);
      this.txtEndTime.TabIndex = 6;
      this.txtEndTime.Text = "[end time]";
      // 
      // txtStartTime
      // 
      this.txtStartTime.Enabled = false;
      this.txtStartTime.Location = new System.Drawing.Point(194, 97);
      this.txtStartTime.Margin = new System.Windows.Forms.Padding(4);
      this.txtStartTime.Name = "txtStartTime";
      this.txtStartTime.Size = new System.Drawing.Size(185, 22);
      this.txtStartTime.TabIndex = 5;
      this.txtStartTime.Text = "[start time]";
      // 
      // btnStartProcess
      // 
      this.btnStartProcess.Enabled = false;
      this.btnStartProcess.Location = new System.Drawing.Point(283, 209);
      this.btnStartProcess.Margin = new System.Windows.Forms.Padding(4);
      this.btnStartProcess.Name = "btnStartProcess";
      this.btnStartProcess.Size = new System.Drawing.Size(235, 33);
      this.btnStartProcess.TabIndex = 7;
      this.btnStartProcess.Text = "Process movement records";
      this.btnStartProcess.UseVisualStyleBackColor = true;
      this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnStartProcess);
      this.Controls.Add(this.lblRecordsProcessed);
      this.Controls.Add(this.txtEndTime);
      this.Controls.Add(this.txtStartTime);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblRecordsProcessed;
    private System.Windows.Forms.TextBox txtEndTime;
    private System.Windows.Forms.TextBox txtStartTime;
    private System.Windows.Forms.Button btnStartProcess;
  }
}

