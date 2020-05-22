using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivIntergForm
{
    class Deriviation
    {
        private Function.Function function;
        private double precision;
        public Deriviation(double pre)
        {
            precision = pre;
        }
        public double DeriviCal(double x,string exp)
        {
            function = new Function.Function(exp);
            double up = function.GetValue(x + precision);
            double down = function.GetValue(x - precision);
            return (up - down) / (2 * precision);
        }

    }
}
