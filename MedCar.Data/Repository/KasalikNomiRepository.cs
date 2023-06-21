using MedCarDomin.AppDbContexts;
using MedCarDomin.Model;
using MedCareServices.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.Repository
{
    public class KasalikNomiRepository : IKasalikNomiRepository
    {
        AppDbContext appDbContext;

        public KasalikNomiRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(KasalikNomi kasalikNomi)
        {
            await appDbContext.KasalikNomlari.AddAsync(kasalikNomi);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == id);

            appDbContext.KasalikNomlari.Remove(kasalikNomi);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<KasalikNomi>> GetAll() =>
            await appDbContext.KasalikNomlari
            .Include(x => x.Belgisi)
            .Include(x => x.DavolanishJadvali)
            .Include(x => x.DavoUsuli)
            .Include(x => x.KasalikSababi)
            .Include(x => x.Klinika)
            .Include(x => x.KutilganKasalik)
            .Include(x => x.ParhezTaom)
            .Include(x => x.Sanatoriya)
            .ToListAsync();

        public async Task Update(int id, KasalikNomi yangiKasalikNomi)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == id);
            yangiKasalikNomi.Id = id;
            appDbContext.KasalikNomlari.Attach(kasalikNomi).CurrentValues.SetValues(yangiKasalikNomi);
            await appDbContext.SaveChangesAsync();
        }
    }
}
