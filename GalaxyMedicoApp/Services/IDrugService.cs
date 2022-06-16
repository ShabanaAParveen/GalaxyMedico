using GalaxyMedicoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedicoApp.Services
{
    public interface IDrugService
    {
        Task<T> GetAllDrugsAsync<T>();
        Task<T> GetDrugByIdAsync<T>(int id);
        Task<T> CreateDrugAsync<T>(DrugDto drugDto);
        Task<T> UpdateDrugAsync<T>(DrugDto drugDto);
        Task<T> DeleteDrugAsync<T>(int id);

    }
}
