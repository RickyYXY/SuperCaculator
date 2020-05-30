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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboEquNum = new System.Windows.Forms.ComboBox();
            this.lblfangchengNum = new System.Windows.Forms.Label();
            this.lblWarn = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.lblInputPow = new System.Windows.Forms.Label();
            this.lblInCoe = new System.Windows.Forms.Label();
            this.txtCoe = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblWarn);
            this.panel1.Controls.Add(this.txtPower);
            this.panel1.Controls.Add(this.lblInputPow);
            this.panel1.Controls.Add(this.lblInCoe);
            this.panel1.Controls.Add(this.txtCoe);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 325);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboEquNum);
            this.panel2.Controls.Add(this.lblfangchengNum);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 48);
            this.panel2.TabIndex = 7;
            // 
            // cboEquNum
            // 
            this.cboEquNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquNum.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboEquNum.FormattingEnabled = true;
            this.cboEquNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboEquNum.Location = new System.Drawing.Point(100, 15);
            this.cboEquNum.Name = "cboEquNum";
            this.cboEquNum.Size = new System.Drawing.Size(59, 20);
            this.cboEquNum.TabIndex = 6;
            // 
            // lblfangchengNum
            // 
            this.lblfangchengNum.AutoSize = true;
            this.lblfangchengNum.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblfangchengNum.Location = new System.Drawing.Point(11, 17);
            this.lblfangchengNum.Name = "lblfangchengNum";
            this.lblfangchengNum.Size = new System.Drawing.Size(91, 14);
            this.lblfangchengNum.TabIndex = 5;
            this.lblfangchengNum.Text = "方程的个数：";
            // 
            // lblWarn
            // 
            this.lblWarn.AutoSize = true;
            this.lblWarn.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn.Location = new System.Drawing.Point(8, 296);
            this.lblWarn.Name = "lblWarn";
            this.lblWarn.Size = new System.Drawing.Size(182, 14);
            this.lblWarn.TabIndex = 4;
            this.lblWarn.Text = "(均使用英文逗号分隔数据）";
            // 
            // txtPower
            // 
            this.txtPower.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPower.Location = new System.Drawing.Point(227, 88);
            this.txtPower.Multiline = true;
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(194, 196);
            this.txtPower.TabIndex = 3;
            // 
            // lblInputPow
            // 
            this.lblInputPow.AutoSize = true;
            this.lblInputPow.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInputPow.Location = new System.Drawing.Point(224, 59);
            this.lblInputPow.Name = "lblInputPow";
            this.lblInputPow.Size = new System.Drawing.Size(133, 14);
            this.lblInputPow.TabIndex = 2;
            this.lblInputPow.Text = "输入方程组次数集：";
            // 
            // lblInCoe
            // 
            this.lblInCoe.AutoSize = true;
            this.lblInCoe.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInCoe.Location = new System.Drawing.Point(11, 59);
            this.lblInCoe.Name = "lblInCoe";
            this.lblInCoe.Size = new System.Drawing.Size(133, 14);
            this.lblInCoe.TabIndex = 0;
            this.lblInCoe.Text = "输入方程组系数集：";
            // 
            // txtCoe
            // 
            this.txtCoe.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoe.Location = new System.Drawing.Point(14, 88);
            this.txtCoe.Multiline = true;
            this.txtCoe.Name = "txtCoe";
            this.txtCoe.Size = new System.Drawing.Size(194, 196);
            this.txtCoe.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(12, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(56, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(74, 339);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DataInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 374);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Name = "DataInputForm";
            this.Text = "DataInputForm";
            this.Load += new System.EventHandler(this.DataInputForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
    }
}