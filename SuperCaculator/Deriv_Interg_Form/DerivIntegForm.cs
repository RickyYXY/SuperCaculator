using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DerivIntegForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cal_button_Click(object sender, EventArgs e)
        {
            if (exp_textBox.Text == "" || up_num_comboBox.Text == "" || down_num_comboBox.Text == "")
            {
                MessageBox.Show("函数输入/积分上限/积分下限不可为空！");
                return;
            }    
            try
            {
                double precision = 0.001 * Math.Pow(10, -pre_trackBar.Value);
                Integral integral = new Integral(precision);
                double result = integral.IntegCal(double.Parse(up_num_comboBox.Text),
                    double.Parse(down_num_comboBox.Text),
                    exp_textBox.Text);
                result_textBox.Text = result.ToString("f10");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            up_num_comboBox.Text = "";
            down_num_comboBox.Text = "";
            exp_textBox.Text = "";
            result_textBox.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
