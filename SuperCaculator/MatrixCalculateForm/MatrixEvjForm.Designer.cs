namespace MatrixCalculateForm
{
    partial class MatrixEvjForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MatrixEvj1textBox = new System.Windows.Forms.TextBox();
            this.MatrixEvj2textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(141, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "矩阵特征值";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(517, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "矩阵特征向量";
            // 
            // MatrixEvj1textBox
            // 
            this.MatrixEvj1textBox.Location = new System.Drawing.Point(69, 101);
            this.MatrixEvj1textBox.Multiline = true;
            this.MatrixEvj1textBox.Name = "MatrixEvj1textBox";
            this.MatrixEvj1textBox.Size = new System.Drawing.Size(268, 259);
            this.MatrixEvj1textBox.TabIndex = 2;
            // 
            // MatrixEvj2textBox
            // 
            this.MatrixEvj2textBox.Location = new System.Drawing.Point(457, 101);
            this.MatrixEvj2textBox.Multiline = true;
            this.MatrixEvj2textBox.Name = "MatrixEvj2textBox";
            this.MatrixEvj2textBox.Size = new System.Drawing.Size(268, 259);
            this.MatrixEvj2textBox.TabIndex = 3;
            // 
            // MatrixEvjForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MatrixEvj2textBox);
            this.Controls.Add(this.MatrixEvj1textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MatrixEvjForm";
            this.Text = "MatrixEvjForm";
            this.Load += new System.EventHandler(this.MatrixEvjForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MatrixEvj1textBox;
        private System.Windows.Forms.TextBox MatrixEvj2textBox;
    }
}