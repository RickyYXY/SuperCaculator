using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationsSolvingModule
{
    public partial class MainForm : Form
    {
        public int unknowNum;  // 未知数的个数
        public int equationNum; // 方程的个数
        public int maxIterativeTime = 10^5; // 最大迭代次数
        public double precision = 10e-6;  // 精度
        public double[] startValue;  // 初值矩阵
        public double[] endValue;  // 计算结果
        public NonlinearEquations equations = new NonlinearEquations();  // 非线性方程组
        public NewtonMethod newton;  // 牛顿迭代式
        public NonlinearEquation[] newEquations;
        public double[,] coefficient; // 方程组系数矩阵
        public int[,] power; // 方程组次数矩阵
        public double[] constant; // 常数项

        public double monoprecision = 10e-6;  // 精度
        public double xInit; // 初始值
        public double[] monoCoefficient=new double[] { }; // 一元高次方程的系数集
        public int[] monoPower=new int[] { };  // 一元高次方程的系数集
        public double resultValue;
        public MonoHighPowEqua monoEqua;

        public string warning; // 提示信息

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            txtPrint.Text = "";
            txtResult.Text = "";
            txtWarn.Text = "";

            if (cboUnoNum.Text == string.Empty)
            {
                txtWarn.Text = "错误！未选择未知数的个数！";
                return;
            }

            unknowNum = Int32.Parse(cboUnoNum.Text);
            if (unknowNum == 1)
            {
                MonoHighPowerForm f0 = new MonoHighPowerForm();
                f0.Owner = this;
                f0.ShowDialog();
                if (f0.isCancelled1 == true)
                {
                    txtWarn.Text = "已取消！";
                    return;
                }

                warning = f0.warning1;
                if (warning != "")
                {
                    txtWarn.Text = warning;
                    return;
                }

                xInit = f0.xInit1;
                monoCoefficient = f0.monoCoefficient1;
                monoPower = f0.monoPower1;
                monoEqua = new MonoHighPowEqua(precision, xInit, monoCoefficient, monoPower);
                txtPrint.Text = monoEqua.MonoEquaToString();

            }
            else
            {
                startValue = new double[unknowNum];
                for (int i = 0; i < unknowNum; i++)
                    startValue[i] = 1;

                DataInputForm f2 = new DataInputForm();
                f2.Owner = this;
                f2.ShowDialog();
                if (f2.isCancelled == true)
                {
                    txtWarn.Text = "已取消！";
                    return;
                }

                warning = f2.warning1;
                if (warning != "")
                {
                    txtWarn.Text = warning;
                    return;
                }

                equationNum = f2.equationNum1;
                coefficient = new double[equationNum, unknowNum];
                coefficient = f2.coefficient1;
                power = new int[equationNum, unknowNum];
                power = f2.power1;
                constant = new double[equationNum];
                constant = f2.constant1;
                newEquations = new NonlinearEquation[equationNum];

                try
                {
                    for (int i = 0; i < equationNum; i++)
                    {
                        newEquations[i] = new NonlinearEquation(unknowNum);
                        for (int j = 0; j < unknowNum; j++)
                        {
                            newEquations[i].theCoefficient[j] = coefficient[i, j];
                            newEquations[i].thePower[j] = power[i, j];
                        }
                        newEquations[i].theConstant = constant[i];
                    }
                    equations.Clear();
                    equations.AddEquations(newEquations);

                    // 构造牛顿迭代法
                    newton = new NewtonMethod(equations, unknowNum, equationNum, maxIterativeTime, precision, startValue);
                    // 将方程组打印出来
                    for (int i = 0; i < equationNum; i++)
                        txtPrint.Text += equations[i].EquationToString() + "\r\n";
                }
                catch (Exception)
                {
                    txtWarn.Text = "警告！未知错误！";
                    return;
                }
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            if (unknowNum == 1)
            {
                try
                {
                    resultValue = monoEqua.Solve();
                    txtWarn.Text = "求解成功！";
                    txtResult.Text = "X = " + resultValue.ToString();
                }
                catch(Exception)
                {
                    txtWarn.Text = "求解失败！未知错误！";
                    return;
                }
            }
            else
            {
                try
                {
                    int CalculateResult = newton.NewtonValue();
                    endValue = newton.EndValue;

                    string mesg = "";
                    // 将结果显示在屏幕上
                    switch (CalculateResult)
                    {
                        case 0:
                            mesg = "线性方程组求解失败！线性方程组无解。";
                            break;
                        case 1:
                            mesg = "线性方程组求解成功！有且仅有一组解。";
                            break;
                        case 2:
                            mesg = "线性方程组求解失败！有无穷多解。";
                            break;
                        case 3:
                            mesg = "非线性方程组求解失败！";
                            break;
                        case 4:
                            mesg = "非线性方程组求解成功！";
                            break;
                        case 5:
                            mesg = "达到最大迭代次数！";
                            break;
                    }
                    txtWarn.Text = mesg;

                    if (CalculateResult == 1 || CalculateResult == 4 || CalculateResult == 5)
                    {
                        // txtPrint.Text += "求解结果：\r\n";
                        for (int i = 1; i < unknowNum + 1; i++)
                        {
                            string x = "X" + i.ToString() + "=" + endValue[i - 1].ToString() + "\r\n";
                            txtResult.Text += x;
                        }
                        //txtPrint.Text += "-------END-------\r\n";
                    }
                }
                catch(Exception)
                {
                    txtWarn.Text = "求解失败！未知错误！";
                    return;
                }
                
            }
        }
    }
}
