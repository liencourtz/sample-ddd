using Sample.Ddd.Service.Services.Interfaces;

namespace Sample_Ddd_Aplication
{
    public class BusinessIntegration
    {
        private readonly ISampleService _service; //1

        public BusinessIntegration(ISampleService service) //2
        {
            _service = service;
        }

        public string BusinessIntegrationTeste()//3
        {
            var teste = _service.TestInterface("Teste App");
            return teste;
        }
    }
}
