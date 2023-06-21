using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class DavolanishJadvaliService : IDavolanishJadvaliService
    {
        IDavolanishJadvaliRepository davolanishJadvaliRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public DavolanishJadvaliService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, IDavolanishJadvaliRepository davolanishJadvaliRepository = null)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.davolanishJadvaliRepository = davolanishJadvaliRepository;
        }

        public async Task AddAsync(DavolanishJadvaliAddDto davolanishJadvaliAddDto)
        {
            var davolanishJadvali = mapper.Map<DavolanishJadvali>(davolanishJadvaliAddDto);
            await davolanishJadvaliRepository.Add(davolanishJadvaliAddDto.KasalikNomiId, davolanishJadvali);
        }

        public async Task DeleteAsync(int id)
        {
            await davolanishJadvaliRepository.Delete(id);
        }

        public async Task<IEnumerable<DavolanishJadvali>> GetAllAsync() =>
            await davolanishJadvaliRepository.GetAll();

        public async Task UpdateAsync(int id, DavolanishJadvaliAddDto yangiDavolanishJadvaliAddDto)
        {
            var davolanishJadvali = mapper.Map<DavolanishJadvali>(yangiDavolanishJadvaliAddDto);
            await davolanishJadvaliRepository.Update(id, davolanishJadvali);
        }
    }
}
