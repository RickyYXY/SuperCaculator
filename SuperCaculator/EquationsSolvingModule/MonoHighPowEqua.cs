using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsSolvingModule
{
    public class MonoHighPowEqua
    {
        public double precision;
        public double xInit;
        public double[] coefficient;
        public int[] power;

        public MonoHighPowEqua() { }

        public MonoHighPowEqua(double prec, double init, double[] coe, int[] pow)
        {
            this.precision = prec;
            this.xInit = init;
            this.coefficient = coe;
            this.power = pow;
        }
        public double GenerateEqua(double x)  // 将x带入方程左侧求值
        {
            double sum = 0.0;

            for (int i = 0; i < coefficient.Length - 1; ++i)
            {
                if (power[i] < 0)
                    continue;
                sum += coefficient[i] * Math.Pow(x, power[i]);
            }

            sum += coefficient[coefficient.Length - 1];
            return sum;
        }

        public double GenerateDeriv(double x) // 求导数
        {
            double sum = 0.0;

            for (int i = 0; i < coefficient.Length - 1; ++i)
            {
                if (power[i] <= 0)
                    continue;
                sum += coefficient[i] * power[i] * Math.Pow(x, power[i] - 1);
            }

            return sum;
        }

        public double Solve()  // 迭代求解
        {
            double x0 = xInit;
            double xn;

            while (true)
            {
                xn = x0 - GenerateEqua(x0) / GenerateDeriv(x0);
                if (Math.Abs(xn - x0) < precision)
                    return xn;
                x0 = xn;
            }
        }

        public string MonoEquaToString()  // 将方程打印出来
        {
            string strEquation = "";

            bool IsCoefficientAllZero = true;
            for (int i = 0; i < coefficient.Length; i++) // 判断是否系数全零
            {
                if (!IsDoubleZero(coefficient[i])) { IsCoefficientAllZero = false; break; }
            }
            if (IsCoefficientAllZero)
            {
                // 系数全为0
                strEquation += "0";
            }
            else
            {
                bool IsFirst = true; // 是否为第一个系数
                for (int i = 0; i < coefficient.Length-1; i++)
                {
                    if (coefficient[i] < 0)
                    {
                        if (i > 0 && !IsFirst)
                            strEquation += " + ";
                        // 系数小于0,系数加括号
                        strEquation += "(";
                        strEquation += coefficient[i].ToString();
                        strEquation += ")*X";
                        if (power[i] > 1)
                        {
                            strEquation += "^";
                            strEquation += power[i].ToString();
                        }
                        if (IsFirst) IsFirst = false; // 此后系数并非第一个
                    }
                    else if (coefficient[i] > 0)
                    {
                        if (i > 0 && !IsFirst)
                            strEquation += " + ";
                        // 系数大于0,系数不加括号
                        strEquation += coefficient[i].ToString();
                        strEquation += "*X";
                        if (power[i] > 1)
                        {
                            strEquation += "^";
                            strEquation += power[i].ToString();
                        }
                        if (IsFirst) IsFirst = false;
                    }
                    // 系数等于0,忽略,不作输出
                }
                if (coefficient[coefficient.Length-1] < 0)
                {
                    strEquation += "+";
                    strEquation += "(";
                    strEquation += coefficient[coefficient.Length-1].ToString();
                    strEquation += ")";
                }
                else if(coefficient[coefficient.Length-1] > 0){
                    strEquation += "+";
                    strEquation += coefficient[coefficient.Length-1].ToString();
                }
            }

            strEquation += " = 0";
            return strEquation;
        }

        private bool IsDoubleZero(double v) // 判断一个浮点数是否等于0
        {
            if (v < 0.0001 && v > -0.0001)
            {
                return true;
            }
            return false;
        }
    }
}
