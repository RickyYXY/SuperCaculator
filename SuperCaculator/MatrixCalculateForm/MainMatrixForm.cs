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
            if ((MatrixAtextBox.Text == "") || (MatrixBtextBox.Text == ""))
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            matrixC.Init(0, 0);
            MatrixCtextBox.Text = "";
            matrixA.ReadAndCheckMatrix(MatrixAtextBox);
            matrixB.ReadAndCheckMatrix(MatrixBtextBox);
            matrixC = TwoMatrix.MatrixMul(matrixA, matrixB);
            var fontsize = (int)(MatrixCtextBox.Width / (Math.Max(matrixC.Columns, matrixC.Rows))) / 5;
            MatrixCtextBox.Font = new System.Drawing.Font(MatrixCtextBox.Font.FontFamily, fontsize);
            Matrix.WriteMatrix(MatrixCtextBox, matrixC);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((MatrixAtextBox.Text == "") || (MatrixBtextBox.Text == ""))
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            matrixC.Init(0, 0);
            MatrixCtextBox.Text = "";
            matrixA.ReadAndCheckMatrix(MatrixAtextBox);
            matrixB.ReadAndCheckMatrix(MatrixBtextBox);
            matrixC = TwoMatrix.MatrixAdd(matrixA, matrixB);
            var fontsize = (int)(MatrixCtextBox.Width / (Math.Max(matrixC.Columns, matrixC.Rows))) / 5;
            MatrixCtextBox.Font = new System.Drawing.Font(MatrixCtextBox.Font.FontFamily, fontsize);

            Matrix.WriteMatrix(MatrixCtextBox, matrixC);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if ((MatrixAtextBox.Text == "") || (MatrixBtextBox.Text == ""))
            {
                MessageBox.Show("请输入数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            matrixC.Init(0, 0);
            MatrixCtextBox.Text = "";
            matrixA.ReadAndCheckMatrix(MatrixAtextBox);
            matrixB.ReadAndCheckMatrix(MatrixBtextBox);
            matrixC = TwoMatrix.MatrixSub(matrixA, matrixB);
            var fontsize = (int)(MatrixCtextBox.Width / (Math.Max(matrixC.Columns, matrixC.Rows))) / 5;
            MatrixCtextBox.Font = new System.Drawing.Font(MatrixCtextBox.Font.FontFamily, fontsize);
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
            MatrixETextBox.Text = "";
            matrixE = OneMatrix.MatrixTranspose(matrixD);
            Matrix.WriteMatrix(MatrixETextBox, matrixE);
            var fontsize = (int)(MatrixETextBox.Width / (Math.Max(matrixE.Columns, matrixE.Rows)))/5;
            MatrixETextBox.Font = new System.Drawing.Font(MatrixETextBox.Font.FontFamily, fontsize);
            //var buttonsize = MatrixETextBox.Font.Size;

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
                MatrixETextBox.Text = "";
                var fontsize = (int)(MatrixETextBox.Width / (Math.Max(matrixD.Columns, matrixD.Rows))) / 15;
                MatrixETextBox.Font = new System.Drawing.Font(MatrixETextBox.Font.FontFamily, fontsize);
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
            //matrixE.Init(0, 0);
            MatrixETextBox.Text = "";
            double temp = OneMatrix.ComputeDetGauss(matrixD);
            double[] result = new double[1] { temp };
            matrixE.Init(1, 1);
            matrixE.SetData(result);
            var fontsize = (int)(MatrixETextBox.Width / (Math.Max(matrixE.Columns, matrixE.Rows))) / 5;
            MatrixETextBox.Font = new System.Drawing.Font(MatrixETextBox.Font.FontFamily, fontsize);
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
            //matrixE.Init(0, 0);
            MatrixETextBox.Text = "";
            int temp = OneMatrix.ComputeRankGauss(matrixD);
            double[] result = new double[1] { temp };
            matrixE.Init(1, 1);
            matrixE.SetData(result);
            var fontsize = (int)(MatrixETextBox.Width / (Math.Max(matrixE.Columns, matrixE.Rows))) / 5;
            MatrixETextBox.Font = new System.Drawing.Font(MatrixETextBox.Font.FontFamily, fontsize);
            Matrix.WriteMatrix(MatrixETextBox, matrixE);
        }
        public Matrix matrixEvj1;
        public Matrix matrixEvj2;
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
            //MatrixEvjForm form = new MatrixEvjForm();
            double[] Evj1 = new double[matrixD.GetNumRows()];
            if (!OneMatrix.ComputeEvJacobi(matrixD, Evj1, matrixE, 100, 0.1 ))
            {
                MessageBox.Show("特征值与特征向量求解失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //matrixEvj1.Init(0, 0);
                matrixEvj1textbox.Text = "";
                //matrixEvj2.Init(0, 0);
                matrixEvj2textbox.Text = "";
                
                matrixEvj1 = new Matrix(Evj1.Length, Evj1.Length);
                var fontsize1 = (int)(matrixEvj1textbox.Width / (Math.Max(matrixEvj1.Columns, matrixEvj1.Rows))) / 3;
                matrixEvj1textbox.Font = new System.Drawing.Font(matrixEvj1textbox.Font.FontFamily, fontsize1);
                matrixEvj1.DiagonalMatrix(Evj1);
                matrixEvj2 = new Matrix(matrixE);
                var fontsize2 = (int)(matrixEvj2textbox.Width / (Math.Max(matrixEvj2.Columns, matrixEvj2.Rows))) / 4;
                matrixEvj2textbox.Font = new System.Drawing.Font(matrixEvj2textbox.Font.FontFamily, fontsize2);
                Matrix.WriteMatrix(matrixEvj1textbox, matrixEvj1);
                Matrix.WriteMatrix(matrixEvj2textbox, matrixEvj2);
            }
        }

        private void OneMatrixTabPage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //保存按钮
        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置对话框标题
            sfd.Title = "保存导出矩阵";
            //设置默认文件名
            sfd.FileName = "Matrix.txt";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            sfd.Filter = "TxT 文本文件（*.txt）|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径
                matrixE.WriteMatrixToFile(localFilePath, matrixE);
                MessageBox.Show(sfd.FileName.ToString());
            }
            else
            {
                MessageBox.Show("取消保存");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置对话框标题
            sfd.Title = "保存导出矩阵";
            //设置默认文件名
            sfd.FileName = "Matrix.txt";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            sfd.Filter = "TxT 文本文件（*.txt）|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径
                matrixE.WriteMatrixToFile(localFilePath, matrixE);
                MessageBox.Show(sfd.FileName.ToString());
            }
            else
            {
                MessageBox.Show("取消保存");
                return;
            }
        }

        private void MatrixEvj1Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            //设置对话框标题
            sfd.Title = "保存导出矩阵";
            //设置默认文件名
            sfd.FileName = "Matrix.txt";
            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;
            sfd.Filter = "TxT 文本文件（*.txt）|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径
                matrixEvj1.WriteMatrixToFile(localFilePath, matrixE);
                MessageBox.Show(sfd.FileName.ToString());
            }
            else
            {
                MessageBox.Show("取消保存");
                return;
            }
        }

        private void MatrixDClear_Click(object sender, EventArgs e)
        {
            matrixD.Init(0, 0);
            MatrixDTextBox.Text = "";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
