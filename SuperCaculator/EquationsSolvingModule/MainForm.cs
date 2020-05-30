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
        public int maxIterativeTime = 100; // 最大迭代次数
        public double precision = 0.001;  // 精度
        public double[] startValue;  // 初值矩阵
        public double[] endValue;  // 计算结果
        public NonlinearEquations equations = new NonlinearEquations();  // 非线性方程组
        public NewtonMethod newton;  // 牛顿迭代式
        public NonlinearEquation[] newEquations;
        public double[,] coefficient; // = new double[2, 2] { { 1, 1 }, { 2, 2 } };
        public int[,] power; // = new int[2, 2] { { 2, 2 }, { 2, 2 } };
        public double[] constant; // = new double[] { 1, 2 };
        public string warning;

        public double monoprecision = 10e-6;  // 精度
        public double xInit; // 初始值
        public double[] monoCoefficient=new double[] { }; // 一元高次方程的系数集
        public int[] monoPower=new int[] { };  // 一元高次方程的系数集
        public double resultValue;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboUnoNum.Text == string.Empty)
            {
                txtResults.Text += "错误！未选择未知数的个数！\r\n-------END-------\r\n";
                return;
            }

            unknowNum = Int32.Parse(cboUnoNum.Text);
            if (unknowNum == 1)
            {
                MonoHighPowerForm f0 = new MonoHighPowerForm();
                f0.Owner = this;
                f0.ShowDialog();
                if (f0.IsCancelled1 == true)
                {
                    txtResults.Text += "已取消！\r\n-------END-------\r\n";
                    return;
                }

                warning = f0.warning1;
                if (warning != "")
                {
                    txtResults.Text += warning;
                    txtResults.Text += "-------END-------\r\n";
                    return;
                }

                xInit = f0.xInit1;
                monoCoefficient = f0.monoCoefficient1;
                monoPower = f0.monoPower1;
                MonoHighPowEqua monoEqua = new MonoHighPowEqua(precision, xInit, monoCoefficient, monoPower);
                txtResults.Text += "正在迭代求解方程：\r\n";
                txtResults.Text += monoEqua.MonoEquaToString();
                txtResults.Text += "\r\n";

                try
                {
                    resultValue = monoEqua.Solve();
                    txtResults.Text += "迭代结果为：\r\nX = ";
                    txtResults.Text += resultValue.ToString();
                    txtResults.Text += "\r\n-------END-------\r\n";
                }
                catch
                {
                    txtResults.Text += "迭代失败！未知错误！\r\n-------END-------\r\n";
                    return;
                }

            }
            else
            {
                startValue = new double[unknowNum];
                for (int i = 0; i < unknowNum; i++)
                    startValue[i] = 1;

                DataInputForm f2 = new DataInputForm();
                f2.Owner = this;
                f2.ShowDialog();
                if (f2.IsCancelled == true)
                {
                    txtResults.Text += "已取消！\r\n-------END-------\r\n";
                    return;
                }

                warning = f2.warning1;
                if (warning != "")
                {
                    txtResults.Text += warning;
                    txtResults.Text += "-------END-------\r\n";
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
                            newEquations[i]._Coefficient[j] = coefficient[i, j];
                            newEquations[i]._Power[j] = power[i, j];
                        }
                        newEquations[i]._Constant = constant[i];
                    }
                    equations.Clear();
                    equations.AddEquations(newEquations);

                    // 调用牛顿迭代法
                    if (unknowNum > 0 || equationNum > 0 || maxIterativeTime > 0 || precision > 0)
                    {
                        newton = new NewtonMethod(equations, unknowNum, equationNum, maxIterativeTime, precision, startValue);
                        int CalculateResult = newton.NewtonValue();
                        endValue = newton.EndValue;

                        txtResults.Text += "正在求解方程组：\r\n";
                        for (int i = 0; i < equationNum; i++)
                            txtResults.Text += equations[i].EquationToString() + "\r\n";

                        string mesg = "";
                        // 将结果显示在屏幕上
                        switch (CalculateResult)
                        {
                            case 0:
                                mesg = "线性方程组求解失败！线性方程组无解。\r\n-------END-------\r\n";
                                break;
                            case 1:
                                mesg = "线性方程组求解成功！有且仅有一组解。\r\n";
                                break;
                            case 2:
                                mesg = "线性方程组求解失败！有无穷多解。\r\n-------END-------\r\n";
                                break;
                            case 3:
                                mesg = "非线性方程组求解失败！\r\n-------END-------\r\n";
                                break;
                            case 4:
                                mesg = "非线性方程组求解成功！\r\n";
                                break;
                            case 5:
                                mesg = "达到最大迭代次数！\r\n";
                                break;
                        }
                        txtResults.Text += mesg;

                        if (CalculateResult == 1 || CalculateResult == 4 || CalculateResult == 5)
                        {
                            txtResults.Text += "求解结果：\r\n";
                            for (int i = 1; i < unknowNum + 1; i++)
                            {
                                string x = "X" + i.ToString() + "=" + endValue[i - 1].ToString() + "\r\n";
                                txtResults.Text += x;
                            }
                            txtResults.Text += "-------END-------\r\n";
                        }
                    }
                    else
                    {
                        txtResults.Text += "求解失败！参数不全！\r\n-------END-------\r\n";
                        return;
                    }

                }
                catch (Exception)
                {
                    txtResults.Text += "求解失败！未知错误！\r\n-------END-------\r\n";
                    return;
                }
            }

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
