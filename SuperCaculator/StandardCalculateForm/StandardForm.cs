using System;
using Function;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardCalculateForm
{
    public partial class StandardCalculat : Form
    {
        public StandardCalculat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void ClickDigit(int digit)
        {
            if (richTxtEquation.Text == "0")
            {
                richTxtEquation.Text = digit.ToString();
            }
            else
            {
                richTxtEquation.Text += digit.ToString();
            }
        }
        public void ClickGeneralOp(string op)
        {
            richTxtEquation.Text += op;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ClickDigit(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ClickDigit(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClickDigit(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ClickDigit(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ClickDigit(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ClickDigit(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ClickDigit(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ClickDigit(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ClickDigit(9);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            richTxtEquation.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ClickDigit(0);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ClickGeneralOp("/");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            ClickGeneralOp("*");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            ClickGeneralOp("-");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClickGeneralOp("+");
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
