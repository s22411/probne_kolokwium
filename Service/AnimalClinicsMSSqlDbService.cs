using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Models;
using Models.DTOs;

namespace Service
{
    public class AnimalClinicsMSSqlDbService : IAnimalClinicsMSSqlDbService
    {
        private readonly string _connectionStringName = "ConnectionString";
        private readonly IConfiguration _configuration;

        public AnimalClinicsMSSqlDbService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task<bool> AddAnimalAsync(Animal animal)
        {
            
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<AnimalsGET>> GetAnimalsAsync(string sortBy)
        {
            if (sortBy is null || sortBy == "") sortBy = "Name";

            try
            {
                using(var con = new SqlConnection(GetConnectionString()))
                {
                    con.Open();

                    var cmd = new SqlCommand($"SELECT Name, Type, AdmissionDate, LastName FROM Animal a JOIN Owner o ON a.IdOwner = O.IdOwner ORDER BY {sortBy}", con);

                    var result = new List<AnimalsGET>();
                    var reader = await cmd.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        result.Add(new AnimalsGET
                        {
                            Name = reader["Name"].ToString(),
                            AnimalType = reader["Type"].ToString(),
                            DateOfAdmission = DateTime.Parse(reader["AdmissionDate"].ToString()),
                            LastNameOfOwner = reader["LastName"].ToString()
                        });
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetConnectionString()
        {
            return _configuration.GetConnectionString(_connectionStringName);
        }

    }
}