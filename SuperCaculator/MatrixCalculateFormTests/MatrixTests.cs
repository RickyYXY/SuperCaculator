using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixCalculateForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalculateForm.Tests
{ 
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod()]
        public void GetDataTest()
        {
            double[] value1 = new double[6] { 1, 2, 3, 4, 5, 6 };
            //这一步已经包含setData
            //这一步已经包含Init
            Matrix matrix1 = new Matrix(3, 2, value1);
            double[,] value2 = new double[2, 2] { { 2, 2 }, { 2, 2 } };
            Matrix matrix2 = new Matrix(value2);
            double[,] value3 = new double[2, 2] { { 1, 1 }, { 1, 1 } };
            Matrix matrix3 = new Matrix(value3);
            double[] value4 = new double[6] { 1, 2, 3, 4, 5, 6 };
            double[] value5 = matrix1.GetData();
            Assert.AreEqual(value4, value5);
        }


        [TestMethod()]
        public void GetColVectorTest()
        {
            double[] value1 = new double[6] { 1, 2, 3, 4, 5, 6 };
            //这一步已经包含setData
            //这一步已经包含Init
            Matrix matrix1 = new Matrix(3, 2, value1);
            double[,] value2 = new double[2, 2] { { 2, 2 }, { 2, 2 } };
            Matrix matrix2 = new Matrix(value2);
            double[,] value3 = new double[2, 2] { { 1, 1 }, { 1, 1 } };
            Matrix matrix3 = new Matrix(value3);
            double[] value6 = new double[3] { 1, 3, 5 };
            double[] target = new double[3];
            matrix1.GetColVector(0, target);
            Assert.AreEqual(value6, target);
        }

        [TestMethod()]
        public void AddTest()
        {
            double[] value1 = new double[6] { 1, 2, 3, 4, 5, 6 };
            //这一步已经包含setData
            //这一步已经包含Init
            Matrix matrix1 = new Matrix(3, 2, value1);
            double[,] value2 = new double[2, 2] { { 2, 2 }, { 2, 2 } };
            Matrix matrix2 = new Matrix(value2);
            double[,] value3 = new double[2, 2] { { 1, 1 }, { 1, 1 } };
            Matrix matrix3 = new Matrix(value3);
            Matrix matrix = new Matrix(new double[2, 2] { { 3, 3 }, { 3, 3 } });
            Matrix result = matrix2.Add(matrix3);
            Assert.AreEqual(matrix, result);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double[] value1 = new double[6] { 1, 2, 3, 4, 5, 6 };
            //这一步已经包含setData
            //这一步已经包含Init
            Matrix matrix1 = new Matrix(3, 2, value1);
            double[,] value2 = new double[2, 2] { { 2, 2 }, { 2, 2 } };
            Matrix matrix2 = new Matrix(value2);
            double[,] value3 = new double[2, 2] { { 1, 1 }, { 1, 1 } };
            Matrix matrix3 = new Matrix(value3);
            Matrix matrix = new Matrix(new double[2, 2] { { 1, 1 }, { 1, 1 } });
            Matrix result = matrix2.Subtract(matrix3);
            Assert.AreEqual(matrix, result);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double[] value1 = new double[6] { 1, 2, 3, 4, 5, 6 };
            //这一步已经包含setData
            //这一步已经包含Init
            Matrix matrix1 = new Matrix(3, 2, value1);
            double[,] value2 = new double[2, 2] { { 2, 2 }, { 2, 2 } };
            Matrix matrix2 = new Matrix(value2);
            double[,] value3 = new double[2, 2] { { 1, 1 }, { 1, 1 } };
            Matrix matrix3 = new Matrix(value3);
            Matrix matrix = new Matrix(new double[3, 2] { { 6, 6 }, { 14, 14 }, { 22, 22 } });
            Matrix result = matrix1.Multiply(matrix2);
            Assert.AreEqual(matrix, result);
        }

    }
}