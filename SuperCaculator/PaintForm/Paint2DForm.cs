﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForm
{
    public partial class Paint2DForm : Form
    {
        private Pen mypen;
        private Pen pen_coordinate;
        private Pen pen_coor;
        Font font = new Font("Ink Free", 15f);
        public delegate double CaculateHandler(double x, double y = 0);
        public event CaculateHandler Caculate;

        private const double limit = 1024;
        int XLENGTH, YLENGTH;
        int Xstart, Ystart;
        double dx, dy;
        double minX, maxX;
        double maxValue, minValue;
        bool ShowXY = false;

        public Paint2DForm(string exp)
        {
            InitializeComponent();
            label_func.Text += exp;
            mypen = new Pen(Color.Black);
            pen_coordinate = new Pen(Color.Black);
            pen_coor = new Pen(Color.Gray);
            float[] dashValues = { 5, 2 };
            pen_coor.DashPattern = dashValues;
            //Caculate = x => x * x;
            //Caculate = x => Math.Log(x);
            //Caculate = x => x * x * x;
        }

        private void Button_color_Click(object sender, EventArgs e)
        {
            using(ColorDialog colorDia = new ColorDialog())
            {
                if (colorDia.ShowDialog() == DialogResult.OK)
                {
                    mypen.Color = colorDia.Color;
                }
            }
        }

        private void Button_draw_Click(object sender, EventArgs e)
        {
            try
            {
                minX = double.Parse(textBox_min.Text);
                maxX = double.Parse(textBox_max.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (maxX <= minX)
            {
                MessageBox.Show("数值输入不合法。");
                return;
            }
            DrawFunction();
        }

        private void Button_clean_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);
            ShowXY = false;
            labelx.Text = "X: ";
            labely.Text = "Y: ";
        }

        private void Button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (ShowXY)
            {
                double x = e.Location.X;
                double y = e.Location.Y;
                x = (x - Xstart) * dx + minX;
                y = (Ystart - y) * dy + minValue;
                labelx.Text = "X: " + x.ToString("#0.000");
                labely.Text = "Y: " + y.ToString("#0.000");
            }
            else
            {
                labelx.Text = "X: ";
                labely.Text = "Y: ";
            }
        }

        private void DrawFunction()
        {
            XLENGTH = (int)(pictureBox.Width * 0.65);
            YLENGTH = (int)(pictureBox.Height * 0.65);
            Xstart = (int)(pictureBox.Width * 0.15);
            Ystart = (int)(pictureBox.Height * 0.85);
            dx = (maxX - minX) / XLENGTH;
            List<double> values = new List<double>();
            double pre_result = Caculate(minX);
            for (int i = 0; i < XLENGTH; i++)
            {
                double result = Caculate(minX + dx * i);
                if (double.IsNaN(result))
                {
                    MessageBox.Show("数值无意义。");
                    return;
                }
                values.Add(result);
            }
            maxValue = values.Max();
            minValue = values.Min();
            bool is_inf = false;
            if (double.IsInfinity(maxValue) || double.IsInfinity(minValue))
            {
                is_inf = true;
                maxValue = maxValue > limit ? limit : maxValue;
                minValue = minValue < (-limit) ? (-limit) : minValue;
            }
            dy = (maxValue - minValue) / YLENGTH;
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
                Point point = new Point(Xstart + i, Ystart - (int)((values[i] - minValue) / dy));
                points.Add(point);
            }
            if (points.Count > 0)
            {
                lines.Add(points);
            }
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(Color.White);
            g.DrawLine(pen_coordinate, Xstart, Ystart, Xstart, Ystart - (int)(YLENGTH * 1.2));
            g.DrawLine(pen_coordinate, Xstart, Ystart, Xstart + (int)(XLENGTH * 1.2), Ystart);
            g.DrawLine(pen_coordinate, Xstart, Ystart, Xstart + (int)(XLENGTH * 1.2), Ystart);
            foreach (List<Point> pts in lines)
            {
                g.DrawCurve(mypen, pts.ToArray());
            }
            DrawCoor();
            Point p = points.Last();
            g.DrawLine(pen_coor, p.X, p.Y, p.X, Ystart);
            g.DrawLine(pen_coor, p.X, p.Y, Xstart, p.Y);
            //StringFormat sf = new StringFormat();
            //sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            //g.DrawString(NumToString(values.Last()), font, Brushes.Black, Xstart, p.Y, sf);
            ShowXY = true;
        }

        private void DrawCoor()
        {
            Graphics g = pictureBox.CreateGraphics();
            Brush brush = Brushes.Black;
            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            g.DrawString("x", font, brush, Xstart + (int)(XLENGTH * 1.2), Ystart);
            g.DrawString("y", font, brush, Xstart, Ystart - (int)(YLENGTH * 1.2), sf);
            if (maxValue >= 0 && minValue < 0)
            {
                int zero = Ystart + (int)(minValue / dy);
                g.DrawLine(pen_coor, Xstart, zero, Xstart + (int)(XLENGTH * 1.2), zero);
                g.DrawString("0", font, brush, Xstart, zero, sf);
            }
            string sx, sy;
            sx = NumToString(minX);
            sy = NumToString(minValue);
            g.DrawString("(" + sy + " ," + sx + ")", font, brush, Xstart, Ystart, sf);
            g.DrawString(maxX.ToString("#0.0"), font, brush, Xstart + XLENGTH, Ystart);

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
