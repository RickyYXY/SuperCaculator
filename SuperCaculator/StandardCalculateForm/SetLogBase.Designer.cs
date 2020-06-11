namespace StandardCalculateForm
{
    partial class SetLogBase
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.bindingSourceLogbase = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLogbase)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("方正舒体", 14F);
            this.button1.Location = new System.Drawing.Point(192, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正舒体", 14F);
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入log的底数：";
            // 
            // txtNum
            // 
            this.txtNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLogbase, "LogBase", true));
            this.txtNum.Font = new System.Drawing.Font("方正舒体", 14F);
            this.txtNum.Location = new System.Drawing.Point(262, 80);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(189, 37);
            this.txtNum.TabIndex = 2;
            this.txtNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberInput);
            // 
            // bindingSourceLogbase
            // 
            this.bindingSourceLogbase.DataSource = typeof(StandardCalculateForm.Log);
            // 
            // SetLogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(483, 239);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "SetLogBase";
            this.Text = "设置底数";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLogbase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.BindingSource bindingSourceLogbase;
    }
}