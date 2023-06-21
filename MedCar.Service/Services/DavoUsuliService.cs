using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class DavoUsuliService : IDavoUsuliService
    {
        IDavoUsuliRepository davoUsuliRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public DavoUsuliService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository = null, IDavoUsuliRepository davoUsuliRepository = null)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.davoUsuliRepository = davoUsuliRepository;
        }

        public async Task AddAsync(DavoUsuliAddDto davoUsuliAddDto)
        {
            var davoUsuli = mapper.Map<DavoUsuli>(davoUsuliAddDto);
            await davoUsuliRepository.Add(davoUsuliAddDto.KasalikNomiId, davoUsuli);
        }

        public async Task DeleteAsync(int id)
        {
            await davoUsuliRepository.Delete(id);
        }

        public async Task<IEnumerable<DavoUsuli>> GetAllAsync() =>
            await davoUsuliRepository.GetAll();

        public async Task UpdateAsync(int id, DavoUsuliAddDto yangidavoUsuliAddDto)
        {
            var davoUsuli = mapper.Map<DavoUsuli>(yangidavoUsuliAddDto);
            await davoUsuliRepository.Update(id, davoUsuli);
        }
    }
}