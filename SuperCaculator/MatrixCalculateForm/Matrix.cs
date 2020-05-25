using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    public class Matrix
    {
        protected int MatrixRow { get; set; } //矩阵行数
        protected int MatrixColumn { get; set; } //矩阵列数
        protected int[, ] ValueNumbers; //矩阵元素值
        Random random = new Random();
        // 初始化矩阵(随机生成)
        public Matrix(int rowNum, int columnNum)
        {
            MatrixRow = rowNum;
            MatrixColumn = columnNum;
            ValueNumbers = new int[MatrixRow, MatrixColumn];
            Random random = new Random();
            for (int i = 0; i < MatrixRow; i++)
            {
                for(int j=0; j < MatrixColumn; j++)
                {
                    ValueNumbers[i, j] = random.Next(1, 100);
                }
            }
        }
        //索引器
        public double this[int row, int column]
        {
            get { return ValueNumbers[row, column]; }
        }
    }
}
