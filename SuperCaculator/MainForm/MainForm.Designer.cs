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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("标准");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("微分积分");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("解方程");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("矩阵");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("函数绘图");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("计算器", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("日期计算");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("单位换算");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("转换器", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
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
            this.panel1.Size = new System.Drawing.Size(956, 510);
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
            this.panelChild.Size = new System.Drawing.Size(683, 485);
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
            treeNode1.Name = "standard";
            treeNode1.Text = "标准";
            treeNode2.Name = "DI";
            treeNode2.Text = "微分积分";
            treeNode3.Name = "solveEquation";
            treeNode3.Text = "解方程";
            treeNode4.Name = "matrix";
            treeNode4.Text = "矩阵";
            treeNode5.Name = "painting";
            treeNode5.Text = "函数绘图";
            treeNode6.Name = "节点0";
            treeNode6.Text = "计算器";
            treeNode7.Name = "date";
            treeNode7.Text = "日期计算";
            treeNode8.Name = "unit";
            treeNode8.Text = "单位换算";
            treeNode9.Name = "节点1";
            treeNode9.Text = "转换器";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(231, 483);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MenuClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 510);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("方正舒体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Text = "多功能计算器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.TreeView treeView1;
    }
}

