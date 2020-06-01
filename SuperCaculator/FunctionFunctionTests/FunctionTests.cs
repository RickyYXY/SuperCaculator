using Microsoft.VisualStudio.TestTools.UnitTesting;
using Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function.FunctionTests
{
    [TestClass()]
    public class FunctionTests
    {
        string testExp1 = "exp(sin(x^3)+cos(ln(x)))-3.14";
        string testExp2 = "tan(x*5!)-tan(x*3!)*2";
        string testExp3 = "1/x+1/(x^2)+1/(x^3)-0.618";
        string testExp4 = "sin(x)*sin(y)-x*y";

        double TestFunction1(double x)
        {
            return Math.Exp(Math.Sin(Math.Pow(x, 3)) + Math.Cos(Math.Log(x, Math.E))) - 3.14;
        }
        double TestFunction2(double x)
        {
            return Math.Tan(x * Function.Factorial(5)) - Math.Tan(x * Function.Factorial(3)) * 2;
        }
        double TestFunction3(double x)
        {
            return 1 / x + 1 / Math.Pow(x, 2) + 1 / Math.Pow(x, 3) - 0.618;
        }
        double TestFunction4(double x, double y)
        {
            return Math.Sin(x) * Math.Sin(y) - x * y;
        }

        [TestMethod()]
        public void GetValueTest1()
        {
            Function function = new Function(testExp1);
            for (int i = 1; i <= 100; i++)
            {
                if (function.GetValue(i) != TestFunction1(i))
                    Assert.Fail();
            }
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetValueTest2()
        {
            Function function = new Function(testExp2);
            for (int i = 1; i <= 100; i++)
            {
                if (function.GetValue(i) != TestFunction2(i))
                    Assert.Fail();
            }
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetValueTest3()
        {
            Function function = new Function(testExp3);
            for (int i = 1; i <= 100; i++)
            {
                if (function.GetValue(i) != TestFunction3(i))
                    Assert.Fail();
            }
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void GetValueTest4()
        {
            Function function = new Function(testExp4);
            for (int i = 1; i <= 100; i++)
            {
                if (function.GetValue(i, i + 1) != TestFunction4(i, i + 1))
                    Assert.Fail();
            }
            Assert.IsTrue(true);
        }
    }


}