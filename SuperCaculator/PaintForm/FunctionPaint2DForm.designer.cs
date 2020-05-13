namespace PaintForm
{
    partial class FunctionPaint2DForm
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
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_exp = new System.Windows.Forms.TextBox();
            this.label_func = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.button_cancel);
            this.panel1.Controls.Add(this.button_confirm);
            this.panel1.Controls.Add(this.textBox_exp);
            this.panel1.Controls.Add(this.label_func);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 453);
            this.panel1.TabIndex = 0;
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.BackColor = System.Drawing.Color.LightCyan;
            this.button_cancel.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_cancel.Location = new System.Drawing.Point(600, 150);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(150, 80);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirm.BackColor = System.Drawing.Color.LightCyan;
            this.button_confirm.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_confirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_confirm.Location = new System.Drawing.Point(600, 300);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(150, 80);
            this.button_confirm.TabIndex = 2;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.Button_confirm_Click);
            // 
            // textBox_exp
            // 
            this.textBox_exp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_exp.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_exp.Location = new System.Drawing.Point(170, 40);
            this.textBox_exp.Name = "textBox_exp";
            this.textBox_exp.Size = new System.Drawing.Size(575, 59);
            this.textBox_exp.TabIndex = 1;
            this.textBox_exp.Text = "x+x*sin(x)+2";
            this.textBox_exp.TextChanged += new System.EventHandler(this.TextBox_exp_TextChanged);
            // 
            // label_func
            // 
            this.label_func.AutoSize = true;
            this.label_func.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_func.Location = new System.Drawing.Point(25, 40);
            this.label_func.Name = "label_func";
            this.label_func.Size = new System.Drawing.Size(143, 52);
            this.label_func.TabIndex = 0;
            this.label_func.Text = "F(x) = ";
            // 
            // FunctionPaint2DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel1);
            this.Name = "FunctionPaint2DForm";
            this.Text = "FunctionPaint2D";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_exp;
        private System.Windows.Forms.Label label_func;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_cancel;
    }
}

