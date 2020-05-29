using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalculateForm
{
    class MatrixReadAndCheck : Matrix
    {
        //从TextBox读取数据
        public bool ReadAndCheckMatrix(TextBox textBox)
        {
            string[] arr = new string[textBox.Lines.Length];
            for(int i = 0; i < textBox.Lines.Length; i++)
            {
                //arr的每一行就是原始输入的每一行
                arr[i] = textBox.Lines[i];
            }
            string[] tem = arr[0].Split();
            numColumns = tem.Length;
            numRows = textBox.Lines.Length;
            for(int i = 0; i < numRows; i++)
            {
                string[] temp = arr[i].Split();
                if(temp.Length != numColumns)
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

    }
}
