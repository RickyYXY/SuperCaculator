using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static string ChangeToNega(string tail)
        {
            if (tail.Length < 2)
            {
                return "(-" + tail + ")";
            }
            else if (tail[0] == '-' )
            {
                return tail.Substring(1, tail.Length - 1);
            }
            else
            {
                return "(-" + tail + ")";
            }
        }

        public static string RemoveFrontZero(string number)
        {
            int i=0;
            while ( i < number.Length)
            {
                if (number[i] != '0')
                {
                    break;
                }
                i++;
            }
            return number.Substring(i, number.Length-1);
        }

        public static string GetLastUnit(string equation)
        {
            if (equation == "") return "";
            if (equation.Length == 1) return equation;

            int startLocation = 0;
            int bktCount = 0;
            
            for (int i = equation.Length-1; i >=0; i--)
            {
                if (equation[i] == ')')
                {
                    bktCount++;
                }
                if (equation[i] == '(')
                {
                    bktCount--;
                }
                if (IsGeneralOp(equation[i])&&i!=equation.Length-1&&bktCount==0)
                {
                    startLocation = i + 1;
                    break;
                }
            }

            string result= equation.Substring(startLocation, equation.Length - startLocation);
            if (result[0] == '(' && result.Last() == ')')
            {
                result = result.Substring(1, result.Length - 2);
            }
            if (result.Length== 0)
            {
                result = "0";
            }
            return result;            
        }

        public static string RemoveLastUnit(string equation)
        {
            if (equation == "") return "";
            if (equation.Length == 1) return "";

            int subLength = 0;
            int bktCount = 0;

            for (int i = equation.Length-1 ; i >=0; i--)
            {
                if (equation[i] == ')')
                {
                    bktCount++;
                }
                if (equation[i] == '(')
                {
                    bktCount--;
                }
                if (IsGeneralOp(equation[i])&&i!=equation.Length-1 && bktCount == 0)
                {
                    subLength = i+1;
                    break;
                }
            }
            return equation.Substring(0, subLength);            
        }
    }
}
