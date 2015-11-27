namespace NineSky_desktop
{
    partial class Monitor
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
            this.MonitorStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonitorClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MonitorStart
            // 
            this.MonitorStart.Location = new System.Drawing.Point(13, 531);
            this.MonitorStart.Name = "MonitorStart";
            this.MonitorStart.Size = new System.Drawing.Size(75, 21);
            this.MonitorStart.TabIndex = 0;
            this.MonitorStart.Text = "开始监控";
            this.MonitorStart.UseVisualStyleBackColor = true;
            this.MonitorStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 525);
            this.panel1.TabIndex = 1;
            // 
            // MonitorClose
            // 
            this.MonitorClose.Location = new System.Drawing.Point(132, 531);
            this.MonitorClose.Name = "MonitorClose";
            this.MonitorClose.Size = new System.Drawing.Size(75, 23);
            this.MonitorClose.TabIndex = 2;
            this.MonitorClose.Text = "关闭监控";
            this.MonitorClose.UseVisualStyleBackColor = true;
            this.MonitorClose.Click += new System.EventHandler(this.MonitorClose_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 563);
            this.Controls.Add(this.MonitorClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MonitorStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitor";
            this.Text = "家庭监视器";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MonitorStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MonitorClose;
    }
}

