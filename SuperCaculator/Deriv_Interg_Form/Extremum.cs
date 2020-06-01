using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivIntergForm
{
    class MinMaxVal
    {
        public double MinVal { get; set; }
        public double MaxVal { get; set; }
    }
    class Extremum
    {
        private double precision;
        private List<Task<MinMaxVal>> taskList;
        private string funcExp;
        private double interval;

        public Extremum(double pre)
        {
            precision = pre;
            taskList = new List<Task<MinMaxVal>>();
        }

        public void ExtremumCal(double up, double down, string exp, 
            out double min, out double max,
            int concurr_num=50000)
        {
            if (up < down)
                throw new Exception("上界不可小于下界！");

            taskList.Clear();
            double maxVal, minVal;
            funcExp = exp;
            Function.Function function = new Function.Function(exp);
            maxVal = function.GetValue(down);
            minVal = function.GetValue(down);
            if (concurr_num  >= (int)((up - down) / precision))
            {
                for (double x = down + precision; x < up; x += precision)
                {
                    double temp = x;
                    Task<MinMaxVal> task = Task.Run(() => ThreadCalSingle(temp));
                    taskList.Add(task);
                }
                minVal = Math.Min(minVal, function.GetValue(up));
                maxVal = Math.Max(maxVal, function.GetValue(up));
            }
            else
            {
                interval = (up - down) / (2 * concurr_num);
                double x = down + interval;
                for (; x < up; x += interval)
                {
                    double temp = x;
                    Task<MinMaxVal> task = Task.Run(() => ThreadCalMutiple(temp));
                    taskList.Add(task);
                }
                for (x = (x - interval + precision); x < up; x += precision)
                {
                    minVal = Math.Min(minVal, function.GetValue(x));
                    maxVal = Math.Max(maxVal, function.GetValue(x));
                }
                minVal = Math.Min(minVal, function.GetValue(up));
                maxVal = Math.Max(maxVal, function.GetValue(up));
            }

            Task.WaitAll(taskList.ToArray());
            foreach (Task<MinMaxVal> t in taskList)
            {
                minVal = Math.Min(minVal, t.Result.MinVal);
                maxVal = Math.Max(maxVal, t.Result.MaxVal);
            }
            min = minVal;
            max = maxVal;
        }

        private MinMaxVal ThreadCalSingle(double x)
        {
            Function.Function function = new Function.Function(funcExp);
            MinMaxVal temp = new MinMaxVal();
            temp.MaxVal = function.GetValue(x);
            temp.MinVal = temp.MaxVal;
            return temp;
        }
        private MinMaxVal ThreadCalMutiple(double x)
        {
            Function.Function function = new Function.Function(funcExp);
            MinMaxVal temp = new MinMaxVal();
            temp.MaxVal = function.GetValue(x);
            temp.MinVal = temp.MaxVal;
            for (double t = precision; t < interval; t += precision)
            {
                double result = function.GetValue(x);
                temp.MaxVal = Math.Max(temp.MaxVal, result);
                temp.MinVal = Math.Min(temp.MinVal, result);
            }
            return temp;
        }
    }
}
