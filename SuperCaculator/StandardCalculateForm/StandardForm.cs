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
        string equation = "0";
        bool isShift=false;
        public StandardCalculat()
        {
            InitializeComponent();
            //richTxtEquation.SelectionAlignment = HorizontalAlignment.Right;
        }
       

        public void ClickDigit(object sender, EventArgs e)
        {
            if (richTxtEquation.Text == "0")
            {
                richTxtEquation.Text =equation= ((Button)sender).Text;               
            }
            else
            {
                richTxtEquation.Text += ((Button)sender).Text;
                equation+= ((Button)sender).Text;
            }
        }
        public void ClickGeneralOp(object sender, EventArgs e)
        {
            richTxtEquation.Text += ((Button)sender).Text;
            if(((Button)sender).Text=="×")
            {
                equation += "*";
            }
            else if (((Button)sender).Text == "÷")
            {
                equation += "/";
            }
        }

        
        private void btnClean_Click(object sender, EventArgs e)
        {
            equation=richTxtEquation.Text = "0";
        }        
       

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Function.Function func = new Function.Function(equation);
            equation=richTxtEquation.Text=func.GetValue().ToString();
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            isShift = !isShift;
            if (isShift)
            {
                btnCube.Text = "³√x";
                btnSqr.Text = "²√x";
                btnPower.Text = "1/x";
                btnLog.Text = "log y(x)";
                btnLn.Text = "e^x";
            }
            else
            {
                btnCube.Text = "x³";
                btnSqr.Text = "x²";
                btnPower.Text = "^";
                btnLog.Text = "log";
                btnLn.Text = "ln";
            }
        }
    }
}
