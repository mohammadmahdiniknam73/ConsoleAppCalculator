using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Entities;
using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Services;
using Session02_CleanCodePrinciples.Sample01.Validators;
using System;

namespace Session02_CleanCodePrinciples.Sample01
{
    public class CallService : ICallService
    {
        private readonly ICalculatorService _calculatorService;
        private readonly Validator _validator;
        public CallService(ICalculatorService calculatorService, Validator validator = null)
        {
            _calculatorService = calculatorService;
            _validator = validator;
        }
        public void CallCalculator()
        {
            int firstNumber = GetValidatedNumber("Please Enter a Number:");
            if (firstNumber == int.MinValue)
            {
                Console.WriteLine("Calculation failed"); 
            }

            char operatorInput = GetValidatedOperator("Please Enter your operation sign (*, /, +, -):");
            if (operatorInput == char.MinValue)
            {
                Console.WriteLine("Calculation failed");
            }

            int secondNumber = GetValidatedNumber("Please Enter another Number:");
            if (secondNumber == int.MinValue)
            {
                Console.WriteLine("Calculation failed");
            }

            ObjectToCalculate objectToCalculate = new ObjectToCalculate
            {
                FirstNumber = firstNumber,
                OperationSign = operatorInput,
                SecoundNumber = secondNumber
            };

            string calculatedResult = _calculatorService.Calculator(objectToCalculate);
            Console.WriteLine($"Your result= {calculatedResult}");
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        private int GetValidatedNumber(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            int number = int.MinValue;
            if (_validator.ValidateNumber(input) == true)
            {
                number = int.Parse(input);
            }
            else
            {
                GetValidatedNumber("Invalid input. Please enter a valid number.");
            }
            return number;
        }

        private char GetValidatedOperator(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            char InputToChar = char.Parse(input);
            char oprator = char.MinValue;
            if (_validator.ValidateOprationSign(input) == true)
            {
                oprator = InputToChar;
            }
            else
            {
                GetValidatedOperator("Invalid input. Please enter a valid operation sign (*, /, +, -).");
            }
            return oprator;
        }
    }
}
