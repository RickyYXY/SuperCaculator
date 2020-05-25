using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    class OneMatrix : Matrix
    {
        public OneMatrix(int rowNum, int columnNum) : base(rowNum, columnNum)
        {
            MatrixRow = rowNum;
            MatrixColumn = columnNum;
            ValueNumbers = new int[MatrixRow, MatrixColumn];
        }

        //矩阵转置
        public Matrix MatrixTranspose(Matrix matrix)
        {

        }
        //矩阵求逆
        public Matrix MatrixInverse(Matrix matrix)
        {

        }

        //矩阵求特征值和特征向量
        public Matrix MatrixEig(Matrix matrix)
        {

        }
    }
}
