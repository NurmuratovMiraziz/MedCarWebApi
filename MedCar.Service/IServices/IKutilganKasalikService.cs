using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IKutilganKasalikService
    {
        public Task AddAsync(KutilganKasalikAddDto kutilganKasalikAddDto);
        public Task<IEnumerable<KutilganKasalik>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, KutilganKasalikAddDto yangiKutilganKasalikAddDto);
    }
}
