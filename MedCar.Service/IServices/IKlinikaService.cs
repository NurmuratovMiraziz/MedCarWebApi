using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IKlinikaService
    {
        public Task AddAsync(KlinikaAddDto klinikaAddDto);
        public Task<IEnumerable<Klinika>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, KlinikaAddDto yangiKlinikaAddDto);
    }
}
