using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintForm
{
    public partial class FunctionPaint3DForm : Form
    {
        public FunctionPaint3DForm()
        {
            InitializeComponent();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string exp = textBox_exp.Text;
            using (Paint3DForm form = new Paint3DForm(exp))
            {
                try
                {
                    Function.Function func = new Function.Function(exp);
                    //form.Caculate += func.GetValue;
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
