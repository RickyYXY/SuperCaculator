using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    public class Function
    {
        protected Stack<double> figures;
        //protected Stack<string> operators;

        protected List<string> RPNExpression; //后缀表达式
        //public string Signature { set; get; } //函数签名

        public virtual double GetValue(double x)//计算函数值
        {
            foreach (string unit in RPNExpression)
            {

                if (unit == "x")
                    figures.Push(x);
                else if (double.TryParse(unit, out double result))
                    figures.Push(result);
                else if (unit == "+" || unit == "-" || unit == "*" || unit == "/" || unit == "^")
                {
                    double n1, n2;
                    switch (unit)
                    {
                        case "+":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n1 + n2);
                            break;
                        case "-":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n2 - n1);
                            break;
                        case "*":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n1 * n2);
                            break;
                        case "/":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(n1 / n2);
                            break;
                        case "^":
                            n1 = figures.Pop();
                            n2 = figures.Pop();
                            figures.Push(Math.Pow(n1, n2));
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    double func_result = FuncMatch.MatchFuncCal(unit, x);
                    figures.Push(func_result);
                }
            }
            double ans = figures.Pop();
            figures.Clear();
            return ans;
        }

        public void BuildRPN(string exp) //生成后缀表达式
        {
            Stack<string> st = new Stack<string>();
            //st.Push("");
            for (int i = 0; i < exp.Length; i++)
            {
                string temp = exp[i].ToString();
                if (temp == "^")
                {
                    if (st.Count == 0)
                    {
                        st.Push(temp);
                        continue;
                    }
                    while (st.Peek() == "^")
                    {
                        RPNExpression.Add(st.Pop());
                    }
                    st.Push(temp);
                }
                else if (temp == "*" || temp == "/")
                {
                    if (st.Count == 0)
                    {
                        st.Push(temp);
                        continue;
                    }
                    while (st.Peek() == "^" || st.Peek() == "*" || st.Peek() == "/")
                    {
                        RPNExpression.Add(st.Pop());
                    }
                    st.Push(temp);
                }
                else if (temp == "+" || temp == "-")
                {
                    if (temp == "-" && (i == 0 || exp[i - 1] == '('))
                    {
                        RPNExpression.Add("0");
                    }
                    if (st.Count == 0)
                    {
                        st.Push(temp);
                        continue;
                    }
                    while (st.Count != 0 && st.Peek() != "(")
                    {
                        RPNExpression.Add(st.Pop());
                    }
                    st.Push(temp);
                }
                else if (temp == "(")
                {
                    st.Push(temp);
                }
                else if (temp == ")")
                {
                    while (st.Peek() != "(")
                    {
                        RPNExpression.Add(st.Pop());
                    }
                    st.Pop();
                }
                else if (temp == "x")
                {
                    
                    RPNExpression.Add(temp);
                }
                else if (exp[i] <= '9' && exp[i] >= '0')
                {
                    int j = i;
                    while (j < exp.Length && (exp[j] <= '9' && exp[j] >= '0' || exp[j] == '.'))
                        j++;
                    temp = exp.Substring(i, j - i);
                    RPNExpression.Add(temp);
                    i = j - 1;
                }
                else
                {
                    //string func_exp; //函数符号，如sin
                    bool flag2 = false;
                    foreach (string reg in FuncMatch.func_names)
                    {
                        int ind = exp.IndexOf(reg, i);
                        if (ind == i)
                        {
                            int j;     //e.g. sin()中(后一位的下标号
                            if (reg == "log")
                            {
                                //func_exp = exp.Substring(i, 4); //log函数后必须指明底数大小,大小为数字
                                j = i + 4;
                                if (exp[i + 1 + reg.Length] > '9' || exp[i + 1 + reg.Length] < '2')
                                    throw new FunctionException("log函数后必须含有数字底数值(>=2)!", 1);
                            }
                            else
                            {
                                //func_exp = exp.Substring(i, reg.Length);
                                j = i + reg.Length;
                            }
                            if (exp[j] != '(')
                                throw new FunctionException("函数后必须含有括弧!", 2);
                            int bnum = 0;//左右括弧数
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

        public Function(string exp)
        {
            RPNExpression = new List<string>();
            figures = new Stack<double>();
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
    }

    class Sin_function : Function
    {

        public Sin_function(string exp) : base(exp) { }
        public override double GetValue(double x)
        {
            return Math.Sin(base.GetValue(x));
        }

    }

    class Cos_function:Function
    {
        public Cos_function(string exp) : base(exp) { }
        public override double GetValue(double x)
        {
            return Math.Cos(base.GetValue(x));
        }
    }

    class Ln_function:Function
    {
        public Ln_function(string exp) : base(exp) { }
        public override double GetValue(double x)
        {
            return Math.Log(base.GetValue(x), Math.E);
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
