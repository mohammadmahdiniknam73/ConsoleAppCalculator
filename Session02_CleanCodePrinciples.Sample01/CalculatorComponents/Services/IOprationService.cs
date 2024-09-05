using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Entities;

namespace Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Services
{
    public interface IOprationService
    {
        int Multiplication(ObjectToCalculate calculator);
        int Divide(ObjectToCalculate calculator);
        int Sum(ObjectToCalculate calculator);
        int Subtraction(ObjectToCalculate calculator);
    }
}
