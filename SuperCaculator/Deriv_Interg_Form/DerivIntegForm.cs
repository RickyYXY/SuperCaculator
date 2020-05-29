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
using DerivIntergForm;
using LogUtils;

namespace DerivIntegForm
{
    public partial class DIForm : Form
    {
        private Queue<Log> log;
        public DIForm()
        {
            InitializeComponent();
            log = new Queue<Log>();
            input_bindingSource.DataSource = log.ToList();
        }
        public DIForm(Queue<Log>log)
        {
            InitializeComponent();
            this.log = log;
            input_bindingSource.DataSource = log.ToList();
        }

        private void Cal_button_Click(object sender, EventArgs e)
        {
            if (exp_textBox.Text == "" || up_num_comboBox.Text == "" || down_num_comboBox.Text == "")
            {
                MessageBox.Show("函数输入/积分上限/积分下限 不可为空！");
                return;
            }    
            try
            {
                string up = up_num_comboBox.Text, down = down_num_comboBox.Text;
                double precision = 0.001 * Math.Pow(10, -pre_trackBar.Value);
                Integral integral = new Integral(precision);
                double result = integral.IntegCal(double.Parse(up_num_comboBox.Text),
                    double.Parse(down_num_comboBox.Text),
                    exp_textBox.Text);
                result_textBox.Text = result.ToString("f10");
                log.Enqueue(new Log(result));
                if (log.Count > 5)
                    log.Dequeue();
                input_bindingSource.DataSource = log.ToList();
                input_bindingSource.ResetBindings(false);
                up_num_comboBox.Text = up;
                down_num_comboBox.Text = down;
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

        private void der_cal_button_Click(object sender, EventArgs e)
        {
            if(dinput_comboBox.Text==""||dinput_textBox.Text=="")
            {
                MessageBox.Show("函数输入/计算点坐标 不可为空！");
                return;
            }
            try
            {
                string x = dinput_comboBox.Text;
                string funExp = dinput_textBox.Text;
                double precision = 0.001 * Math.Pow(10, -dpre_trackBar.Value);
                Deriviation deriviation = new Deriviation(precision);
                double result = deriviation.DerivCal(double.Parse(x), funExp);
                doutput_textBox.Text = result.ToString("f10");
                log.Enqueue(new Log(result));
                if (log.Count > 5)
                    log.Dequeue();
                input_bindingSource.DataSource = log.ToList();
                input_bindingSource.ResetBindings(false);
                dinput_comboBox.Text = x;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void der_clear_button_Click(object sender, EventArgs e)
        {
            dinput_comboBox.Text = "";
            dinput_textBox.Text = "";
            doutput_textBox.Text = "";
        }

        private void der_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void vcal_button_Click(object sender, EventArgs e)
        {
            if (vup_comboBox.Text == "" || vdown_comboBox.Text == ""||vinput_exp_textBox.Text=="")
            {
                MessageBox.Show("函数输入/上界/下界 不可为空！");
                return;
            }
            try
            {
                string up = vup_comboBox.Text;
                string down = vdown_comboBox.Text;
                string funExp = vinput_exp_textBox.Text;
                double precision = 0.001 * Math.Pow(10, -v_trackBar.Value);
                Extremum extremum = new Extremum(precision);
                extremum.ExtremumCal(double.Parse(up),double.Parse(down),funExp,
                    out double minVal,out double maxVal);
                vminoutput_textBox.Text = minVal.ToString("f10");
                vmaxoutput_textBox.Text = maxVal.ToString("f10");

                log.Enqueue(new Log(minVal));
                if (log.Count > 5)
                    log.Dequeue();
                log.Enqueue(new Log(maxVal));
                if (log.Count > 5)
                    log.Dequeue();

                input_bindingSource.DataSource = log.ToList();
                input_bindingSource.ResetBindings(false);
                vup_comboBox.Text = up;
                vdown_comboBox.Text = down;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void vclear_button_Click(object sender, EventArgs e)
        {
            vinput_exp_textBox.Text = "";
            vup_comboBox.Text = "";
            vdown_comboBox.Text = "";
            vmaxoutput_textBox.Text = "";
            vminoutput_textBox.Text = "";
        }

        private void vexit_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
