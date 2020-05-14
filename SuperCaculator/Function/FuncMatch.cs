using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class FuncMatch
    {
        public static readonly string[] func_names = { "sin", "cos", "tan", "exp", "log" ,"ln"};
        public static double MatchFuncCal(string input,double x)
        {
            foreach (string s in func_names)
            {
                string func_name = s;
                if (func_name != "log")
                    func_name += "("; //log函数后面接非(的数字，其余函数均接(，由此区分tan(与tanh(
                if (input.IndexOf(func_name) == 0)
                {
                    string exp = input.Substring(func_name.Length + 1, input.Length - func_name.Length - 2);
                    switch (func_name)
                    {
                        case "sin":
                            Sin_function sin_Function = new Sin_function(exp);
                            return sin_Function.GetValue(x);
                        case "cos":
                            Cos_function cos_Function = new Cos_function(exp);
                            return cos_Function.GetValue(x);
                        case "tan":
                            Tan_function tan_Function = new Tan_function(exp);
                            return tan_Function.GetValue(x);
                        case "exp":
                            Exp_function exp_Function = new Exp_function(exp);
                            return exp_Function.GetValue(x);
                        case "ln":
                            Ln_function ln_Function = new Ln_function(exp);
                            return ln_Function.GetValue(x);
                        case "log":
                            int j = 0;
                            string temp = input.Substring(func_name.Length);
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
