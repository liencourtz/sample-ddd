using Microsoft.Extensions.DependencyInjection;
using Sample.Ddd.Console.Infrastructure;
using Sample.Ddd.Service.Services.Interfaces;
using Sample_Ddd_Aplication;

namespace Sample.Ddd.Console
{
    public class Program
    {
        public static int Main(string[] args)//1
        {
            ServiceCollection services = new ServiceCollection();//2
            ConfigurationService.ConfigureServices(services);//3
            var inject = services.BuildServiceProvider();//4
            BusinessIntegration integration = new BusinessIntegration(inject.GetService<ISampleService>());//5
            var result = integration.BusinessIntegrationTeste();//6
            System.Console.WriteLine(result);//7
            return 0;//8
        }
    }
}
