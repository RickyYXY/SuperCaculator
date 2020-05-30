namespace EquationsSolvingModule
{
    partial class MonoHighPowerForm
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
            this.lblCoe = new System.Windows.Forms.Label();
            this.lblWarn1 = new System.Windows.Forms.Label();
            this.txtCoe = new System.Windows.Forms.TextBox();
            this.lblPower = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.lblWarn2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblInit = new System.Windows.Forms.Label();
            this.txtInit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtInit);
            this.panel1.Controls.Add(this.lblInit);
            this.panel1.Controls.Add(this.lblWarn2);
            this.panel1.Controls.Add(this.txtPower);
            this.panel1.Controls.Add(this.lblPower);
            this.panel1.Controls.Add(this.txtCoe);
            this.panel1.Controls.Add(this.lblWarn1);
            this.panel1.Controls.Add(this.lblCoe);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 151);
            this.panel1.TabIndex = 0;
            // 
            // lblCoe
            // 
            this.lblCoe.AutoSize = true;
            this.lblCoe.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCoe.Location = new System.Drawing.Point(12, 20);
            this.lblCoe.Name = "lblCoe";
            this.lblCoe.Size = new System.Drawing.Size(91, 14);
            this.lblCoe.TabIndex = 6;
            this.lblCoe.Text = "输入系数集：";
            // 
            // lblWarn1
            // 
            this.lblWarn1.AutoSize = true;
            this.lblWarn1.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn1.Location = new System.Drawing.Point(3, 43);
            this.lblWarn1.Name = "lblWarn1";
            this.lblWarn1.Size = new System.Drawing.Size(245, 14);
            this.lblWarn1.TabIndex = 7;
            this.lblWarn1.Text = "（英文逗号间隔，默认最后为常数项）";
            // 
            // txtCoe
            // 
            this.txtCoe.Location = new System.Drawing.Point(99, 18);
            this.txtCoe.Name = "txtCoe";
            this.txtCoe.Size = new System.Drawing.Size(170, 21);
            this.txtCoe.TabIndex = 8;
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPower.Location = new System.Drawing.Point(12, 67);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(91, 14);
            this.lblPower.TabIndex = 9;
            this.lblPower.Text = "输入次数集：";
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(99, 65);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(170, 21);
            this.txtPower.TabIndex = 10;
            // 
            // lblWarn2
            // 
            this.lblWarn2.AutoSize = true;
            this.lblWarn2.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarn2.Location = new System.Drawing.Point(3, 89);
            this.lblWarn2.Name = "lblWarn2";
            this.lblWarn2.Size = new System.Drawing.Size(217, 14);
            this.lblWarn2.TabIndex = 11;
            this.lblWarn2.Text = "（英文逗号间隔，常数项不输入）";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(77, 163);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(15, 163);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(56, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInit.Location = new System.Drawing.Point(14, 112);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(91, 14);
            this.lblInit.TabIndex = 12;
            this.lblInit.Text = "输入初始值：";
            // 
            // txtInit
            // 
            this.txtInit.Location = new System.Drawing.Point(99, 110);
            this.txtInit.Name = "txtInit";
            this.txtInit.Size = new System.Drawing.Size(170, 21);
            this.txtInit.TabIndex = 13;
            // 
            // MonoHighPowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 203);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Name = "MonoHighPowerForm";
            this.Text = "MonoHighPowerForm";
            this.Load += new System.EventHandler(this.MonoHighPowerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.TextBox txtCoe;
        private System.Windows.Forms.Label lblWarn1;
        private System.Windows.Forms.Label lblCoe;
        private System.Windows.Forms.Label lblWarn2;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.TextBox txtInit;
    }
}