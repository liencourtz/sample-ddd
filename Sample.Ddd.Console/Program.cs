using Microsoft.Extensions.DependencyInjection;
using Sample.Ddd.Service.Services.Interfaces;
using Sample_Ddd_Aplication;

namespace Sample.Ddd.Console
{
    public class Program
    {
        static string Main()
        {
            ServiceCollection services = new ServiceCollection();
            var inject = services.BuildServiceProvider();
            BusinessIntegration integration = new BusinessIntegration(inject.GetService<ISampleService>());
            var result = integration.BusinessIntegrationTeste();
            System.Console.WriteLine(result);
            return result;
        }


    }
}
