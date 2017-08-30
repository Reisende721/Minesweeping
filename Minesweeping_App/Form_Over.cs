using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeping_App
{
    public partial class Form_Over : Form
    {
        private String Time;
        private bool flag;
        private int x, y, w, h;

        public Form_Over()
        {
            InitializeComponent();
        }

        public Form_Over(String t, bool f, int x, int y, int w, int h)
        {
            InitializeComponent();
            this.Time = t;
            this.flag = f;
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        private void Form_Over_Load(object sender, EventArgs e)
        {
            if (this.Size.Width < w)
            {
                x += (w - this.Size.Width) / 2;
            }
            if (this.Size.Height < h)
            {
                y += (h - this.Size.Height) / 2;
            }
            this.Location = new Point(x, y);
            if (flag)
            {
                pictureBox1.Image = Properties.Resources.win;
                label1.Text = ":) 你赢了！\n游戏花费时间：" + Time + "秒";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.fail;
                label1.Text = "T_T 很遗憾，你输了。";
            }
        }
    }
}
