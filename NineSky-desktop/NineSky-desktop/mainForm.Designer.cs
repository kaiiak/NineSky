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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonCheck1 = new buttonCheckLib.buttonCheck();
            this.buttonCheck2 = new buttonCheckLib.buttonCheck();
            this.buttonCheck3 = new buttonCheckLib.buttonCheck();
            this.buttonCheck4 = new buttonCheckLib.buttonCheck();
            this.switch1 = new System.Windows.Forms.Label();
            this.switch2 = new System.Windows.Forms.Label();
            this.switch3 = new System.Windows.Forms.Label();
            this.switch4 = new System.Windows.Forms.Label();
            this.settingBtn = new System.Windows.Forms.Button();
            this.startMonitor = new System.Windows.Forms.Button();
            this.cpuTem = new System.Windows.Forms.Label();
            this.gpuTem = new System.Windows.Forms.Label();
            this.showCpuTem = new System.Windows.Forms.Label();
            this.showGpuTem = new System.Windows.Forms.Label();
            this.memUse = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.memUse)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheck1
            // 
            this.buttonCheck1.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck1.Checked = false;
            this.buttonCheck1.Location = new System.Drawing.Point(328, 74);
            this.buttonCheck1.Name = "buttonCheck1";
            this.buttonCheck1.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck1.TabIndex = 0;
            // 
            // buttonCheck2
            // 
            this.buttonCheck2.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck2.Checked = false;
            this.buttonCheck2.Location = new System.Drawing.Point(328, 192);
            this.buttonCheck2.Name = "buttonCheck2";
            this.buttonCheck2.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck2.TabIndex = 1;
            // 
            // buttonCheck3
            // 
            this.buttonCheck3.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck3.Checked = false;
            this.buttonCheck3.Location = new System.Drawing.Point(472, 74);
            this.buttonCheck3.Name = "buttonCheck3";
            this.buttonCheck3.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck3.TabIndex = 2;
            // 
            // buttonCheck4
            // 
            this.buttonCheck4.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheck4.Checked = false;
            this.buttonCheck4.Location = new System.Drawing.Point(472, 192);
            this.buttonCheck4.Name = "buttonCheck4";
            this.buttonCheck4.Size = new System.Drawing.Size(85, 35);
            this.buttonCheck4.TabIndex = 3;
            // 
            // switch1
            // 
            this.switch1.AutoSize = true;
            this.switch1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch1.Location = new System.Drawing.Point(337, 49);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(51, 21);
            this.switch1.TabIndex = 4;
            this.switch1.Text = "开关1";
            // 
            // switch2
            // 
            this.switch2.AutoSize = true;
            this.switch2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch2.Location = new System.Drawing.Point(468, 52);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(51, 21);
            this.switch2.TabIndex = 5;
            this.switch2.Text = "开关2";
            // 
            // switch3
            // 
            this.switch3.AutoSize = true;
            this.switch3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch3.Location = new System.Drawing.Point(324, 167);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(51, 21);
            this.switch3.TabIndex = 6;
            this.switch3.Text = "开关3";
            // 
            // switch4
            // 
            this.switch4.AutoSize = true;
            this.switch4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch4.Location = new System.Drawing.Point(468, 170);
            this.switch4.Name = "switch4";
            this.switch4.Size = new System.Drawing.Size(51, 21);
            this.switch4.TabIndex = 7;
            this.switch4.Text = "开关4";
            // 
            // settingBtn
            // 
            this.settingBtn.Location = new System.Drawing.Point(472, 289);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(75, 23);
            this.settingBtn.TabIndex = 8;
            this.settingBtn.Text = "设置";
            this.settingBtn.UseVisualStyleBackColor = true;
            this.settingBtn.Click += new System.EventHandler(this.setting_Click);
            // 
            // startMonitor
            // 
            this.startMonitor.Location = new System.Drawing.Point(369, 289);
            this.startMonitor.Name = "startMonitor";
            this.startMonitor.Size = new System.Drawing.Size(75, 23);
            this.startMonitor.TabIndex = 9;
            this.startMonitor.Text = "开始监控";
            this.startMonitor.UseVisualStyleBackColor = true;
            this.startMonitor.Click += new System.EventHandler(this.startMonitor_Click);
            // 
            // cpuTem
            // 
            this.cpuTem.AutoSize = true;
            this.cpuTem.BackColor = System.Drawing.SystemColors.Control;
            this.cpuTem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpuTem.Location = new System.Drawing.Point(101, 340);
            this.cpuTem.Name = "cpuTem";
            this.cpuTem.Size = new System.Drawing.Size(91, 21);
            this.cpuTem.TabIndex = 10;
            this.cpuTem.Text = "CPU温度：";
            // 
            // gpuTem
            // 
            this.gpuTem.AutoSize = true;
            this.gpuTem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gpuTem.Location = new System.Drawing.Point(328, 340);
            this.gpuTem.Name = "gpuTem";
            this.gpuTem.Size = new System.Drawing.Size(92, 21);
            this.gpuTem.TabIndex = 11;
            this.gpuTem.Text = "GPU温度：";
            // 
            // showCpuTem
            // 
            this.showCpuTem.AutoSize = true;
            this.showCpuTem.BackColor = System.Drawing.Color.LawnGreen;
            this.showCpuTem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showCpuTem.Location = new System.Drawing.Point(198, 340);
            this.showCpuTem.Name = "showCpuTem";
            this.showCpuTem.Size = new System.Drawing.Size(55, 21);
            this.showCpuTem.TabIndex = 12;
            this.showCpuTem.Text = "label3";
            // 
            // showGpuTem
            // 
            this.showGpuTem.AutoSize = true;
            this.showGpuTem.BackColor = System.Drawing.Color.LawnGreen;
            this.showGpuTem.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showGpuTem.Location = new System.Drawing.Point(425, 340);
            this.showGpuTem.Name = "showGpuTem";
            this.showGpuTem.Size = new System.Drawing.Size(55, 21);
            this.showGpuTem.TabIndex = 13;
            this.showGpuTem.Text = "label4";
            // 
            // memUse
            // 
            chartArea1.Name = "ChartArea1";
            this.memUse.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.memUse.Legends.Add(legend1);
            this.memUse.Location = new System.Drawing.Point(12, 12);
            this.memUse.Name = "memUse";
            this.memUse.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.memUse.Series.Add(series1);
            this.memUse.Size = new System.Drawing.Size(300, 300);
            this.memUse.TabIndex = 14;
            this.memUse.Text = "memUse";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 379);
            this.Controls.Add(this.memUse);
            this.Controls.Add(this.showGpuTem);
            this.Controls.Add(this.showCpuTem);
            this.Controls.Add(this.gpuTem);
            this.Controls.Add(this.cpuTem);
            this.Controls.Add(this.startMonitor);
            this.Controls.Add(this.settingBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.memUse)).EndInit();
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
        private System.Windows.Forms.Button settingBtn;
        private System.Windows.Forms.Button startMonitor;
        private System.Windows.Forms.Label cpuTem;
        private System.Windows.Forms.Label gpuTem;
        private System.Windows.Forms.Label showCpuTem;
        private System.Windows.Forms.Label showGpuTem;
        private System.Windows.Forms.DataVisualization.Charting.Chart memUse;
    }
}