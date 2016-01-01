using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NineSky_desktop
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
            netAdress.Text = config.Default.netAdress;
            netPort.Text = config.Default.netPort;
            controlPort.Text = config.Default.controlPort;
        }

        private void setSure_Click(object sender, EventArgs e)
        {
            config.Default.netAdress = netAdress.Text;
            config.Default.netPort = netPort.Text;
            this.Close();
        }

        private void setExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
