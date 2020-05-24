using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivIntergForm
{
    class Deriviation
    {
        private double precision;
        public Deriviation(double pre)
        {
            precision = pre;
        }
        public double DerivCal(double x,string exp)
        {
            Function.Function function = new Function.Function(exp);
            double up = function.GetValue(x + precision);
            double down = function.GetValue(x - precision);
            return (up - down) / (2 * precision);
        }

    }
}
