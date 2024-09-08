using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Entities;

namespace Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IOprationService _oprationService;
        public CalculatorService(IOprationService oprationService)
        {
            _oprationService = oprationService;
        }
        public string Calculator(ObjectToCalculate calculator)
        {
            string result = string.Empty;
            int resultNumber;
            switch (calculator.OperationSign)
            {
                case OprationSign.MULTIPLICATION:
                    resultNumber = _oprationService.Multiplication(calculator);
                    result = resultNumber.ToString();
                    break;
                case OprationSign.DIVIDE:
                    resultNumber = _oprationService.Divide(calculator);
                    result = resultNumber.ToString();
                    break;
                case OprationSign.SUM:
                    resultNumber = _oprationService.Sum(calculator);
                    result = resultNumber.ToString();
                    break;
                case OprationSign.SUBTRACTION:
                    resultNumber = _oprationService.Subtraction(calculator);
                    result = resultNumber.ToString();
                    break;
                default:
                    result = string.Empty;
                    break;
            }

            return result;
        }
    }
}
