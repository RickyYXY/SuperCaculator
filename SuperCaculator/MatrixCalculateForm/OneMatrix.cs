using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm
{
    class OneMatrix
    {
        //矩阵转置
        static public Matrix MatrixTranspose(Matrix matrix)
        {
            // 构造目标矩阵
            Matrix Trans = new Matrix(matrix.Columns, matrix.Rows);

            // 转置各元素
            for (int i = 0; i < matrix.Rows; ++i)
            {
                for (int j = 0; j < matrix.Columns; ++j)
                    Trans.SetElement(j, i, matrix.GetElement(i, j));
            }

            return Trans;
        }
        //矩阵求逆
        //没有逆矩阵的情况在form中处理
        static public bool MatrixInverse(Matrix matrix)
        {
            int i, j, k, l, u, v;
            double d = 0, p = 0;

            // 分配内存
            int[] pnRow = new int[matrix.Columns];
            int[] pnCol = new int[matrix.Columns];

            // 消元
            for (k = 0; k <= matrix.Columns - 1; k++)
            {
                d = 0.0;
                for (i = k; i <= matrix.Columns - 1; i++)
                {
                    for (j = k; j <= matrix.Columns - 1; j++)
                    {
                        l = i * matrix.Columns + j; p = Math.Abs(matrix.elements[l]);
                        if (p > d)
                        {
                            d = p;
                            pnRow[k] = i;
                            pnCol[k] = j;
                        }
                    }
                }

                // 失败
                if (d == 0.0)
                {
                    return false;
                }

                if (pnRow[k] != k)
                {
                    for (j = 0; j <= matrix.Columns - 1; j++)
                    {
                        u = k * matrix.Columns + j;
                        v = pnRow[k] * matrix.Columns + j;
                        p = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = p;
                    }
                }

                if (pnCol[k] != k)
                {
                    for (i = 0; i <= matrix.Columns - 1; i++)
                    {
                        u = i * matrix.Columns + k;
                        v = i * matrix.Columns + pnCol[k];
                        p = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = p;
                    }
                }

                l = k * matrix.Columns + k;
                matrix.elements[l] = 1.0 / matrix.elements[l];
                for (j = 0; j <= matrix.Columns - 1; j++)
                {
                    if (j != k)
                    {
                        u = k * matrix.Columns + j;
                        matrix.elements[u] = matrix.elements[u] * matrix.elements[l];
                    }
                }

                for (i = 0; i <= matrix.Columns - 1; i++)
                {
                    if (i != k)
                    {
                        for (j = 0; j <= matrix.Columns - 1; j++)
                        {
                            if (j != k)
                            {
                                u = i * matrix.Columns + j;
                                matrix.elements[u] = matrix.elements[u] - matrix.elements[i * matrix.Columns + k] * matrix.elements[k * matrix.Columns + j];
                            }
                        }
                    }
                }

                for (i = 0; i <= matrix.Columns - 1; i++)
                {
                    if (i != k)
                    {
                        u = i * matrix.Columns + k;
                        matrix.elements[u] = -matrix.elements[u] * matrix.elements[l];
                    }
                }
            }

            // 调整恢复行列次序
            for (k = matrix.Columns - 1; k >= 0; k--)
            {
                if (pnCol[k] != k)
                {
                    for (j = 0; j <= matrix.Columns - 1; j++)
                    {
                        u = k * matrix.Columns + j;
                        v = pnCol[k] * matrix.Columns + j;
                        p = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = p;
                    }
                }

                if (pnRow[k] != k)
                {
                    for (i = 0; i <= matrix.Columns - 1; i++)
                    {
                        u = i * matrix.Columns + k;
                        v = i * matrix.Columns + pnRow[k];
                        p = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = p;
                    }
                }
            }

            // 成功返回
            return true;
        }
        /**
         * 求行列式值的全选主元高斯消去法
         * 
         * @return double型，行列式的值
         */
        static public double ComputeDetGauss(Matrix matrix)
        {
            int i, j, k, nis = 0, js = 0, l, u, v;
            double f, det, q, d;

            // 初值
            f = 1.0;
            det = 1.0;

            // 消元
            for (k = 0; k <= matrix.Columns - 2; k++)
            {
                q = 0.0;
                for (i = k; i <= matrix.Columns - 1; i++)
                {
                    for (j = k; j <= matrix.Columns - 1; j++)
                    {
                        l = i * matrix.Columns + j;
                        d = Math.Abs(matrix.elements[l]);
                        if (d > q)
                        {
                            q = d;
                            nis = i;
                            js = j;
                        }
                    }
                }

                if (q == 0.0)
                {
                    det = 0.0;
                    return (det);
                }

                if (nis != k)
                {
                    f = -f;
                    for (j = k; j <= matrix.Columns - 1; j++)
                    {
                        u = k * matrix.Columns + j;
                        v = nis * matrix.Columns + j;
                        d = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = d;
                    }
                }

                if (js != k)
                {
                    f = -f;
                    for (i = k; i <= matrix.Columns - 1; i++)
                    {
                        u = i * matrix.Columns + js;
                        v = i * matrix.Columns + k;
                        d = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = d;
                    }
                }

                l = k * matrix.Columns + k;
                det = det * matrix.elements[l];
                for (i = k + 1; i <= matrix.Columns - 1; i++)
                {
                    d = matrix.elements[i * matrix.Columns + k] / matrix.elements[l];
                    for (j = k + 1; j <= matrix.Columns - 1; j++)
                    {
                        u = i * matrix.Columns + j;
                        matrix.elements[u] = matrix.elements[u] - d * matrix.elements[k * matrix.Columns + j];
                    }
                }
            }

            // 求值
            det = f * det * matrix.elements[matrix.Columns * matrix.Columns - 1];

            return (det);
        }
        /**
         * 求矩阵秩的全选主元高斯消去法
         * 
         * @return int型，矩阵的秩
         */
        static public int ComputeRankGauss(Matrix matrix)
        {
            int i, j, k, nn, nis = 0, js = 0, l, ll, u, v;
            double q, d;

            // 秩小于等于行列数
            nn = matrix.Rows;
            if (matrix.Rows >= matrix.Columns)
                nn = matrix.Columns;

            k = 0;

            // 消元求解
            for (l = 0; l <= nn - 1; l++)
            {
                q = 0.0;
                for (i = l; i <= matrix.Rows - 1; i++)
                {
                    for (j = l; j <= matrix.Columns - 1; j++)
                    {
                        ll = i * matrix.Columns + j;
                        d = Math.Abs(matrix.elements[ll]);
                        if (d > q)
                        {
                            q = d;
                            nis = i;
                            js = j;
                        }
                    }
                }

                if (q == 0.0)
                    return (k);

                k = k + 1;
                if (nis != l)
                {
                    for (j = l; j <= matrix.Columns - 1; j++)
                    {
                        u = l * matrix.Columns + j;
                        v = nis * matrix.Columns + j;
                        d = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = d;
                    }
                }
                if (js != l)
                {
                    for (i = l; i <= matrix.Rows - 1; i++)
                    {
                        u = i * matrix.Columns + js;
                        v = i * matrix.Columns + l;
                        d = matrix.elements[u];
                        matrix.elements[u] = matrix.elements[v];
                        matrix.elements[v] = d;
                    }
                }

                ll = l * matrix.Columns + l;
                for (i = l + 1; i <= matrix.Columns - 1; i++)
                {
                    d = matrix.elements[i * matrix.Columns + l] / matrix.elements[ll];
                    for (j = l + 1; j <= matrix.Columns - 1; j++)
                    {
                        u = i * matrix.Columns + j;
                        matrix.elements[u] = matrix.elements[u] - d * matrix.elements[l * matrix.Columns + j];
                    }
                }
            }

            return (k);
        }
        /**
         * 求实对称矩阵特征值与特征向量的雅可比法
         * 
         * @param dblEigenValue - 一维数组，长度为矩阵的阶数，返回时存放特征值
         * @param mtxEigenVector - 返回时存放特征向量矩阵，其中第i列为与数组
         *                         dblEigenValue中第j个特征值对应的特征向量
         * @param nMaxIt - 迭代次数
         * @param eps - 计算精度
         * @return bool型，求解是否成功
         */
        static public bool ComputeEvJacobi(Matrix matrix, double[] dblEigenValue, Matrix mtxEigenVector, int nMaxIt, double eps)
        {
            int i, j, p = 0, q = 0, u, w, t, s, l;
            double fm, cn, sn, omega, x, y, d;

            if (!mtxEigenVector.Init(matrix.Columns, matrix.Columns))
                return false;

            l = 1;
            for (i = 0; i <= matrix.Columns - 1; i++)
            {
                mtxEigenVector.elements[i * matrix.Columns + i] = 1.0;
                for (j = 0; j <= matrix.Columns - 1; j++)
                    if (i != j)
                        mtxEigenVector.elements[i * matrix.Columns + j] = 0.0;
            }

            while (true)
            {
                fm = 0.0;
                for (i = 1; i <= matrix.Columns - 1; i++)
                {
                    for (j = 0; j <= i - 1; j++)
                    {
                        d = Math.Abs(matrix.elements[i * matrix.Columns + j]);
                        if ((i != j) && (d > fm))
                        {
                            fm = d;
                            p = i;
                            q = j;
                        }
                    }
                }

                if (fm < eps)
                {
                    for (i = 0; i < matrix.Columns; ++i)
                        dblEigenValue[i] = matrix.GetElement(i, i);
                    return true;
                }

                if (l > nMaxIt)
                    return false;

                l = l + 1;
                u = p * matrix.Columns + q;
                w = p * matrix.Columns + p;
                t = q * matrix.Columns + p;
                s = q * matrix.Columns + q;
                x = -matrix.elements[u];
                y = (matrix.elements[s] - matrix.elements[w]) / 2.0;
                omega = x / Math.Sqrt(x * x + y * y);

                if (y < 0.0)
                    omega = -omega;

                sn = 1.0 + Math.Sqrt(1.0 - omega * omega);
                sn = omega / Math.Sqrt(2.0 * sn);
                cn = Math.Sqrt(1.0 - sn * sn);
                fm = matrix.elements[w];
                matrix.elements[w] = fm * cn * cn + matrix.elements[s] * sn * sn + matrix.elements[u] * omega;
                matrix.elements[s] = fm * sn * sn + matrix.elements[s] * cn * cn - matrix.elements[u] * omega;
                matrix.elements[u] = 0.0;
                matrix.elements[t] = 0.0;
                for (j = 0; j <= matrix.Columns - 1; j++)
                {
                    if ((j != p) && (j != q))
                    {
                        u = p * matrix.Columns + j; w = q * matrix.Columns + j;
                        fm = matrix.elements[u];
                        matrix.elements[u] = fm * cn + matrix.elements[w] * sn;
                        matrix.elements[w] = -fm * sn + matrix.elements[w] * cn;
                    }
                }

                for (i = 0; i <= matrix.Columns - 1; i++)
                {
                    if ((i != p) && (i != q))
                    {
                        u = i * matrix.Columns + p;
                        w = i * matrix.Columns + q;
                        fm = matrix.elements[u];
                        matrix.elements[u] = fm * cn + matrix.elements[w] * sn;
                        matrix.elements[w] = -fm * sn + matrix.elements[w] * cn;
                    }
                }

                for (i = 0; i <= matrix.Columns - 1; i++)
                {
                    u = i * matrix.Columns + p;
                    w = i * matrix.Columns + q;
                    fm = mtxEigenVector.elements[u];
                    mtxEigenVector.elements[u] = fm * cn + mtxEigenVector.elements[w] * sn;
                    mtxEigenVector.elements[w] = -fm * sn + mtxEigenVector.elements[w] * cn;
                }
            }
        }
    }
}
