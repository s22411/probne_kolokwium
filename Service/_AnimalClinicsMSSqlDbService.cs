using Microsoft.Extensions.Configuration;

namespace Service
{
    public class AnimalClinicsMSSqlDbService
    {
        private readonly IConfiguration _configuration;

        public AnimalClinicsMSSqlDbService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetConnectionString()
        {
            return _configuration.GetConnectionString("DefaultConnection");
        }

    }
}