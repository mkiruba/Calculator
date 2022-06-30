namespace WebApplication1.Serivce
{
    public interface ICalculatorService
    {
        int Add(object a, object b);
        int Divide(int a, int b);
        int Multiply(int a, int b);
        int Subtract(int a, int b);
    }
}