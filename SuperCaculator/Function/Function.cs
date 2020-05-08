using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Function
    {
        protected Stack<double> figures;
        protected Stack<string> operators;

        protected List<string> RPNExpression; //后缀表达式
        public string Signature { set; get; } //函数签名

        public virtual double GetValue(double x) { return 0; }  //计算函数值
        public Function(string exp, string sign)
        {
            Signature = sign;
        }

    }
    class Sin_function : Function
    {

        public Sin_function(string exp, string sign) : base(exp, sign) { }
        public override double GetValue(double x)
        {

        }
    }
}
