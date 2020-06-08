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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionPaintForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_2D = new System.Windows.Forms.TabPage();
            this.pictureBox_2D = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_draw_2D = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button_save_2D = new System.Windows.Forms.Button();
            this.button_color_2D = new System.Windows.Forms.Button();
            this.button_clean_2D = new System.Windows.Forms.Button();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_exp_2D = new System.Windows.Forms.TextBox();
            this.label_func_2D = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_max_2D = new System.Windows.Forms.TextBox();
            this.label_range_2D = new System.Windows.Forms.Label();
            this.textBox_min_2D = new System.Windows.Forms.TextBox();
            this.label_X_2D = new System.Windows.Forms.Label();
            this.tabPage_3D = new System.Windows.Forms.TabPage();
            this.pictureBox_3D = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button_draw_3D = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label_density = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_exp_3D = new System.Windows.Forms.TextBox();
            this.label_func_3D = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.button_save_3D = new System.Windows.Forms.Button();
            this.button_color_3D = new System.Windows.Forms.Button();
            this.button_clear_3D = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_range_3D = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_maxY_3D = new System.Windows.Forms.TextBox();
            this.textBox_minX_3D = new System.Windows.Forms.TextBox();
            this.textBox_maxX_3D = new System.Windows.Forms.TextBox();
            this.label_Y_3D = new System.Windows.Forms.Label();
            this.textBox_minY_3D = new System.Windows.Forms.TextBox();
            this.label_X_3D = new System.Windows.Forms.Label();
            this.tabPage_help = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage_2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2D)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tabPage_3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3D)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage_help.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_2D);
            this.tabControl.Controls.Add(this.tabPage_3D);
            this.tabControl.Controls.Add(this.tabPage_help);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("方正舒体", 15F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(982, 753);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage_2D
            // 
            this.tabPage_2D.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_2D.Controls.Add(this.pictureBox_2D);
            this.tabPage_2D.Controls.Add(this.panel2);
            this.tabPage_2D.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_2D.Font = new System.Drawing.Font("方正舒体", 15F);
            this.tabPage_2D.Location = new System.Drawing.Point(4, 36);
            this.tabPage_2D.Name = "tabPage_2D";
            this.tabPage_2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_2D.Size = new System.Drawing.Size(974, 713);
            this.tabPage_2D.TabIndex = 0;
            this.tabPage_2D.Text = "一元函数";
            // 
            // pictureBox_2D
            // 
            this.pictureBox_2D.BackColor = System.Drawing.Color.White;
            this.pictureBox_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_2D.Location = new System.Drawing.Point(3, 203);
            this.pictureBox_2D.Name = "pictureBox_2D";
            this.pictureBox_2D.Size = new System.Drawing.Size(968, 476);
            this.pictureBox_2D.TabIndex = 6;
            this.pictureBox_2D.TabStop = false;
            this.pictureBox_2D.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_2D_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.labelx);
            this.panel2.Controls.Add(this.labely);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 679);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 31);
            this.panel2.TabIndex = 5;
            // 
            // labelx
            // 
            this.labelx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Ink Free", 15F);
            this.labelx.Location = new System.Drawing.Point(0, 0);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(29, 31);
            this.labelx.TabIndex = 0;
            this.labelx.Text = "x:";
            // 
            // labely
            // 
            this.labely.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labely.Location = new System.Drawing.Point(250, 0);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(37, 31);
            this.labely.TabIndex = 1;
            this.labely.Text = "y: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.button_draw_2D, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(968, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_draw_2D
            // 
            this.button_draw_2D.BackColor = System.Drawing.Color.LightCyan;
            this.button_draw_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_draw_2D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_draw_2D.Location = new System.Drawing.Point(777, 3);
            this.button_draw_2D.Name = "button_draw_2D";
            this.button_draw_2D.Size = new System.Drawing.Size(188, 194);
            this.button_draw_2D.TabIndex = 19;
            this.button_draw_2D.Text = "绘图";
            this.button_draw_2D.UseVisualStyleBackColor = false;
            this.button_draw_2D.Click += new System.EventHandler(this.Button_draw_2D_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel14, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(768, 194);
            this.tableLayoutPanel4.TabIndex = 20;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33533F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33233F));
            this.tableLayoutPanel5.Controls.Add(this.button_save_2D, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_color_2D, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.button_clean_2D, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(762, 58);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // button_save_2D
            // 
            this.button_save_2D.BackColor = System.Drawing.Color.LightCyan;
            this.button_save_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_save_2D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_save_2D.Location = new System.Drawing.Point(510, 3);
            this.button_save_2D.Name = "button_save_2D";
            this.button_save_2D.Size = new System.Drawing.Size(249, 52);
            this.button_save_2D.TabIndex = 19;
            this.button_save_2D.Text = "保存";
            this.button_save_2D.UseVisualStyleBackColor = false;
            this.button_save_2D.Click += new System.EventHandler(this.Button_save_2D_Click);
            // 
            // button_color_2D
            // 
            this.button_color_2D.BackColor = System.Drawing.Color.LightCyan;
            this.button_color_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_color_2D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_color_2D.Location = new System.Drawing.Point(3, 3);
            this.button_color_2D.Name = "button_color_2D";
            this.button_color_2D.Size = new System.Drawing.Size(248, 52);
            this.button_color_2D.TabIndex = 16;
            this.button_color_2D.Text = "颜色";
            this.button_color_2D.UseVisualStyleBackColor = false;
            this.button_color_2D.Click += new System.EventHandler(this.Button_color_2D_Click);
            // 
            // button_clean_2D
            // 
            this.button_clean_2D.BackColor = System.Drawing.Color.LightCyan;
            this.button_clean_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clean_2D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_clean_2D.Location = new System.Drawing.Point(257, 3);
            this.button_clean_2D.Name = "button_clean_2D";
            this.button_clean_2D.Size = new System.Drawing.Size(247, 52);
            this.button_clean_2D.TabIndex = 18;
            this.button_clean_2D.Text = "清屏";
            this.button_clean_2D.UseVisualStyleBackColor = false;
            this.button_clean_2D.Click += new System.EventHandler(this.Button_clean_2D_Click);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.textBox_exp_2D, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.label_func_2D, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(762, 59);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // textBox_exp_2D
            // 
            this.textBox_exp_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_exp_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_exp_2D.Location = new System.Drawing.Point(153, 3);
            this.textBox_exp_2D.Name = "textBox_exp_2D";
            this.textBox_exp_2D.Size = new System.Drawing.Size(606, 51);
            this.textBox_exp_2D.TabIndex = 19;
            this.textBox_exp_2D.Text = "x+x*sin(x)+2";
            // 
            // label_func_2D
            // 
            this.label_func_2D.AutoSize = true;
            this.label_func_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_func_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_func_2D.Location = new System.Drawing.Point(3, 0);
            this.label_func_2D.Name = "label_func_2D";
            this.label_func_2D.Size = new System.Drawing.Size(144, 59);
            this.label_func_2D.TabIndex = 19;
            this.label_func_2D.Text = "F(x) =";
            this.label_func_2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 4;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.textBox_max_2D, 3, 0);
            this.tableLayoutPanel14.Controls.Add(this.label_range_2D, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.textBox_min_2D, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.label_X_2D, 2, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(762, 59);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // textBox_max_2D
            // 
            this.textBox_max_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_max_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_max_2D.Location = new System.Drawing.Point(534, 3);
            this.textBox_max_2D.Name = "textBox_max_2D";
            this.textBox_max_2D.Size = new System.Drawing.Size(225, 51);
            this.textBox_max_2D.TabIndex = 17;
            this.textBox_max_2D.Text = "1";
            this.textBox_max_2D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_range_2D
            // 
            this.label_range_2D.AutoSize = true;
            this.label_range_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_range_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_range_2D.Location = new System.Drawing.Point(3, 0);
            this.label_range_2D.Name = "label_range_2D";
            this.label_range_2D.Size = new System.Drawing.Size(144, 59);
            this.label_range_2D.TabIndex = 18;
            this.label_range_2D.Text = "范围:";
            this.label_range_2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_min_2D
            // 
            this.textBox_min_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_min_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_min_2D.Location = new System.Drawing.Point(153, 3);
            this.textBox_min_2D.Name = "textBox_min_2D";
            this.textBox_min_2D.Size = new System.Drawing.Size(225, 51);
            this.textBox_min_2D.TabIndex = 16;
            this.textBox_min_2D.Text = "-1";
            this.textBox_min_2D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_X_2D
            // 
            this.label_X_2D.AutoSize = true;
            this.label_X_2D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_X_2D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_X_2D.Location = new System.Drawing.Point(384, 0);
            this.label_X_2D.Name = "label_X_2D";
            this.label_X_2D.Size = new System.Drawing.Size(144, 59);
            this.label_X_2D.TabIndex = 15;
            this.label_X_2D.Text = "< x <";
            this.label_X_2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_3D
            // 
            this.tabPage_3D.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_3D.Controls.Add(this.pictureBox_3D);
            this.tabPage_3D.Controls.Add(this.tableLayoutPanel6);
            this.tabPage_3D.Location = new System.Drawing.Point(4, 36);
            this.tabPage_3D.Name = "tabPage_3D";
            this.tabPage_3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_3D.Size = new System.Drawing.Size(974, 713);
            this.tabPage_3D.TabIndex = 1;
            this.tabPage_3D.Text = "二元函数";
            // 
            // pictureBox_3D
            // 
            this.pictureBox_3D.BackColor = System.Drawing.Color.White;
            this.pictureBox_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_3D.Location = new System.Drawing.Point(3, 278);
            this.pictureBox_3D.Name = "pictureBox_3D";
            this.pictureBox_3D.Size = new System.Drawing.Size(968, 432);
            this.pictureBox_3D.TabIndex = 3;
            this.pictureBox_3D.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(968, 275);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.button_draw_3D, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(721, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(244, 269);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // button_draw_3D
            // 
            this.button_draw_3D.BackColor = System.Drawing.Color.LightCyan;
            this.button_draw_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_draw_3D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_draw_3D.Location = new System.Drawing.Point(3, 63);
            this.button_draw_3D.Name = "button_draw_3D";
            this.button_draw_3D.Size = new System.Drawing.Size(238, 203);
            this.button_draw_3D.TabIndex = 12;
            this.button_draw_3D.Text = "绘图";
            this.button_draw_3D.UseVisualStyleBackColor = false;
            this.button_draw_3D.Click += new System.EventHandler(this.Button_draw_3D_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.trackBar, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label_density, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(238, 54);
            this.tableLayoutPanel8.TabIndex = 13;
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.LightBlue;
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.Location = new System.Drawing.Point(123, 3);
            this.trackBar.Name = "trackBar";
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.Size = new System.Drawing.Size(112, 48);
            this.trackBar.TabIndex = 19;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 8;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // label_density
            // 
            this.label_density.AutoSize = true;
            this.label_density.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_density.Font = new System.Drawing.Font("方正舒体", 20F);
            this.label_density.Location = new System.Drawing.Point(3, 0);
            this.label_density.Name = "label_density";
            this.label_density.Size = new System.Drawing.Size(114, 54);
            this.label_density.TabIndex = 20;
            this.label_density.Text = "密度:";
            this.label_density.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel15, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(712, 269);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.textBox_exp_3D, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label_func_3D, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(706, 59);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // textBox_exp_3D
            // 
            this.textBox_exp_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_exp_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_exp_3D.Location = new System.Drawing.Point(203, 3);
            this.textBox_exp_3D.Name = "textBox_exp_3D";
            this.textBox_exp_3D.Size = new System.Drawing.Size(500, 51);
            this.textBox_exp_3D.TabIndex = 16;
            this.textBox_exp_3D.Text = "x*x*y*y";
            // 
            // label_func_3D
            // 
            this.label_func_3D.AutoSize = true;
            this.label_func_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_func_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_func_3D.Location = new System.Drawing.Point(3, 0);
            this.label_func_3D.Name = "label_func_3D";
            this.label_func_3D.Size = new System.Drawing.Size(194, 59);
            this.label_func_3D.TabIndex = 15;
            this.label_func_3D.Text = "F(x, y) =";
            this.label_func_3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.Controls.Add(this.button_save_3D, 2, 0);
            this.tableLayoutPanel15.Controls.Add(this.button_color_3D, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.button_clear_3D, 1, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 193);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(706, 73);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // button_save_3D
            // 
            this.button_save_3D.BackColor = System.Drawing.Color.LightCyan;
            this.button_save_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_save_3D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_save_3D.Location = new System.Drawing.Point(473, 3);
            this.button_save_3D.Name = "button_save_3D";
            this.button_save_3D.Size = new System.Drawing.Size(230, 67);
            this.button_save_3D.TabIndex = 28;
            this.button_save_3D.Text = "保存";
            this.button_save_3D.UseVisualStyleBackColor = false;
            this.button_save_3D.Click += new System.EventHandler(this.Button_save_3D_Click);
            // 
            // button_color_3D
            // 
            this.button_color_3D.BackColor = System.Drawing.Color.LightCyan;
            this.button_color_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_color_3D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_color_3D.Location = new System.Drawing.Point(3, 3);
            this.button_color_3D.Name = "button_color_3D";
            this.button_color_3D.Size = new System.Drawing.Size(229, 67);
            this.button_color_3D.TabIndex = 21;
            this.button_color_3D.Text = "颜色";
            this.button_color_3D.UseVisualStyleBackColor = false;
            this.button_color_3D.Click += new System.EventHandler(this.Button_color_3D_Click);
            // 
            // button_clear_3D
            // 
            this.button_clear_3D.BackColor = System.Drawing.Color.LightCyan;
            this.button_clear_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear_3D.Font = new System.Drawing.Font("方正舒体", 20F);
            this.button_clear_3D.Location = new System.Drawing.Point(238, 3);
            this.button_clear_3D.Name = "button_clear_3D";
            this.button_clear_3D.Size = new System.Drawing.Size(229, 67);
            this.button_clear_3D.TabIndex = 23;
            this.button_clear_3D.Text = "清屏";
            this.button_clear_3D.UseVisualStyleBackColor = false;
            this.button_clear_3D.Click += new System.EventHandler(this.Button_clean_3D_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label_range_3D, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(706, 119);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label_range_3D
            // 
            this.label_range_3D.AutoSize = true;
            this.label_range_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_range_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_range_3D.Location = new System.Drawing.Point(3, 0);
            this.label_range_3D.Name = "label_range_3D";
            this.label_range_3D.Size = new System.Drawing.Size(194, 119);
            this.label_range_3D.TabIndex = 19;
            this.label_range_3D.Text = "范围:";
            this.label_range_3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBox_maxY_3D, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_minX_3D, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox_maxX_3D, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label_Y_3D, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox_minY_3D, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label_X_3D, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(503, 113);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // textBox_maxY_3D
            // 
            this.textBox_maxY_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_maxY_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_maxY_3D.Location = new System.Drawing.Point(329, 59);
            this.textBox_maxY_3D.Name = "textBox_maxY_3D";
            this.textBox_maxY_3D.Size = new System.Drawing.Size(171, 51);
            this.textBox_maxY_3D.TabIndex = 23;
            this.textBox_maxY_3D.Text = "1";
            this.textBox_maxY_3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_minX_3D
            // 
            this.textBox_minX_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_minX_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_minX_3D.Location = new System.Drawing.Point(3, 3);
            this.textBox_minX_3D.Name = "textBox_minX_3D";
            this.textBox_minX_3D.Size = new System.Drawing.Size(170, 51);
            this.textBox_minX_3D.TabIndex = 19;
            this.textBox_minX_3D.Text = "-1";
            this.textBox_minX_3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_maxX_3D
            // 
            this.textBox_maxX_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_maxX_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_maxX_3D.Location = new System.Drawing.Point(329, 3);
            this.textBox_maxX_3D.Name = "textBox_maxX_3D";
            this.textBox_maxX_3D.Size = new System.Drawing.Size(171, 51);
            this.textBox_maxX_3D.TabIndex = 20;
            this.textBox_maxX_3D.Text = "1";
            this.textBox_maxX_3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Y_3D
            // 
            this.label_Y_3D.AutoSize = true;
            this.label_Y_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Y_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_Y_3D.Location = new System.Drawing.Point(179, 56);
            this.label_Y_3D.Name = "label_Y_3D";
            this.label_Y_3D.Size = new System.Drawing.Size(144, 57);
            this.label_Y_3D.TabIndex = 21;
            this.label_Y_3D.Text = "< y <";
            this.label_Y_3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_minY_3D
            // 
            this.textBox_minY_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_minY_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.textBox_minY_3D.Location = new System.Drawing.Point(3, 59);
            this.textBox_minY_3D.Name = "textBox_minY_3D";
            this.textBox_minY_3D.Size = new System.Drawing.Size(170, 51);
            this.textBox_minY_3D.TabIndex = 22;
            this.textBox_minY_3D.Text = "-1";
            this.textBox_minY_3D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_X_3D
            // 
            this.label_X_3D.AutoSize = true;
            this.label_X_3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_X_3D.Font = new System.Drawing.Font("方正舒体", 25F);
            this.label_X_3D.Location = new System.Drawing.Point(179, 3);
            this.label_X_3D.Margin = new System.Windows.Forms.Padding(3);
            this.label_X_3D.Name = "label_X_3D";
            this.label_X_3D.Size = new System.Drawing.Size(144, 50);
            this.label_X_3D.TabIndex = 18;
            this.label_X_3D.Text = "< x <";
            this.label_X_3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_help
            // 
            this.tabPage_help.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage_help.Controls.Add(this.tableLayoutPanel11);
            this.tabPage_help.Location = new System.Drawing.Point(4, 36);
            this.tabPage_help.Name = "tabPage_help";
            this.tabPage_help.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_help.Size = new System.Drawing.Size(974, 713);
            this.tabPage_help.TabIndex = 2;
            this.tabPage_help.Text = "注意事项";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(968, 707);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("方正舒体", 18F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(962, 707);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FunctionPaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.tabControl);
            this.Name = "FunctionPaintForm";
            this.Text = "函数绘图";
            this.tabControl.ResumeLayout(false);
            this.tabPage_2D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2D)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tabPage_3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3D)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage_help.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_3D;
        private System.Windows.Forms.TabPage tabPage_2D;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_range_2D;
        private System.Windows.Forms.TextBox textBox_max_2D;
        private System.Windows.Forms.TextBox textBox_min_2D;
        private System.Windows.Forms.Label label_X_2D;
        private System.Windows.Forms.Label label_func_2D;
        private System.Windows.Forms.Button button_draw_2D;
        private System.Windows.Forms.TextBox textBox_exp_2D;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button_save_2D;
        private System.Windows.Forms.Button button_color_2D;
        private System.Windows.Forms.Button button_clean_2D;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button_draw_3D;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label_density;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox textBox_exp_3D;
        private System.Windows.Forms.Label label_func_3D;
        private System.Windows.Forms.TextBox textBox_maxY_3D;
        private System.Windows.Forms.TextBox textBox_minX_3D;
        private System.Windows.Forms.TextBox textBox_maxX_3D;
        private System.Windows.Forms.Label label_Y_3D;
        private System.Windows.Forms.TextBox textBox_minY_3D;
        private System.Windows.Forms.Label label_X_3D;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Button button_save_3D;
        private System.Windows.Forms.Button button_color_3D;
        private System.Windows.Forms.Button button_clear_3D;
        private System.Windows.Forms.PictureBox pictureBox_3D;
        private System.Windows.Forms.PictureBox pictureBox_2D;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label_range_3D;
        private System.Windows.Forms.TabPage tabPage_help;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Label label1;
    }
}