using Sample.Ddd.Domain.Repositories;

namespace Sample.Ddd.Data.Repositories
{
    public class SampleRepository : ISampleRepository
    {
        public string SampleTestInterface(string interfaceName)
        {
            var teste1 = "Sucesso Repos";
            return teste1;
        }
    }
}
