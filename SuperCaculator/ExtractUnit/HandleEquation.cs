using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExtractUnit
{
    public class HandleEquation
    {
        public static bool IsGeneralOp(char operation)
        {
            if (   operation == '+'
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
            int startLocation=0;

            if(IsGeneralOp(equation.Last()))
            {
                for(int i = equation.Length - 1; i > 0; i--)
                {
                    if (IsGeneralOp(equation[i]))
                    {
                        startLocation = i + 1;
                        continue;
                    }
                }
                return equation.Substring(startLocation, equation.Length - startLocation-1);
            }
            else
            {
                for (int i = equation.Length - 1; i > 0; i--)
                {
                    if (IsGeneralOp(equation[i]))
                    {
                        startLocation = i + 1;
                        continue;
                    }
                }
                return equation.Substring(startLocation, equation.Length - startLocation);
            }
        }

        public static string RemoveLastUnit(string equation)
        {
            if (equation == "") return "";
            int subLength = 0;

            if (IsGeneralOp(equation.Last()))
            {
                for (int i = equation.Length - 1; i > 0; i--)
                {
                    if (IsGeneralOp(equation[i]))
                    {
                        subLength = i;
                        continue;
                    }
                }
                return equation.Substring(0, subLength);
            }
            else
            {
                for (int i = equation.Length - 1; i > 0; i--)
                {
                    if (IsGeneralOp(equation[i]))
                    {
                        subLength = i;
                        continue;
                    }
                }
                return equation.Substring(subLength,subLength);
            }
        }
    }
}
