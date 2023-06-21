using MedCarDomin.AppDbContexts;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MedCareServices.Repository
{
    public class BelgisiRepository : IBelgisiRepository
    {
        AppDbContext appDbContext;

        public BelgisiRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task Add(int KasalikNomisId, Belgisi belgisi)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);
            kasalikNomi.Belgisi.Add(belgisi);
            await appDbContext.Belgilari.AddAsync(belgisi);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var belgi = await appDbContext.Belgilari
                .FirstOrDefaultAsync(belgi => belgi.Id == id);

            appDbContext.Belgilari.Remove(belgi);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Belgisi>> GetAll() =>
            await appDbContext.Belgilari.ToListAsync();

        public async Task Update(int id, Belgisi yangiBelgisi)
        {
            var belgi = await appDbContext.Belgilari
                .FirstOrDefaultAsync(belgi => belgi.Id == id);
            yangiBelgisi.Id = id;
            appDbContext.Belgilari.Attach(belgi).CurrentValues.SetValues(yangiBelgisi);
            await appDbContext.SaveChangesAsync();
        }
    }
}
