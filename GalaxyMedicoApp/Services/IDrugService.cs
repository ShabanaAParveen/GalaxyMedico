using GalaxyMedicoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Services
{
    public interface IDrugService
    {
        Task<T> GetAllDrugsAsync<T>(string token);
        Task<T> GetDrugByIdAsync<T>(int id, string token);
        Task<T> CreateDrugAsync<T>(DrugDto drugDto, string token);
        Task<T> UpdateDrugAsync<T>(DrugDto drugDto, string token);
        Task<T> DeleteDrugAsync<T>(int id,string token);

    }
}
