namespace Minesweeping_App
{
    partial class Form_Set
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_OK = new System.Windows.Forms.Button();
            this.NumericUpDown_Mine = new System.Windows.Forms.NumericUpDown();
            this.Label_Mine = new System.Windows.Forms.Label();
            this.NumericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.Label_Height = new System.Windows.Forms.Label();
            this.NumericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Width = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.LightGray;
            this.Button_Cancel.FlatAppearance.BorderSize = 0;
            this.Button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.Location = new System.Drawing.Point(86, 82);
            this.Button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(67, 24);
            this.Button_Cancel.TabIndex = 19;
            this.Button_Cancel.Text = "取  消";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_OK
            // 
            this.Button_OK.BackColor = System.Drawing.Color.LightGray;
            this.Button_OK.FlatAppearance.BorderSize = 0;
            this.Button_OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.Button_OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.Button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_OK.Location = new System.Drawing.Point(13, 82);
            this.Button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(67, 24);
            this.Button_OK.TabIndex = 18;
            this.Button_OK.Text = "确  定";
            this.Button_OK.UseVisualStyleBackColor = false;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // NumericUpDown_Mine
            // 
            this.NumericUpDown_Mine.Location = new System.Drawing.Point(63, 57);
            this.NumericUpDown_Mine.Margin = new System.Windows.Forms.Padding(2);
            this.NumericUpDown_Mine.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NumericUpDown_Mine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_Mine.Name = "NumericUpDown_Mine";
            this.NumericUpDown_Mine.Size = new System.Drawing.Size(90, 21);
            this.NumericUpDown_Mine.TabIndex = 17;
            this.NumericUpDown_Mine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Mine.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Label_Mine
            // 
            this.Label_Mine.AutoSize = true;
            this.Label_Mine.Location = new System.Drawing.Point(11, 59);
            this.Label_Mine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Mine.Name = "Label_Mine";
            this.Label_Mine.Size = new System.Drawing.Size(47, 12);
            this.Label_Mine.TabIndex = 16;
            this.Label_Mine.Text = "地雷数:";
            // 
            // NumericUpDown_Height
            // 
            this.NumericUpDown_Height.Location = new System.Drawing.Point(63, 32);
            this.NumericUpDown_Height.Margin = new System.Windows.Forms.Padding(2);
            this.NumericUpDown_Height.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumericUpDown_Height.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Height.Name = "NumericUpDown_Height";
            this.NumericUpDown_Height.Size = new System.Drawing.Size(90, 21);
            this.NumericUpDown_Height.TabIndex = 15;
            this.NumericUpDown_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Height.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.Location = new System.Drawing.Point(11, 34);
            this.Label_Height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(47, 12);
            this.Label_Height.TabIndex = 14;
            this.Label_Height.Text = "高  度:";
            // 
            // NumericUpDown_Width
            // 
            this.NumericUpDown_Width.Location = new System.Drawing.Point(63, 8);
            this.NumericUpDown_Width.Margin = new System.Windows.Forms.Padding(2);
            this.NumericUpDown_Width.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericUpDown_Width.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Width.Name = "NumericUpDown_Width";
            this.NumericUpDown_Width.Size = new System.Drawing.Size(90, 21);
            this.NumericUpDown_Width.TabIndex = 13;
            this.NumericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Width.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.Location = new System.Drawing.Point(11, 9);
            this.Label_Width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(47, 12);
            this.Label_Width.TabIndex = 12;
            this.Label_Width.Text = "宽  度:";
            // 
            // Form_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(172, 114);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.NumericUpDown_Mine);
            this.Controls.Add(this.Label_Mine);
            this.Controls.Add(this.NumericUpDown_Height);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.NumericUpDown_Width);
            this.Controls.Add(this.Label_Width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Set";
            this.ShowInTaskbar = false;
            this.Text = "自定义设置";
            this.Load += new System.EventHandler(this.Form_Set_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Mine;
        private System.Windows.Forms.Label Label_Mine;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Height;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Width;
        private System.Windows.Forms.Label Label_Width;
    }
}