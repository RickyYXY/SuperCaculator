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
    public partial class FunctionPaintForm : Form
    {
        public FunctionPaintForm()
        {
            InitializeComponent();
        }

        private void Button_confirm_2D_Click(object sender, EventArgs e)
        {
            string exp = textBox_exp_2D.Text;
            try
            {
                Function.Function func = new Function.Function(exp);
                using (Paint2DForm form = new Paint2DForm(exp, func.GetValue))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void Button_confirm_3D_Click(object sender, EventArgs e)
        {
            string exp = textBox_exp_3D.Text;
            try
            {
                Function.Function func = new Function.Function(exp);
                using (Paint3DForm form = new Paint3DForm(exp, func.GetValue))
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_cancel_2D_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_cancel_3D_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
