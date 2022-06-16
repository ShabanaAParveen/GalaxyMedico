using AutoMapper;
using GalaxyMedico.Services.DrugAPI.DbContexts;
using GalaxyMedico.Services.DrugAPI.Models;
using GalaxyMedico.Services.DrugAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyMedico.Services.DrugAPI.Repository
{
    public class DrugRepository : IDrugRespository
    {
        private readonly ApplicationContext _db;
        private IMapper _mapper;

        public DrugRepository(ApplicationContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<DrugDto> CreateUpdateDrug(DrugDto drugDto)
        {
            Drug drug = _mapper.Map<DrugDto, Drug>(drugDto);
            if(drug!=null && drug.DrugId>0)
            {
                _db.Drugs.Update(drug);
            }
            else
            {
                _db.Add(drug);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Drug,DrugDto>(drug);
        }

        public async Task<bool> DeleteDrug(int drugId)
        {
            try
            {
                Drug drug = await _db.Drugs.Where(x => x.DrugId == drugId).FirstOrDefaultAsync();
                if (drug == null) { return false; }
                _db.Remove(drug);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<DrugDto> GetDrugById(int drugId)
        {
            Drug drug = await _db.Drugs.Where(x=>x.DrugId==drugId).FirstOrDefaultAsync();
            return _mapper.Map<DrugDto>(drug);
        }

        public async Task<IEnumerable<DrugDto>> GetDrugs()
        {
            IEnumerable<Drug> drugList = await _db.Drugs.ToListAsync();
            return _mapper.Map<List<DrugDto>>(drugList);
        }
    }
}
