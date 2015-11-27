using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using buttonCheckLib;

namespace NineSky_desktop
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void setting_Click(object sender, EventArgs e)
        {//打开新窗体
            setting newform = new setting();
            newform.Show(); 
        }

        private void startMonitor_Click(object sender, EventArgs e)
        {
            Monitor newMon = new Monitor();
            newMon.Show();
        }
    }
}
