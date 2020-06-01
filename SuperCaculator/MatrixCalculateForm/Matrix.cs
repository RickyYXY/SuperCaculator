using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatrixCalculateForm
{
    public class Matrix
    {
        protected int numColumns = 0;			// 矩阵列数
        protected int numRows = 0;			// 矩阵行数
        protected double eps = 0.0;			// 缺省精度
        public double[] elements = null;	// 矩阵数据缓冲区
        //属性:矩阵列数
        public int Columns
        {
            get
            {
                return numColumns;
            }
            set
            {
                numColumns = value;
            }
        }
        /**
         * 属性: 矩阵行数
         */
        public int Rows
        {
            get
            {
                return numRows;
            }
        }

        /**
         * 索引器: 访问矩阵元素
         * @param row - 元素的行
         * @param col - 元素的列
         */
        public double this[int row, int col]
        {
            get
            {
                return elements[col + row * numColumns];
            }
            set
            {
                elements[col + row * numColumns] = value;
            }
        }
        /**
         * 属性: Eps
         */
        public double Eps
        {
            get
            {
                return eps;
            }
            set
            {
                eps = value;
            }
        }

        /**
         * 基本构造函数
         */
        public Matrix()
        {
            numColumns = 1;
            numRows = 1;
            Init(numRows, numColumns);
        }

        /**
         * 指定行列构造函数
         * 
         * @param nRows - 指定的矩阵行数
         * @param nCols - 指定的矩阵列数
         */
        public Matrix(int nRows, int nCols)
        {
            numRows = nRows;
            numColumns = nCols;
            Init(numRows, numColumns);
        }
        /**
         * 指定值构造函数
         * 
         * @param value - 二维数组，存储矩阵各元素的值
         */
        public Matrix(double[,] value)
        {
            numRows = value.GetLength(0);
            numColumns = value.GetLength(1);
            double[] data = new double[numRows * numColumns];
            int k = 0;
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    data[k++] = value[i, j];
                }
            }
            Init(numRows, numColumns);
            SetData(data);
        }

        /**
         * 指定值构造函数
         * 
         * @param nRows - 指定的矩阵行数
         * @param nCols - 指定的矩阵列数
         * @param value - 一维数组，长度为nRows*nCols，存储矩阵各元素的值
         */
        public Matrix(int nRows, int nCols, double[] value)
        {
            numRows = nRows;
            numColumns = nCols;
            Init(numRows, numColumns);
            SetData(value);
        }

        /**
         * 方阵构造函数
         * 
         * @param nSize - 方阵行列数
         */
        public Matrix(int nSize)
        {
            numRows = nSize;
            numColumns = nSize;
            Init(nSize, nSize);
        }

        /**
         * 方阵构造函数
         * 
         * @param nSize - 方阵行列数
         * @param value - 一维数组，长度为nRows*nRows，存储方阵各元素的值
         */
        public Matrix(int nSize, double[] value)
        {
            numRows = nSize;
            numColumns = nSize;
            Init(nSize, nSize);
            SetData(value);
        }

        /**
         * 拷贝构造函数
         * 
         * @param other - 源矩阵
         */
        public Matrix(Matrix other)
        {
            numColumns = other.GetNumColumns();
            numRows = other.GetNumRows();
            Init(numRows, numColumns);
            SetData(other.elements);
        }

        /**
         * 初始化函数
         * 
         * @param nRows - 指定的矩阵行数
         * @param nCols - 指定的矩阵列数
         * @return bool, 成功返回true, 否则返回false
         */
        public bool Init(int nRows, int nCols)
        {
            numRows = nRows;
            numColumns = nCols;
            int nSize = nCols * nRows;
            if (nSize < 0)
                return false;

            // 分配内存
            elements = new double[nSize];

            return true;
        }

        /**
         * 设置矩阵运算的精度
         * 
         * @param newEps - 新的精度值
         */
        public void SetEps(double newEps)
        {
            eps = newEps;
        }

        /**
         * 取矩阵的精度值
         * 
         * @return double型，矩阵的精度值
         */
        public double GetEps()
        {
            return eps;
        }

        /**
         * 重载 + 运算符
         * 
         * @return Matrix对象
         */
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            return m1.Add(m2);
        }

        /**
         * 重载 - 运算符
         * 
         * @return Matrix对象
         */
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            return m1.Subtract(m2);
        }

        /**
         * 重载 * 运算符
         * 
         * @return Matrix对象
         */
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            return m1.Multiply(m2);
        }

        /**
         * 重载 double[] 运算符
         * 
         * @return double[]对象
         */
        public static implicit operator double[](Matrix m)
        {
            return m.elements;
        }
        /**
         * 将矩阵各元素的值转化为字符串, 元素之间的分隔符为",", 行与行之间有回车换行符
         * @return string 型，转换得到的字符串
         */
        public override string ToString()
        {
            return ToString(",", true);
        }

        /**
         * 将矩阵各元素的值转化为字符串
         * 
         * @param sDelim - 元素之间的分隔符
         * @param bLineBreak - 行与行之间是否有回车换行符
         * @return string 型，转换得到的字符串
         */
        public string ToString(string sDelim, bool bLineBreak)
        {
            string s = "";

            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    string ss = GetElement(i, j).ToString("F");
                    s += ss;

                    if (bLineBreak)
                    {
                        if (j != numColumns - 1)
                            s += sDelim;
                    }
                    else
                    {
                        if (i != numRows - 1 || j != numColumns - 1)
                            s += sDelim;
                    }
                }
                if (bLineBreak)
                    if (i != numRows - 1)
                        s += "\r\n";
            }

            return s;
        }

        /**
         * 将矩阵指定行中各元素的值转化为字符串
         * 
         * @param nRow - 指定的矩阵行，nRow = 0表示第一行
         * @param sDelim - 元素之间的分隔符
         * @return string 型，转换得到的字符串
         */
        public string ToStringRow(int nRow, string sDelim)
        {
            string s = "";

            if (nRow >= numRows)
                return s;

            for (int j = 0; j < numColumns; ++j)
            {
                string ss = GetElement(nRow, j).ToString("F");
                s += ss;
                if (j != numColumns - 1)
                    s += sDelim;
            }

            return s;
        }

        /**
         * 将矩阵指定列中各元素的值转化为字符串
         * 
         * @param nCol - 指定的矩阵行，nCol = 0表示第一列
         * @param sDelim - 元素之间的分隔符
         * @return string 型，转换得到的字符串
         */
        public string ToStringCol(int nCol, string sDelim /*= " "*/)
        {
            string s = "";

            if (nCol >= numColumns)
                return s;

            for (int i = 0; i < numRows; ++i)
            {
                string ss = GetElement(i, nCol).ToString("F");
                s += ss;
                if (i != numRows - 1)
                    s += sDelim;
            }

            return s;
        }
        /**
         * 设置矩阵各元素的值
         * 
         * @param value - 一维数组，长度为numColumns*numRows，存储
         *	              矩阵各元素的值
         */
        public void SetData(double[] value)
        {
            elements = (double[])value.Clone();
        }

        /**
         * 设置指定元素的值
         * 
         * @param nRow - 元素的行
         * @param nCol - 元素的列
         * @param value - 指定元素的值
         * @return bool 型，说明设置是否成功
         */
        public bool SetElement(int nRow, int nCol, double value)
        {
            if (nCol < 0 || nCol >= numColumns || nRow < 0 || nRow >= numRows)
                return false;						// array bounds error

            elements[nCol + nRow * numColumns] = value;

            return true;
        }

        /**
         * 获取指定元素的值
         * 
         * @param nRow - 元素的行
         * @param nCol - 元素的列
         * @return double 型，指定元素的值
         */
        public double GetElement(int nRow, int nCol)
        {
            return elements[nCol + nRow * numColumns];
        }

        /**
         * 获取矩阵的列数
         * 
         * @return int 型，矩阵的列数
         */
        public int GetNumColumns()
        {
            return numColumns;
        }

        /**
         * 获取矩阵的行数
         * @return int 型，矩阵的行数
         */
        public int GetNumRows()
        {
            return numRows;
        }

        /**
         * 获取矩阵的数据
         * 
         * @return double型数组，指向矩阵各元素的数据缓冲区
         */
        public double[] GetData()
        {
            return elements;
        }

        /**
         * 获取指定行的向量
         * 
         * @param nRow - 向量所在的行
         * @param pVector - 指向向量中各元素的缓冲区
         * @return int 型，向量中元素的个数，即矩阵的列数
         */
        public int GetRowVector(int nRow, double[] pVector)
        {
            for (int j = 0; j < numColumns; ++j)
                pVector[j] = GetElement(nRow, j);

            return numColumns;
        }

        /**
         * 获取指定列的向量
         * 
         * @param nCol - 向量所在的列
         * @param pVector - 指向向量中各元素的缓冲区
         * @return int 型，向量中元素的个数，即矩阵的行数
         */
        public int GetColVector(int nCol, double[] pVector)
        {
            for (int i = 0; i < numRows; ++i)
                pVector[i] = GetElement(i, nCol);

            return numRows;
        }

        /**
         * 给矩阵赋值
         * 
         * @param other - 用于给矩阵赋值的源矩阵
         * @return Matrix型，阵与other相等
         */
        public Matrix SetValue(Matrix other)
        {
            if (other != this)
            {
                Init(other.GetNumRows(), other.GetNumColumns());
                SetData(other.elements);
            }

            // finally return a reference to ourselves
            return this;
        }
        /**
         * 判断矩阵否相等
         * 
         * @param other - 用于比较的矩阵
         * @return bool 型，两个矩阵相等则为true，否则为false
         */
        public override bool Equals(object other)
        {
            Matrix matrix = other as Matrix;
            if (matrix == null)
                return false;

            // 首先检查行列数是否相等
            if (numColumns != matrix.GetNumColumns() || numRows != matrix.GetNumRows())
                return false;

            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    if (Math.Abs(GetElement(i, j) - matrix.GetElement(i, j)) > eps)
                        return false;
                }
            }

            return true;
        }

        /**
         * 因为重写了Equals，因此必须重写GetHashCode
         * 
         * @return int型
         */
        public override int GetHashCode()
        {
            double sum = 0;
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                {
                    sum += Math.Abs(GetElement(i, j));
                }
            }
            return (int)Math.Sqrt(sum);
        }
        /**
         * 实现矩阵的加法
         * 
         * @param other - 与指定矩阵相加的矩阵
         * @return Matrix型，指定矩阵与other相加之和
         * @如果矩阵的行/列数不匹配，则会抛出异常
         */
        public Matrix Add(Matrix other)
        {
            // 首先检查行列数是否相等
            if (numColumns != other.GetNumColumns() ||
                numRows != other.GetNumRows())
                throw new Exception("矩阵的行/列数不匹配。");

            // 构造结果矩阵
            Matrix result = new Matrix(this);		// 拷贝构造

            // 矩阵加法
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                    result.SetElement(i, j, result.GetElement(i, j) + other.GetElement(i, j));
            }

            return result;
        }

        /**
         * 实现矩阵的减法
         * 
         * @param other - 与指定矩阵相减的矩阵
         * @return Matrix型，指定矩阵与other相减之差
         * @如果矩阵的行/列数不匹配，则会抛出异常
         */
        public Matrix Subtract(Matrix other)
        {
            if (numColumns != other.GetNumColumns() ||
                numRows != other.GetNumRows())
                throw new Exception("矩阵的行/列数不匹配。");

            // 构造结果矩阵
            Matrix result = new Matrix(this);		// 拷贝构造

            // 进行减法操作
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                    result.SetElement(i, j, result.GetElement(i, j) - other.GetElement(i, j));
            }

            return result;
        }

        /**
         * 实现矩阵的数乘
         * 
         * @param value - 与指定矩阵相乘的实数
         * @return Matrix型，指定矩阵与value相乘之积
         */
        public Matrix Multiply(double value)
        {
            // 构造目标矩阵
            Matrix result = new Matrix(this);		

            // 进行数乘
            for (int i = 0; i < numRows; ++i)
            {
                for (int j = 0; j < numColumns; ++j)
                    result.SetElement(i, j, result.GetElement(i, j) * value);
            }

            return result;
        }

        /**
         * 实现矩阵的乘法
         * 
         * @param other - 与指定矩阵相乘的矩阵
         * @return Matrix型，指定矩阵与other相乘之积
         * @如果矩阵的行/列数不匹配，则会抛出异常
         */
        public Matrix Multiply(Matrix other)
        {
            // 首先检查行列数是否符合要求
            if (numColumns != other.GetNumRows())
                throw new Exception("矩阵的行/列数不匹配。");

            // ruct the object we are going to return
            Matrix result = new Matrix(numRows, other.GetNumColumns());

            
            double value;
            for (int i = 0; i < result.GetNumRows(); ++i)
            {
                for (int j = 0; j < other.GetNumColumns(); ++j)
                {
                    value = 0.0;
                    for (int k = 0; k < numColumns; ++k)
                    {
                        value += GetElement(i, k) * other.GetElement(k, j);
                    }

                    result.SetElement(i, j, value);
                }
            }

            return result;
        }
        //从TextBox读取数据
        public bool ReadAndCheckMatrix(TextBox textBox)
        {
            string[] arr = new string[textBox.Lines.Length];
            for (int i = 0; i < textBox.Lines.Length; i++)
            {
                //arr的每一行就是原始输入的每一行
                arr[i] = textBox.Lines[i];
            }
            string[] tem = arr[0].Split();
            Init(tem.Length, textBox.Lines.Length);
            numColumns = tem.Length;
            numRows = textBox.Lines.Length;
            for (int i = 0; i < numRows; i++)
            {
                string[] temp = arr[i].Split();
                if (temp.Length != numColumns)
                {
                    return false;
                }
                for (int j = 0; j < numColumns; j++)
                {
                    SetElement(i, j, Convert.ToInt32(temp[j]));
                }
            }
            return true;
        }
        //将矩阵写入文本框
        static public bool WriteMatrix(TextBox textBox, Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    textBox.Text += matrix[i, j].ToString();
                    textBox.Text += " ";
                }
                textBox.Text += "\r\n";
            }
            return true;
        }
        //将矩阵写入文件
        public bool WriteMatrixToFile(String path, Matrix matrix)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    sw.Write(matrix[i, j].ToString() + " ");
                }
                sw.WriteLine();
            }
            sw.Flush();
            sw.Close();
            sw.Dispose();
            return true;
        }
    }
}
