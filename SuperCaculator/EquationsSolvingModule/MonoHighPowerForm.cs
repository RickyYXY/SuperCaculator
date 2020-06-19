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
    public partial class MonoHighPowerForm : Form
    {
        public double xInit1; // 初始值
        public double[] monoCoefficient1; // 一元高次方程的系数集
        public int[] monoPower1;  // 一元高次方程的系数集
        public int itemNum; // 项的个数
        public string warning1;
        public bool isCancelled1 = false;

        public MonoHighPowerForm()
        {
            InitializeComponent();
        }

        private void MonoHighPowerForm_Load(object sender, EventArgs e)
        {
            MainForm f1 = (MainForm)this.Owner;
            warning1 = "";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtCoe.Text == string.Empty)
            {
                warning1 = "错误！系数集为空！\r\n";
                this.Close();
                return;
            }
            if (txtPower.Text == string.Empty)
            {
                warning1 = "错误！次数集为空！\r\n";
                this.Close();
                return;
            }
            if (txtInit.Text == string.Empty)
            {
                warning1 = "错误！初始值为空！\r\n";
                this.Close();
                return;
            }

            try
            {
                string[] arrTempC = new string[] { };
                for (int i = 0; i < txtCoe.Lines.Length; i++)
                    arrTempC = txtCoe.Lines[i].Split(',');

                itemNum = arrTempC.Length;
                monoCoefficient1 = new double[itemNum];
                for (int i = 0; i < itemNum; i++)
                    monoCoefficient1[i] = Double.Parse(arrTempC[i]);

                string[] arrTempP = new string[] { };
                for (int i = 0; i < txtPower.Lines.Length; i++)
                    arrTempP = txtPower.Lines[i].Split(',');

                monoPower1 = new int[arrTempP.Length];
                for (int i = 0; i < arrTempP.Length; i++)
                    monoPower1[i] = int.Parse(arrTempP[i]);

                xInit1 = Double.Parse(txtInit.Text);
            }
            catch (Exception)
            {
                warning1 = "失败！输入格式有误！\r\n";
                this.Close();
                return;
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isCancelled1 = true;
            this.Close();
        }
    }
}
