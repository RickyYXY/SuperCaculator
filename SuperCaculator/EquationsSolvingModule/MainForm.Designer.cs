namespace EquationsSolvingModule
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboUnoNum = new System.Windows.Forms.ComboBox();
            this.lblyuanNum = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.lblfangchengzu = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWarn = new System.Windows.Forms.Label();
            this.txtWarn = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.cboUnoNum);
            this.panel1.Controls.Add(this.lblyuanNum);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.AliceBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(318, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 30);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始求解";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuit.Location = new System.Drawing.Point(257, 19);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(55, 30);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "退出";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(196, 19);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(55, 30);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboUnoNum
            // 
            this.cboUnoNum.BackColor = System.Drawing.Color.AliceBlue;
            this.cboUnoNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnoNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnoNum.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboUnoNum.FormattingEnabled = true;
            this.cboUnoNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboUnoNum.Location = new System.Drawing.Point(102, 24);
            this.cboUnoNum.Name = "cboUnoNum";
            this.cboUnoNum.Size = new System.Drawing.Size(70, 20);
            this.cboUnoNum.TabIndex = 2;
            // 
            // lblyuanNum
            // 
            this.lblyuanNum.AutoSize = true;
            this.lblyuanNum.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblyuanNum.Location = new System.Drawing.Point(3, 24);
            this.lblyuanNum.Name = "lblyuanNum";
            this.lblyuanNum.Size = new System.Drawing.Size(104, 17);
            this.lblyuanNum.TabIndex = 0;
            this.lblyuanNum.Text = "未知元个数：";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtPrint);
            this.panel2.Controls.Add(this.lblfangchengzu);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 296);
            this.panel2.TabIndex = 1;
            // 
            // txtPrint
            // 
            this.txtPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPrint.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrint.Location = new System.Drawing.Point(19, 38);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ReadOnly = true;
            this.txtPrint.Size = new System.Drawing.Size(275, 245);
            this.txtPrint.TabIndex = 0;
            this.txtPrint.Text = "\r\n";
            // 
            // lblfangchengzu
            // 
            this.lblfangchengzu.AutoSize = true;
            this.lblfangchengzu.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfangchengzu.Location = new System.Drawing.Point(16, 8);
            this.lblfangchengzu.Name = "lblfangchengzu";
            this.lblfangchengzu.Size = new System.Drawing.Size(152, 17);
            this.lblfangchengzu.TabIndex = 2;
            this.lblfangchengzu.Text = "所要求解的方程组：";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.AliceBlue;
            this.txtResult.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(3, 38);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(268, 245);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "\r\n";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblResult);
            this.panel3.Controls.Add(this.txtResult);
            this.panel3.Location = new System.Drawing.Point(315, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 296);
            this.panel3.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(-3, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(88, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "求解结果：";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(-2, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 307);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblWarn);
            this.panel5.Controls.Add(this.txtWarn);
            this.panel5.Location = new System.Drawing.Point(-2, 382);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(624, 103);
            this.panel5.TabIndex = 4;
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn.Location = new System.Drawing.Point(12, 15);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(88, 17);
            this.lblWarn.TabIndex = 3;
            this.lblWarn.Text = "提示信息：";
            // 
            // txtWarn
            // 
            this.txtWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarn.BackColor = System.Drawing.Color.AliceBlue;
            this.txtWarn.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWarn.Location = new System.Drawing.Point(12, 35);
            this.txtWarn.Multiline = true;
            this.txtWarn.Name = "txtWarn";
            this.txtWarn.ReadOnly = true;
            this.txtWarn.Size = new System.Drawing.Size(598, 47);
            this.txtWarn.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(622, 485);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboUnoNum;
        private System.Windows.Forms.Label lblyuanNum;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblfangchengzu;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.TextBox txtWarn;
    }
}

