using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Session02_CleanCodePrinciples.Sample01.CalculatorComponents.Services;
using Session02_CleanCodePrinciples.Sample01.Validators;
using System;
namespace Session02_CleanCodePrinciples.Sample01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // Resolve the service and run the application
            var calculatorService = host.Services.GetRequiredService<ICallService>();
            calculatorService.CallCalculator();
            
        }
        static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((_, services) =>
                services.AddTransient<IOprationService, OprationService>()
                        .AddTransient<ICalculatorService, CalculatorService>()
                        .AddTransient<ICallService, CallService>()
                        .AddTransient<Validator>());
    }
}
