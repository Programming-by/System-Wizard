namespace System_Wizard
{
    partial class frmMain
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
            this.cbOptions = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblScreenResolution = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDisplayResolution = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOptions
            // 
            this.cbOptions.FormattingEnabled = true;
            this.cbOptions.Items.AddRange(new object[] {
            "None",
            "Change Desktop Wallpaper",
            "Shut Down"});
            this.cbOptions.Location = new System.Drawing.Point(39, 55);
            this.cbOptions.Name = "cbOptions";
            this.cbOptions.Size = new System.Drawing.Size(200, 24);
            this.cbOptions.TabIndex = 0;
            this.cbOptions.SelectedIndexChanged += new System.EventHandler(this.cbOptions_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblScreenResolution
            // 
            this.lblScreenResolution.AutoSize = true;
            this.lblScreenResolution.Location = new System.Drawing.Point(135, 32);
            this.lblScreenResolution.Name = "lblScreenResolution";
            this.lblScreenResolution.Size = new System.Drawing.Size(117, 16);
            this.lblScreenResolution.TabIndex = 1;
            this.lblScreenResolution.Text = "Screen Resolution";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDisplayResolution);
            this.groupBox1.Controls.Add(this.lblScreenResolution);
            this.groupBox1.Location = new System.Drawing.Point(456, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 190);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblDisplayResolution
            // 
            this.lblDisplayResolution.AutoSize = true;
            this.lblDisplayResolution.Location = new System.Drawing.Point(6, 32);
            this.lblDisplayResolution.Name = "lblDisplayResolution";
            this.lblDisplayResolution.Size = new System.Drawing.Size(123, 16);
            this.lblDisplayResolution.TabIndex = 2;
            this.lblDisplayResolution.Text = "Display Resolution:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbOptions);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOptions;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblScreenResolution;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDisplayResolution;
    }
}

