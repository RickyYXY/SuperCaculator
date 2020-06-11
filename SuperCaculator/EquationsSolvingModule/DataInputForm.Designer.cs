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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.lblfangchengNum.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfangchengNum.Location = new System.Drawing.Point(11, 20);
            this.lblfangchengNum.Name = "lblfangchengNum";
            this.lblfangchengNum.Size = new System.Drawing.Size(104, 17);
            this.lblfangchengNum.TabIndex = 5;
            this.lblfangchengNum.Text = "方程的个数：";
            // 
            // cboEquNum
            // 
            this.cboEquNum.BackColor = System.Drawing.Color.AliceBlue;
            this.cboEquNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEquNum.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboEquNum.FormattingEnabled = true;
            this.cboEquNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboEquNum.Location = new System.Drawing.Point(121, 20);
            this.cboEquNum.Name = "cboEquNum";
            this.cboEquNum.Size = new System.Drawing.Size(59, 25);
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
            this.txtPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPower.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPower.Location = new System.Drawing.Point(3, 27);
            this.txtPower.Multiline = true;
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(264, 244);
            this.txtPower.TabIndex = 3;
            // 
            // lblInputPow
            // 
            this.lblInputPow.AutoSize = true;
            this.lblInputPow.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInputPow.Location = new System.Drawing.Point(3, 7);
            this.lblInputPow.Name = "lblInputPow";
            this.lblInputPow.Size = new System.Drawing.Size(152, 17);
            this.lblInputPow.TabIndex = 2;
            this.lblInputPow.Text = "输入方程组次数集：";
            // 
            // lblInCoe
            // 
            this.lblInCoe.AutoSize = true;
            this.lblInCoe.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInCoe.Location = new System.Drawing.Point(3, 7);
            this.lblInCoe.Name = "lblInCoe";
            this.lblInCoe.Size = new System.Drawing.Size(152, 17);
            this.lblInCoe.TabIndex = 0;
            this.lblInCoe.Text = "输入方程组系数集：";
            // 
            // txtCoe
            // 
            this.txtCoe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoe.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCoe.Location = new System.Drawing.Point(6, 27);
            this.txtCoe.Multiline = true;
            this.txtCoe.Name = "txtCoe";
            this.txtCoe.Size = new System.Drawing.Size(253, 244);
            this.txtCoe.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.AliceBlue;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.btnCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("方正舒体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(93, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 31);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lblInCoe);
            this.panel2.Controls.Add(this.txtCoe);
            this.panel2.Location = new System.Drawing.Point(11, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 274);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lblInputPow);
            this.panel3.Controls.Add(this.txtPower);
            this.panel3.Location = new System.Drawing.Point(276, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 274);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(1, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(557, 323);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.btnConfirm);
            this.panel5.Location = new System.Drawing.Point(1, 391);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 62);
            this.panel5.TabIndex = 8;
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
            this.Text = "DataInputForm";
            this.Load += new System.EventHandler(this.DataInputForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}