namespace Minesweeping_App
{
    partial class Form_Challenge
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
            this.File_label = new System.Windows.Forms.Label();
            this.File_textBox = new System.Windows.Forms.TextBox();
            this.Cancle_button = new System.Windows.Forms.Button();
            this.Find_button = new System.Windows.Forms.Button();
            this.Next_label = new System.Windows.Forms.Label();
            this.NumericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.Label_Height = new System.Windows.Forms.Label();
            this.NumericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.Label_Width = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).BeginInit();
            this.SuspendLayout();
            // 
            // File_label
            // 
            this.File_label.AutoSize = true;
            this.File_label.Font = new System.Drawing.Font("宋体", 10F);
            this.File_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.File_label.Location = new System.Drawing.Point(12, 23);
            this.File_label.Name = "File_label";
            this.File_label.Size = new System.Drawing.Size(63, 14);
            this.File_label.TabIndex = 0;
            this.File_label.Text = "备注信息";
            // 
            // File_textBox
            // 
            this.File_textBox.Location = new System.Drawing.Point(15, 43);
            this.File_textBox.Name = "File_textBox";
            this.File_textBox.Size = new System.Drawing.Size(210, 21);
            this.File_textBox.TabIndex = 1;
            this.File_textBox.Visible = false;
            // 
            // Cancle_button
            // 
            this.Cancle_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Cancle_button.FlatAppearance.BorderSize = 0;
            this.Cancle_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Cancle_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Cancle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancle_button.Font = new System.Drawing.Font("宋体", 9F);
            this.Cancle_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Cancle_button.Location = new System.Drawing.Point(15, 127);
            this.Cancle_button.Name = "Cancle_button";
            this.Cancle_button.Size = new System.Drawing.Size(60, 28);
            this.Cancle_button.TabIndex = 2;
            this.Cancle_button.Text = "取 消";
            this.Cancle_button.UseVisualStyleBackColor = false;
            this.Cancle_button.Click += new System.EventHandler(this.Cancle_button_Click);
            // 
            // Find_button
            // 
            this.Find_button.BackColor = System.Drawing.Color.SkyBlue;
            this.Find_button.FlatAppearance.BorderSize = 0;
            this.Find_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Find_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.Find_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Find_button.Font = new System.Drawing.Font("宋体", 9F);
            this.Find_button.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Find_button.Location = new System.Drawing.Point(244, 43);
            this.Find_button.Name = "Find_button";
            this.Find_button.Size = new System.Drawing.Size(60, 21);
            this.Find_button.TabIndex = 2;
            this.Find_button.Text = "浏 览";
            this.Find_button.UseVisualStyleBackColor = false;
            this.Find_button.Visible = false;
            this.Find_button.Click += new System.EventHandler(this.Find_button_Click);
            // 
            // Next_label
            // 
            this.Next_label.AutoSize = true;
            this.Next_label.BackColor = System.Drawing.Color.Transparent;
            this.Next_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next_label.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.Next_label.ForeColor = System.Drawing.Color.SteelBlue;
            this.Next_label.Location = new System.Drawing.Point(239, 127);
            this.Next_label.Name = "Next_label";
            this.Next_label.Size = new System.Drawing.Size(72, 27);
            this.Next_label.TabIndex = 3;
            this.Next_label.Text = "下一步";
            this.Next_label.Click += new System.EventHandler(this.Next_label_Click);
            // 
            // NumericUpDown_Height
            // 
            this.NumericUpDown_Height.Location = new System.Drawing.Point(138, 90);
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
            this.NumericUpDown_Height.TabIndex = 19;
            this.NumericUpDown_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Height.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Height.Visible = false;
            // 
            // Label_Height
            // 
            this.Label_Height.AutoSize = true;
            this.Label_Height.BackColor = System.Drawing.Color.Transparent;
            this.Label_Height.Location = new System.Drawing.Point(86, 92);
            this.Label_Height.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Height.Name = "Label_Height";
            this.Label_Height.Size = new System.Drawing.Size(47, 12);
            this.Label_Height.TabIndex = 18;
            this.Label_Height.Text = "高  度:";
            this.Label_Height.Visible = false;
            // 
            // NumericUpDown_Width
            // 
            this.NumericUpDown_Width.Location = new System.Drawing.Point(138, 66);
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
            this.NumericUpDown_Width.TabIndex = 17;
            this.NumericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDown_Width.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_Width.Visible = false;
            // 
            // Label_Width
            // 
            this.Label_Width.AutoSize = true;
            this.Label_Width.BackColor = System.Drawing.Color.Transparent;
            this.Label_Width.Location = new System.Drawing.Point(86, 67);
            this.Label_Width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Width.Name = "Label_Width";
            this.Label_Width.Size = new System.Drawing.Size(47, 12);
            this.Label_Width.TabIndex = 16;
            this.Label_Width.Text = "宽  度:";
            this.Label_Width.Visible = false;
            // 
            // Form_Challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(319, 166);
            this.Controls.Add(this.NumericUpDown_Height);
            this.Controls.Add(this.Label_Height);
            this.Controls.Add(this.NumericUpDown_Width);
            this.Controls.Add(this.Label_Width);
            this.Controls.Add(this.Next_label);
            this.Controls.Add(this.Find_button);
            this.Controls.Add(this.Cancle_button);
            this.Controls.Add(this.File_textBox);
            this.Controls.Add(this.File_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Challenge";
            this.ShowInTaskbar = false;
            this.Text = "Form_Challenge";
            this.Load += new System.EventHandler(this.Form_Challenge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label File_label;
        private System.Windows.Forms.TextBox File_textBox;
        private System.Windows.Forms.Button Cancle_button;
        private System.Windows.Forms.Button Find_button;
        private System.Windows.Forms.Label Next_label;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Height;
        private System.Windows.Forms.Label Label_Height;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Width;
        private System.Windows.Forms.Label Label_Width;
    }
}