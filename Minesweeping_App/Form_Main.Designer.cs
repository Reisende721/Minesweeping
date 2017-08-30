namespace Minesweeping_App
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Time_label = new System.Windows.Forms.Label();
            this.Num_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Sure_button = new System.Windows.Forms.Button();
            this.PS_label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(386, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GameToolStripMenuItem
            // 
            this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FStripMenuItem,
            this.NToolStripMenuItem,
            this.toolStripSeparator1,
            this.BaseToolStripMenuItem,
            this.IToolStripMenuItem,
            this.EToolStripMenuItem,
            this.SToolStripMenuItem,
            this.toolStripSeparator2,
            this.CToolStripMenuItem,
            this.DToolStripMenuItem,
            this.toolStripSeparator3,
            this.VToolStripMenuItem});
            this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
            this.GameToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.GameToolStripMenuItem.Text = "游戏(&G)";
            // 
            // FStripMenuItem
            // 
            this.FStripMenuItem.Name = "FStripMenuItem";
            this.FStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.FStripMenuItem.Text = "重新开始(&F)";
            this.FStripMenuItem.Visible = false;
            this.FStripMenuItem.Click += new System.EventHandler(this.FStripMenuItem_Click);
            // 
            // NToolStripMenuItem
            // 
            this.NToolStripMenuItem.Name = "NToolStripMenuItem";
            this.NToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.NToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NToolStripMenuItem.Text = "新游戏(&N)";
            this.NToolStripMenuItem.Click += new System.EventHandler(this.NToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // BaseToolStripMenuItem
            // 
            this.BaseToolStripMenuItem.Name = "BaseToolStripMenuItem";
            this.BaseToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.BaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BaseToolStripMenuItem.Text = "初级(&B)";
            this.BaseToolStripMenuItem.Click += new System.EventHandler(this.BaseToolStripMenuItem_Click);
            // 
            // IToolStripMenuItem
            // 
            this.IToolStripMenuItem.Name = "IToolStripMenuItem";
            this.IToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.IToolStripMenuItem.Text = "中级(&I)";
            this.IToolStripMenuItem.Click += new System.EventHandler(this.IToolStripMenuItem_Click);
            // 
            // EToolStripMenuItem
            // 
            this.EToolStripMenuItem.Name = "EToolStripMenuItem";
            this.EToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EToolStripMenuItem.Text = "高级(&E)";
            this.EToolStripMenuItem.Click += new System.EventHandler(this.EToolStripMenuItem_Click);
            // 
            // SToolStripMenuItem
            // 
            this.SToolStripMenuItem.Name = "SToolStripMenuItem";
            this.SToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SToolStripMenuItem.Text = "自定义(&S)";
            this.SToolStripMenuItem.Click += new System.EventHandler(this.SToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // CToolStripMenuItem
            // 
            this.CToolStripMenuItem.Name = "CToolStripMenuItem";
            this.CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.CToolStripMenuItem.Text = "发起挑战(&C)";
            this.CToolStripMenuItem.Click += new System.EventHandler(this.CToolStripMenuItem_Click);
            // 
            // DToolStripMenuItem
            // 
            this.DToolStripMenuItem.Name = "DToolStripMenuItem";
            this.DToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DToolStripMenuItem.Text = "接受挑战(&D)";
            this.DToolStripMenuItem.Click += new System.EventHandler(this.DToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // VToolStripMenuItem
            // 
            this.VToolStripMenuItem.Name = "VToolStripMenuItem";
            this.VToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.VToolStripMenuItem.Text = "声音(&V)";
            this.VToolStripMenuItem.Click += new System.EventHandler(this.VToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.HelpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // AToolStripMenuItem
            // 
            this.AToolStripMenuItem.Name = "AToolStripMenuItem";
            this.AToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.AToolStripMenuItem.Text = "关于(&A)";
            this.AToolStripMenuItem.Click += new System.EventHandler(this.AToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 43);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.21428F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.21428F));
            this.tableLayoutPanel1.Controls.Add(this.Time_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Num_label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Time_label.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold);
            this.Time_label.ForeColor = System.Drawing.Color.Blue;
            this.Time_label.Location = new System.Drawing.Point(92, 0);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(97, 40);
            this.Time_label.TabIndex = 1;
            this.Time_label.Text = "Time";
            this.Time_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Num_label
            // 
            this.Num_label.AutoSize = true;
            this.Num_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Num_label.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold);
            this.Num_label.ForeColor = System.Drawing.Color.Red;
            this.Num_label.Location = new System.Drawing.Point(195, 0);
            this.Num_label.Name = "Num_label";
            this.Num_label.Size = new System.Drawing.Size(97, 40);
            this.Num_label.TabIndex = 1;
            this.Num_label.Text = "Num";
            this.Num_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Minesweeping_App.Properties.Resources.Timer;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::Minesweeping_App.Properties.Resources.Mine_Show;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(310, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 34);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Sure_button
            // 
            this.Sure_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Sure_button.BackColor = System.Drawing.Color.MintCream;
            this.Sure_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sure_button.FlatAppearance.BorderSize = 0;
            this.Sure_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.Sure_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.Sure_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sure_button.Location = new System.Drawing.Point(339, 0);
            this.Sure_button.Name = "Sure_button";
            this.Sure_button.Size = new System.Drawing.Size(47, 24);
            this.Sure_button.TabIndex = 2;
            this.Sure_button.Text = "确定";
            this.Sure_button.UseVisualStyleBackColor = false;
            this.Sure_button.Visible = false;
            this.Sure_button.Click += new System.EventHandler(this.Sure_button_Click);
            // 
            // PS_label
            // 
            this.PS_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PS_label.AutoSize = true;
            this.PS_label.BackColor = System.Drawing.Color.Transparent;
            this.PS_label.Location = new System.Drawing.Point(161, 6);
            this.PS_label.Name = "PS_label";
            this.PS_label.Size = new System.Drawing.Size(189, 14);
            this.PS_label.TabIndex = 3;
            this.PS_label.Text = "如要取消，请选择左侧游戏。";
            this.PS_label.Visible = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 359);
            this.Controls.Add(this.Sure_button);
            this.Controls.Add(this.PS_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "扫雷";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Num_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VToolStripMenuItem;
        private System.Windows.Forms.Button Sure_button;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PS_label;
    }
}

