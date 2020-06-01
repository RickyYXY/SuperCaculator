using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationsSolvingModule
{
    public partial class DataInputForm : Form
    {
        public int unknowNum1;  // 未知数的个数
        public int equationNum1; // 方程的个数
        public double[,] coefficient1; // = new double[2, 2] { { 1, 1 }, { 2, 2 } };
        public int[,] power1; // = new int[2, 2] { { 2, 2 }, { 2, 2 } };
        public double[] constant1; // = new double[] { 1, 2 };
        public string warning1;
        public bool isCancelled = false;

        public DataInputForm()
        {
            InitializeComponent();
        }

        private void DataInputForm_Load(object sender, EventArgs e)
        {
            MainForm f1 = (MainForm)this.Owner;
            unknowNum1 = f1.unknowNum;
            warning1 = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboEquNum.SelectedIndex == -1)
            {
                warning1 = "错误！未选择方程个数！\r\n";
                this.Close();
                return;
            }
            if (txtCoe.Text == string.Empty){
                warning1 = "错误！系数集为空！\r\n";
                this.Close();
                return;
            }
            if (txtPower.Text == string.Empty){
                warning1 = "错误！次数集为空！\r\n";
                this.Close();
                return;
            }

            equationNum1 = Int32.Parse(cboEquNum.Text);
            if (equationNum1 < unknowNum1)
            {
                warning1 = "错误！未知元个数大于方程个数！\r\n";
                this.Close();
                return;
            }
            coefficient1 = new double[equationNum1, unknowNum1];
            power1 = new int[equationNum1, unknowNum1];
            constant1 = new double[equationNum1];

            try
            {
                string[] arrTemp;
                for (int i = 0; i < txtCoe.Lines.Length; i++)
                {
                    arrTemp = txtCoe.Lines[i].Split(',');
                    if (arrTemp.Length < unknowNum1 + 1)
                    {
                        warning1 = "错误！系数集输入有误！\r\n";
                        this.Close();
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < arrTemp.Length - 1; j++)
                            coefficient1[i, j] = Int32.Parse(arrTemp[j]);
                        constant1[i] = Int32.Parse(arrTemp[arrTemp.Length - 1]);

                    }
                }

                for (int i = 0; i < txtPower.Lines.Length; i++)
                {
                    arrTemp = txtPower.Lines[i].Split(',');
                    if (arrTemp.Length < unknowNum1)
                    {
                        warning1 = "错误！次数输入有误！\r\n";
                        this.Close();
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < arrTemp.Length; j++)
                            power1[i, j] = Int32.Parse(arrTemp[j]);
                    }
                }
            }catch(Exception)
            {
                warning1 = "失败！输入格式有误！\r\n";
                this.Close();
                return;
            }
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCancelled = true;
            this.Close();
        }
    }
}
