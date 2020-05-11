using System;
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
            string exp = "log10(x)";
            Function f = new Function(exp);
            for(double x=1;x<100;x+=1)
            {
                Console.WriteLine("test:{0},true:{1}",f.GetValue(x),Test_cal(x));
            }
        }
        public static double Test_cal(double x)
        {
            return Math.Log10(x);
        }
    }
}
