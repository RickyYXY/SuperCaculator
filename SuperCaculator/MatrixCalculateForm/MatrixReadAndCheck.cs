using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatrixCalculateForm
{
    class MatrixReadAndCheck : Matrix
    {
        //从TextBox读取数据
        //public bool ReadAndCheckMatrix(TextBox textBox)
        //{
        //    string[] arr = new string[textBox.Lines.Length];
        //    for(int i = 0; i < textBox.Lines.Length; i++)
        //    {
        //        //arr的每一行就是原始输入的每一行
        //        arr[i] = textBox.Lines[i];
        //    }
        //    string[] tem = arr[0].Split();
        //    Init(tem.Length, textBox.Lines.Length);
        //    numColumns = tem.Length;
        //    numRows = textBox.Lines.Length;
        //    for(int i = 0; i < numRows; i++)
        //    {
        //        string[] temp = arr[i].Split();
        //        if(temp.Length != numColumns)
        //        {
        //            return false;
        //        }
        //        for (int j = 0; j < numColumns; j++)
        //        {
        //            SetElement(i, j, Convert.ToInt32(temp[j]));
        //        }
        //    }
        //    return true;
        //}
        ////将矩阵写入文本框
        //public bool WriteMatrix(TextBox textBox, Matrix matrix)
        //{
        //    for(int i = 0; i < matrix.Rows; i++)
        //    {
        //        for(int j = 0; j < matrix.Columns; j++)
        //        {
        //            textBox.Text += matrix[i, j].ToString();
        //            textBox.Text += " ";
        //        }
        //        textBox.Text += "\r\n";
        //    }
        //    return true;
        //}
        ////将矩阵写入文件
        //public bool WriteMatrixToFile(String path, Matrix matrix)
        //{
        //    FileStream fs = new FileStream(path, FileMode.Create);
        //    StreamWriter sw = new StreamWriter(fs);
        //    for(int i = 0; i < matrix.Rows; i++)
        //    {
        //        for(int j = 0; j < matrix.Columns; j++)
        //        {
        //            sw.Write(matrix[i, j].ToString() + " ");
        //        }
        //        sw.WriteLine();
        //    }
        //    sw.Flush();
        //    sw.Close();
        //    sw.Dispose();
        //    return true;
        //}
    }
}
