using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForm
{
    public partial class FunctionPaintForm : Form
    {
        private Pen pen_2D, pen_3D;
        private bool ShowXY_2D;
        private int rate;

        private Painter2D painter2D;
        private Painter3D painter3D;

        public double Min_2D { get; set; }
        public double Max_2D { get; set; }
        public double MinX_3D { get; set; }
        public double MaxX_3D { get; set; }
        public double MinY_3D { get; set; }
        public double MaxY_3D { get; set; }


        private Func<double?, double?, double> Caculate2D;
        private Func<double?, double?, double> Caculate3D;

        public FunctionPaintForm()
        {
            InitializeComponent();
            textBox_min_2D.DataBindings.Add("Text", this, "Min_2D");
            textBox_max_2D.DataBindings.Add("Text", this, "Max_2D");
            textBox_minX_3D.DataBindings.Add("Text", this, "MinX_3D");
            textBox_maxX_3D.DataBindings.Add("Text", this, "MaxX_3D");
            textBox_minY_3D.DataBindings.Add("Text", this, "MinY_3D");
            textBox_maxY_3D.DataBindings.Add("Text", this, "MaxY_3D");
            pen_2D = new Pen(Color.Black);
            pen_3D = new Pen(Color.Black);
            ShowXY_2D = false;
            pictureBox_2D.Image = new Bitmap(pictureBox_2D.Width, pictureBox_2D.Height);
            pictureBox_3D.Image = new Bitmap(pictureBox_3D.Width, pictureBox_3D.Height);
            rate = 11 - trackBar.Value;
        }

        private void Button_color_2D_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDia = new ColorDialog())
            {
                if (colorDia.ShowDialog() == DialogResult.OK)
                {
                    pen_2D.Color = colorDia.Color;
                }
            }
        }

        private void Button_clean_2D_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox_2D.Width, pictureBox_2D.Height);
            using(Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                pictureBox_2D.Image = bitmap;
            }
            ShowXY_2D = false;
            labelx_2D.Text = "X: ";
            labely_2D.Text = "Y: ";
            labelFx.Text = "F(x) = ";
        }

        private void Button_save_2D_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.FileName = "picture2D";
                save.Filter = "(.jpg)|*.jpg";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_2D.Image.Save(save.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("保存成功");
                }
            }
        }

        private void Button_draw_2D_Click(object sender, EventArgs e)
        {
            string exp = textBox_exp_2D.Text;
            try
            {
                Function.Function func = new Function.Function(exp);
                Caculate2D = func.GetValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (Max_2D <= Min_2D)
            {
                MessageBox.Show("定义域输入不合法。");
                return;
            }
            Bitmap bitmap = new Bitmap(pictureBox_2D.Width, pictureBox_2D.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                painter2D = new Painter2D(pictureBox_2D, g, pen_2D, Caculate2D, Min_2D, Max_2D);
                try
                {
                    painter2D.Draw();
                    pictureBox_2D.Image = bitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
            ShowXY_2D = true;
        }

        private void PictureBox_2D_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShowXY_2D)
            {
                double x = e.Location.X;
                double y = e.Location.Y;
                x = (x - painter2D.Xstart) * painter2D.Dx + Min_2D;
                y = (painter2D.Ystart - y) * painter2D.Dy + painter2D.MinValue;
                labelx_2D.Text = "X: " + x.ToString("#0.000");
                labely_2D.Text = "Y: " + y.ToString("#0.000");
                if (x < Min_2D || x > Max_2D)
                {
                    labelFx.Text = "F(x)超出定义域范围";
                }
                else
                {
                    labelFx.Text = "F(x) = " + Caculate2D(x, 0).ToString("#0.000");
                }
            }
            else
            {
                labelx_2D.Text = "X: ";
                labely_2D.Text = "Y: ";
                labelFx.Text = "F(x) = ";
            }
        }

        private void Button_color_3D_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDia = new ColorDialog())
            {
                if (colorDia.ShowDialog() == DialogResult.OK)
                {
                    pen_3D.Color = colorDia.Color;
                }
            }
        }

        private void Button_clean_3D_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox_3D.Width, pictureBox_3D.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                pictureBox_3D.Image = bitmap;
            }
        }

        private void Button_save_3D_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.FileName = "picture3D";
                save.Filter = "(.jpg)|*.jpg";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_3D.Image.Save(save.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("保存成功");
                }
            }
        }

        private void Button_draw_3D_Click(object sender, EventArgs e)
        {
            string exp = textBox_exp_3D.Text;
            try
            {
                Function.Function func = new Function.Function(exp);
                Caculate3D = func.GetValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (MaxX_3D <= MinX_3D || MaxY_3D <= MinY_3D)
            {
                MessageBox.Show("数值输入不合法。");
                return;
            }
            Bitmap bitmap = new Bitmap(pictureBox_3D.Width, pictureBox_3D.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                painter3D = new Painter3D(pictureBox_3D, g, pen_3D, Caculate3D, MinX_3D, MaxX_3D, MinY_3D, MaxY_3D, rate);
                try
                {
                    painter3D.Draw();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                pictureBox_3D.Image = bitmap;
            }
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            rate = 11 - trackBar.Value;
        }
    }
}
