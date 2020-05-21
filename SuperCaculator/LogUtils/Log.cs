using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtils
{
    public class Log
    {
        public double Context { set; get; }
        public Log(double x)
        {
            Context = x;
        }
    }
}
