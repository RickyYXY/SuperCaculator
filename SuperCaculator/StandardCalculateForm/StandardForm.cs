using System;
using Function;
using HandleEqua;
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
        bool isClickPoint = false;
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
            if (HandleEquation.IsGeneralOp(equation.Last())) { return; }
            richTxtEquation.Text += ((Button)sender).Text;
            isClickPoint = false;
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

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!isClickPoint&&(richTxtEquation.Text.Last()>=48) && (richTxtEquation.Text.Last() <= 57))
            {
                equation += ".";
                richTxtEquation.Text += ".";
                isClickPoint = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (equation.Last() >= 48 && equation.Last() <= 57)
            {
                equation = equation.Substring(0, equation.Length - 1);
                richTxtEquation.Text = richTxtEquation.Text.Substring(0, richTxtEquation.Text.Length - 1);
            }
            else if (equation.Last() == '.')
            {
                equation = equation.Substring(0, equation.Length - 1);
                richTxtEquation.Text = richTxtEquation.Text.Substring(0, richTxtEquation.Text.Length - 1);
                isClickPoint = false;
            }
            else if (HandleEquation.IsGeneralOp(equation.Last()))
            {
                equation = equation.Substring(0, equation.Length - 1);
                richTxtEquation.Text = richTxtEquation.Text.Substring(0, richTxtEquation.Text.Length - 1);
                string tail=HandleEquation.GetLastUnit(equation);
                if (tail.Contains(".")) { isClickPoint = true; }
                else { isClickPoint = false; }
            }
            else
            {
                equation = HandleEquation.RemoveLastUnit(equation);
                richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text);
                isClickPoint = false;
            }


        }

        private void Function_Click(object sender, EventArgs e)
        {
            string tail = HandleEquation.GetLastUnit(equation);
            equation = HandleEquation.RemoveLastUnit(equation) + ((ToolStripMenuItem)sender).Text + "(" + tail + ")";
            string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
            richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + ((ToolStripMenuItem)sender).Text + "(" + tail2 + ")";
        }

        private void ClickFFunction(object sender, EventArgs e)
        {
            string tail = HandleEquation.GetLastUnit(equation);            
            string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "toolStripMenuItemAbs":
                    equation = HandleEquation.RemoveLastUnit(equation) + "|" + tail + "|";
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "|" + tail2 + "|";
                    break;
                case "toolStripMenuItemFloor":
                    equation = HandleEquation.RemoveLastUnit(equation) + "⌊" + tail + "⌋";
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "⌊" + tail2 + "⌋";
                    break;
                case "toolStripMenuItemCeil":
                    equation = HandleEquation.RemoveLastUnit(equation) + "⌈" + tail + "⌉";
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "⌈" + tail2 + "⌉";
                    break;
                default:
                    break;
            }
            
        }

        private void ClickRand(object sender, EventArgs e)
        {
            Random rd = new Random();
            int randInt = rd.Next(100,9999);
            double randDouble = randInt / 10000.0;
            string randString = randDouble.ToString();
            if (HandleEquation.IsGeneralOp(equation.Last()))
            {
                equation += randString;
                richTxtEquation.Text += randString;
            }
            else
            {
                equation = HandleEquation.RemoveLastUnit(equation) + randString;
                richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + randString;
            }
        }
    }
}
