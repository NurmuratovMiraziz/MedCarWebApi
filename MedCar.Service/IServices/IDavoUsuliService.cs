using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IDavoUsuliService
    {
        public Task AddAsync(DavoUsuliAddDto davoUsuliAddDto);
        public Task<IEnumerable<DavoUsuli>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, DavoUsuliAddDto yangidavoUsuliAddDto);
    }
}
