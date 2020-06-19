using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForm
{
    public partial class Paint3DForm : Form
    {
        readonly Func<double?, double?, double> Caculate;
        readonly Pen mypen;
        public double minX { get; set; }
        public double maxX { get; set; }
        public double minY { get; set; }
        public double maxY { get; set; }
        //int XLENGTH, YLENGTH, ZLENGTH;
        //int Xstart, Ystart;
        //private const double sqrt2 = 1.4142135623730950488016887242;
        private int rate;

        public Paint3DForm(string exp, Func<double?, double?, double> Caculate)
        {
            InitializeComponent();
            label_func.Text += exp;
            this.Caculate = Caculate;
            mypen = new Pen(Color.Black);
            //pen_coor = new Pen(Color.Gray);
            //float[] dashValues = { 5, 2 };
            //pen_coor.DashPattern = dashValues;
            rate = trackBar.Value + 1;
            //Caculate = (x, y) => x * x * y * y;
            //Caculate = (x, y) => x + y;
            //Caculate = (x, y) => x / y;
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            textBox_minX.DataBindings.Add("Text", this, "minX");
            textBox_maxX.DataBindings.Add("Text", this, "maxX");
            textBox_minY.DataBindings.Add("Text", this, "minY");
            textBox_maxY.DataBindings.Add("Text", this, "maxY");
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            rate = trackBar.Value + 1;
        }

        private void Button_color_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDia = new ColorDialog())
            {
                if (colorDia.ShowDialog() == DialogResult.OK)
                {
                    mypen.Color = colorDia.Color;
                }
            }
        }

        private void Button_clean_Click(object sender, EventArgs e)
        {
            //Graphics g = pictureBox.CreateGraphics();
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            pictureBox.Image = bitmap;
            g.Dispose();
        }


        private void Button_draw_Click(object sender, EventArgs e)
        {
            //double minX, minY, maxX, maxY;
            //try
            //{
            //    minX = double.Parse(textBox_minX.Text);
            //    maxX = double.Parse(textBox_maxX.Text);
            //    minY = double.Parse(textBox_minY.Text);
            //    maxY = double.Parse(textBox_maxY.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
            if (maxX <= minX || maxY <= minY)
            {
                MessageBox.Show("数值输入不合法。");
                return;
            }
            //DrawFunction();
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            Painter3D painter = new Painter3D(pictureBox, g, mypen, Caculate, minX, maxX, minY, maxY, rate);
            try
            {
                painter.Draw();
                pictureBox.Image = bitmap;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                g.Dispose();
            }
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.FileName = "picture3D";
                save.Filter = "(.jpg)|*.jpg";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(save.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("保存成功");
                }
            }
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        //private void DrawFunction()
        //{
        //    XLENGTH = (int)(pictureBox.Width * 0.5);
        //    ZLENGTH = (int)(pictureBox.Height * 0.5);
        //    YLENGTH = XLENGTH < ZLENGTH ? XLENGTH : ZLENGTH;
        //    if (XLENGTH > ZLENGTH)
        //    {
        //        XLENGTH = (int)(pictureBox.Width * 0.8 - YLENGTH / sqrt2);
        //    }
        //    else
        //    {
        //        ZLENGTH = (int)(pictureBox.Height * 0.8 - YLENGTH / sqrt2);
        //    }
        //    Xstart = (int)(pictureBox.Width * 0.1);
        //    Ystart = (int)(pictureBox.Height * 0.9);
        //    int XL = (int)(XLENGTH / rate);
        //    double[,] values = new double[XL, YLENGTH];
        //    double dx = (maxX - minX) / XLENGTH * rate;
        //    double dy = (maxY - minY) / YLENGTH;
        //    double maxZ = Caculate(minX, minY);
        //    double minZ = maxZ;
        //    for (int i = 0; i < XL; i++)
        //    {
        //        double tempx = minX + dx * i;
        //        for (int j = 0; j < YLENGTH; j++)
        //        {
        //            values[i, j] = Caculate(tempx, minY + dy * j);
        //            if (maxZ < values[i, j])
        //            {
        //                maxZ = values[i, j];
        //            }
        //            if (minZ > values[i, j])
        //            {
        //                minZ = values[i, j];
        //            }
        //        }
        //    }
        //    double dz = (maxZ - minZ) / ZLENGTH;
        //    int[,] x = new int[XL, YLENGTH];
        //    int[,] y = new int[XL, YLENGTH];
        //    int[,] z = new int[XL, YLENGTH];
        //    for (int i = 0; i < XL; i++)
        //    {
        //        for (int j = 0; j < YLENGTH; j++)
        //        {
        //            z[i, j] = (int)((values[i, j] - minZ) / dz);
        //            Transform(i, j, z[i, j], out x[i, j], out y[i, j]);
        //        }
        //    }

        //    Graphics g = pictureBox.CreateGraphics();
        //    DrawBox();

        //    Brush brush = Brushes.Black;
        //    StringFormat sf = new StringFormat();
        //    Font font = new Font("Ink Free", 20f);
        //    Font font1 = new Font("Ink Free", 15f);
        //    sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
        //    g.DrawString("x", font, brush, Xstart + XLENGTH / 2, Ystart);
        //    g.DrawString("y", font, brush,
        //        Xstart + XLENGTH + (int)(YLENGTH / sqrt2 / 2), Ystart - (int)(YLENGTH / sqrt2 / 2));
        //    g.DrawString("z", font, brush, Xstart, Ystart - ZLENGTH / 2, sf);
        //    g.DrawString(NumToString(minZ), font1, brush, Xstart, Ystart, sf);
        //    g.DrawString(NumToString(maxZ), font1, brush, Xstart, Ystart - ZLENGTH, sf);

        //    List<Point> firsts, lasts;
        //    firsts = new List<Point>();
        //    lasts = new List<Point>();
        //    for (int i = 0; i < XL; i++)
        //    {
        //        List<Point> points = new List<Point>();
        //        for (int j = 0; j < YLENGTH; j++)
        //        {
        //            int y0 = Ystart - y[i, j];
        //            if (y0 > pictureBox.Height || y0 < 0)
        //            {
        //                continue;
        //            }
        //            points.Add(new Point(Xstart + x[i, j], y0));
        //        }
        //        if (points.Count > 1)
        //        {
        //            g.DrawCurve(mypen, points.ToArray());
        //            firsts.Add(points.First());
        //            lasts.Add(points.Last());
        //        }
        //    }
        //    if (firsts.Count > 1)
        //    {
        //        g.DrawCurve(mypen, firsts.ToArray());
        //    }
        //    if(lasts.Count > 1)
        //    {
        //        g.DrawCurve(mypen, lasts.ToArray());
        //    }
        //}

        //private void DrawBox()
        //{
        //    Graphics g = pictureBox.CreateGraphics();
        //    g.Clear(Color.White);
        //    g.DrawLine(pen_coor, Xstart, Ystart, Xstart, Ystart - ZLENGTH);
        //    g.DrawLine(pen_coor, Xstart, Ystart, Xstart + XLENGTH, Ystart);
        //    g.DrawLine(pen_coor, Xstart, Ystart, Xstart + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart, Ystart - ZLENGTH,
        //        Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2),
        //        Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart + XLENGTH, Ystart, Xstart + XLENGTH, Ystart - ZLENGTH);
        //    g.DrawLine(pen_coor, Xstart, Ystart - ZLENGTH, Xstart + XLENGTH, Ystart - ZLENGTH);
        //    g.DrawLine(pen_coor, Xstart + XLENGTH, Ystart,
        //        Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2),
        //        Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2),
        //        Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart + XLENGTH, Ystart - ZLENGTH,
        //        Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
        //    g.DrawLine(pen_coor, Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2),
        //        Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
        //}

        //private void Transform(int x, int y, int z, out int cx, out int cy)
        //{
        //    cx = (int)(x * rate + y / sqrt2);
        //    cy = z + (int)(y / sqrt2);
        //}

        //private string NumToString(double num)
        //{
        //    string str;
        //    if (num < 0)
        //    {
        //        str = (-num).ToString("#0.0");
        //        str += "-";
        //    }
        //    else
        //    {
        //        str = num.ToString("#0.0");
        //    }
        //    return str;
        //}
    }
}
