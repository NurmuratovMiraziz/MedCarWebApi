using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IParhezTaomService
    {
        public Task AddAsync(ParhezTaomAddDto parhezTaomAddDto);
        public Task<IEnumerable<ParhezTaom>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, ParhezTaomAddDto yangiParhezTaomAddDto);
    }
}
