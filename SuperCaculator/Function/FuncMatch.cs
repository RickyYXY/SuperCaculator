using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class FuncMatch
    {
        public static string[] func_names = { "sin", "cos", "tan", "exp", "log" ,"ln"};
        public static double MatchFuncCal(string input,double x)
        {
            foreach (string s in func_names)
            {
                if (input.IndexOf(s) == 0)
                {
                    string exp = input.Substring(s.Length + 1, input.Length - s.Length - 2);
                    switch (s)
                    {
                        case "sin":
                            Sin_function sin_Function = new Sin_function(exp);
                            return sin_Function.GetValue(x);
                        case "cos":
                            Cos_function cos_Function = new Cos_function(exp);
                            return cos_Function.GetValue(x);
                        case "ln":
                            Ln_function ln_Function = new Ln_function(exp);
                            return ln_Function.GetValue(x);
                        case "log":
                            int j = 0;
                            string temp = input.Substring(s.Length);
                            while (j < temp.Length && (temp[j] <= '9' && temp[j] >= '0' || temp[j] == '.'))
                                j++;
                            double newbase = double.Parse(temp.Substring(0, j));
                            exp = temp.Substring(j + 1, temp.Length - j - 2);
                            Log_function log_Function = new Log_function(exp, newbase);
                            return log_Function.GetValue(x);
                    }
                }
            }
            throw new FunctionException("使用了非库函数!", 3);
        }
    }
}
