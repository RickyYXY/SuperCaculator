using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    public class MatrixCreate : Matrix
    {
        //生成零矩阵
        //public bool ZerosMatrix()
        //{
        //    for (int i = 0; i < numRows; ++i)
        //        for (int j = 0; j < numColumns; ++j)
        //            if (i == j)
        //                SetElement(i, j, 0);

        //    return true;
        //}

        //生成单位矩阵
        public bool IdentityMatrix()
        {
            for (int i = 0; i < numRows; ++i)
                for (int j = 0; j < numColumns; ++j)
                    if (i == j)
                        SetElement(i, j, 1);

            return true;
        }

        //生成对角矩阵
        public bool DiagonalMatrix(double[] element)
        {
            int temp = 0;
            int length = element.Length;
            for (int i = 0; i < length; ++i)
            {
                for (int j = 0; j < length; ++j)
                {
                    if (i == j)
                    {
                        if(temp < length)
                        {
                            double temp1 = Math.Round(element[temp], 2);
                            SetElement(i, j, temp1);
                            temp++;
                        }
                    }
                }
            }                       
            return true;
        }
    }
}
