namespace NineSky_desktop
{
    partial class mainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.buttonCheck1 = new buttonCheckLib.buttonCheck();
            this.buttonCheck2 = new buttonCheckLib.buttonCheck();
            this.buttonCheck3 = new buttonCheckLib.buttonCheck();
            this.buttonCheck4 = new buttonCheckLib.buttonCheck();
            this.SuspendLayout();
            // 
            // buttonCheck1
            // 
            this.buttonCheck1.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck1.Checked = false;
            this.buttonCheck1.Location = new System.Drawing.Point(301, 262);
            this.buttonCheck1.Name = "buttonCheck1";
            this.buttonCheck1.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck1.TabIndex = 0;
            // 
            // buttonCheck2
            // 
            this.buttonCheck2.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck2.Checked = false;
            this.buttonCheck2.Location = new System.Drawing.Point(442, 262);
            this.buttonCheck2.Name = "buttonCheck2";
            this.buttonCheck2.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck2.TabIndex = 1;
            // 
            // buttonCheck3
            // 
            this.buttonCheck3.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck3.Checked = false;
            this.buttonCheck3.Location = new System.Drawing.Point(301, 332);
            this.buttonCheck3.Name = "buttonCheck3";
            this.buttonCheck3.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck3.TabIndex = 2;
            // 
            // buttonCheck4
            // 
            this.buttonCheck4.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck4.Checked = false;
            this.buttonCheck4.Location = new System.Drawing.Point(442, 332);
            this.buttonCheck4.Name = "buttonCheck4";
            this.buttonCheck4.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck4.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 379);
            this.Controls.Add(this.buttonCheck4);
            this.Controls.Add(this.buttonCheck3);
            this.Controls.Add(this.buttonCheck2);
            this.Controls.Add(this.buttonCheck1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.Text = "九天智能家居";
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private buttonCheckLib.buttonCheck buttonCheck1;
        private buttonCheckLib.buttonCheck buttonCheck2;
        private buttonCheckLib.buttonCheck buttonCheck3;
        private buttonCheckLib.buttonCheck buttonCheck4;
    }
}