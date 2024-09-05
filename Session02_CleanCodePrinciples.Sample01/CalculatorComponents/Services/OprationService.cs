using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Entities;

namespace Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Services
{
    public class OprationService : IOprationService
    {
        public int Multiplication(ObjectToCalculate calculator)
        {
            int result;
            result = calculator.FirstNumber * calculator.SecoundNumber;
            return result;
        }
        public int Divide(ObjectToCalculate calculator)
        {
            int result;
            result = calculator.FirstNumber / calculator.SecoundNumber;
            return result;
        }
        public int Sum(ObjectToCalculate calculator)
        {
            int result;
            result = calculator.FirstNumber + calculator.SecoundNumber;
            return result;
        }
        public int Subtraction(ObjectToCalculate calculator)
        {
            int result;
            result = calculator.FirstNumber - calculator.SecoundNumber;
            return result;
        }
    }
}
