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
                            Sin_function sin_func = new Sin_function(exp);
                            return sin_func.GetValue(x);
                        case "cos":
                            Cos_function cos_func = new Cos_function(exp);
                            return cos_func.GetValue(x);
                    }
                }
            }
            throw new FunctionException("使用了非库函数!", 3);
        }
    }
}
