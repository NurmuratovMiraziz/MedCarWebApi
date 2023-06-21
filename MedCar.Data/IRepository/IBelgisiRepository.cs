using MedCarDomin.Model;

namespace MedCareServices.IRepository
{
    public interface IBelgisiRepository
    {
        public Task Add(int KasalikNomisId, Belgisi belgisi);
        public Task<IEnumerable<Belgisi>> GetAll();
        public Task Update(int id, Belgisi yangiBelgisi);
        public Task Delete(int id);
    }
}
