using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationsSolvingModule
{
    public class NewtonMethod
    {
        private NonlinearEquations theEquations; // 非线性方程组
        private NonlinearEquation[,] theJacobiEquations; // 雅克比方程(theEquationNum行,theUnknowNum列)
        private int theUnknowNum;   // 未知数的个数
        private int theEquationNum;   // 方程的个数
        private int theMaxIterativeTime; // 最大迭代次数
        private double thePrecision;  // 精度
        private double[] theStartValue;  // 初值矩阵
        private double[] theEndValue; // 计算结果

        public double[] EndValue
        {
            get { return theEndValue; }
        }

        public NewtonMethod() // 默认构造函数
        {
        }

        // 通过非线性方程组构造牛顿迭代
        public NewtonMethod(NonlinearEquations e, int uNum, int eNum, int mItera, double preci, double[] sVal)
        {
            theUnknowNum = uNum;
            theEquationNum = eNum;
            theMaxIterativeTime = mItera;
            thePrecision = preci;
            theStartValue = new double[uNum];
            for (int i = 0; i < uNum; i++)
            {
                theStartValue[i] = sVal[i];
            }

            // 构造非线性方程组
            theEquations = new NonlinearEquations();
            theEquations.Clear();
            for (int i = 0; i < eNum; i++)
            {
                theEquations.AddEquation(e[i]);
            }

            // 构造雅各比方程组
            theJacobiEquations = new NonlinearEquation[theEquationNum, theUnknowNum];
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    theJacobiEquations[i, j] = new NonlinearEquation(theUnknowNum);
                    theJacobiEquations[i, j] = PartialDifferential(theEquations[i], j);
                }
            }

            theEndValue = new double[uNum];
        }

        // 非线性方程e对未知数n求偏微分,未知数n从0开始计数
        private NonlinearEquation PartialDifferential(NonlinearEquation e, int n) 
        {
            NonlinearEquation result = new NonlinearEquation(e.theUnknowNum);
            for (int i = 0; i < e.theUnknowNum; i++)
            {
                if (i != n)
                {
                    result.theCoefficient[i] = 0;
                    result.thePower[i] = 0;
                }
            }

            if (e.thePower[n] > 1)
            {
                result.thePower[n] = e.thePower[n] - 1; // 降次
                result.theCoefficient[n] = e.theCoefficient[n] * e.thePower[n]; // 系数乘以次数
                result.theConstant = 0; // 常数项归零
            }
            else
            {
                //降次后变成常数项
                result.thePower[n] = 1; // 次数归1
                result.theCoefficient[n] = 0; // 系数归0
                result.theConstant = -e.theCoefficient[n]; // 移项
            }
            return result;
        }

        private double[,] JacobiMatrix(double[] x) // 根据初值矩阵构造雅克比矩阵
        {
            double[,] JacobiM = new double[theEquationNum, theUnknowNum];
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    JacobiM[i, j] = theJacobiEquations[i, j].EquationValue(x);
                }
            }
            return JacobiM;
        }

        private double[,] CoefficientMatrix(NonlinearEquations e) // 返回方程组e的系数矩阵
        {
            double[,] c = new double[theEquationNum, theUnknowNum];
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    c[i, j] = e[i].theCoefficient[j];
                }
            }
            return c;
        }

        private double[,] CoefficientMatrix(NonlinearEquation[] e) // 返回方程组e的系数矩阵
        {
            double[,] c = new double[theEquationNum, theUnknowNum];
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    c[i, j] = e[i].theCoefficient[j];
                }
            }
            return c;
        }

        private double[] ConstantMatrix(NonlinearEquations e) // 返回方程组e的常数项矩阵
        {
            double[] y = new double[theEquationNum];
            for (int i = 0; i < theEquationNum; i++)
            {
                y[i] = e[i].theConstant;
            }
            return y;
        }

        private double[] ConstantMatrix(NonlinearEquation[] e) // 返回方程组e的常数项矩阵
        {
            double[] y = new double[theEquationNum];
            for (int i = 0; i < theEquationNum; i++)
            {
                y[i] = e[i].theConstant;
            }
            return y;
        }

        private double[,] AugmentationMatrix(NonlinearEquations e) // 返回方程组e的增广矩阵
        {
            double[,] a = new double[theEquationNum, theUnknowNum + 1];
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    a[i, j] = e[i].theCoefficient[j];
                }
                a[i, theUnknowNum] = e[i].theConstant;
            }
            return a;
        }

        private double[,] AugmentationMatrix(NonlinearEquation[] e) // 返回方程组e的增广矩阵
        {
            double[,] a = new double[theEquationNum, theUnknowNum + 1];
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    a[i, j] = e[i].theCoefficient[j];
                }
                a[i, theUnknowNum] = e[i].theConstant;
            }
            return a;
        }

        private bool IsDoubleZero(double v) // 判断一个浮点数是否等于0
        {
            if (v < 0.0001 && v > -0.0001)
            {
                return true;
            }
            return false;
        }

        private bool IsEquationsLinear() // 判断方程组是否为线性
        {
            for (int i = 0; i < theEquationNum; i++)
            {
                for (int j = 0; j < theUnknowNum; j++)
                {
                    if (theEquations[i].thePower[j] >= 2) { return false; }
                }
            }
            return true;
        }

        // 根据系数矩阵c和常数项y求解线性方程组,返回线性方程组解的个数:0无解,1唯一解,2无穷解
        private int LinearEquations(double[,] c, double[] y, ref double[] x)
        { 
            // 行_EquationNum
            // 列_UnknowNum
            x = new double[theUnknowNum];
            int ResultForm = 1;

            #region 奇次线性方程组
            bool ZeroY = true;
            for (int i = 0; i < theEquationNum; i++)
            {
                if (!IsDoubleZero(y[i])) { ZeroY = false; break; }
            }
            #endregion

            #region 交换列主
            for (int i = 0; i < theUnknowNum; i++)
            {
                for (int j = i + 1; j < theEquationNum; j++)
                {
                    double MainValue = Math.Abs(c[i, i]); //列主的绝对值大小
                    int MainLine = i; //列主的行号
                    if (MainValue < Math.Abs(c[j, i]))
                    {
                        MainLine = j;
                        MainValue = Math.Abs(c[j, i]);
                        double temp;
                        for (int k = 0; k < theUnknowNum; k++)
                        {
                            temp = c[i, k]; c[i, k] = c[MainLine, k]; c[MainLine, k] = temp;
                        }
                        temp = y[i]; y[i] = y[MainLine]; y[MainLine] = temp;
                    }
                }
            }
            #endregion

            #region 消元
            for (int i = 0; i < theUnknowNum; i++)
            {
                if (!IsDoubleZero(c[i, i]))
                {
                    for (int j = i + 1; j < theEquationNum; j++)
                    {
                        double ratio = c[j, i] / c[i, i];
                        for (int k = 0; k < i + 1; k++)
                        {
                            c[j, k] = 0;
                        }
                        for (int k = i + 1; k < theUnknowNum; k++)
                        {
                            c[j, k] = c[j, k] - ratio * c[i, k];
                        }
                        y[j] = y[j] - ratio * y[i];
                    }
                }
            }
            #endregion

            #region 判断解的性质
            int FirstZeroColumn = 0; // 第一次系数全为0的行号
            for (int i = 0; i < theEquationNum; i++)
            {
                bool IsColumnZero = true;
                for (int j = 0; j < theUnknowNum; j++)
                {
                    // 这一行的元素全部为0
                    if (!IsDoubleZero(c[i, j])) { IsColumnZero = false; break; }
                }
                if (IsColumnZero) { break; }
                FirstZeroColumn++;
            }
            if (FirstZeroColumn < theEquationNum)
            {
                // 有系数全为0的行
                if (!IsDoubleZero(y[FirstZeroColumn])) { return 0; } //无解
                double CoefficientMatrixRank = FirstZeroColumn; //系数矩阵的秩
                if (CoefficientMatrixRank == theUnknowNum) { ResultForm = 1; } // 唯一解
                else if (CoefficientMatrixRank < theUnknowNum) { ResultForm = 2; } // 无穷解
                else { ResultForm = 2; }
            }
            else { ResultForm = 1; }
            #endregion

            #region 回代
            if (!ZeroY)
            {
                //回代
                for (int i = 0; i < theUnknowNum; i++)
                {
                    for (int j = theUnknowNum - 1; j >= 0; j--)
                    {
                        double Value = y[j];
                        for (int k = j + 1; k < theUnknowNum; k++)
                        {
                            Value = Value - c[j, k] * x[k];
                        }
                        x[j] = Value / c[j, j];
                    }
                }
            }
            else
            {
                // 齐次线性方程组,有一组零解
                for (int i = 0; i < theUnknowNum; i++) { x[i] = 0; }
            }
            #endregion

            return ResultForm;
        }

        // 使用牛顿迭代法求非线性方程组
        // 返回"0":线性方程组无解; 返回"1":线性方程组有唯一解; 返回"2":线性方程组有无穷解
        // 返回"3":非线性方程组求解失败; 返回"4":非线性方程组求解成功; 返回"5":非线性方程组达到最大迭代次数
        public int NewtonValue()
        {
            if (IsEquationsLinear())
            {
                //是线性方程组
                double[,] c = new double[theEquationNum, theUnknowNum];
                double[] y = new double[theEquationNum];
                c = CoefficientMatrix(theEquations);
                y = ConstantMatrix(theEquations);
                return LinearEquations(c, y, ref theEndValue);
            }
            else
            {
                //非线性方程组,牛顿迭代法
                bool IsCirculate = false;
                int IterativeTime = 0;
                double[] x = new double[theUnknowNum];
                for (int j = 0; j < theUnknowNum; j++) { x[j] = theStartValue[j]; }
                do
                {
                    IsCirculate = false;
                    double[,] c = JacobiMatrix(x);
                    double[] y = new double[theEquationNum];
                    for (int j = 0; j < theEquationNum; j++) { y[j] = -theEquations[j].EquationValue(x); }
                    double[] detx = new double[theUnknowNum];
                    if (LinearEquations(c, y, ref detx) == 0) return 3;
                    for (int j = 0; j < theUnknowNum; j++) { x[j] += detx[j]; }
                    // 当差值小于初值时则迭代终止
                    for (int j = 0; j < theUnknowNum; j++)
                    {
                        if (Math.Abs(detx[j]) >= thePrecision)
                        {
                            IsCirculate = true;
                            break;
                        }
                    }
                    IterativeTime++;
                    if (IterativeTime >= theMaxIterativeTime) { break; } // 达到最大迭代次数
                } while (IsCirculate);
                for (int j = 0; j < theUnknowNum; j++) { theEndValue[j] = x[j]; }
                if (!IsCirculate) { return 4; }
                if (IterativeTime >= theMaxIterativeTime) { return 5; }
                return 3;
            }
        }
    }
}
