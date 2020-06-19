namespace MainForm
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
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("标准计算");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("微分积分");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("解方程");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("矩阵运算");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("函数绘图");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("计算器", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("日期计算");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("单位换算");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("转换器", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.panelChild);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.panel1.Size = new System.Drawing.Size(1269, 621);
            this.panel1.TabIndex = 1;
            // 
            // panelChild
            // 
            this.panelChild.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChild.BackColor = System.Drawing.Color.AliceBlue;
            this.panelChild.Location = new System.Drawing.Point(256, 13);
            this.panelChild.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(996, 596);
            this.panelChild.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.BackColor = System.Drawing.Color.AliceBlue;
            this.treeView1.Font = new System.Drawing.Font("方正舒体", 21F);
            this.treeView1.Location = new System.Drawing.Point(17, 13);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "standard";
            treeNode10.Text = "标准计算";
            treeNode11.Name = "DI";
            treeNode11.Text = "微分积分";
            treeNode12.Name = "solveEquation";
            treeNode12.Text = "解方程";
            treeNode13.Name = "matrix";
            treeNode13.Text = "矩阵运算";
            treeNode14.Name = "painting";
            treeNode14.Text = "函数绘图";
            treeNode15.Name = "节点0";
            treeNode15.Text = "计算器";
            treeNode16.Name = "date";
            treeNode16.Text = "日期计算";
            treeNode17.Name = "unit";
            treeNode17.Text = "单位换算";
            treeNode18.Name = "节点1";
            treeNode18.Text = "转换器";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode18});
            this.treeView1.Size = new System.Drawing.Size(231, 594);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MenuClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 621);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("方正舒体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Text = "多功能科学计算器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.TreeView treeView1;
    }
}

