using AutoMapper;
using MedCar.Service.IServices;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using MedCareWebApi.DTO;

namespace MedCar.Service.Services
{
    public class ParhezTaomService : IParhezTaomService
    {
        IParhezTaomRepository parhezTaomRepository;
        IKasalikNomiRepository kasalikNomiRepository;
        IMapper mapper;

        public ParhezTaomService(IMapper mapper, IKasalikNomiRepository kasalikNomiRepository, IParhezTaomRepository parhezTaomRepository)
        {
            this.mapper = mapper;
            this.kasalikNomiRepository = kasalikNomiRepository;
            this.parhezTaomRepository = parhezTaomRepository;
        }

        public async Task AddAsync(ParhezTaomAddDto parhezTaomAddDto)
        {
            var parhezTaom = mapper.Map<ParhezTaom>(parhezTaomAddDto);
            await parhezTaomRepository.Add(parhezTaomAddDto.KasalikNomiId, parhezTaom);
        }

        public async Task DeleteAsync(int id)
        {
            await parhezTaomRepository.Delete(id);
        }

        public async Task<IEnumerable<ParhezTaom>> GetAllAsync() =>
            await parhezTaomRepository.GetAll();

        public async Task UpdateAsync(int id, ParhezTaomAddDto yangiParhezTaomAddDto)
        {
            var parhezTaom = mapper.Map<ParhezTaom>(yangiParhezTaomAddDto);
            await parhezTaomRepository.Update(id, parhezTaom);
        }
    }
}
