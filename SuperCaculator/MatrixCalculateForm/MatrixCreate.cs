using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    class MatrixCreate : Matrix
    {
        public MatrixCreate(int rowNum, int columnNum) : base(rowNum, columnNum)
        {
            MatrixRow = rowNum;
            MatrixColumn = columnNum;
            ValueNumbers = new int[MatrixRow, MatrixColumn];
        }

        public void ZerosMatrix()
        {
            for(int i = 0; i < MatrixRow; i++)
            {
                for(int j=0; j<MatrixColumn; j++)
                {
                    ValueNumbers[i, j] = 0;
                }
            }
        }

        public void IdentityMatrix()
        {
            int temp = 0;
            for(int i = 0; i < MatrixRow; i++)
            {
                for(int j =0;j<MatrixColumn; j++)
                {
                    if(i == (j + temp))
                    {
                        ValueNumbers[i, j] = 1;
                    }
                    else
                    {
                        ValueNumbers[i, j] = 0;
                    }
                }
            }
        }
    }
}
