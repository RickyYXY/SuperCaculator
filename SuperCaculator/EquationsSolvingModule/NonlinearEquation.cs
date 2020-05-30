using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsSolvingModule
{
    public class NonlinearEquation
    {
        public int _UnknowNum; // 未知数的个数
        public double[] _Coefficient; // 未知数的系数
        public int[] _Power; // 未知数的系数(权),次数为0表示常数
        public double _Constant; //常数项

        public NonlinearEquation() // 默认构造函数
        {
            _UnknowNum = 0;
        }

        public NonlinearEquation(int n) // 构造一个带有n个未知数的非线性方程
        {
            _UnknowNum = n;
            _Coefficient = new double[n];
            _Power = new int[n];
        }

        public void InitEquation()  // 默认方程初始化
        {
            for (int i = 0; i < _UnknowNum; i++)
            {
                _Coefficient[i] = 0;
                _Power[i] = 1;
            }
            _Constant = 0;
        }

        public string EquationToString()  // 把方程转化成字符串输出
        {
            if (_UnknowNum <= 0) return null;
            string strEquation = "";

            bool IsCoefficientAllZero = true;
            for (int i = 0; i < _UnknowNum; i++) // 判断是否系数全零
            {
                if (!IsDoubleZero(_Coefficient[i])) { IsCoefficientAllZero = false; break; }
            }
            if (IsCoefficientAllZero)
            {
                // 系数全为0
                strEquation += "0";
            }
            else
            {
                bool IsFirst = true; // 是否为第一个系数
                for (int i = 0; i < _UnknowNum; i++)
                {
                    if (_Coefficient[i] < 0)
                    {
                        if (i > 0 && !IsFirst)
                            strEquation += " + ";
                        // 系数小于0,系数加括号
                        strEquation += "(";
                        strEquation += _Coefficient[i].ToString();
                        strEquation += ")*X";
                        strEquation += (i + 1).ToString(); // 第(i+1)个未知数
                        if (_Power[i] > 1)
                        {
                            strEquation += "^";
                            strEquation += _Power[i].ToString();
                        }
                        if (IsFirst) IsFirst = false; // 此后系数并非第一个
                    }
                    else if (_Coefficient[i] > 0)
                    {
                        if (i > 0 && !IsFirst)
                            strEquation += " + ";
                        // 系数大于0,系数不加括号
                        strEquation += _Coefficient[i].ToString();
                        strEquation += "*X";
                        strEquation += (i + 1).ToString();
                        if (_Power[i] > 1)
                        {
                            strEquation += "^";
                            strEquation += _Power[i].ToString();
                        }
                        if (IsFirst) IsFirst = false;
                    }
                    // 系数等于0,忽略,不作输出
                }
            }
            // 写方程右侧
            strEquation += " = ";
            strEquation += _Constant.ToString();
            return strEquation;
        }

        public double EquationValue(double[] x) // 设置方程未知数的值,验证解的正确性
        {
            double y = 0;
            for (int i = 0; i < _UnknowNum; i++)
            {
                double result = 0;
                if (_Coefficient[i] != 0)
                {
                    result = 1;
                    for (int j = 0; j < _Power[i]; j++)
                    {
                        // 次数
                        result *= x[i];
                    }
                    result *= _Coefficient[i]; // 系数
                }
                y += result;
            }
            y -= _Constant; // 常数项移项
            return y; // 为0则解正确
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
