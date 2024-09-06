using Microsoft.Extensions.DependencyInjection;
using Sample.Ddd.Data.Repositories;
using Sample.Ddd.Domain.Repositories;
using Sample.Ddd.Service.Services;
using Sample.Ddd.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Ddd.Console.Infrastructure
{
    internal class ConfigurationService
    {
        public static void ConfigureServices(IServiceCollection services) { //1

            //service
            services.AddTransient<ISampleService, SampleService>();//2

            //repository/data
            services.AddTransient<ISampleRepository, SampleRepository>();//3
        }
    }
}
