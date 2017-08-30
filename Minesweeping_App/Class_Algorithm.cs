using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeping_App
{
    class Class_Algorithm
    {
        private static int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 }; //x坐标偏移量
        private static int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 }; //y坐标偏移量
        private static int[] px = new int[] { 1, -1, 0, 0, 1, -1, 1, -1 }; //四方向x坐标偏移量
        private static int[] py = new int[] { 0, 0, 1, -1, 1, 1, -1, -1 }; //四方向y坐标偏移量

        #region 扫雷随机生成算法
        /// <summary>
        /// 扫雷随机生成算法
        /// </summary>
        /// <param name="pMine"> 每个点的内容 </param>
        /// <param name="pstate"> 每个点的状态 </param>
        /// <param name="nWidth"> 雷区的宽度 </param>
        /// <param name="nHeight"> 雷区的高度 </param>
        /// <param name="nMineCnt"> 地雷数目 </param>
        /// <param name="MouseFocus"> 高亮点 </param>
        public static void Mine_generate(ref int[,] pMine, ref int[,] pstate, int nWidth, int nHeight, int nMineCnt, ref Point MouseFocus)
        {
            //初始化
            Array.Clear(pMine, 0, pMine.Length);
            Array.Clear(pstate, 0, pstate.Length);
            MouseFocus.X = MouseFocus.Y = 0;

            //生成随机地雷坐标
            Random rand = new Random();
            for (int i = 1; i < nMineCnt + 1; )
            {
                int x = rand.Next(nWidth) + 1;
                int y = rand.Next(nHeight) + 1;
                if (pMine[x, y] != -1)
                {
                    pMine[x, y] = -1;
                    i++;
                }
            }

            //生成雷区的每个点的信息
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
        }
        #endregion

        #region 扫雷一次点击后拓展算法
        /// <summary>
        /// 扫雷一次点击后拓展算法
        /// </summary>
        /// <param name="pMine"> 每个点的内容 </param>
        /// <param name="pstate"> 每个点的状态 </param>
        /// <param name="nWidth"> 雷区的宽度 </param>
        /// <param name="nHeight"> 雷区的高度 </param>
        /// <param name="MouseFocus"> 高亮点 </param>
        public static void Mine_solve(int[,] pMine, ref int[,] pstate, int nWidth, int nHeight, Point MouseFocus)
        {
            int sx = MouseFocus.X, sy = MouseFocus.Y;
            pstate[sx, sy] = 1; //访问该点
            for(int i = 0; i < 8; i++)
            {
                int x = sx + px[i];
                int y = sy + py[i];
                if(x >= 1 && x <= nWidth && y >= 1 && y <= nHeight
                   && pMine[x, y] != -1 && pMine[sx, sy] == 0
                   && (pstate[x, y] == 0 || pstate[x, y] == 3))
                {
                    MouseFocus.X = x;
                    MouseFocus.Y = y;
                    Mine_solve(pMine, ref pstate, nWidth, nHeight, MouseFocus); //访问该点
                }
            }
        }
        #endregion
    }
}
