namespace NineSky_desktop
{
    partial class setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.netAdress = new System.Windows.Forms.TextBox();
            this.setSure = new System.Windows.Forms.Button();
            this.setExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.netPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "网络地址：";
            // 
            // netAdress
            // 
            this.netAdress.Location = new System.Drawing.Point(125, 43);
            this.netAdress.Name = "netAdress";
            this.netAdress.Size = new System.Drawing.Size(271, 21);
            this.netAdress.TabIndex = 1;
            // 
            // setSure
            // 
            this.setSure.Location = new System.Drawing.Point(101, 208);
            this.setSure.Name = "setSure";
            this.setSure.Size = new System.Drawing.Size(75, 23);
            this.setSure.TabIndex = 2;
            this.setSure.Text = "保存";
            this.setSure.UseVisualStyleBackColor = true;
            this.setSure.Click += new System.EventHandler(this.setSure_Click);
            // 
            // setExit
            // 
            this.setExit.Location = new System.Drawing.Point(295, 208);
            this.setExit.Name = "setExit";
            this.setExit.Size = new System.Drawing.Size(75, 23);
            this.setExit.TabIndex = 3;
            this.setExit.Text = "取消";
            this.setExit.UseVisualStyleBackColor = true;
            this.setExit.Click += new System.EventHandler(this.setExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号：";
            // 
            // netPort
            // 
            this.netPort.Location = new System.Drawing.Point(125, 80);
            this.netPort.Name = "netPort";
            this.netPort.Size = new System.Drawing.Size(100, 21);
            this.netPort.TabIndex = 5;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 262);
            this.Controls.Add(this.netPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setExit);
            this.Controls.Add(this.setSure);
            this.Controls.Add(this.netAdress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "setting";
            this.Text = "设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox netAdress;
        private System.Windows.Forms.Button setSure;
        private System.Windows.Forms.Button setExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox netPort;
    }
}