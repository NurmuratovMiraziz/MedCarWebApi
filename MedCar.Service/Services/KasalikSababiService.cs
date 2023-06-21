using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class KasalikSababiService : IKasalikSababiService
    {
        IKasalikSababiRepository kasalikSababiRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public KasalikSababiService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, IKasalikSababiRepository kasalikSababiRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.kasalikSababiRepository = kasalikSababiRepository;
        }

        public async Task AddAsync(KasalikSababiAddDto kasalikSababiAddDto)
        {
            var kasalikSababi = mapper.Map<KasalikSababi>(kasalikSababiAddDto);
            await kasalikSababiRepository.Add(kasalikSababiAddDto.KasalikNomiId, kasalikSababi);
        }

        public async Task DeleteAsync(int id)
        {
            await kasalikSababiRepository.Delete(id);
        }

        public async Task<IEnumerable<KasalikSababi>> GetAllAsync() =>
            await kasalikSababiRepository.GetAll();

        public async Task UpdateAsync(int id, KasalikSababiAddDto yangiKasalikSababiAddDto)
        {
            var kasalikSababi = mapper.Map<KasalikSababi>(yangiKasalikSababiAddDto);
            await kasalikSababiRepository.Update(id, kasalikSababi);
        }
    }
}
