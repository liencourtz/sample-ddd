using Sample.Ddd.Domain.Repositories;
using Sample.Ddd.Service.Services.Interfaces;

namespace Sample.Ddd.Service.Services
{
    public class SampleService : ISampleService //1
    {
        private readonly ISampleRepository _SampleRepository; //2

        public SampleService(ISampleRepository sampleRepository) //3
        { 
            _SampleRepository = sampleRepository;
        }

        public string TestInterface(string interfaceName) //4
        {
            var TesteInterface = _SampleRepository.SampleTestInterface(interfaceName);
            return TesteInterface;
        }
    }
}
