using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Deriv_Integ_Form
{
    class Integral
    {
        private double precision;
        private double result;
        private string threadLock;
        private string funcExp;
        public Integral(double pre=0.001)
        {
            precision = pre;
            threadLock = "";
        }
        public double IntegCal(double up,double down, string exp,int concurr_num=1000)
        {
            ThreadPool.SetMaxThreads(concurr_num, 10);
            result = 0;
            funcExp = exp;
            Function.Function function = new Function.Function(exp);
            result += function.GetValue(up);
            result += function.GetValue(down);
            for (double x = down+precision; x < up; x += precision)
            {
                ThreadPool.QueueUserWorkItem(ThreadCal,x);
            }
            while(true)
            {
                ThreadPool.GetAvailableThreads(out int workNum, out int ioNum);
                if (workNum == concurr_num)
                    break;
            }
            return result * precision / 2;
        }
        private void ThreadCal(object input)
        {
            double x = (double)input;
            Function.Function function=new Function.Function(funcExp);
            double temp = 2 * function.GetValue(x);
            lock(threadLock)
            {
                result += temp;
            }
        }
    }
}
