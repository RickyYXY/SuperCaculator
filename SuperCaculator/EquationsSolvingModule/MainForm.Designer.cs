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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboUnoNum = new System.Windows.Forms.ComboBox();
            this.lblyuanNum = new System.Windows.Forms.Label();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.lblfangchengzu = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblWarn = new System.Windows.Forms.Label();
            this.txtWarn = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.cboUnoNum);
            this.panel1.Controls.Add(this.lblyuanNum);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightCyan;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
<<<<<<< HEAD
            this.btnStart.Location = new System.Drawing.Point(343, 24);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.btnStart.Location = new System.Drawing.Point(294, 19);
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 38);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始求解";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightCyan;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(261, 24);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirm.Name = "btnConfirm";
<<<<<<< HEAD
            this.btnConfirm.Size = new System.Drawing.Size(73, 38);
=======
            this.btnConfirm.Size = new System.Drawing.Size(92, 30);
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboUnoNum
            // 
            this.cboUnoNum.BackColor = System.Drawing.SystemColors.Menu;
            this.cboUnoNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnoNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnoNum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnoNum.FormattingEnabled = true;
            this.cboUnoNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
<<<<<<< HEAD
            this.cboUnoNum.Location = new System.Drawing.Point(136, 30);
            this.cboUnoNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboUnoNum.Name = "cboUnoNum";
            this.cboUnoNum.Size = new System.Drawing.Size(92, 23);
=======
            this.cboUnoNum.Location = new System.Drawing.Point(102, 21);
            this.cboUnoNum.Name = "cboUnoNum";
            this.cboUnoNum.Size = new System.Drawing.Size(70, 27);
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.cboUnoNum.TabIndex = 2;
            // 
            // lblyuanNum
            // 
            this.lblyuanNum.AutoSize = true;
            this.lblyuanNum.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblyuanNum.Location = new System.Drawing.Point(4, 30);
            this.lblyuanNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblyuanNum.Name = "lblyuanNum";
            this.lblyuanNum.Size = new System.Drawing.Size(130, 21);
            this.lblyuanNum.TabIndex = 0;
            this.lblyuanNum.Text = "未知元个数：";
            // 
            // txtPrint
            // 
            this.txtPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtPrint.BackColor = System.Drawing.Color.AliceBlue;
            this.txtPrint.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrint.Location = new System.Drawing.Point(12, 48);
            this.txtPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.txtPrint.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrint.Location = new System.Drawing.Point(9, 38);
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.ReadOnly = true;
            this.txtPrint.Size = new System.Drawing.Size(412, 320);
            this.txtPrint.TabIndex = 0;
            // 
            // lblfangchengzu
            // 
            this.lblfangchengzu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfangchengzu.AutoSize = true;
            this.lblfangchengzu.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfangchengzu.Location = new System.Drawing.Point(8, 11);
            this.lblfangchengzu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfangchengzu.Name = "lblfangchengzu";
            this.lblfangchengzu.Size = new System.Drawing.Size(140, 21);
            this.lblfangchengzu.TabIndex = 2;
            this.lblfangchengzu.Text = "求解方程(组)：";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.txtResult.BackColor = System.Drawing.Color.AliceBlue;
            this.txtResult.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(4, 49);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(424, 319);
=======
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(3, 38);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(318, 257);
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.txtResult.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(4, 11);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(110, 21);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "求解结果：";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Location = new System.Drawing.Point(-3, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 389);
            this.panel4.TabIndex = 3;
            // 
            // splitContainer1
            // 
<<<<<<< HEAD
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.splitContainer1.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
<<<<<<< HEAD
=======
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MintCream;
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.splitContainer1.Panel1.Controls.Add(this.txtPrint);
            this.splitContainer1.Panel1.Controls.Add(this.lblfangchengzu);
            // 
            // splitContainer1.Panel2
            // 
<<<<<<< HEAD
            this.splitContainer1.Panel2.Controls.Add(this.lblResult);
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(876, 385);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.SplitterWidth = 5;
=======
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer1.Panel2.Controls.Add(this.lblResult);
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(657, 308);
            this.splitContainer1.SplitterDistance = 322;
>>>>>>> fc8f6f9be99f5942de054c0245f9bc5c5679fa36
            this.splitContainer1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.MintCream;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblWarn);
            this.panel5.Controls.Add(this.txtWarn);
            this.panel5.Location = new System.Drawing.Point(-3, 478);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(880, 128);
            this.panel5.TabIndex = 4;
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn.Location = new System.Drawing.Point(12, 12);
            this.lblWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(110, 21);
            this.lblWarn.TabIndex = 3;
            this.lblWarn.Text = "提示信息：";
            // 
            // txtWarn
            // 
            this.txtWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarn.BackColor = System.Drawing.SystemColors.Window;
            this.txtWarn.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWarn.Location = new System.Drawing.Point(12, 52);
            this.txtWarn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWarn.Multiline = true;
            this.txtWarn.Name = "txtWarn";
            this.txtWarn.ReadOnly = true;
            this.txtWarn.Size = new System.Drawing.Size(849, 58);
            this.txtWarn.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(879, 606);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "解方程";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboUnoNum;
        private System.Windows.Forms.Label lblyuanNum;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblfangchengzu;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.TextBox txtWarn;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

