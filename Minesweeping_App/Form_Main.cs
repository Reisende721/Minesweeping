using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeping_App
{
    public partial class Form_Main : Form
    {
        private Form_Challenge challenge;                       //预留，解决一个尚未处理的代码逻辑问题
        private const int max_Width = 64;                       //最大宽度
        private const int max_Height = 32;                      //最大高度
        private const int max_MineCnt = 520;                    //最大地雷数目 参考值，，随意设定的
        public int nWidth;                                      //表示雷区的宽度
        public int nHeight;                                     //表示雷区的高度
        public int nMineCnt;                                    //表示地雷的数目
        private int[,] pMine = new int[max_Height, max_Width];  //每个点的内容
        private int[,] pstate = new int[max_Height, max_Width]; //每个点的状态
        private bool bMouseLeft;                                //鼠标左键是否按下
        private bool bMouseRight;                               //鼠标右键是否按下
        private bool game_over;                                 //游戏是否结束的标志
        private bool game_run;                                  //游戏是否还在运行的标志
        private bool vaudio;                                    //游戏声音是否开启
        public int cflag;                                       //是否有挑战的标志
        private Point MouseFocus;                               //高亮点记录
        System.Media.SoundPlayer soundBomb;                     //爆炸

        public Form_Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //开启双缓冲
            
            //初始化设置
            Game_set(10, 10, 10);
            Menu_select(1);
            New_game();
            soundBomb = new System.Media.SoundPlayer(Properties.Resources.Bomb);
            cflag = 0;
            vaudio = false;
        }

        #region 计时器设置
        /// <summary>
        /// 控制计时器的显示
        /// </summary>
        /// <param name="Timer_flag">  true 启动 </param>
        /// <param name="game_run">  true 游戏在进行中 </param>
        private void Timer_set(Boolean Timer_flag)
        {
            timer1.Enabled = false;
            game_run = false;
            if (Timer_flag)//启动
            {
                Time_label.Text = "0";
                timer1.Enabled = true;
                game_run = true;
                Num_label.Text = nMineCnt.ToString();
            }
        }

        /// <summary>
        /// 控制计时器的运行
        /// </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            Time_label.Text = Convert.ToString(Convert.ToInt32(Time_label.Text) + 1); //自增1秒
        }
        #endregion

        #region 新的游戏
        public void New_game()
        {
            if (cflag == 1 || cflag == 2 || cflag == 3)
            {
                Game_set(10, 10, 10);
                Menu_select(1);
                cflag = 0;
                Timer_set(true);
                game_run = true;
                game_over = false;
                Class_UI.Updatesize(this, this.menuStrip1, this.panel1, nWidth, nHeight);
                Class_Algorithm.Mine_generate(ref pMine, ref pstate, nWidth, nHeight, nMineCnt, ref MouseFocus);
            }
            else
            {
                Timer_set(true);
                game_run = true;
                game_over = false;
                Class_UI.Updatesize(this, this.menuStrip1, this.panel1, nWidth, nHeight);
                Class_Algorithm.Mine_generate(ref pMine, ref pstate, nWidth, nHeight, nMineCnt, ref MouseFocus);
            }
        }
        #endregion

        #region 菜单栏设置
        private void NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FStripMenuItem.Visible = false;
            Sure_button.Visible = false;
            PS_label.Visible = false;
            if (SToolStripMenuItem.Checked == true)
            {
                SToolStripMenuItem.Checked = false;
                Game_set(10, 10, 10);
                Menu_select(1);
            }
            if (cflag == 2)
            {
                cflag = 0;
                Game_set(10, 10, 10);
                Menu_select(1);
            }
            New_game();
        }

        private void FStripMenuItem_Click(object sender, EventArgs e)
        {
            Array.Clear(pstate, 0, pstate.Length);
            FStripMenuItem.Visible = false;
            game_over = false;
            Timer_set(true);
            Sure_button.Visible = false;
            PS_label.Visible = false;
        }

        private void BaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_select(1);
            Game_set(10, 10, 10);
            NToolStripMenuItem_Click(sender, e);
        }

        private void IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_select(2);
            Game_set(16, 16, 40);
            NToolStripMenuItem_Click(sender, e);
        }

        private void EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_select(3);
            Game_set(30, 16, 99);
            NToolStripMenuItem_Click(sender, e);
        }

        private void SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_select(4);
            Form_Set f = new Form_Set(this, this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            f.ShowDialog();
            New_game();
        }

        private void CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cflag = 1;
            challenge = new Form_Challenge(this, 1, this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            Timer_set(false);
            Time_label.Text = "0";
            Num_label.Text = "0";
            Array.Clear(pMine, 0, pMine.Length);
            Array.Clear(pstate, 0, pstate.Length);
            Menu_select(5);
            challenge.ShowDialog();
        }

        private void DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu_select(6);
            cflag = 2;
            challenge = new Form_Challenge(this, 2, this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            challenge.ShowDialog();
            if (challenge.Filepath != "")
            {
                Array.Clear(pMine, 0, pMine.Length);
                Array.Clear(pstate, 0, pstate.Length);
                String fp = challenge.Filepath; //文件路径

                //读取文件
                StreamReader sr = File.OpenText(fp);
                string s;
                string[] ss;
                s = sr.ReadLine();
                ss = s.Split(',');
                nWidth = Convert.ToInt32(ss[0]);
                nHeight = Convert.ToInt32(ss[1]);
                nMineCnt = Convert.ToInt32(ss[2]);
                for (int i = 0; i < nWidth; ++i)
                {
                    s = sr.ReadLine();
                    ss = s.Split(',');
                    for (int j = 0; j < nHeight; ++j)
                    {
                        pMine[i + 1, j + 1] = Convert.ToInt32(ss[j]);
                    }
                }
                sr.Close();

                cflag = 0;
                Timer_set(true);
                game_run = true;
                game_over = false;
                Num_label.Text = nMineCnt.ToString();
                Class_UI.Updatesize(this, this.menuStrip1, this.panel1, nWidth, nHeight);
            }
            challenge.Close();
        }

        private void VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vaudio)
            {
                vaudio = false;
                VToolStripMenuItem.Checked = false;
            }
            else
            {
                vaudio = true;
                VToolStripMenuItem.Checked = true;
            }
        }

        private void Sure_button_Click(object sender, EventArgs e)
        {
            Sure_botton_(false);
            String fp = challenge.Filepath; //文件路径
            challenge.Close();
            cflag = 2;

            //生成雷区的每个点的信息
            Array.Clear(pstate, 0, pstate.Length);
            int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 }; //x坐标偏移量
            int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 }; //y坐标偏移量
            for (int i = 1; i <= nWidth; i++) //枚举宽度
            {
                for (int j = 1; j <= nHeight; j++) //枚举高度
                {
                    if (pMine[i, j] != -1) //不是地雷，显示周围地雷数
                    {
                        for (int k = 0; k < 8; k++) //八个方向拓展
                        {
                            if (pMine[i + dx[k], j + dy[k]] == -1) //找到地雷
                            {
                                pMine[i, j]++; //地雷数自增
                            }
                        }
                    }
                }
            }

            //二维数组写入文件并保存(*.txt)
            FileStream fs = new FileStream(fp, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(nWidth);
            sw.Write(',');
            sw.Write(nHeight);
            sw.Write(',');
            sw.Write(nMineCnt);
            sw.WriteLine();
            for (int i = 1; i <= nWidth; i++)
            {
                for (int j = 1; j <= nHeight; j++)
                {
                    sw.Write(pMine[i, j]);
                    if (j < nHeight)
                    {
                        sw.Write(',');
                    }
                }
                sw.WriteLine();
            }
            sw.Flush();
            sw.Close();
            fs.Close();

            Timer_set(true);
            game_over = false;
            Class_UI.Updatesize(this, this.menuStrip1, this.panel1, nWidth, nHeight);
        }

        /// <summary>
        /// 系统关于对话框（API）
        /// </summary>
        /// <param name="hWnd"> 窗口句柄 </param>
        /// <param name="szApp"> 标题文本 </param>
        /// <param name="szOtherStuff"> 内容文本 </param>
        /// <param name="hIcon"> 图标句柄 </param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        private void AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShellAbout(this.Handle, "扫雷", "A minesweeper game using C# language by Reisende_721\nMinesweeper V1.1", this.Icon.Handle);
        }
        #endregion

        #region 游戏参数设置
        /// <summary>
        /// 游戏参数设置
        /// </summary>
        /// <param name="width"> 雷区的宽度 </param>
        /// <param name="height"> 雷区的高度 </param>
        /// <param name="minecnt"> 地雷的数目 </param>
        private void Game_set(int width, int height, int minecnt)
        {
            nWidth = width;
            nHeight = height;
            nMineCnt = minecnt;
            Num_label.Text = nMineCnt.ToString();
        }
        #endregion

        #region 菜单栏的选择
        private void Menu_select(int Menu_flag)
        {
            BaseToolStripMenuItem.Checked = false;
            IToolStripMenuItem.Checked = false;
            EToolStripMenuItem.Checked = false;
            SToolStripMenuItem.Checked = false;
            CToolStripMenuItem.Checked = false;
            DToolStripMenuItem.Checked = false;
            if (Menu_flag == 1)
            {
                BaseToolStripMenuItem.Checked = true;
            }
            else if (Menu_flag == 2)
            {
                IToolStripMenuItem.Checked = true;
            }
            else if (Menu_flag == 3)
            {
                EToolStripMenuItem.Checked = true;
            }
            else if (Menu_flag == 4)
            {
                SToolStripMenuItem.Checked = true;
            }
            else if (Menu_flag == 5)
            {
                CToolStripMenuItem.Checked = true;
            }
            else if (Menu_flag == 6)
            {
                DToolStripMenuItem.Checked = true;
            }
        }
        #endregion

        #region 游戏区绘制
        private void Form_Main_Paint(object sender, PaintEventArgs e)
        {
            if (cflag == 1) //这个为当处于发起挑战操作时
            {
                Class_UI.Game_paintC(e.Graphics, this.menuStrip1, MouseFocus, nWidth, nHeight, pMine, pstate);
            }
            else
            {
                Class_UI.Game_paint(e.Graphics, this.menuStrip1, MouseFocus, nWidth, nHeight, pMine, pstate);
                if (game_over)
                {
                    Class_UI.Mine_paint(e.Graphics, this.menuStrip1, nWidth, nHeight, pMine, pstate);
                }
            }
        }
        #endregion

        #region 鼠标移动
        private void Form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            Class_UI.Game_MouseMove(this, this.menuStrip1, ref MouseFocus, e, nWidth, nHeight);
        }
        #endregion

        #region 鼠标按下
        private void Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //鼠标左键被按下
            {
                bMouseLeft = true;
            }
            if (e.Button == MouseButtons.Right) //鼠标右键被按下
            {
                bMouseRight = true;
            }
        }
        #endregion

        #region 鼠标按下后释放
        private void Form_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (cflag == 1) //这个为当处于发起挑战操作时
            {
                if (MouseFocus.X != 0 && MouseFocus.Y != 0 && !(bMouseLeft && bMouseRight))
                {
                    if (bMouseLeft)
                    {
                        if (pMine[MouseFocus.X, MouseFocus.Y] == 0)
                        {
                            pMine[MouseFocus.X, MouseFocus.Y] = -1;
                            pstate[MouseFocus.X, MouseFocus.Y] = 1;
                            nMineCnt++;
                            Num_label.Text = Convert.ToString(Convert.ToInt32(Num_label.Text) + 1); //地雷数目加1
                        }
                    }
                    else if (bMouseRight)
                    {
                        if (pMine[MouseFocus.X, MouseFocus.Y] == -1)
                        {
                            pMine[MouseFocus.X, MouseFocus.Y] = 0;
                            pstate[MouseFocus.X, MouseFocus.Y] = 0;
                            nMineCnt--;
                            Num_label.Text = Convert.ToString(Convert.ToInt32(Num_label.Text) - 1); //地雷数目减1
                        }
                    }
                    this.Refresh();
                    bMouseLeft = bMouseRight = false;
                }
            }
            else
            {
                if (MouseFocus.X != 0 && MouseFocus.Y != 0 && !(bMouseLeft && bMouseRight) && game_run)
                {
                    if (bMouseLeft)
                    {
                        if (pMine[MouseFocus.X, MouseFocus.Y] == -1)
                        {
                            //游戏结束
                            if (pstate[MouseFocus.X, MouseFocus.Y] == 0)
                            {
                                pstate[MouseFocus.X, MouseFocus.Y] = 1;
                                game_over = true;
                                if (vaudio)
                                {
                                    soundBomb.Play();
                                }
                            }
                        }
                        else
                        {
                            Class_Algorithm.Mine_solve(pMine, ref pstate, nWidth, nHeight, MouseFocus);
                        }
                    }
                    else if (bMouseRight)
                    {
                        if (pstate[MouseFocus.X, MouseFocus.Y] == 0) //未点开
                        {
                            if (Convert.ToInt32(Num_label.Text) > 0)
                            {
                                pstate[MouseFocus.X, MouseFocus.Y] = 2; //红旗
                                Num_label.Text = Convert.ToString(Convert.ToInt32(Num_label.Text) - 1); //剩余地雷数目减1
                            }
                        }
                        else if (pstate[MouseFocus.X, MouseFocus.Y] == 2) //红旗
                        {
                            pstate[MouseFocus.X, MouseFocus.Y] = 3; //问号
                            Num_label.Text = Convert.ToString(Convert.ToInt32(Num_label.Text) + 1); //剩余地雷数目加1
                        }
                        else if (pstate[MouseFocus.X, MouseFocus.Y] == 3) //问号
                        {
                            pstate[MouseFocus.X, MouseFocus.Y] = 0; //未点开
                        }
                    }
                    this.Refresh();
                    bMouseLeft = bMouseRight = false;
                    Game_over();
                }
            }
        }
        #endregion

        #region 游戏结果是否结束判断
        private void Game_over()
        {
            if (game_run)
            {
                if (game_over) //输了
                {
                    FStripMenuItem.Visible = true;
                    Timer_set(false);
                    Form_Over f = new Form_Over("0", false, this.Location.X, this.Location.Y, this.Size .Width, this.Size.Height);
                    f.ShowDialog();
                }
                else //判断赢了没
                {
                    int win = 0;
                    for (int i = 1; i < nWidth + 1; ++i)
                    {
                        for (int j = 1; j < nHeight + 1; ++j)
                        {
                            if ((pstate[i, j] == 1 && pMine[i, j] != -1) || (pstate[i, j] == 2 && pMine[i, j] == -1))
                            {
                                win++;
                            }
                        }
                    }
                    if (win == nWidth * nHeight)
                    {
                        Timer_set(false);
                        Form_Over f = new Form_Over(Time_label.Text, true, this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
                        f.ShowDialog();
                    }
                }
            }
        }
        #endregion

        #region 显示\隐藏 右上角的确定控件
        public void Sure_botton_(bool s)
        {
            if (s)
            {
                Sure_button.Visible = true;
                PS_label.Visible = true;
            }
            else
            {
                Sure_button.Visible = false;
                PS_label.Visible = false;
            }
        }
        #endregion
    }
}
