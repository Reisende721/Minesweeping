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
{//重新写一个设置
    public partial class Form_Challenge : Form
    {
        Form_Main Main;
        private int num;
        private int choose;
        private int x, y, w, h;
        public string Filepath;

        public Form_Challenge()
        {
            InitializeComponent();
        }

        public Form_Challenge(Form_Main _Main, int choose, int x, int y, int w, int h)
        {
            InitializeComponent();
            Main = _Main;
            num = 1;
            File_label.Text = ":) 游戏愉快!";
            Filepath = "";
            this.choose = choose;
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        private void Form_Challenge_Load(object sender, EventArgs e)
        {
            File_textBox.Visible = false;
            Find_button.Visible = false;
            Label_Width.Visible = false;
            NumericUpDown_Width.Visible = false;
            Label_Height.Visible = false;
            NumericUpDown_Height.Visible = false;
            if (this.Size.Width < w)
            {
                x += (w - this.Size.Width) / 2;
            }
            if (this.Size.Height < h)
            {
                y += (h - this.Size.Height) / 2;
            }
            this.Location = new Point(x, y);
        }

        private void Next_label_Click(object sender, EventArgs e)
        {
            if (num == 5 && choose == 1)
            {
                Main.Sure_botton_(true);
                Main.nWidth = Convert.ToInt32(NumericUpDown_Width.Value);
                Main.nHeight = Convert.ToInt32(NumericUpDown_Height.Value);
                Main.nMineCnt = 0;
                Class_UI.Updatesize(Main, Main.menuStrip1, Main.panel1, Main.nWidth, Main.nHeight);
                this.Hide();
            }
            else if (num == 4 && choose == 2)
            {
                this.Hide();
            }
            if (choose == 1)
            {
                if (num == 1)
                {
                    File_label.Text = "在这里，你可以自定义雷区及地雷的位置。";
                    num++;
                }
                else if (num == 2)
                {
                    File_label.Text = "首先，定义雷区大小。";
                    Label_Width.Visible = true;
                    NumericUpDown_Width.Visible = true;
                    Label_Height.Visible = true;
                    NumericUpDown_Height.Visible = true;
                    num++;
                }
                else if (num == 3)
                {
                    File_label.Text = "设置文件保存路径";
                    Label_Width.Visible = false;
                    NumericUpDown_Width.Visible = false;
                    Label_Height.Visible = false;
                    NumericUpDown_Height.Visible = false;
                    File_textBox.Visible = true;
                    Find_button.Visible = true;
                    num++;
                }
                else if (num == 4 && File_textBox.Text != "")
                {
                    File_label.Text = "接下来你可以自定义地雷位置，\n最后点击右上角确定结束";
                    File_textBox.Visible = false;
                    Find_button.Visible = false;
                    num++;
                }
            }
            else if (choose == 2)
            {
                if (num == 1)
                {
                    File_label.Text = "在这里，你可以选择接收到的挑战，\n即来自好友的扫雷*.txt文件，\n导入它，开始游戏。";
                    num++;
                }
                else if (num == 2)
                {
                    File_label.Text = "导入文件的路径";
                    File_textBox.Visible = true;
                    Find_button.Visible = true;
                    num++;
                }
                else if (num == 3 && File_textBox.Text != "")
                {
                    File_textBox.Visible = false;
                    Find_button.Visible = false;
                    File_label.Text = "^-^点击确定开始游戏吧！";
                    Next_label.Text = "确 定";
                    num++;
                }
            }
        }

        private void Cancle_button_Click(object sender, EventArgs e)
        {
            Main.cflag = 3;
            Main.New_game();
            this.Close();
        }

        private void Find_button_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = "Mine_挑战.txt";
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.File_textBox.Text = saveFileDialog1.FileName;     //显示文件路径 
                    Filepath = saveFileDialog1.FileName;
                }
            }
            else if (choose == 2)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();   //显示选择文件对话框 
                //openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.File_textBox.Text = openFileDialog1.FileName;     //显示文件路径 
                    Filepath = openFileDialog1.FileName;
                }
            }
        }
    }
}
