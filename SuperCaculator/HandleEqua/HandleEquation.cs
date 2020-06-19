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

        public static bool IsLeftOp(char operation)
        {
            if (operation == '('
                || operation == '⌊'
                || operation == '⌈') return true;
            else return false;
        }

        public static bool IsRightOp(char operation)
        {
            if (operation == ')'
                || operation == '⌋'
                || operation == '⌉') return true;
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
            return number.Substring(i, number.Length-i);
        }

        public static string GetLastUnit(string equation)
        {
            if (equation == "") return "";
            if (equation.Length == 1) return equation;

            int startLocation = 0;
            int bktCount = 0;
            int absCount = 0;
            int ceilCount = 0;
            int floorCount = 0;
            
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
                if (equation[i] == '⌊')
                {
                    floorCount++;
                }
                if (equation[i] == '⌋')
                {
                    floorCount--;
                }
                if (equation[i] == '⌈')
                {
                    ceilCount++;
                }
                if (equation[i] == '⌉')
                {
                    ceilCount--;
                }
                if (equation[i] == '|')
                {
                    if (i == 0)
                    {
                        absCount--;
                    }
                    else if (char.IsNumber(equation[i - 1]))
                    {
                        absCount++;
                    }
                    else
                    {
                        absCount--;
                    }
                }
                
                if (IsGeneralOp(equation[i])
                    && i!=equation.Length-1
                    && bktCount==0
                    && ceilCount==0
                    && floorCount==0
                    && absCount==0)
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
            int bktCount=0,ceilCount=0,floorCount=0,absCount = 0;

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
                if (equation[i] == '⌊')
                {
                    floorCount++;
                }
                if (equation[i] == '⌋')
                {
                    floorCount--;
                }
                if (equation[i] == '⌈')
                {
                    ceilCount++;
                }
                if (equation[i] == '⌉')
                {
                    ceilCount--;
                }
                if (equation[i] == '|')
                {
                    if (i == 0)  //左边的绝对值符
                    {
                        absCount--;
                    }
                    else if (i == equation.Length - 1 ) //算式最后一个符号为绝对值符时，必然是右边的绝对值符
                    {
                        absCount++;
                    }
                    else if ( IsGeneralOp(equation[i - 1])|| char.IsNumber(equation[i + 1])
                        ||IsLeftOp(equation[i + 1]) || IsLeftOp(equation[i - 1]))  //左边的绝对值符
                    {
                        absCount--;
                    }
                    else if ( char.IsNumber(equation[i - 1])|| IsGeneralOp(equation[i + 1]) 
                        || IsRightOp(equation[i + 1]) || IsRightOp(equation[i - 1]))
                    {
                        absCount++;
                    }                    
                    else
                    {
                        absCount++;   
                    }
                }
                if (IsGeneralOp(equation[i])
                    &&i!=equation.Length-1 
                    && bktCount == 0 
                    && ceilCount == 0
                    && floorCount == 0
                    && absCount == 0)
                {
                    subLength = i+1;
                    break;
                }
            }
            return equation.Substring(0, subLength);            
        }
    }
}
