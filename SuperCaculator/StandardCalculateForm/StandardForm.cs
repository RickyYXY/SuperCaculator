using System;
using HandleEqua;
using System.Linq;
using System.Windows.Forms;

namespace StandardCalculateForm
{
    
    public partial class StandardCalculat : Form
    {
        string equation = "0";
        bool isShift = false;
        bool isClickPoint = false;
        int bktAmount = 0;
        Log someLog = new Log();
        SetLogBase setBaseForm = new SetLogBase(new Log());
        
        public StandardCalculat()
        {
            InitializeComponent();
            //richTxtEquation.SelectionAlignment = HorizontalAlignment.Right;
        }


        public void Digit_Click(object sender, EventArgs e)
        {
            if (richTxtEquation.Text == "0")
            {
                richTxtEquation.Text = equation = ((Button)sender).Text;
            }
            else if (richTxtEquation.Text.Last() == ')')
            {
                return;
            }
            else
            {
                richTxtEquation.Text += ((Button)sender).Text;
                equation += ((Button)sender).Text;
            }
        }
        public void GeneralOp_Click(object sender, EventArgs e)
        {
            if (HandleEquation.IsGeneralOp(equation.Last())) { return; }
            richTxtEquation.Text += ((Button)sender).Text;
            isClickPoint = false;
            if (((Button)sender).Text == "×")
            {
                equation += "*";
            }
            else if (((Button)sender).Text == "÷")
            {
                equation += "/";
            }
            else
            {
                equation += ((Button)sender).Text;
            }
        }


