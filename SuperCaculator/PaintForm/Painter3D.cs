using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForm
{
    class Painter3D
    {
        private Graphics g;
        private Pen pen;
        Func<double?, double?, double> Caculate;

        double minX, maxX, minY, maxY, minZ, maxZ;
        readonly int rate;
        int XLENGTH, YLENGTH, ZLENGTH, Xstart, Ystart;

        const double sqrt2 = 1.4142135623730950488016887242;

        public Painter3D(PictureBox pb, Graphics g, Pen pen, Func<double?, double?, double> Caculate,
            double minX, double maxX, double minY, double maxY, int rate)
        {
            //g = pb.CreateGraphics();
            this.g = g;
            this.pen = pen;
            this.Caculate = Caculate;
            this.minX = minX;
            this.maxX = maxX;
            this.minY = minY;
            this.maxY = maxY;
            this.rate = rate;
            XLENGTH = (int)(pb.Width * 0.5);
            ZLENGTH = (int)(pb.Height * 0.5);
            YLENGTH = XLENGTH < ZLENGTH ? XLENGTH : ZLENGTH;
            if (XLENGTH > ZLENGTH)
            {
                XLENGTH = (int)(pb.Width * 0.8 - YLENGTH / sqrt2);
            }
            else
            {
                ZLENGTH = (int)(pb.Height * 0.8 - YLENGTH / sqrt2);
            }
            Xstart = (int)(pb.Width * 0.1);
            Ystart = (int)(pb.Height * 0.9);
        }

        public void Draw()
        {
            //double[,] values;
            //try
            //{
            //    values = GetValues();
            //}
            //catch(Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //    return;
            //}
            double[,] values = GetValues();
            DrawBox();
            DrawCoor();
            double dz = (maxZ - minZ) / ZLENGTH;
            int XL = (int)((XLENGTH - 1) / rate) + 1;
            if (dz == 0)
            {
                for (int i = 0; i < XL; i++)
                {
                    g.DrawLine(pen, Xstart + rate * i, Ystart - ZLENGTH / 2, Xstart + rate * i + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH / 2 - (int)(YLENGTH / sqrt2));
                }
                g.DrawLine(pen, Xstart, Ystart - ZLENGTH / 2, Xstart + XLENGTH, Ystart - ZLENGTH / 2);
                g.DrawLine(pen, Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH / 2 - (int)(YLENGTH / sqrt2), Xstart + (int)(YLENGTH / sqrt2) + XLENGTH, Ystart - ZLENGTH / 2 - (int)(YLENGTH / sqrt2));
                return;
            }
            int[,] x = new int[XL, YLENGTH];
            int[,] y = new int[XL, YLENGTH];
            for (int i = 0; i < XL; i++)
            {
                for (int j = 0; j < YLENGTH; j++)
                {
                    Transform(i, j, (int)((values[i, j] - minZ) / dz), out x[i, j], out y[i, j]);
                }
            }
            List<Point> firsts, lasts;
            firsts = new List<Point>();
            lasts = new List<Point>();
            for (int i = 0; i < XL; i++)
            {
                List<Point> points = new List<Point>();
                for (int j = 0; j < YLENGTH; j++)
                {
                    int y0 = Ystart - y[i, j];
                    if (y0 > ZLENGTH * 2 || y0 < 0)
                    {
                        continue;
                    }
                    points.Add(new Point(Xstart + x[i, j], y0));
                }
                if (points.Count > 1)
                {
                    g.DrawCurve(pen, points.ToArray());
                    firsts.Add(points.First());
                    lasts.Add(points.Last());
                }
            }
            if (firsts.Count > 1)
            {
                g.DrawCurve(pen, firsts.ToArray());
            }
            if (lasts.Count > 1)
            {
                g.DrawCurve(pen, lasts.ToArray());
            }
        }

        private double[,] GetValues()
        {
            int XL = (int)((XLENGTH - 1) / rate) + 1;
            double[,] values = new double[XL, YLENGTH];
            double dx = (maxX - minX) / XLENGTH * rate;
            double dy = (maxY - minY) / YLENGTH;
            maxZ = Caculate(minX, minY);
            minZ = maxZ;
            for (int i = 0; i < XL; i++)
            {
                double tempx = minX + dx * i;
                for (int j = 0; j < YLENGTH; j++)
                {
                    double result = Caculate(tempx, minY + dy * j);
                    if (double.IsNaN(result)||double.IsInfinity(result)||double.IsNegativeInfinity(result))
                    {
                        throw new Exception("数值无意义。");
                    }
                    values[i, j] = result;
                    if (maxZ < values[i, j])
                    {
                        maxZ = values[i, j];
                    }
                    if (minZ > values[i, j])
                    {
                        minZ = values[i, j];
                    }
                }
            }
            return values;
        }

        private void DrawBox()
        {
            Pen pen_box = new Pen(Color.Gray);
            float[] dashValues = { 5, 2 };
            pen_box.DashPattern = dashValues;
            g.Clear(Color.White);
            g.DrawLine(pen_box, Xstart, Ystart, Xstart, Ystart - ZLENGTH);
            g.DrawLine(pen_box, Xstart, Ystart, Xstart + XLENGTH, Ystart);
            g.DrawLine(pen_box, Xstart, Ystart, Xstart + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart, Ystart - ZLENGTH,
                Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2),
                Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart + XLENGTH, Ystart, Xstart + XLENGTH, Ystart - ZLENGTH);
            g.DrawLine(pen_box, Xstart, Ystart - ZLENGTH, Xstart + XLENGTH, Ystart - ZLENGTH);
            g.DrawLine(pen_box, Xstart + XLENGTH, Ystart,
                Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2),
                Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - (int)(YLENGTH / sqrt2),
                Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart + XLENGTH, Ystart - ZLENGTH,
                Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));
            g.DrawLine(pen_box, Xstart + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2),
                Xstart + XLENGTH + (int)(YLENGTH / sqrt2), Ystart - ZLENGTH - (int)(YLENGTH / sqrt2));

        }

        private void DrawCoor()
        {
            Brush brush = Brushes.Black;
            StringFormat sf = new StringFormat();
            Font font = new Font("方正舒体", 20f);
            Font font1 = new Font("方正舒体", 15f);
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            string info = "x: " + minX.ToString("#0.0") + " ~ " + maxX.ToString("#0.0");
            g.DrawString(info, font, brush, Xstart + XLENGTH / 2 - info.Length * 7, Ystart);
            g.DrawString("y: " + minY.ToString("#0.0") + " ~ " + maxY.ToString("#0.0"), font, brush,
                Xstart + XLENGTH + (int)(YLENGTH / sqrt2 / 2), Ystart - (int)(YLENGTH / sqrt2 / 2));
            //g.DrawString("z", font, brush, Xstart, Ystart - ZLENGTH / 2, sf);
            if(minZ == maxZ)
            {
                g.DrawString("F(x, y) = "+ NumToString(minZ), font1, brush, Xstart, Ystart - ZLENGTH / 2, sf);
                return;
            }
            g.DrawString("min: " + minZ.ToString("#0.00"), font1, brush, Xstart, Ystart, sf);
            g.DrawString("max: " + maxZ.ToString("#0.00"), font1, brush, Xstart, Ystart - ZLENGTH, sf);
            g.DrawString("(F(x, y", font, brush, Xstart, Ystart - ZLENGTH / 2, sf);
        }

        private void Transform(int x, int y, int z, out int cx, out int cy)
        {
            cx = (int)(x * rate + y / sqrt2);
            cy = z + (int)(y / sqrt2);
        }

        private string NumToString(double num)
        {
            string str;
            if (num < 0)
            {
                str = (-num).ToString("#0.0");
                str += "-";
            }
            else
            {
                str = num.ToString("#0.0");
            }
            return str;
        }
    }
}
