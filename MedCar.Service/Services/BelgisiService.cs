using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class BelgisiService : IBelgisiService
    {
        IBelgisiRepository belgisiRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public BelgisiService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, IBelgisiRepository belgisiRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.belgisiRepository = belgisiRepository;
        }

        public async Task AddAsync(BelgisiAddDto belgisiAddDto)
        {
            var belgisi = mapper.Map<Belgisi>(belgisiAddDto);
            await belgisiRepository.Add(belgisiAddDto.KasalikNomisId, belgisi);
        }

        public async Task DeleteAsync(int id)
        {
            await belgisiRepository.Delete(id);
        }

        public async Task<IEnumerable<Belgisi>> GetAllAsync() =>
            await belgisiRepository.GetAll();

        public async Task UpdateAsync(int id, BelgisiAddDto yangiBelgisiAddDto)
        {
            var belgi = mapper.Map<Belgisi>(yangiBelgisiAddDto);
            await belgisiRepository.Update(id, belgi);
        }
    }
}
