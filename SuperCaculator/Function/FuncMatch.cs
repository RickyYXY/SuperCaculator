using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class FuncMatch
    {
        public static readonly string[] func_names = 
            { "sin", "cos", "tan", "exp", "log" ,"ln","csc","sec","cot","abs","ceil","floor"};
        
        public static double MatchFuncCal(string input, double? x,double? y)
        {
            foreach (string s in func_names)
            {
                string func_name = s;
                if (func_name != "log")
                    func_name += "("; //log函数后面接非(的数字，其余函数均接(，由此区分tan(与tanh(
                if (input.IndexOf(func_name) == 0)
                {
                    if (func_name.Last() == '(')
                        func_name = func_name.Substring(0, func_name.Length - 1);
                    string exp = input.Substring(func_name.Length + 1, input.Length - func_name.Length - 2);
                    switch (func_name)
                    {
                        case "sin":
                            Sin_function sin_Function = new Sin_function(exp);
                            return sin_Function.GetValue(x,y);
                        case "cos":
                            Cos_function cos_Function = new Cos_function(exp);
                            return cos_Function.GetValue(x,y);
                        case "tan":
                            Tan_function tan_Function = new Tan_function(exp);
                            return tan_Function.GetValue(x,y);
                        case "exp":
                            Exp_function exp_Function = new Exp_function(exp);
                            return exp_Function.GetValue(x,y);
                        case "ln":
                            Ln_function ln_Function = new Ln_function(exp);
                            return ln_Function.GetValue(x,y);
                        case "log":
                            int j = 0;
                            string temp = input.Substring(func_name.Length);
                            while (j < temp.Length && (temp[j] <= '9' && temp[j] >= '0' || temp[j] == '.'))
                                j++;
                            double newbase = double.Parse(temp.Substring(0, j));
                            exp = temp.Substring(j + 1, temp.Length - j - 2);
                            Log_function log_Function = new Log_function(exp, newbase);
                            return log_Function.GetValue(x,y);
                        case "csc":
                            Csc_function csc_Function = new Csc_function(exp);
                            return csc_Function.GetValue(x, y);
                        case "sec":
                            Sec_function sec_Function = new Sec_function(exp);
                            return sec_Function.GetValue(x, y);
                        case "cot":
                            Cot_function cot_Function = new Cot_function(exp);
                            return cot_Function.GetValue(x, y);
                        case "abs":
                            Abs_function abs_Function = new Abs_function(exp);
                            return abs_Function.GetValue(x, y);
                        case "ceil":
                            Ceil_function ceil_Function = new Ceil_function(exp);
                            return ceil_Function.GetValue(x, y);
                        case "floor":
                            Floor_function floor_Function = new Floor_function(exp);
                            return floor_Function.GetValue(x, y);
                    }
                }
            }
            throw new FunctionException("使用了非库函数!", 3);
        }
    }
}
