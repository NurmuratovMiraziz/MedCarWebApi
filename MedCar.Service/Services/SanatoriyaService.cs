using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class SanatoriyaService : ISanatoriyaService
    {
        ISanatoriyaRepository sanatoriyaRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public SanatoriyaService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, ISanatoriyaRepository sanatoriyaRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.sanatoriyaRepository = sanatoriyaRepository;
        }

        public async Task AddAsync(SanatoriyaAddDto sanatoriyaAddDto)
        {
            var sanatoriya = mapper.Map<Sanatoriya>(sanatoriyaAddDto);
            await sanatoriyaRepository.Add(sanatoriyaAddDto.KasalikNomiId, sanatoriya);
        }

        public async Task DeleteAsync(int id)
        {
            await sanatoriyaRepository.Delete(id);
        }

        public async Task<IEnumerable<Sanatoriya>> GetAllAsync() =>
            await sanatoriyaRepository.GetAll();

        public async Task UpdateAsync(int id, SanatoriyaAddDto yangiSanatoriyaAddDto)
        {
            var sanatoriya = mapper.Map<Sanatoriya>(yangiSanatoriyaAddDto);
            await sanatoriyaRepository.Update(id, sanatoriya);
        }
    }
}
