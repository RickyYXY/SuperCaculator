using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    class TwoMatrix
    {
        //矩阵相加
        static public Matrix MatrixAdd(Matrix matrix1, Matrix matrix2)
        {
            return matrix1 + matrix2;
        }
        //矩阵相减
        static public Matrix MatrixSub(Matrix matrix1, Matrix matrix2)
        {
            return matrix1 - matrix2;
        }
        //矩阵相乘
        static public Matrix MatrixMul(Matrix matrix1, Matrix matrix2)
        {
            return matrix1 * matrix2;
        }
    }
}
