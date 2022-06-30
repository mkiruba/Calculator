using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Serivce;

public class CalculatorService : ICalculatorService
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
