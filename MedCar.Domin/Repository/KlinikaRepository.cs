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
    public class KlinikaRepository : IKlinikaRepository
    {
        AppDbContext appDbContext;

        public KlinikaRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(int KasalikNomisId, Klinika klinika)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);
            kasalikNomi.Klinika.Add(klinika);
            await appDbContext.KlinikaLar.AddAsync(klinika);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var klinika = await appDbContext.KlinikaLar
                .FirstOrDefaultAsync(klinika => klinika.Id == id);

            appDbContext.KlinikaLar.Remove(klinika);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Klinika>> GetAll()=>
            await appDbContext.KlinikaLar.ToListAsync();

        public async Task Update(int id, Klinika yangiKlinika)
        {
            var klinika = await appDbContext.KlinikaLar
                .FirstOrDefaultAsync(klinika => klinika.Id == id);
            yangiKlinika.Id = id;
            appDbContext.KlinikaLar.Attach(klinika).CurrentValues.SetValues(yangiKlinika);
            await appDbContext.SaveChangesAsync();
        }
    }
}
