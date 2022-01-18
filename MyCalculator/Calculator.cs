using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal class Calculator : ICalculator
    {
        public int divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int minus(int num1, int num2)
        {
            return num1 - num2;
        }

        public int multiple(int num1, int num2)
        {
            return num1 * num2;
        }

        public int plus(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
