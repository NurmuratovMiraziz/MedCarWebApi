using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class KutilganKasalikService : IKutilganKasalikService
    {
        IKutilganKasalikRepository kutilganKasalikRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public KutilganKasalikService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, IKutilganKasalikRepository kutilganKasalikRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.kutilganKasalikRepository = kutilganKasalikRepository;
        }

        public async Task AddAsync(KutilganKasalikAddDto kutilganKasalikAddDto)
        {
            var kutilganKasalik = mapper.Map<KutilganKasalik>(kutilganKasalikAddDto);
            await kutilganKasalikRepository.Add(kutilganKasalikAddDto.KasalikNomiId, kutilganKasalik);
        }

        public async Task DeleteAsync(int id)
        {
            await kutilganKasalikRepository.Delete(id);
        }

        public async Task<IEnumerable<KutilganKasalik>> GetAllAsync() =>
            await kutilganKasalikRepository.GetAll();

        public async Task UpdateAsync(int id, KutilganKasalikAddDto yangiKutilganKasalikAddDto)
        {
            var kutilganKasalik = mapper.Map<KutilganKasalik>(yangiKutilganKasalikAddDto);
            await kutilganKasalikRepository.Update(id, kutilganKasalik);
        }
    }
}
