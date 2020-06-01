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
    public partial class MainMatrixForm : Form
    {
        public MainMatrixForm()
        {
            InitializeComponent();
        }
        //初始化计算矩阵
        Matrix matrixA = new Matrix();
        Matrix matrixB = new Matrix();
        //结果存放矩阵
        Matrix matrixC = new Matrix();
        //矩阵相乘
        private void button1_Click(object sender, EventArgs e)
        {
            matrixA.ReadAndCheckMatrix(MatrixAtextBox);
            matrixB.ReadAndCheckMatrix(MatrixBtextBox);
            matrixC = TwoMatrix.MatrixMul(matrixA, matrixB);
            Matrix.WriteMatrix(MatrixCtextBox, matrixC);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            matrixA.ReadAndCheckMatrix(MatrixAtextBox);
            matrixB.ReadAndCheckMatrix(MatrixBtextBox);
            matrixC = TwoMatrix.MatrixAdd(matrixA, matrixB);
            Matrix.WriteMatrix(MatrixCtextBox, matrixC);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            matrixA.ReadAndCheckMatrix(MatrixAtextBox);
            matrixB.ReadAndCheckMatrix(MatrixBtextBox);
            matrixC = TwoMatrix.MatrixSub(matrixA, matrixB);
            Matrix.WriteMatrix(MatrixCtextBox, matrixC);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            matrixA.Init(0, 0);
            matrixB.Init(0, 0);
            matrixC.Init(0, 0);
            MatrixAtextBox.Text = "";
            MatrixBtextBox.Text = "";
            MatrixCtextBox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //源矩阵
        Matrix matrixD = new Matrix();
        //结果矩阵
        Matrix matrixE = new Matrix();
        private void Transposebutton_Click(object sender, EventArgs e)
        {
            if (MatrixDTextBox.Text == "")
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!matrixD.ReadAndCheckMatrix(MatrixDTextBox))
            {
                MessageBox.Show("矩阵行列有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            matrixE = OneMatrix.MatrixTranspose(matrixD);
            Matrix.WriteMatrix(MatrixETextBox, matrixE);
        }

        private void Inversebutton_Click(object sender, EventArgs e)
        {
            if (MatrixDTextBox.Text == "")
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!matrixD.ReadAndCheckMatrix(MatrixDTextBox))
            {
                MessageBox.Show("矩阵行列有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!OneMatrix.MatrixInverse(matrixD))
            {
                MessageBox.Show("该矩阵无逆矩阵", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Matrix.WriteMatrix(MatrixETextBox, matrixD);
            }
        }

        private void ComputeDetbutton_Click(object sender, EventArgs e)
        {
            if (MatrixDTextBox.Text == "")
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!matrixD.ReadAndCheckMatrix(MatrixDTextBox))
            {
                MessageBox.Show("矩阵行列有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            double temp = OneMatrix.ComputeDetGauss(matrixD);
            double[] result = new double[1] { temp };
            matrixE.SetData(result);
            Matrix.WriteMatrix(MatrixETextBox, matrixE);
        }

        private void ComputeRankbutton_Click(object sender, EventArgs e)
        {
            if (MatrixDTextBox.Text == "")
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!matrixD.ReadAndCheckMatrix(MatrixDTextBox))
            {
                MessageBox.Show("矩阵行列有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int temp = OneMatrix.ComputeRankGauss(matrixD);
            double[] result = new double[1] { temp };
            matrixE.SetData(result);
            Matrix.WriteMatrix(MatrixETextBox, matrixE);
        }

        private void ComputeEvJbutton_Click(object sender, EventArgs e)
        {
            if (MatrixDTextBox.Text == "")
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!matrixD.ReadAndCheckMatrix(MatrixDTextBox))
            {
                MessageBox.Show("矩阵行列有误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (matrixD.GetNumColumns() != matrixD.GetNumRows())
            {
                MessageBox.Show("该矩阵不为方阵，无法求出特征值与特征向量", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MatrixEvjForm form = new MatrixEvjForm();
            double[] Evj1 = new double[matrixD.GetNumRows()];
            if (!OneMatrix.ComputeEvJacobi(matrixD, Evj1, matrixE, 100, 0.01 ))
            {
                MessageBox.Show("特征值与特征向量求解失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                form.matrixEvj1 = new Matrix(1, matrixD.GetNumRows(), Evj1);
                form.matrixEvj2 = new Matrix(matrixE);
                form.ShowDialog();
            }
        }

        private void OneMatrixTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}
