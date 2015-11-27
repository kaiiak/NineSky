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
            this.buttonCheck1 = new buttonCheckLib.buttonCheck();
            this.buttonCheck2 = new buttonCheckLib.buttonCheck();
            this.buttonCheck3 = new buttonCheckLib.buttonCheck();
            this.buttonCheck4 = new buttonCheckLib.buttonCheck();
            this.switch1 = new System.Windows.Forms.Label();
            this.switch2 = new System.Windows.Forms.Label();
            this.switch3 = new System.Windows.Forms.Label();
            this.switch4 = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCheck1
            // 
            this.buttonCheck1.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck1.Checked = false;
            this.buttonCheck1.Location = new System.Drawing.Point(366, 121);
            this.buttonCheck1.Name = "buttonCheck1";
            this.buttonCheck1.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck1.TabIndex = 0;
            // 
            // buttonCheck2
            // 
            this.buttonCheck2.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck2.Checked = false;
            this.buttonCheck2.Location = new System.Drawing.Point(366, 239);
            this.buttonCheck2.Name = "buttonCheck2";
            this.buttonCheck2.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck2.TabIndex = 1;
            // 
            // buttonCheck3
            // 
            this.buttonCheck3.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck3.Checked = false;
            this.buttonCheck3.Location = new System.Drawing.Point(510, 121);
            this.buttonCheck3.Name = "buttonCheck3";
            this.buttonCheck3.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck3.TabIndex = 2;
            // 
            // buttonCheck4
            // 
            this.buttonCheck4.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck4.Checked = false;
            this.buttonCheck4.Location = new System.Drawing.Point(510, 239);
            this.buttonCheck4.Name = "buttonCheck4";
            this.buttonCheck4.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck4.TabIndex = 3;
            // 
            // switch1
            // 
            this.switch1.AutoSize = true;
            this.switch1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch1.Location = new System.Drawing.Point(375, 96);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(51, 21);
            this.switch1.TabIndex = 4;
            this.switch1.Text = "开关1";
            // 
            // switch2
            // 
            this.switch2.AutoSize = true;
            this.switch2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch2.Location = new System.Drawing.Point(506, 99);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(51, 21);
            this.switch2.TabIndex = 5;
            this.switch2.Text = "开关2";
            // 
            // switch3
            // 
            this.switch3.AutoSize = true;
            this.switch3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch3.Location = new System.Drawing.Point(362, 214);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(51, 21);
            this.switch3.TabIndex = 6;
            this.switch3.Text = "开关3";
            // 
            // switch4
            // 
            this.switch4.AutoSize = true;
            this.switch4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch4.Location = new System.Drawing.Point(506, 217);
            this.switch4.Name = "switch4";
            this.switch4.Size = new System.Drawing.Size(51, 21);
            this.switch4.TabIndex = 7;
            this.switch4.Text = "开关4";
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(434, 329);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(75, 23);
            this.setting.TabIndex = 8;
            this.setting.Text = "设置";
            this.setting.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 379);
            this.Controls.Add(this.setting);
            this.Controls.Add(this.switch4);
            this.Controls.Add(this.switch3);
            this.Controls.Add(this.switch2);
            this.Controls.Add(this.switch1);
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
            this.PerformLayout();

        }

        #endregion

        private buttonCheckLib.buttonCheck buttonCheck1;
        private buttonCheckLib.buttonCheck buttonCheck2;
        private buttonCheckLib.buttonCheck buttonCheck3;
        private buttonCheckLib.buttonCheck buttonCheck4;
        private System.Windows.Forms.Label switch1;
        private System.Windows.Forms.Label switch2;
        private System.Windows.Forms.Label switch3;
        private System.Windows.Forms.Label switch4;
        private System.Windows.Forms.Button setting;
    }
}