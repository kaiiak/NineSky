using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NineSky_desktop;

namespace buttonCheck
{
    public partial class buttonCheck : UserControl
    {
        public buttonCheck()
        {
            InitializeComponent();

            //设置Style支持透明背景色并且双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
        }
        bool isCheck = false;

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Checked
        {
            set { isCheck = value; this.Invalidate(); }
            get { return isCheck; }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitMapOn = null;
            Bitmap bitMapOff = null;

           
            bitMapOn = global::NineSky_desktop.Properties.Resources.open;
            bitMapOff = global::NineSky_desktop.Properties.Resources.close;


            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            if (isCheck)
            {
                g.DrawImage(bitMapOn, rec);
            }
            else
            {
                g.DrawImage(bitMapOff, rec);
            }
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            isCheck = !isCheck;
            this.Invalidate();
        }
    }
}
