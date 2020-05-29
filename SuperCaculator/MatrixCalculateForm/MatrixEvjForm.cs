using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculateForm
{
    public partial class MatrixEvjForm : Form
    {
        public MatrixEvjForm()
        {
            InitializeComponent();
        }
        public Matrix matrixEvj1;
        public Matrix matrixEvj2;

        private void MatrixEvjForm_Load(object sender, EventArgs e)
        {
            Matrix.WriteMatrix(MatrixEvj1textBox, matrixEvj1);
            Matrix.WriteMatrix(MatrixEvj2textBox, matrixEvj2);
        }
    }
}
