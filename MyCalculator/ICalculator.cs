using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    internal interface ICalculator
    {
        int plus(int num1 , int num2);
        int minus(int num1, int num2);
        int multiple(int num1, int num2);
        int divide(int num1, int num2);
    }
}
