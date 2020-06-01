using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DerivIntegForm
{ 
    class Integral
    {
        private double precision;
        private double interval;
        private string funcExp;
        private List<Task<double>> taskList;
        public Integral(double pre = 0.001)
        {
            taskList = new List<Task<double>>();
            precision = pre;
        }
        //梯形逼近法计算函数积分
        public double IntegCal(double up, double down, string exp, int concurr_num = 50000)
        {
            taskList.Clear();
            double sign = 1;
            if (up < down)
            {
                double temp = up;
                up = down;
                down = temp;
                sign = -1;
            }
            double result = 0;
            funcExp = exp;
            Function.Function function = new Function.Function(exp);
            result += function.GetValue(up);
            result += function.GetValue(down);

            if (concurr_num >= (int)((up - down) / precision))
            {
                for (double x = down + precision; x < up; x += precision)
                {
                    double temp = x;
                    Task<double> task = Task.Run(() => ThreadCalSingle(temp));
                    taskList.Add(task);
                }
            }
            else
            {
                interval = (up - down) / (2 * concurr_num);
                double x = down + interval;
                for (; x < up; x += interval)
                {
                    double temp = x;
                    Task<double> task = Task.Run(() => ThreadCalMutiple(temp));
                    taskList.Add(task);
                }
                double sum = 0;
                for (x = (x - interval + precision); x < up; x += precision)
                {
                    sum += 2 * function.GetValue(x);
                }
                result += sum;
            }

            Task.WaitAll(taskList.ToArray());
            foreach(Task<double> t in taskList)
            {
                result += t.Result;
            }
            return sign * result * precision / 2;
        }

        private double ThreadCalSingle(double x)
        {
            Function.Function function = new Function.Function(funcExp);
            double temp = 2 * function.GetValue(x);
            return temp;
        }

        private double ThreadCalMutiple(double x)
        {
            Function.Function function = new Function.Function(funcExp);
            double temp = 0;
            for (double t = 0; t < interval; t += precision)
            {
                temp += 2 * function.GetValue(x - t);
            }
            return temp;
        }
    }
}
