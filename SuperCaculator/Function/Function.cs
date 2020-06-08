using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Function
    {
        //protected Stack<double> figures; //计算使用栈
        protected List<string> RPNExpression; //后缀表达式

        public Function(string exp)
        {
            RPNExpression = new List<string>();
            //figures = new Stack<double>();
            try
            {
                BuildRPN(exp);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new FunctionException("数学符号式输入非法,请检查格式是否正确!", 4);
            }
            catch (InvalidOperationException)
            {
                throw new FunctionException("输入算式形式非法,请检查!", 5);
            }
        }

        public virtual double GetValue(double? x = null, double? y = null)//计算二元函数值
        {
            Stack<double> figures = new Stack<double>();
            foreach (string unit in RPNExpression)
            {
                if (unit == "x")
                    if (x == null)
                        throw new FunctionException("计算不支持x作为自变量！", 7);
                    else
                        figures.Push(x.Value);
                else if (unit == "y")
                    if (y == null)
                        throw new FunctionException("计算不支持y作为自变量！", 8);
                    else
                        figures.Push(y.Value);
                else if (unit == "e")
                    figures.Push(Math.E);
                else if (unit == "pi")
                    figures.Push(Math.PI);
                else if (double.TryParse(unit, out double result))
                    figures.Push(result);
                else if (unit == "+" || unit == "-" || unit == "*"
                    || unit == "/" || unit == "^" || unit == "!")
                {
                    double n1, n2;
                    switch (unit)
                    {
                        case "+":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n2 + n1);
                            break;
                        case "-":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n2 - n1);
                            break;
                        case "*":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n2 * n1);
                            break;
                        case "/":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n2 / n1);
                            break;
                        case "^":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(Math.Pow(n2, n1));
                            break;
                        case "!":
                            n1 = figures.Pop(); //0弹出
                            n2 = figures.Pop();
                            figures.Push(Factorial(n2));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    double func_result = FuncMatch.MatchFuncCal(unit, x, y);
                    figures.Push(func_result);
                }
            }
            double ans = figures.Pop();
            return ans;
        }

        private void BuildRPN(string exp) //生成后缀表达式
        {
            Stack<string> st = new Stack<string>();

            for (int i = 0; i < exp.Length; i++)
            {
                string temp = exp[i].ToString();
                if (temp == "!")
                {
                    if (st.Count == 0)
                    {
                        RPNExpression.Add("0");//将x!转化为x!0
                        st.Push(temp);
                        continue;
                    }
                    while (st.Count != 0 && st.Peek() == "!")
                        RPNExpression.Add(st.Pop());
                    RPNExpression.Add("0");//将x!转化为x!0
                    st.Push(temp);
                }
                else if (temp == "^")
                {
                    if (st.Count == 0)
                    {
                        st.Push(temp);
                        continue;
                    }
                    while (st.Count != 0 && (st.Peek() == "^" || st.Peek() == "!"))
                        RPNExpression.Add(st.Pop());
                    st.Push(temp);
                }
                else if (temp == "*" || temp == "/")
                {
                    if (st.Count == 0)
                    {
                        st.Push(temp);
                        continue;
                    }
                    while (st.Count != 0 && (st.Peek() == "!" || st.Peek() == "^" ||
                        st.Peek() == "*" || st.Peek() == "/"))
                        RPNExpression.Add(st.Pop());
                    st.Push(temp);
                }
                else if (temp == "+" || temp == "-")
                {
                    if (temp == "-" && (i == 0 || exp[i - 1] == '('))
                        RPNExpression.Add("0"); //将-x转化为0-x
                    if (st.Count == 0)
                    {
                        st.Push(temp);
                        continue;
                    }
                    while (st.Count != 0 && st.Peek() != "(")
                        RPNExpression.Add(st.Pop());
                    st.Push(temp);
                }
                else if (temp == "(")
                    st.Push(temp);
                else if (temp == ")")
                {
                    while (st.Peek() != "(")
                        RPNExpression.Add(st.Pop());
                    st.Pop();
                }
                else if (temp == "x" || temp == "y")
                    RPNExpression.Add(temp);
                else if (exp[i] <= '9' && exp[i] >= '0')
                {
                    int j = i;
                    while (j < exp.Length && (exp[j] <= '9' && exp[j] >= '0' || exp[j] == '.'))
                        j++;
                    temp = exp.Substring(i, j - i);
                    RPNExpression.Add(temp);
                    i = j - 1;
                }
                else if (temp == "e" && (i == exp.Length - 1 || exp[i + 1] != 'x')) //添加常数e
                    RPNExpression.Add(temp);
                else if (temp == "p" && i < exp.Length - 1 && exp[i + 1] == 'i') //添加常数pi
                {
                    RPNExpression.Add("pi");
                    i++;
                }    
                else
                {
                    bool flag2 = false;
                    foreach (string reg in FuncMatch.func_names)
                    {
                        int ind = exp.IndexOf(reg, i); //确认exp中含有reg函数
                        if (ind == i)
                        {
                            int j;
                            if (reg == "log") //log后面的底数长度未知，需要单独判断
                            {
                                if (exp[i + reg.Length] > '9' || exp[i + reg.Length] < '1')
                                    throw new FunctionException("log函数后必须含有合法数字底数值!", 1);
                                j = i;
                                while (exp[j] != '(')
                                    j++;
                            }
                            else //其余函数正常处理
                                j = i + reg.Length;
                            //j对应： e.g. sin()中(后一位的下标号
                            if (exp[j] != '(')
                                throw new FunctionException("函数后必须含有括弧!", 2);
                            int bnum = 0;  //左右括弧对称数
                            for (; j < exp.Length; j++)
                            {
                                if (exp[j] == '(')
                                    bnum++;
                                else if (exp[j] == ')')
                                    bnum--;
                                else
                                    continue;
                                if (bnum < 0)
                                    throw new FunctionException("括弧输入非法!", 3);
                                else if (bnum == 0)
                                    break;
                            }
                            if (bnum == 0)
                            {
                                temp = exp.Substring(i, j - i + 1);
                                RPNExpression.Add(temp);
                                i = j;
                                flag2 = true;
                            }
                            else
                                throw new FunctionException("括弧输入非法!", 3);
                            break;
                        }
                    }
                    if (!flag2)
                        throw new FunctionException("使用了非库函数!", 3);
                }
            }
            while (st.Count > 0)
                RPNExpression.Add(st.Pop());
        }

        static public double Factorial(double x)
        {
            double result = 1;
            while (x > 0)
                result *= x--;
            return result;
        }
    }

    class Sin_function : Function
    {

        public Sin_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return Math.Sin(base.GetValue(x, y));
        }

    }

    class Cos_function : Function
    {
        public Cos_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return Math.Cos(base.GetValue(x, y));
        }
    }

    class Tan_function : Function
    {
        public Tan_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return Math.Tan(base.GetValue(x, y));
        }
    }

    class Ln_function : Function
    {
        public Ln_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return Math.Log(base.GetValue(x, y), Math.E);
        }
    }

    class Exp_function : Function
    {
        public Exp_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return Math.Exp(base.GetValue(x, y));
        }
    }

    class Log_function : Function
    {
        private double log_base;
        public Log_function(string exp, double newbase) : base(exp)
        {
            log_base = newbase;
        }
        public override double GetValue(double? x, double? y)
        {
            return Math.Log(base.GetValue(x, y), log_base);
        }
    }
    class Csc_function : Function
    {
        public Csc_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return 1 / Math.Sin(base.GetValue(x, y));
        }
    }

    class Sec_function : Function
    {
        public Sec_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return 1 / Math.Cos(base.GetValue(x, y));
        }
    }
    class Cot_function : Function
    {
        public Cot_function(string exp) : base(exp) { }
        public override double GetValue(double? x, double? y)
        {
            return 1 / Math.Tan(base.GetValue(x, y));
        }
    }

    class FunctionException : Exception
    {
        public int Code { set; get; }
        public FunctionException(string message, int code) : base(message)
        {
            Code = code;
        }
    }
}
