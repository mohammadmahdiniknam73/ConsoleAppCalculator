using System;

namespace Session02_CleanCodePrinciples.Sample01.Validators
{
    public class Validator
    {
        public bool ValidateNumber(string input)
        {
            bool result = false;
            if (int.TryParse(input, out int firstNumber))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public bool ValidateOprationSign(string input)
        {
            bool result = false;
            char[] allowedOperators = { '*', '/', '+', '-' };

            if (input.Length == 1 && Array.Exists(allowedOperators, element => element == input[0]))
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
