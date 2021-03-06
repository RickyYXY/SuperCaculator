﻿using System;
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

        private readonly int XLENGTH, YLENGTH, XSTART, YSTART;
        double dx, dy;
        double minX, maxX, maxY, minY;
        const int limit = 100;

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
            //XLENGTH = (int)(pb.Width * 0.65);
            //YLENGTH = (int)(pb.Height * 0.65);
            XLENGTH = (int)(pb.Width * 0.75);
            YLENGTH = (int)(pb.Height * 0.75);
            //XSTART = (int)(pb.Width * 0.15);
            //YSTART = (int)(pb.Height * 0.85);
            XSTART = (int)(pb.Width * 0.15);
            YSTART = (int)(pb.Height * 0.9);
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
            //if (double.IsInfinity(maxY) || double.IsInfinity(minY))
            if (double.IsInfinity(maxY) || double.IsInfinity(minY)/* || maxY - minY > limit * 2*/)
            {
                is_inf = true;
                maxY = maxY > limit ? limit : maxY;
                minY = minY < (-limit) ? (-limit) : minY;
            }
            dy = maxY == minY ? 1 : (maxY - minY) / YLENGTH;

            List<List<Point>> lines = new List<List<Point>>();
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
            Font font1 = new Font("Cambria", 15f);
            Font font = new Font("Cambria", 20f);
            Brush brush = Brushes.Black;
            Pen pen_coor = new Pen(Color.Gray);
            //Pen blackpen = new Pen(brush);
            float[] dashValues = { 5, 2 };
            pen_coor.DashPattern = dashValues;
            StringFormat sf = new StringFormat
            {
                FormatFlags = StringFormatFlags.DirectionRightToLeft
            };
            //DrawPoint(XSTART, YSTART); 
            //DrawPoint(XSTART + XLENGTH, YSTART);
            //g.DrawLine(blackpen, XSTART, YSTART, XSTART, YSTART - (int)(YLENGTH * 1.2));
            //g.DrawLine(blackpen, XSTART - (int)(XLENGTH * 0.05), YSTART, XSTART + (int)(XLENGTH * 1.2), YSTART);
            g.DrawLine(pen_coor, XSTART, YSTART, XSTART + XLENGTH, YSTART);
            g.DrawLine(pen_coor, XSTART, YSTART, XSTART, YSTART - (int)((Caculate(minX, 0) - minY) / dy));
            g.DrawLine(pen_coor, XSTART + XLENGTH, YSTART, XSTART + XLENGTH, YSTART - (int)((Caculate(maxX, 0) - minY) / dy));
            g.DrawLine(pen_coor, XSTART + XLENGTH, YSTART, XSTART + XLENGTH, YSTART - YLENGTH);
            g.DrawLine(pen_coor, XSTART, YSTART, XSTART, YSTART - YLENGTH);
            g.DrawLine(pen_coor, XSTART, YSTART - YLENGTH, XSTART + XLENGTH, YSTART - YLENGTH);
            //g.DrawLine(blackpen, XSTART, YSTART, XSTART + (int)(XLENGTH * 1.2), YSTART);
            //g.DrawString("F(x)=" + minY.ToString("#0.00"), font, brush, XSTART + (int)(XLENGTH * 1.1), YSTART);
            string info = "x: " + minX.ToString("#0.0") + " ~ " + maxX.ToString("#0.0");
            g.DrawString(info, font, brush, XSTART + XLENGTH / 2 - info.Length * 7, YSTART);
            g.DrawString("(F(x", font, brush, XSTART, YSTART - YLENGTH / 2, sf);
            g.DrawString("min: " + minY.ToString("#0.00"), font1, brush, XSTART, YSTART, sf);
            g.DrawString("max: " + maxY.ToString("#0.00"), font1, brush, XSTART, YSTART - YLENGTH, sf);
            if (maxY >= 0 && minY < 0)
            {
                int zero = YSTART + (int)(minY / dy);
                //g.DrawLine(pen_coor, XSTART - (int)(XLENGTH * 0.05), zero, XSTART + (int)(XLENGTH * 1.2), zero);
                g.DrawLine(pen_coor, XSTART, zero, XSTART + XLENGTH, zero);
                g.DrawString("F(x) = 0", font1, brush, XSTART + XLENGTH, zero/*, sf*/);
                DrawPoint(Xstart + XLENGTH, zero);
            }
            //string sx, sy;
            //sx = NumToString(minX);
            //sy = NumToString(minY);
            //g.DrawString("(" + sy + " ," + sx + ")", font, brush, XSTART, YSTART, sf);
            //g.DrawString("Ymin: " + sy, font, brush, XSTART, YSTART, sf);
            //g.DrawString(minX.ToString("#0.00"), font, brush, XSTART, YSTART);
            //g.DrawString(maxX.ToString("#0.00"), font, brush, XSTART + XLENGTH, YSTART);
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

        private void DrawPoint(int X, int Y)
        {
            Point[] points = new Point[4];
            points[0].X = X;
            points[0].Y = Y - 2;
            points[1].X = X + 2;
            points[1].Y = Y;
            points[2].X = X;
            points[2].Y = Y + 2;
            points[3].X = X - 2;
            points[3].Y = Y;
            g.DrawPolygon(Pens.Black, points);
        }
    }
}
