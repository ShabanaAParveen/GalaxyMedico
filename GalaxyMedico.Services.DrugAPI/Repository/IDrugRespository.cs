using GalaxyMedico.Services.DrugAPI.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.DrugAPI.Repository
{
    public interface IDrugRespository
    {
        Task<IEnumerable<DrugDto>> GetDrugs();
        Task<DrugDto> GetDrugById(int drugId);

        Task<DrugDto> CreateUpdateDrug(DrugDto drugDto);

        Task<bool> DeleteDrug(int drugId);
    }
}
