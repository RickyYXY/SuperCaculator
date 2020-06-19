using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogUtils
{
    public class Log
    {
        public string Context
        {
            get { return context.ToString("f20"); }
        }
        private double context;
        public Log(double x)
        {
            context = x;
        }
    }
}
