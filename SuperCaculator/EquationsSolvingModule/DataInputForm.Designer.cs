namespace EquationsSolvingModule
{
    partial class DataInputForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblfangchengNum = new System.Windows.Forms.Label();
            this.cboEquNum = new System.Windows.Forms.ComboBox();
            this.lblWarn = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.lblInputPow = new System.Windows.Forms.Label();
            this.lblInCoe = new System.Windows.Forms.Label();
            this.txtCoe = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblfangchengNum);
            this.panel1.Controls.Add(this.cboEquNum);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 68);
            this.panel1.TabIndex = 0;
            // 
            // lblfangchengNum
            // 
            this.lblfangchengNum.AutoSize = true;
            this.lblfangchengNum.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfangchengNum.Location = new System.Drawing.Point(15, 20);
            this.lblfangchengNum.Name = "lblfangchengNum";
            this.lblfangchengNum.Size = new System.Drawing.Size(123, 20);
            this.lblfangchengNum.TabIndex = 5;
            this.lblfangchengNum.Text = "方程的个数：";
            // 
            // cboEquNum
            // 
            this.cboEquNum.BackColor = System.Drawing.SystemColors.Menu;
            this.cboEquNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEquNum.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquNum.FormattingEnabled = true;
            this.cboEquNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboEquNum.Location = new System.Drawing.Point(140, 19);
            this.cboEquNum.Name = "cboEquNum";
            this.cboEquNum.Size = new System.Drawing.Size(71, 27);
            this.cboEquNum.TabIndex = 6;
            // 
            // lblWarn
            // 
            this.lblWarn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn.Location = new System.Drawing.Point(3, 10);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(204, 17);
            this.lblWarn.TabIndex = 4;
            this.lblWarn.Text = "(均使用英文逗号分隔数据）";
            // 
            // txtPower
            // 
            this.txtPower.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPower.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.Location = new System.Drawing.Point(3, 29);
            this.txtPower.Multiline = true;
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(264, 241);
            this.txtPower.TabIndex = 3;
            // 
            // lblInputPow
            // 
            this.lblInputPow.AutoSize = true;
            this.lblInputPow.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInputPow.Location = new System.Drawing.Point(3, 6);
            this.lblInputPow.Name = "lblInputPow";
            this.lblInputPow.Size = new System.Drawing.Size(180, 20);
            this.lblInputPow.TabIndex = 2;
            this.lblInputPow.Text = "输入方程组次数集：";
            // 
            // lblInCoe
            // 
            this.lblInCoe.AutoSize = true;
            this.lblInCoe.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInCoe.Location = new System.Drawing.Point(3, 6);
            this.lblInCoe.Name = "lblInCoe";
            this.lblInCoe.Size = new System.Drawing.Size(180, 20);
            this.lblInCoe.TabIndex = 0;
            this.lblInCoe.Text = "输入方程组系数集：";
            // 
            // txtCoe
            // 
            this.txtCoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoe.Location = new System.Drawing.Point(3, 29);
            this.txtCoe.Multiline = true;
            this.txtCoe.Name = "txtCoe";
            this.txtCoe.Size = new System.Drawing.Size(257, 241);
            this.txtCoe.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightCyan;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(11, 15);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(65, 31);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCyan;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("方正舒体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(82, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.MintCream;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.splitContainer1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(1, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 323);
            this.panel4.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(11, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblInCoe);
            this.splitContainer1.Panel1.Controls.Add(this.txtCoe);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblInputPow);
            this.splitContainer1.Panel2.Controls.Add(this.txtPower);
            this.splitContainer1.Size = new System.Drawing.Size(538, 273);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.lblWarn);
            this.panel6.Location = new System.Drawing.Point(11, 280);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(539, 36);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.MintCream;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnConfirm);
            this.panel5.Location = new System.Drawing.Point(1, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 62);
            this.panel5.TabIndex = 8;
            // 
            // DataInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(558, 454);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "DataInputForm";
            this.Text = "多元方程组";
            this.Load += new System.EventHandler(this.DataInputForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWarn;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label lblInputPow;
        private System.Windows.Forms.Label lblInCoe;
        private System.Windows.Forms.TextBox txtCoe;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblfangchengNum;
        private System.Windows.Forms.ComboBox cboEquNum;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}