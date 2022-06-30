using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Service
{
    public class CalculatorService
    {
        public int Add(object a, object b)
        {
            return (int)a + (int)b;
        }

        public int Subtract(int a, int b)
        { 
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
