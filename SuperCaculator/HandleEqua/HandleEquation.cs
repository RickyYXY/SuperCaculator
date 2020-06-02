using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleEqua
{
    public class HandleEquation
    {
        public static bool IsGeneralOp(char operation)
        {
            if (operation == '+'
                || operation == '-'
                || operation == '×'
                || operation == '÷'
                || operation == '*'
                || operation == '/') return true;
            else return false;
        }

        public static string GetLastUnit(string equation)
        {
            if (equation == "") return "";
            if (equation.Length == 1) return equation;

            int startLocation = 0;
            
            for (int i = equation.Length-1; i >=0; i--)
            {
                if (IsGeneralOp(equation[i])&&i!=equation.Length-1)
                {
                    startLocation = i + 1;
                    break;
                }
            }
            return equation.Substring(startLocation, equation.Length - startLocation);            
        }

        public static string RemoveLastUnit(string equation)
        {
            if (equation == "") return "";
            if (equation.Length == 1) return "";

            int subLength = 0;
           
            for (int i = equation.Length-1 ; i >=0; i--)
            {
                if (IsGeneralOp(equation[i])&&i!=equation.Length-1)
                {
                    subLength = i+1;
                    break;
                }
            }
            return equation.Substring(0, subLength);            
        }
    }
}
