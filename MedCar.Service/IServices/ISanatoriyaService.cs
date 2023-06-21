using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface ISanatoriyaService
    {
        public Task AddAsync(SanatoriyaAddDto sanatoriyaAddDto);
        public Task<IEnumerable<Sanatoriya>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, SanatoriyaAddDto yangiSanatoriyaAddDto);
    }
}
