using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IBelgisiService
    {
        public Task AddAsync(BelgisiAddDto belgisiAddDto);
        public Task<IEnumerable<Belgisi>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, BelgisiAddDto yangiBelgisiAddDto);
    }
}
