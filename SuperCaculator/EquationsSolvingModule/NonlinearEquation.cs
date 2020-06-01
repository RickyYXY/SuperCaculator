using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsSolvingModule
{
    public class NonlinearEquation
    {
        public int theUnknowNum; // 未知数的个数
        public double[] theCoefficient; // 未知数的系数
        public int[] thePower; // 未知数的系数(权),次数为0表示常数
        public double theConstant; //常数项

        public NonlinearEquation() // 默认构造函数
        {
            theUnknowNum = 0;
        }

        public NonlinearEquation(int n) // 构造一个带有n个未知数的非线性方程
        {
            theUnknowNum = n;
            theCoefficient = new double[n];
            thePower = new int[n];
        }

        public void InitEquation()  // 默认方程初始化
        {
            for (int i = 0; i < theUnknowNum; i++)
            {
                theCoefficient[i] = 0;
                thePower[i] = 1;
            }
            theConstant = 0;
        }

        public string EquationToString()  // 把方程转化成字符串输出
        {
            if (theUnknowNum <= 0) return null;
            string strEquation = "";

            bool IsCoefficientAllZero = true;
            for (int i = 0; i < theUnknowNum; i++) // 判断是否系数全零
            {
                if (!IsDoubleZero(theCoefficient[i])) { IsCoefficientAllZero = false; break; }
            }
            if (IsCoefficientAllZero)
            {
                // 系数全为0
                strEquation += "0";
            }
            else
            {
                bool IsFirst = true; // 是否为第一个系数
                for (int i = 0; i < theUnknowNum; i++)
                {
                    if (theCoefficient[i] < 0)
                    {
                        if (i > 0 && !IsFirst)
                            strEquation += " + ";
                        // 系数小于0,系数加括号
                        strEquation += "(";
                        strEquation += theCoefficient[i].ToString();
                        strEquation += ")*X";
                        strEquation += (i + 1).ToString(); // 第(i+1)个未知数
                        if (thePower[i] > 1)
                        {
                            strEquation += "^";
                            strEquation += thePower[i].ToString();
                        }
                        if (IsFirst) IsFirst = false; // 此后系数并非第一个
                    }
                    else if (theCoefficient[i] > 0)
                    {
                        if (i > 0 && !IsFirst)
                            strEquation += " + ";
                        // 系数大于0,系数不加括号
                        strEquation += theCoefficient[i].ToString();
                        strEquation += "*X";
                        strEquation += (i + 1).ToString();
                        if (thePower[i] > 1)
                        {
                            strEquation += "^";
                            strEquation += thePower[i].ToString();
                        }
                        if (IsFirst) IsFirst = false;
                    }
                    // 系数等于0,忽略,不作输出
                }
            }
            // 写方程右侧
            strEquation += " = ";
            strEquation += theConstant.ToString();
            return strEquation;
        }

        public double EquationValue(double[] x) // 设置方程未知数的值
        {
            double y = 0;
            for (int i = 0; i < theUnknowNum; i++)
            {
                double result = 0;
                if (theCoefficient[i] != 0)
                {
                    result = 1;
                    for (int j = 0; j < thePower[i]; j++)
                    {
                        // 次数
                        result *= x[i];
                    }
                    result *= theCoefficient[i]; // 系数
                }
                y += result;
            }
            y -= theConstant; // 常数项移项
            return y;
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
