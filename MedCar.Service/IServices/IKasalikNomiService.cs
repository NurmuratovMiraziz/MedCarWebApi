using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IKasalikNomiService
    {
        public Task AddAsync(KasalikNomiAddDto kasalikNomiAddDto);
        public Task<IEnumerable<KasalikNomi>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, KasalikNomiAddDto yangiKasalikNomiAddDto);
    }
}
