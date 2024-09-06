using Microsoft.Extensions.DependencyInjection;
using Sample.Ddd.Service.Services.Interfaces;
using Sample_Ddd_Aplication;

namespace Sample.Ddd.Console
{
    public class Program
    {
        public static int Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            var inject = services.BuildServiceProvider();
            BusinessIntegration integration = new BusinessIntegration(inject.GetService<ISampleService>());
            var result = integration.BusinessIntegrationTeste();
            System.Console.WriteLine(result);
            return 0;
        }
    }
}
