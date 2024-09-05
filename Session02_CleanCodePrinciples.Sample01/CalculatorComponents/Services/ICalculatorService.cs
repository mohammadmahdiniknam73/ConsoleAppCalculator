using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Services
{
    public interface ICalculatorService
    {
        string Calculator(ObjectToCalculate calculator);
    }
}
