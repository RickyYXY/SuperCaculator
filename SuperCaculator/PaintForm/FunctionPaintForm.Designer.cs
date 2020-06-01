namespace PaintForm
{
    partial class FunctionPaintForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_2D = new System.Windows.Forms.TabPage();
            this.panel_2D = new System.Windows.Forms.Panel();
            this.button_cancel_2D = new System.Windows.Forms.Button();
            this.button_confirm_2D = new System.Windows.Forms.Button();
            this.textBox_exp_2D = new System.Windows.Forms.TextBox();
            this.label_func_2D = new System.Windows.Forms.Label();
            this.tabPage_3D = new System.Windows.Forms.TabPage();
            this.panel_3D = new System.Windows.Forms.Panel();
            this.button_cancel_3D = new System.Windows.Forms.Button();
            this.button_confirm_3D = new System.Windows.Forms.Button();
            this.textBox_exp_3D = new System.Windows.Forms.TextBox();
            this.label_func_3D = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_2D.SuspendLayout();
            this.panel_2D.SuspendLayout();
            this.tabPage_3D.SuspendLayout();
            this.panel_3D.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_2D);
            this.tabControl1.Controls.Add(this.tabPage_3D);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("方正舒体", 15F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_2D
            // 
            this.tabPage_2D.Controls.Add(this.panel_2D);
            this.tabPage_2D.Font = new System.Drawing.Font("方正舒体", 15F);
            this.tabPage_2D.Location = new System.Drawing.Point(4, 36);
            this.tabPage_2D.Name = "tabPage_2D";
            this.tabPage_2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_2D.Size = new System.Drawing.Size(792, 410);
            this.tabPage_2D.TabIndex = 0;
            this.tabPage_2D.Text = "一元函数";
            this.tabPage_2D.UseVisualStyleBackColor = true;
            // 
            // panel_2D
            // 
            this.panel_2D.BackColor = System.Drawing.Color.MintCream;
            this.panel_2D.Controls.Add(this.button_cancel_2D);
            this.panel_2D.Controls.Add(this.button_confirm_2D);
            this.panel_2D.Controls.Add(this.textBox_exp_2D);
            this.panel_2D.Controls.Add(this.label_func_2D);
            this.panel_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2D.Location = new System.Drawing.Point(3, 3);
            this.panel_2D.Name = "panel_2D";
            this.panel_2D.Size = new System.Drawing.Size(786, 404);
            this.panel_2D.TabIndex = 1;
            // 
            // button_cancel_2D
            // 
            this.button_cancel_2D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel_2D.BackColor = System.Drawing.Color.LightCyan;
            this.button_cancel_2D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_cancel_2D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_cancel_2D.Location = new System.Drawing.Point(600, 150);
            this.button_cancel_2D.Name = "button_cancel_2D";
            this.button_cancel_2D.Size = new System.Drawing.Size(150, 80);
            this.button_cancel_2D.TabIndex = 3;
            this.button_cancel_2D.Text = "取消";
            this.button_cancel_2D.UseVisualStyleBackColor = false;
            this.button_cancel_2D.Click += new System.EventHandler(this.Button_cancel_2D_Click);
            // 
            // button_confirm_2D
            // 
            this.button_confirm_2D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirm_2D.BackColor = System.Drawing.Color.LightCyan;
            this.button_confirm_2D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_confirm_2D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_confirm_2D.Location = new System.Drawing.Point(600, 300);
            this.button_confirm_2D.Name = "button_confirm_2D";
            this.button_confirm_2D.Size = new System.Drawing.Size(150, 80);
            this.button_confirm_2D.TabIndex = 2;
            this.button_confirm_2D.Text = "确定";
            this.button_confirm_2D.UseVisualStyleBackColor = false;
            this.button_confirm_2D.Click += new System.EventHandler(this.Button_confirm_2D_Click);
            // 
            // textBox_exp_2D
            // 
            this.textBox_exp_2D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_exp_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_exp_2D.Location = new System.Drawing.Point(170, 40);
            this.textBox_exp_2D.Name = "textBox_exp_2D";
            this.textBox_exp_2D.Size = new System.Drawing.Size(555, 51);
            this.textBox_exp_2D.TabIndex = 1;
            this.textBox_exp_2D.Text = "x+x*sin(x)+2";
            // 
            // label_func_2D
            // 
            this.label_func_2D.AutoSize = true;
            this.label_func_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_func_2D.Location = new System.Drawing.Point(25, 40);
            this.label_func_2D.Name = "label_func_2D";
            this.label_func_2D.Size = new System.Drawing.Size(140, 44);
            this.label_func_2D.TabIndex = 0;
            this.label_func_2D.Text = "F(x) = ";
            // 
            // tabPage_3D
            // 
            this.tabPage_3D.Controls.Add(this.panel_3D);
            this.tabPage_3D.Location = new System.Drawing.Point(4, 36);
            this.tabPage_3D.Name = "tabPage_3D";
            this.tabPage_3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_3D.Size = new System.Drawing.Size(792, 410);
            this.tabPage_3D.TabIndex = 1;
            this.tabPage_3D.Text = "二元函数";
            this.tabPage_3D.UseVisualStyleBackColor = true;
            // 
            // panel_3D
            // 
            this.panel_3D.BackColor = System.Drawing.Color.MintCream;
            this.panel_3D.Controls.Add(this.button_cancel_3D);
            this.panel_3D.Controls.Add(this.button_confirm_3D);
            this.panel_3D.Controls.Add(this.textBox_exp_3D);
            this.panel_3D.Controls.Add(this.label_func_3D);
            this.panel_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_3D.Location = new System.Drawing.Point(3, 3);
            this.panel_3D.Name = "panel_3D";
            this.panel_3D.Size = new System.Drawing.Size(786, 404);
            this.panel_3D.TabIndex = 2;
            // 
            // button_cancel_3D
            // 
            this.button_cancel_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel_3D.BackColor = System.Drawing.Color.LightCyan;
            this.button_cancel_3D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_cancel_3D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_cancel_3D.Location = new System.Drawing.Point(600, 150);
            this.button_cancel_3D.Name = "button_cancel_3D";
            this.button_cancel_3D.Size = new System.Drawing.Size(150, 80);
            this.button_cancel_3D.TabIndex = 3;
            this.button_cancel_3D.Text = "取消";
            this.button_cancel_3D.UseVisualStyleBackColor = false;
            this.button_cancel_3D.Click += new System.EventHandler(this.Button_cancel_3D_Click);
            // 
            // button_confirm_3D
            // 
            this.button_confirm_3D.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_confirm_3D.BackColor = System.Drawing.Color.LightCyan;
            this.button_confirm_3D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_confirm_3D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_confirm_3D.Location = new System.Drawing.Point(600, 300);
            this.button_confirm_3D.Name = "button_confirm_3D";
            this.button_confirm_3D.Size = new System.Drawing.Size(150, 80);
            this.button_confirm_3D.TabIndex = 2;
            this.button_confirm_3D.Text = "确定";
            this.button_confirm_3D.UseVisualStyleBackColor = false;
            this.button_confirm_3D.Click += new System.EventHandler(this.Button_confirm_3D_Click);
            // 
            // textBox_exp_3D
            // 
            this.textBox_exp_3D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_exp_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_exp_3D.Location = new System.Drawing.Point(210, 40);
            this.textBox_exp_3D.Name = "textBox_exp_3D";
            this.textBox_exp_3D.Size = new System.Drawing.Size(515, 51);
            this.textBox_exp_3D.TabIndex = 1;
            this.textBox_exp_3D.Text = "x*x*y*y";
            // 
            // label_func_3D
            // 
            this.label_func_3D.AutoSize = true;
            this.label_func_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_func_3D.Location = new System.Drawing.Point(25, 40);
            this.label_func_3D.Name = "label_func_3D";
            this.label_func_3D.Size = new System.Drawing.Size(181, 44);
            this.label_func_3D.TabIndex = 0;
            this.label_func_3D.Text = "F(x, y) = ";
            // 
            // FunctionPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FunctionPaintForm";
            this.Text = "函数绘图";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_2D.ResumeLayout(false);
            this.panel_2D.ResumeLayout(false);
            this.panel_2D.PerformLayout();
            this.tabPage_3D.ResumeLayout(false);
            this.panel_3D.ResumeLayout(false);
            this.panel_3D.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_2D;
        private System.Windows.Forms.TabPage tabPage_3D;
        private System.Windows.Forms.Panel panel_3D;
        private System.Windows.Forms.Button button_cancel_3D;
        private System.Windows.Forms.Button button_confirm_3D;
        private System.Windows.Forms.TextBox textBox_exp_3D;
        private System.Windows.Forms.Label label_func_3D;
        private System.Windows.Forms.Panel panel_2D;
        private System.Windows.Forms.Button button_cancel_2D;
        private System.Windows.Forms.Button button_confirm_2D;
        private System.Windows.Forms.TextBox textBox_exp_2D;
        private System.Windows.Forms.Label label_func_2D;
    }
}