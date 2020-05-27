using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForm
{
    class Painter2D
    {
        Graphics g;
        Pen pen;
        Func<double?, double?, double> Caculate;

        int XLENGTH, YLENGTH, XSTART, YSTART;
        double dx, dy, minX, maxX, maxY, minY;
        const int limit = 1024;

        public int Xstart { get => XSTART; }
        public int Ystart { get => YSTART; }
        public double MinValue { get => minY; }
        public double Dx { get => dx; }
        public double Dy { get => dy; }

        public Painter2D(PictureBox pb, Graphics g, Pen pen,
            Func<double?, double?, double> Caculate, double minX, double maxX)
        {
            this.g = g;
            this.pen = pen;
            this.Caculate = Caculate;
            this.minX = minX;
            this.maxX = maxX;
            XLENGTH = (int)(pb.Width * 0.65);
            YLENGTH = (int)(pb.Height * 0.65);
            XSTART = (int)(pb.Width * 0.15);
            YSTART = (int)(pb.Height * 0.85);
            dx = (maxX - minX) / XLENGTH;
        }

        public void Draw()
        {
            List<List<Point>> lines = GetPoints();
            g.Clear(Color.White);
            foreach (List<Point> pts in lines)
            {
                g.DrawCurve(pen, pts.ToArray());
            }
            DrawCoor();

        }

        private List<List<Point>> GetPoints()
        {
            List<double> values = new List<double>();
            //double pre_result = Caculate(minX, 0);
            for (int i = 0; i < XLENGTH; i++)
            {
                double result = Caculate(minX + dx * i, 0);
                if (double.IsNaN(result))
                {
                    throw new Exception("数值无意义。");
                }
                values.Add(result);
            }
            maxY = values.Max();
            minY = values.Min();
            bool is_inf = false;
            if (double.IsInfinity(maxY) || double.IsInfinity(minY))
            {
                is_inf = true;
                maxY = maxY > limit ? limit : maxY;
                minY = minY < (-limit) ? (-limit) : minY;
            }
            dy = maxY == minY ? 1 : (maxY - minY) / YLENGTH;

            List <List<Point>> lines = new List<List<Point>>();
            List<Point> points = new List<Point>();
            for (int i = 0; i < XLENGTH; i++)
            {
                if (is_inf && Math.Abs(values[i]) > limit)
                {
                    if (points.Count > 0)
                    {
                        lines.Add(points);
                        points = new List<Point>();
                    }
                    continue;
                }
                Point point = new Point(XSTART + i, YSTART - (int)((values[i] - minY) / dy));
                points.Add(point);
            }
            if (points.Count > 0)
            {
                lines.Add(points);
            }
            return lines;
        }

        private void DrawCoor()
        {
            Font font = new Font("Ink Free", 15f);
            Brush brush = Brushes.Black;
            Pen pen_coor = new Pen(Color.Gray);
            Pen blackpen = new Pen(brush);
            float[] dashValues = { 5, 2 };
            pen_coor.DashPattern = dashValues;
            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            g.DrawLine(blackpen, XSTART, YSTART, XSTART, YSTART - (int)(YLENGTH * 1.2));
            g.DrawLine(blackpen, XSTART, YSTART, XSTART + (int)(XLENGTH * 1.2), YSTART);
            g.DrawLine(blackpen, XSTART, YSTART, XSTART + (int)(XLENGTH * 1.2), YSTART);
            g.DrawString("x", font, brush, XSTART + (int)(XLENGTH * 1.2), YSTART);
            g.DrawString("y", font, brush, XSTART, YSTART - (int)(YLENGTH * 1.2), sf);
            if (maxY >= 0 && minY < 0)
            {
                int zero = YSTART + (int)(minY / dy);
                g.DrawLine(pen_coor, XSTART, zero, XSTART + (int)(XLENGTH * 1.2), zero);
                g.DrawString("0", font, brush, XSTART, zero, sf);
            }
            string sx, sy;
            sx = NumToString(minX);
            sy = NumToString(minY);
            //g.DrawString("(" + sy + " ," + sx + ")", font, brush, XSTART, YSTART, sf);
            g.DrawString("Ymin: " + sy, font, brush, XSTART, YSTART, sf);
            g.DrawString(maxX.ToString("#0.0"), font, brush, XSTART + XLENGTH, YSTART);
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
