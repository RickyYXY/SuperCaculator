namespace PaintForm
{
    partial class Paint2DForm
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
            this.label_func = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_draw = new System.Windows.Forms.Button();
            this.button_color = new System.Windows.Forms.Button();
            this.label_range = new System.Windows.Forms.Label();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.label_X = new System.Windows.Forms.Label();
            this.panel_paint = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_paint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.button_save);
            this.panel1.Controls.Add(this.label_func);
            this.panel1.Controls.Add(this.button_clean);
            this.panel1.Controls.Add(this.button_close);
            this.panel1.Controls.Add(this.button_draw);
            this.panel1.Controls.Add(this.button_color);
            this.panel1.Controls.Add(this.label_range);
            this.panel1.Controls.Add(this.textBox_max);
            this.panel1.Controls.Add(this.textBox_min);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 250);
            this.panel1.TabIndex = 1;
            // 
            // label_func
            // 
            this.label_func.AutoSize = true;
            this.label_func.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_func.Location = new System.Drawing.Point(35, 20);
            this.label_func.Name = "label_func";
            this.label_func.Size = new System.Drawing.Size(143, 52);
            this.label_func.TabIndex = 14;
            this.label_func.Text = "F(x) = ";
            // 
            // button_clean
            // 
            this.button_clean.BackColor = System.Drawing.Color.LightCyan;
            this.button_clean.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_clean.Location = new System.Drawing.Point(400, 175);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(150, 55);
            this.button_clean.TabIndex = 12;
            this.button_clean.Text = "Clean";
            this.button_clean.UseVisualStyleBackColor = false;
            this.button_clean.Click += new System.EventHandler(this.Button_clean_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.LightCyan;
            this.button_close.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_close.Location = new System.Drawing.Point(760, 175);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(150, 55);
            this.button_close.TabIndex = 13;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // button_draw
            // 
            this.button_draw.BackColor = System.Drawing.Color.LightCyan;
            this.button_draw.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_draw.Location = new System.Drawing.Point(220, 175);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(150, 55);
            this.button_draw.TabIndex = 11;
            this.button_draw.Text = "Draw";
            this.button_draw.UseVisualStyleBackColor = false;
            this.button_draw.Click += new System.EventHandler(this.Button_draw_Click);
            // 
            // button_color
            // 
            this.button_color.BackColor = System.Drawing.Color.LightCyan;
            this.button_color.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_color.Location = new System.Drawing.Point(40, 175);
            this.button_color.Name = "button_color";
            this.button_color.Size = new System.Drawing.Size(150, 55);
            this.button_color.TabIndex = 10;
            this.button_color.Text = "Color";
            this.button_color.UseVisualStyleBackColor = false;
            this.button_color.Click += new System.EventHandler(this.Button_color_Click);
            // 
            // label_range
            // 
            this.label_range.AutoSize = true;
            this.label_range.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_range.Location = new System.Drawing.Point(35, 90);
            this.label_range.Name = "label_range";
            this.label_range.Size = new System.Drawing.Size(141, 52);
            this.label_range.TabIndex = 9;
            this.label_range.Text = "Range:";
            // 
            // textBox_max
            // 
            this.textBox_max.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_max.Location = new System.Drawing.Point(570, 90);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(225, 59);
            this.textBox_max.TabIndex = 8;
            this.textBox_max.Text = "1";
            this.textBox_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_min
            // 
            this.textBox_min.Font = new System.Drawing.Font("Ink Free", 25F);
            this.textBox_min.Location = new System.Drawing.Point(206, 90);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(225, 59);
            this.textBox_min.TabIndex = 7;
            this.textBox_min.Text = "-1";
            this.textBox_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Ink Free", 25F);
            this.label_X.Location = new System.Drawing.Point(450, 90);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(103, 52);
            this.label_X.TabIndex = 6;
            this.label_X.Text = "< x <";
            // 
            // panel_paint
            // 
            this.panel_paint.AutoScroll = true;
            this.panel_paint.Controls.Add(this.pictureBox);
            this.panel_paint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_paint.Location = new System.Drawing.Point(0, 250);
            this.panel_paint.Name = "panel_paint";
            this.panel_paint.Size = new System.Drawing.Size(932, 453);
            this.panel_paint.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(932, 453);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
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
            this.labely.Location = new System.Drawing.Point(200, 0);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(37, 31);
            this.labely.TabIndex = 1;
            this.labely.Text = "y: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.labelx);
            this.panel2.Controls.Add(this.labely);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 672);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 31);
            this.panel2.TabIndex = 4;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LightCyan;
            this.button_save.Font = new System.Drawing.Font("Ink Free", 20F);
            this.button_save.Location = new System.Drawing.Point(580, 175);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 55);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Paint2DForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_paint);
            this.Controls.Add(this.panel1);
            this.Name = "Paint2DForm";
            this.Text = "Paint2D";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_paint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_range;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Button button_color;
        private System.Windows.Forms.Panel panel_paint;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_func;
        private System.Windows.Forms.Button button_save;
    }
}