using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IDavolanishJadvaliService
    {
        public Task AddAsync(DavolanishJadvaliAddDto davolanishJadvaliAddDto);
        public Task<IEnumerable<DavolanishJadvali>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, DavolanishJadvaliAddDto yangiDavolanishJadvaliAddDto);
    }
}
