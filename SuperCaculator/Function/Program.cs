﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            string exp = "sin(sin(x)*x^3)/45";
            string exp2 = "sinh(x)+1";
            string exp3 = "abs(-1)+ceil(0.5)-floor(0.5)";
            Function f = new Function(exp2);
            for (double x = 1; x < 100; x += 1)
            {
                Console.WriteLine("x={2},test:{0},true:{1}", f.GetValue(x), Test_cal1(x, x), x);
            }
        }
        public static double Test_cal1(double x,double y)
        {
            return Math.Sin(Math.Sin(x)*Math.Pow(y,3))/45;
        }
        public static double Test_cal2(double x)
        {
            return Math.Sin(x) * Math.Pow(x, 3);
        }
    }
}