        private void btnClean_Click(object sender, EventArgs e)
        {
            equation = richTxtEquation.Text = "0";
        }


        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Function.Function func = new Function.Function(equation);
            equation = richTxtEquation.Text = func.GetValue().ToString();
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
                btnLog.Text = "lg";
                btnLn.Text = "ln";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!isClickPoint && (richTxtEquation.Text.Last() >= 48) && (richTxtEquation.Text.Last() <= 57))
            {
                equation += ".";
                richTxtEquation.Text += ".";
                isClickPoint = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (equation.Length == 1)
            {
                equation = "0";
                richTxtEquation.Text = "0";
            }
            else if (equation.Last() >= 48 && equation.Last() <= 57)
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
                string tail = HandleEquation.GetLastUnit(equation);
                if (tail.Contains(".")) { isClickPoint = true; }
                else { isClickPoint = false; }
            }
            else
            {
                equation = HandleEquation.RemoveLastUnit(equation);
                richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text);
                isClickPoint = false;
            }

            if (equation == ""||richTxtEquation.Text=="")
            {
                equation = "0";
                richTxtEquation.Text = "0";
            }
        }

        private void Function_Click(object sender, EventArgs e)
        {
            string tail = HandleEquation.GetLastUnit(equation);
            equation = HandleEquation.RemoveLastUnit(equation) + ((ToolStripMenuItem)sender).Text + "(" + tail + ")";
            string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
            richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + ((ToolStripMenuItem)sender).Text + "(" + tail2 + ")";
        }

        private void FFunction_Click(object sender, EventArgs e)
        {
            string tail = HandleEquation.GetLastUnit(equation);
            string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "toolStripMenuItemAbs":
                    equation = HandleEquation.RemoveLastUnit(equation) + "abs(" + tail + ")";
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "|" + tail2 + "|";
                    break;
                case "toolStripMenuItemFloor":
                    equation = HandleEquation.RemoveLastUnit(equation) + "floor(" + tail + ")";
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "⌊" + tail2 + "⌋";
                    break;
                case "toolStripMenuItemCeil":
                    equation = HandleEquation.RemoveLastUnit(equation) + "ceil(" + tail + ")";
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "⌈" + tail2 + "⌉";
                    break;
                default:
                    break;
            }

        }

        private void Rand_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int randInt = rd.Next(100, 9999);
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

        private void btnNega_Click(object sender, EventArgs e)
        {
            string tail = HandleEquation.GetLastUnit(equation);
            string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
            string removedTail = HandleEquation.RemoveLastUnit(equation);
            string removedTail2 = HandleEquation.RemoveLastUnit(richTxtEquation.Text);
            if (removedTail.Length == 0)
            {
                equation = "-" + tail;
                richTxtEquation.Text = "-" + tail2;
            }
            else if (removedTail.Last() == '-')
            {
                if (removedTail.Length == 1)
                {
                    equation = tail;
                    richTxtEquation.Text = tail2;
                }
                else
                {
                    equation = removedTail.Substring(0, removedTail.Length - 1) + "+" + tail;
                    richTxtEquation.Text = removedTail2.Substring(0, removedTail2.Length - 1) + "+" + tail2;
                }
            }
            else if (removedTail.Last() == '+')
            {
                equation = removedTail.Substring(0, removedTail.Length - 1) + "-" + tail;
                richTxtEquation.Text = removedTail2.Substring(0, removedTail2.Length - 1) + "-" + tail2;
            }
            else
            {
                equation = removedTail.Substring(0, removedTail.Length - 1) + "(-" + tail + ")";
                richTxtEquation.Text = removedTail2.Substring(0, removedTail2.Length - 1) + "(-" + tail2 + ")";

            }
        }

        private void Constant_Click(object sender, EventArgs e)
        {
            if (HandleEquation.IsGeneralOp(equation.Last()))
            {
                if (((Button)sender).Text == "e")
                {
                    equation += "e";
                }
                else
                {
                    equation += "pi";
                }                
                richTxtEquation.Text += ((Button)sender).Text;
            }
            else
            {
                if (((Button)sender).Text == "e")
                {
                    equation = HandleEquation.RemoveLastUnit(equation) + "e";
                }
                else
                {
                    equation = HandleEquation.RemoveLastUnit(equation) + "pi";
                }               
                richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + ((Button)sender).Text;
            }
        }

        private void btnFac_Click(object sender, EventArgs e)
        {
            string tail = HandleEquation.GetLastUnit(equation);
            equation = HandleEquation.RemoveLastUnit(equation) + "(" + tail + ")!";
            string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
            richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "(" + tail2 + ")!";

        }

        private void LeftBkt_Click(object sender, EventArgs e)
        {
            if (richTxtEquation.Text == "0")
            {
                equation = richTxtEquation.Text = ((Button)sender).Text;
                bktAmount++;
            }
            else if (!HandleEquation.IsGeneralOp(equation.Last()))
            {
                return;
            }
            else
            {
                richTxtEquation.Text += ((Button)sender).Text;
                equation += ((Button)sender).Text;
                bktAmount++;
            }
        }

        private void RightBkt_Click(object sender, EventArgs e)
        {
            if (bktAmount <= 0)
            {
                return;
            }
            else if (HandleEquation.IsGeneralOp(equation.Last()))
            {
                richTxtEquation.Text =richTxtEquation.Text.Substring(0,richTxtEquation.Text.Length-1)+ ((Button)sender).Text;
                equation = equation.Substring(0, equation.Length - 1) + ((Button)sender).Text;
                bktAmount--;           
            }
            else
            {
                richTxtEquation.Text += ((Button)sender).Text;
                equation += ((Button)sender).Text;
                bktAmount--;
            }
        }

        private void ShiftManaged_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text){
                case "x³":
                    equation += "^3";
                    richTxtEquation.Text += "^3";
                    break;
                case "x²":
                    equation += "^2";
                    richTxtEquation.Text += "^2";
                    break;
                case "^":
                    equation += "^";
                    richTxtEquation.Text += "^";
                    break;
                case "lg":
                    string tail = HandleEquation.GetLastUnit(equation);
                    equation = HandleEquation.RemoveLastUnit(equation) + "log10(" + tail + ")";
                    string tail0 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + ((Button)sender).Text + "(" + tail0 + ")";
                    break;
                case "ln":
                    string tail1 = HandleEquation.GetLastUnit(equation);
                    equation = HandleEquation.RemoveLastUnit(equation) + ((Button)sender).Text + "(" + tail1 + ")";
                    string tail2 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + ((Button)sender).Text + "(" + tail2 + ")";                   
                    break;
                case "²√x":
                    equation += "^(1/2)";
                    string tail3 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "²√(" + tail3 + ")";
                    break;
                case "³√x":
                    equation += "^(1/3)";
                    string tail4 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "³√(" + tail4 + ")";
                    break;
                case "1/x":
                    string tail5 = HandleEquation.GetLastUnit(equation);
                    equation = HandleEquation.RemoveLastUnit(equation) +  "1/(" + tail5 + ")";
                    string tail6 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text)+ "1/(" + tail6 + ")";
                    break;               
                case "e^x":
                    string tail7 = HandleEquation.GetLastUnit(equation);
                    equation = HandleEquation.RemoveLastUnit(equation) + "e^(" + tail7 + ")";
                    string tail8 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "e^(" + tail8 + ")";
                    break;
                case "log y(x)":
                    MessageBox.Show("请先右键此按钮设置底数。");
                    break;
                default:
                    string tail9 = HandleEquation.GetLastUnit(equation);
                    equation = HandleEquation.RemoveLastUnit(equation) + "log"+someLog.LogBase+"(" + tail9 + ")";
                    string tail10 = HandleEquation.GetLastUnit(richTxtEquation.Text);
                    richTxtEquation.Text = HandleEquation.RemoveLastUnit(richTxtEquation.Text) + "log " + someLog.LogBase +  "(" + tail10 + ")";
                    break;
            }
        }

      
        private void MouseRight_Click(object sender, MouseEventArgs e)
        {
            if (((Button)sender).Text != "lg" && e.Button == MouseButtons.Right)
            {
                if (((Button)sender).Text == "log y(x)")
                {
                    someLog.LogBase = "";
                }
                if (setBaseForm.ShowDialog() == DialogResult.OK)
                {
                    someLog = setBaseForm.Somelog;
                    btnLog.Text = "log " + someLog.LogBase + "(x)";
                }                              
            }
        }
    }
}
