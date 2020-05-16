namespace DerivIntegForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pre_trackBar = new System.Windows.Forms.TrackBar();
            this.Clear_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.Cal_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.down_num_comboBox = new System.Windows.Forms.ComboBox();
            this.up_num_comboBox = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exp_textBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pre_trackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "微分计算";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MintCream;
            this.tabPage2.Controls.Add(this.exit_button);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pre_trackBar);
            this.tabPage2.Controls.Add(this.Clear_button);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.Cal_button);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "积分计算";
            // 
            // exit_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.LightCyan;
            this.exit_button.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit_button.Location = new System.Drawing.Point(490, 292);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(266, 61);
            this.exit_button.TabIndex = 11;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precision";
            // 
            // pre_trackBar
            // 
            this.pre_trackBar.BackColor = System.Drawing.Color.LightBlue;
            this.pre_trackBar.Location = new System.Drawing.Point(700, 55);
            this.pre_trackBar.Maximum = 4;
            this.pre_trackBar.Name = "pre_trackBar";
            this.pre_trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.pre_trackBar.Size = new System.Drawing.Size(56, 119);
            this.pre_trackBar.TabIndex = 9;
            this.pre_trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Clear_button
            // 
            this.Clear_button.BackColor = System.Drawing.Color.LightCyan;
            this.Clear_button.Font = new System.Drawing.Font("方正舒体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Clear_button.Location = new System.Drawing.Point(490, 225);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(266, 61);
            this.Clear_button.TabIndex = 8;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = false;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.result_textBox);
            this.groupBox2.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(8, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // result_textBox
            // 
            this.result_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result_textBox.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.result_textBox.Location = new System.Drawing.Point(6, 52);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(434, 39);
            this.result_textBox.TabIndex = 0;
            // 
            // Cal_button
            // 
            this.Cal_button.AutoSize = true;
            this.Cal_button.BackColor = System.Drawing.Color.LightCyan;
            this.Cal_button.Font = new System.Drawing.Font("方正舒体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cal_button.Location = new System.Drawing.Point(490, 16);
            this.Cal_button.Name = "Cal_button";
            this.Cal_button.Size = new System.Drawing.Size(178, 166);
            this.Cal_button.TabIndex = 6;
            this.Cal_button.Text = "Caculate";
            this.Cal_button.UseVisualStyleBackColor = false;
            this.Cal_button.Click += new System.EventHandler(this.Cal_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.down_num_comboBox);
            this.groupBox1.Controls.Add(this.up_num_comboBox);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.exp_textBox);
            this.groupBox1.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // down_num_comboBox
            // 
            this.down_num_comboBox.FormattingEnabled = true;
            this.down_num_comboBox.Location = new System.Drawing.Point(61, 144);
            this.down_num_comboBox.Name = "down_num_comboBox";
            this.down_num_comboBox.Size = new System.Drawing.Size(121, 32);
            this.down_num_comboBox.TabIndex = 7;
            // 
            // up_num_comboBox
            // 
            this.up_num_comboBox.FormattingEnabled = true;
            this.up_num_comboBox.Location = new System.Drawing.Point(61, 31);
            this.up_num_comboBox.Name = "up_num_comboBox";
            this.up_num_comboBox.Size = new System.Drawing.Size(121, 32);
            this.up_num_comboBox.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.MintCream;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(415, 80);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(40, 36);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "dx";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // exp_textBox
            // 
            this.exp_textBox.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp_textBox.Location = new System.Drawing.Point(61, 80);
            this.exp_textBox.Name = "exp_textBox";
            this.exp_textBox.Size = new System.Drawing.Size(348, 43);
            this.exp_textBox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MintCream;
            this.tabPage3.Font = new System.Drawing.Font("方正舒体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "极值计算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "函数运算";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pre_trackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox exp_textBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Cal_button;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.TextBox result_textBox;
        private System.Windows.Forms.ComboBox down_num_comboBox;
        private System.Windows.Forms.ComboBox up_num_comboBox;
        private System.Windows.Forms.TrackBar pre_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button;
    }
}

