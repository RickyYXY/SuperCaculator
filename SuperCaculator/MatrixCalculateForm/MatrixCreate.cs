using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    class MatrixCreate : Matrix
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
        public bool DiagonalMatrix(int element)
        {
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    if (i == j)
                    {
                        SetElement(i, j, element);
                    }
                }
            }                       
            return true;
        }
    }
}
