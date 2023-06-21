using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class KasalikNomiService : IKasalikNomiService
    {
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public KasalikNomiService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
        }

        public async Task AddAsync(KasalikNomiAddDto kasalikNomiAddDto)
        {
            var kasalikNomi = mapper.Map<KasalikNomi>(kasalikNomiAddDto);
            await kasalikNomiRepository.Add(kasalikNomi);
        }

        public async Task DeleteAsync(int id)
        {
            await kasalikNomiRepository.Delete(id);
        }

        public async Task<IEnumerable<KasalikNomi>> GetAllAsync() =>
            await kasalikNomiRepository.GetAll();

        public async Task UpdateAsync(int id, KasalikNomiAddDto yangiKasalikNomiAddDto)
        {
            var kasalikNomi = mapper.Map<KasalikNomi>(yangiKasalikNomiAddDto);
            await kasalikNomiRepository.Update(id, kasalikNomi);
        }
    }
}
