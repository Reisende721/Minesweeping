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
    public partial class Form_Set : Form
    {
        Form_Main Main;
        private int x, y, w, h;

        public Form_Set()
        {
            InitializeComponent();
        }

        public Form_Set(Form_Main _Main, int x, int y, int w, int h)
        {
            InitializeComponent();
            Main = _Main;   //传递父窗口的实例
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            Main.nWidth = Convert.ToInt32(NumericUpDown_Width.Value);
            Main.nHeight = Convert.ToInt32(NumericUpDown_Height.Value);
            Main.nMineCnt = Convert.ToInt32(NumericUpDown_Mine.Value);
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Set_Load(object sender, EventArgs e)
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
            NumericUpDown_Width.Value = Convert.ToDecimal(Main.nWidth);
            NumericUpDown_Height.Value = Convert.ToDecimal(Main.nHeight);
            NumericUpDown_Mine.Value = Convert.ToDecimal(Main.nMineCnt);
        }
    }
}
