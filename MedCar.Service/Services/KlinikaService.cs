using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class KlinikaService : IKlinikaService
    {
        IKlinikaRepository klinikaRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public KlinikaService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, IKlinikaRepository klinikaRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.klinikaRepository = klinikaRepository;
        }

        public async Task AddAsync(KlinikaAddDto klinikaAddDto)
        {
            var klinika = mapper.Map<Klinika>(klinikaAddDto);
            await klinikaRepository.Add(klinikaAddDto.KasalikNomiId, klinika);
        }

        public async Task DeleteAsync(int id)
        {
            await klinikaRepository.Delete(id);
        }

        public async Task<IEnumerable<Klinika>> GetAllAsync() =>
            await klinikaRepository.GetAll();

        public async Task UpdateAsync(int id, KlinikaAddDto yangiKlinikaAddDto)
        {
            var klinika = mapper.Map<Klinika>(yangiKlinikaAddDto);
            await klinikaRepository.Update(id, klinika);
        }
    }
}
