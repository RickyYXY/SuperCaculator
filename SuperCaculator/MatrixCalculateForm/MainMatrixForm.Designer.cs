namespace MatrixCalculateForm
{
    partial class MainMatrixForm
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
            this.MaintabControl = new System.Windows.Forms.TabControl();
            this.OneMatrixTabPage = new System.Windows.Forms.TabPage();
            this.TwoMatrixTabPage = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MatrixCtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MatrixBtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MatrixAtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AttentionTabPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.MatrixDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MatrixETextBox = new System.Windows.Forms.TextBox();
            this.Transposebutton = new System.Windows.Forms.Button();
            this.Inversebutton = new System.Windows.Forms.Button();
            this.ComputeDetbutton = new System.Windows.Forms.Button();
            this.ComputeRankbutton = new System.Windows.Forms.Button();
            this.ComputeEvJbutton = new System.Windows.Forms.Button();
            this.MaintabControl.SuspendLayout();
            this.OneMatrixTabPage.SuspendLayout();
            this.TwoMatrixTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaintabControl
            // 
            this.MaintabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaintabControl.Controls.Add(this.OneMatrixTabPage);
            this.MaintabControl.Controls.Add(this.TwoMatrixTabPage);
            this.MaintabControl.Controls.Add(this.AttentionTabPage);
            this.MaintabControl.Location = new System.Drawing.Point(0, 1);
            this.MaintabControl.Name = "MaintabControl";
            this.MaintabControl.SelectedIndex = 0;
            this.MaintabControl.Size = new System.Drawing.Size(798, 428);
            this.MaintabControl.TabIndex = 0;
            // 
            // OneMatrixTabPage
            // 
            this.OneMatrixTabPage.Controls.Add(this.ComputeEvJbutton);
            this.OneMatrixTabPage.Controls.Add(this.ComputeRankbutton);
            this.OneMatrixTabPage.Controls.Add(this.ComputeDetbutton);
            this.OneMatrixTabPage.Controls.Add(this.Inversebutton);
            this.OneMatrixTabPage.Controls.Add(this.Transposebutton);
            this.OneMatrixTabPage.Controls.Add(this.MatrixETextBox);
            this.OneMatrixTabPage.Controls.Add(this.label5);
            this.OneMatrixTabPage.Controls.Add(this.MatrixDTextBox);
            this.OneMatrixTabPage.Controls.Add(this.label4);
            this.OneMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.OneMatrixTabPage.Name = "OneMatrixTabPage";
            this.OneMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OneMatrixTabPage.Size = new System.Drawing.Size(790, 402);
            this.OneMatrixTabPage.TabIndex = 0;
            this.OneMatrixTabPage.Text = "一元运算";
            this.OneMatrixTabPage.UseVisualStyleBackColor = true;
            // 
            // TwoMatrixTabPage
            // 
            this.TwoMatrixTabPage.Controls.Add(this.buttonClear);
            this.TwoMatrixTabPage.Controls.Add(this.buttonSub);
            this.TwoMatrixTabPage.Controls.Add(this.buttonAdd);
            this.TwoMatrixTabPage.Controls.Add(this.button1);
            this.TwoMatrixTabPage.Controls.Add(this.MatrixCtextBox);
            this.TwoMatrixTabPage.Controls.Add(this.label3);
            this.TwoMatrixTabPage.Controls.Add(this.MatrixBtextBox);
            this.TwoMatrixTabPage.Controls.Add(this.label2);
            this.TwoMatrixTabPage.Controls.Add(this.MatrixAtextBox);
            this.TwoMatrixTabPage.Controls.Add(this.label1);
            this.TwoMatrixTabPage.Location = new System.Drawing.Point(4, 22);
            this.TwoMatrixTabPage.Name = "TwoMatrixTabPage";
            this.TwoMatrixTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TwoMatrixTabPage.Size = new System.Drawing.Size(790, 402);
            this.TwoMatrixTabPage.TabIndex = 1;
            this.TwoMatrixTabPage.Text = "二元运算";
            this.TwoMatrixTabPage.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(545, 351);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(386, 351);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 23);
            this.buttonSub.TabIndex = 8;
            this.buttonSub.Text = "矩阵相减";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(234, 351);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "矩阵相加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "矩阵相乘";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatrixCtextBox
            // 
            this.MatrixCtextBox.Location = new System.Drawing.Point(545, 96);
            this.MatrixCtextBox.Multiline = true;
            this.MatrixCtextBox.Name = "MatrixCtextBox";
            this.MatrixCtextBox.Size = new System.Drawing.Size(210, 206);
            this.MatrixCtextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(619, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "结果";
            // 
            // MatrixBtextBox
            // 
            this.MatrixBtextBox.Location = new System.Drawing.Point(276, 96);
            this.MatrixBtextBox.Multiline = true;
            this.MatrixBtextBox.Name = "MatrixBtextBox";
            this.MatrixBtextBox.Size = new System.Drawing.Size(210, 206);
            this.MatrixBtextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(342, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "矩阵B";
            // 
            // MatrixAtextBox
            // 
            this.MatrixAtextBox.Location = new System.Drawing.Point(24, 96);
            this.MatrixAtextBox.Multiline = true;
            this.MatrixAtextBox.Name = "MatrixAtextBox";
            this.MatrixAtextBox.Size = new System.Drawing.Size(210, 206);
            this.MatrixAtextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(95, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "矩阵A";
            // 
            // AttentionTabPage
            // 
            this.AttentionTabPage.Location = new System.Drawing.Point(4, 22);
            this.AttentionTabPage.Name = "AttentionTabPage";
            this.AttentionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AttentionTabPage.Size = new System.Drawing.Size(790, 402);
            this.AttentionTabPage.TabIndex = 2;
            this.AttentionTabPage.Text = "注意事项";
            this.AttentionTabPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(146, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "矩阵";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // MatrixDTextBox
            // 
            this.MatrixDTextBox.Location = new System.Drawing.Point(43, 95);
            this.MatrixDTextBox.Multiline = true;
            this.MatrixDTextBox.Name = "MatrixDTextBox";
            this.MatrixDTextBox.Size = new System.Drawing.Size(254, 241);
            this.MatrixDTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(542, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "结果";
            // 
            // MatrixETextBox
            // 
            this.MatrixETextBox.Location = new System.Drawing.Point(448, 95);
            this.MatrixETextBox.Multiline = true;
            this.MatrixETextBox.Name = "MatrixETextBox";
            this.MatrixETextBox.Size = new System.Drawing.Size(254, 241);
            this.MatrixETextBox.TabIndex = 3;
            // 
            // Transposebutton
            // 
            this.Transposebutton.Location = new System.Drawing.Point(336, 95);
            this.Transposebutton.Name = "Transposebutton";
            this.Transposebutton.Size = new System.Drawing.Size(75, 23);
            this.Transposebutton.TabIndex = 4;
            this.Transposebutton.Text = "矩阵转置";
            this.Transposebutton.UseVisualStyleBackColor = true;
            this.Transposebutton.Click += new System.EventHandler(this.Transposebutton_Click);
            // 
            // Inversebutton
            // 
            this.Inversebutton.Location = new System.Drawing.Point(336, 154);
            this.Inversebutton.Name = "Inversebutton";
            this.Inversebutton.Size = new System.Drawing.Size(75, 23);
            this.Inversebutton.TabIndex = 5;
            this.Inversebutton.Text = "矩阵求逆";
            this.Inversebutton.UseVisualStyleBackColor = true;
            this.Inversebutton.Click += new System.EventHandler(this.Inversebutton_Click);
            // 
            // ComputeDetbutton
            // 
            this.ComputeDetbutton.Location = new System.Drawing.Point(336, 211);
            this.ComputeDetbutton.Name = "ComputeDetbutton";
            this.ComputeDetbutton.Size = new System.Drawing.Size(91, 23);
            this.ComputeDetbutton.TabIndex = 6;
            this.ComputeDetbutton.Text = "矩阵行列式";
            this.ComputeDetbutton.UseVisualStyleBackColor = true;
            this.ComputeDetbutton.Click += new System.EventHandler(this.ComputeDetbutton_Click);
            // 
            // ComputeRankbutton
            // 
            this.ComputeRankbutton.Location = new System.Drawing.Point(336, 260);
            this.ComputeRankbutton.Name = "ComputeRankbutton";
            this.ComputeRankbutton.Size = new System.Drawing.Size(75, 23);
            this.ComputeRankbutton.TabIndex = 7;
            this.ComputeRankbutton.Text = "矩阵求秩";
            this.ComputeRankbutton.UseVisualStyleBackColor = true;
            this.ComputeRankbutton.Click += new System.EventHandler(this.ComputeRankbutton_Click);
            // 
            // ComputeEvJbutton
            // 
            this.ComputeEvJbutton.Location = new System.Drawing.Point(303, 313);
            this.ComputeEvJbutton.Name = "ComputeEvJbutton";
            this.ComputeEvJbutton.Size = new System.Drawing.Size(139, 23);
            this.ComputeEvJbutton.TabIndex = 8;
            this.ComputeEvJbutton.Text = "矩阵特征值与特征向量";
            this.ComputeEvJbutton.UseVisualStyleBackColor = true;
            this.ComputeEvJbutton.Click += new System.EventHandler(this.ComputeEvJbutton_Click);
            // 
            // MainMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaintabControl);
            this.Name = "MainMatrixForm";
            this.Text = "主窗口";
            this.MaintabControl.ResumeLayout(false);
            this.OneMatrixTabPage.ResumeLayout(false);
            this.OneMatrixTabPage.PerformLayout();
            this.TwoMatrixTabPage.ResumeLayout(false);
            this.TwoMatrixTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MaintabControl;
        private System.Windows.Forms.TabPage OneMatrixTabPage;
        private System.Windows.Forms.TabPage TwoMatrixTabPage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox MatrixCtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MatrixBtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MatrixAtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage AttentionTabPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MatrixETextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MatrixDTextBox;
        private System.Windows.Forms.Button Transposebutton;
        private System.Windows.Forms.Button Inversebutton;
        private System.Windows.Forms.Button ComputeDetbutton;
        private System.Windows.Forms.Button ComputeRankbutton;
        private System.Windows.Forms.Button ComputeEvJbutton;
    }
}

