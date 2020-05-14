namespace PaintForm
{
    partial class Paint3DForm
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
            this.panel_paint = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_rate = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.textBox_maxY = new System.Windows.Forms.TextBox();
            this.textBox_minY = new System.Windows.Forms.TextBox();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_func = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_draw = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.label_range = new System.Windows.Forms.Label();
            this.textBox_maxX = new System.Windows.Forms.TextBox();
            this.textBox_minX = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.panel_paint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_paint
            // 
            this.panel_paint.AutoScroll = true;
            this.panel_paint.Controls.Add(this.pictureBox);
            this.panel_paint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_paint.Location = new System.Drawing.Point(0, 300);
            this.panel_paint.Name = "panel_paint";
            this.panel_paint.Size = new System.Drawing.Size(882, 453);
            this.panel_paint.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(882, 453);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.label_rate);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Controls.Add(this.textBox_maxY);
            this.panel1.Controls.Add(this.textBox_minY);
            this.panel1.Controls.Add(this.label_Y);
            this.panel1.Controls.Add(this.label_func);
            this.panel1.Controls.Add(this.button_clean);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.button_draw);
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.label_range);
            this.panel1.Controls.Add(this.textBox_maxX);
            this.panel1.Controls.Add(this.textBox_minX);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 300);
            this.panel1.TabIndex = 5;
            // 
            // label_rate
            // 
            this.label_rate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_rate.AutoSize = true;
            this.label_rate.Font = new System.Drawing.Font("Ink Free", 20F);
            this.label_rate.Location = new System.Drawing.Point(765, 85);
            this.label_rate.Name = "label_rate";
            this.label_rate.Size = new System.Drawing.Size(97, 42);
            this.label_rate.TabIndex = 19;
            this.label_rate.Text = "Rate:";
            // 
            // trackBar
            // 
            this.trackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar.BackColor = System.Drawing.Color.LightBlue;
            this.trackBar.Location = new System.Drawing.Point(785, 130);
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar.Size = new System.Drawing.Size(56, 150);
            this.trackBar.TabIndex = 18;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 2;
            this.trackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            // 
            // textBox_maxY
            // 
            this.textBox_maxY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_maxY.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_maxY.Location = new System.Drawing.Point(545, 160);
            this.textBox_maxY.Name = "textBox_maxY";
            this.textBox_maxY.Size = new System.Drawing.Size(200, 59);
            this.textBox_maxY.TabIndex = 17;
            this.textBox_maxY.Text = "1";
            this.textBox_maxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_minY
            // 
            this.textBox_minY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_minY.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_minY.Location = new System.Drawing.Point(205, 160);
            this.textBox_minY.Name = "textBox_minY";
            this.textBox_minY.Size = new System.Drawing.Size(200, 59);
            this.textBox_minY.TabIndex = 16;
            this.textBox_minY.Text = "-1";
            this.textBox_minY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Y
            // 
            this.label_Y.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Y.AutoSize = true;
            this.label_Y.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_Y.Location = new System.Drawing.Point(425, 160);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(105, 52);
            this.label_Y.TabIndex = 15;
            this.label_Y.Text = "< y <";
            // 
            // label_func
            // 
            this.label_func.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_func.AutoSize = true;
            this.label_func.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_func.Location = new System.Drawing.Point(35, 20);
            this.label_func.Name = "label_func";
            this.label_func.Size = new System.Drawing.Size(182, 52);
            this.label_func.TabIndex = 14;
            this.label_func.Text = "F(x, y) = ";
            // 
            // button_clean
            // 
            this.button_clean.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_clean.BackColor = System.Drawing.Color.LightCyan;
            this.button_clean.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_clean.Location = new System.Drawing.Point(410, 235);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(150, 55);
            this.button_clean.TabIndex = 12;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = false;
            this.button_clean.Click += new System.EventHandler(this.Button_clean_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_close.BackColor = System.Drawing.Color.LightCyan;
            this.button_close.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_close.Location = new System.Drawing.Point(595, 235);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(150, 55);
            this.button_close.TabIndex = 13;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // button_draw
            // 
            this.button_draw.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_draw.BackColor = System.Drawing.Color.LightCyan;
            this.button_draw.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_draw.Location = new System.Drawing.Point(225, 235);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(150, 55);
            this.button_draw.TabIndex = 11;
            this.button_draw.Text = "Draw";
            this.button_draw.UseVisualStyleBackColor = false;
            this.button_draw.Click += new System.EventHandler(this.Button_draw_Click);
            // 
            // button_color
            // 
            this.button_color.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_color.BackColor = System.Drawing.Color.LightCyan;
            this.button_color.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_color.Location = new System.Drawing.Point(40, 235);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(150, 55);
            this.button_color.TabIndex = 10;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.Button_color_Click);
            // 
            // label_range
            // 
            this.label_range.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_range.AutoSize = true;
            this.label_range.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_range.Location = new System.Drawing.Point(35, 125);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(141, 52);
            this.label_range.TabIndex = 9;
            this.label_range.Text = "Range:";
            // 
            // textBox_maxX
            // 
            this.textBox_maxX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_maxX.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_maxX.Location = new System.Drawing.Point(545, 90);
            this.textBox_maxX.Name = "textBox_maxX";
            this.textBox_maxX.Size = new System.Drawing.Size(200, 59);
            this.textBox_maxX.TabIndex = 8;
            this.textBox_maxX.Text = "1";
            this.textBox_maxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_minX
            // 
            this.textBox_minX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_minX.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_minX.Location = new System.Drawing.Point(205, 90);
            this.textBox_minX.Name = "textBox_minX";
            this.textBox_minX.Size = new System.Drawing.Size(200, 59);
            this.textBox_minX.TabIndex = 7;
            this.textBox_minX.Text = "-1";
            this.textBox_minX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_X
            // 
            this.label_X.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_X.Location = new System.Drawing.Point(425, 90);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(103, 52);
            this.label_X.TabIndex = 6;
            this.label_X.Text = "< x <";
            // 
            // Paint3DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.panel_paint);
            this.Controls.Add(this.panel1);
            this.Name = "Paint3DForm";
            this.Text = "Paint3D";
            this.panel_paint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_paint;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_func;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.TextBox textBox_maxX;
        private System.Windows.Forms.TextBox textBox_minX;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox textBox_maxY;
        private System.Windows.Forms.TextBox textBox_minY;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_rate;
        private System.Windows.Forms.TrackBar trackBar;
    }
}