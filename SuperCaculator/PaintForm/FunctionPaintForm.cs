using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Function;

namespace PaintForm
{
    public partial class FunctionPaintForm : Form
    {
        public FunctionPaintForm()
        {
            InitializeComponent();
        }

        private void Button_confirm_Click(object sender, EventArgs e)
        {
            string exp = textBox_exp.Text;
            using(PaintForm form = new PaintForm(exp))
            {
                try
                {
                    Function.Function func = new Function.Function(exp);
                    form.Caculate += func.GetValue;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBox_exp_TextChanged(object sender, EventArgs e)
        {
            textBox_exp.Text = textBox_exp.Text.Replace(" ", "");
        }
    }
}
