using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeping_App
{
    class Class_UI
    {
        #region 界面更新设置
        /// <summary>
        /// 界面更新设置
        /// </summary>
        /// <param name="f"> 需要修改的窗体 </param>
        /// <param name="m"> 窗体内的菜单栏 </param>
        /// <param name="p"> 窗体内的容器 </param>
        /// <param name="nWidth"> 表示雷区的宽度 </param>
        /// <param name="nHeight"> 表示雷区的高度 </param>
        public static void Updatesize(Form f, MenuStrip m, Panel p, int nWidth, int nHeight)
        {
            int nOffsetX = f.Width - f.ClientSize.Width;             //包含了窗口标题栏以及上下边框的高度
            int nOffsetY = f.Height - f.ClientSize.Height;           //包含了左右边框的宽度
            int nAdditionY = m.Height + p.Height;                    //包含了菜单栏以及下方显示信息栏的高度
            f.Width = 12 + 34 * nWidth + nOffsetX;                   //设置窗口高度，34为每个雷区的高度，12为上下总空隙（6px+6px），再加上偏移量
            f.Height = 12 + 34 * nHeight + nAdditionY + nOffsetY;    //设置窗口宽度，同理
        }
        #endregion

        #region 游戏区绘制
        /// <summary>
        /// 游戏区绘制
        /// </summary>
        /// <param name="g"> 布局 </param>
        /// <param name="m"> 窗体内的菜单栏 </param>
        /// <param name="MouseFocus"> 高亮点 </param>
        /// <param name="nWidth"> 表示雷区的宽度 </param>
        /// <param name="nHeight"> 表示雷区的高度 </param>
        /// <param name="pMine"> 每个点的内容 </param>
        /// <param name="pstate"> 每个点的状态 </param>
        public static void Game_paint(Graphics g, MenuStrip m, Point MouseFocus, int nWidth, int nHeight, int[,] pMine, int [,] pstate)
        {
            g.Clear(Color.White);        //清空绘图区
            //雷区在用户显示的区域上下左右保持6px的偏移量，使得整体看起来更加协调
            int nOffsetX = 6;            //X方向偏移量
            int nOffsetY = 6 + m.Height; //Y方向偏移量
            for (int i = 1; i <= nWidth; ++i) //绘制行
            {
                for (int j = 1; j <= nHeight; ++j) //绘制列
                {
                    //第一个参数为笔刷，这里采用内置笔刷SandyBronw
                    //第二个参数为方块的参数，这里采用左上角坐标以及长宽的形式给出
                    if (pstate[i, j] != 1) //未点开
                    {
                        // 绘制背景
                        if (i == MouseFocus.X && j == MouseFocus.Y) //是否为高亮点
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.SandyBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32)); //绘制雷区方块
                        }
                        //绘制标记
                        if (pstate[i, j] == 2)
                        {
                            g.DrawImage(Properties.Resources.Flag, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);   // 绘制红旗
                        }
                        if (pstate[i, j] == 3)
                        {
                            g.DrawImage(Properties.Resources.Doubt, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);   // 绘制问号
                        }
                    }
                    else if (pstate[i, j] == 1) //点开
                    {
                        //绘制背景
                        if (MouseFocus.X == i && MouseFocus.Y == j)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.LightGray)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.LightGray, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        // 绘制数字
                        if (pMine[i, j] > 0)
                        {
                            Brush DrawBrush = new SolidBrush(Color.Blue);    // 定义钢笔
                            // 各个地雷数目的颜色
                            if (pMine[i, j] == 2) { DrawBrush = new SolidBrush(Color.Green); }
                            if (pMine[i, j] == 3) { DrawBrush = new SolidBrush(Color.Red); }
                            if (pMine[i, j] == 4) { DrawBrush = new SolidBrush(Color.DarkBlue); }
                            if (pMine[i, j] == 5) { DrawBrush = new SolidBrush(Color.DarkRed); }
                            if (pMine[i, j] == 6) { DrawBrush = new SolidBrush(Color.DarkSeaGreen); }
                            if (pMine[i, j] == 7) { DrawBrush = new SolidBrush(Color.Black); }
                            if (pMine[i, j] == 8) { DrawBrush = new SolidBrush(Color.DarkGray); }
                            SizeF Size = g.MeasureString(pMine[i, j].ToString(), new Font("Consolas", 16));
                            g.DrawString(pMine[i, j].ToString(), new Font("Consolas", 16), DrawBrush, nOffsetX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, nOffsetY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);
                        }
                        // 绘制地雷
                        if (pMine[i, j] == -1)
                        {
                            g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);   // 绘制地雷
                        }
                    }
                }
            }
        }
        #endregion

        #region 发起挑战游戏区绘制
        /// <summary>
        /// 游戏区绘制
        /// </summary>
        /// <param name="g"> 布局 </param>
        /// <param name="m"> 窗体内的菜单栏 </param>
        /// <param name="MouseFocus"> 高亮点 </param>
        /// <param name="nWidth"> 表示雷区的宽度 </param>
        /// <param name="nHeight"> 表示雷区的高度 </param>
        /// <param name="pMine"> 每个点的内容 </param>
        /// <param name="pstate"> 每个点的状态 </param>
        public static void Game_paintC(Graphics g, MenuStrip m, Point MouseFocus, int nWidth, int nHeight, int[,] pMine, int[,] pstate)
        {
            g.Clear(Color.White);        //清空绘图区
            //雷区在用户显示的区域上下左右保持6px的偏移量，使得整体看起来更加协调
            int nOffsetX = 6;            //X方向偏移量
            int nOffsetY = 6 + m.Height; //Y方向偏移量
            for (int i = 1; i <= nWidth; ++i) //绘制行
            {
                for (int j = 1; j <= nHeight; ++j) //绘制列
                {
                    //第一个参数为笔刷，这里采用内置笔刷SandyBronw
                    //第二个参数为方块的参数，这里采用左上角坐标以及长宽的形式给出
                    // 绘制背景
                    if (pstate[i, j] != 1) //未点开
                    {
                        // 绘制背景
                        if (i == MouseFocus.X && j == MouseFocus.Y) //是否为高亮点
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.SandyBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32)); //绘制雷区方块
                        }
                    }
                    else if (pstate[i, j] == 1)
                    {
                        //绘制背景
                        if (MouseFocus.X == i && MouseFocus.Y == j)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.LightGray)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.LightGray, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        //绘制标记
                        if (pMine[i, j] == -1)
                        {
                            g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);   // 绘制问号
                        }
                    }
                }
            }
        }
        #endregion

        #region 鼠标移动的游戏区显示
        /// <summary>
        /// 鼠标移动的游戏区显示
        /// </summary>
        /// /// <param name="f"> 需要修改的窗体 </param>
        /// <param name="m"> 窗体内的菜单栏 </param>
        /// <param name="MouseFocus"> 高亮点 </param>
        /// <param name="e"> 鼠标位置 </param>
        /// <param name="nWidth"> 表示雷区的宽度 </param>
        /// <param name="nHeight"> 表示雷区的高度 </param>
        public static void Game_MouseMove(Form f, MenuStrip m, ref Point MouseFocus, MouseEventArgs e, int nWidth, int nHeight)
        {
            if (e.X < 6 || e.X > 6 + nWidth * 34 || e.Y < 6 + m.Height || e.Y > 6 + m.Height + nHeight * 34) //不在地雷区域
            {
                MouseFocus.X = 0;
                MouseFocus.Y = 0;
            }
            else
            {
                int x = (e.X - 6) / 34 + 1;            //获取x位置
                int y = (e.Y - m.Height - 6) / 34 + 1; //获取y位置
                MouseFocus.X = x;
                MouseFocus.Y = y;                      //设置当前高亮点
            }
            f.Refresh();                               //重绘雷区
        }
        #endregion

        #region 雷区绘制
        /// <summary>
        /// 雷区绘制
        /// </summary>
        /// <param name="g"> 布局 </param>
        /// <param name="m"> 窗体内的菜单栏 </param>
        /// <param name="nWidth"> 表示雷区的宽度 </param>
        /// <param name="nHeight"> 表示雷区的高度 </param>
        /// <param name="pMine"> 每个点的内容 </param>
        /// <param name="pstate"> 每个点的状态 </param>
        public static void Mine_paint(Graphics g, MenuStrip m, int nWidth, int nHeight, int[,] pMine, int[,] pstate)
        {
            int nOffsetX = 6;            //X方向偏移量
            int nOffsetY = 6 + m.Height; //Y方向偏移量
            for (int i = 1; i <= nWidth; ++i) //绘制行
            {
                for (int j = 1; j <= nHeight; ++j) //绘制列
                {
                    if (pMine[i, j] == -1)
                    {
                        if (pstate[i, j] == 0 || pstate[i, j] == 3) //未点开
                        {
                            g.FillRectangle(Brushes.LightGreen, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else if (pstate[i, j] == 2) //已标记
                        {
                            g.FillRectangle(Brushes.LightSkyBlue, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else if (pstate[i, j] == 1) //点开
                        {
                            g.FillRectangle(Brushes.Red, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2); //绘制地雷
                    }
                    else if (pstate[i, j] == 2)
                    {
                        g.FillRectangle(Brushes.SaddleBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2); //绘制地雷
                    }
                }
            }
        }
        #endregion
    }
}
