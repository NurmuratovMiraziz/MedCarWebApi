using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCar.Service.IServices
{
    public interface IKasalikSababiService
    {
        public Task AddAsync(KasalikSababiAddDto kasalikSababiAddDto);
        public Task<IEnumerable<KasalikSababi>> GetAllAsync();
        public Task DeleteAsync(int id);
        public Task UpdateAsync(int id, KasalikSababiAddDto yangiKasalikSababiAddDto);
    }
}
