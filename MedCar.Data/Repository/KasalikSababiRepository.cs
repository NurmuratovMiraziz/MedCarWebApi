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
    public class KasalikSababiRepository : IKasalikSababiRepository
    {
        AppDbContext appDbContext;

        public KasalikSababiRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(int KasalikNomisId, KasalikSababi kasalikSababi)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);

            await appDbContext.KasalikSabablari.AddAsync(kasalikSababi);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var kasalikSababi = await appDbContext.KasalikSabablari
                .FirstOrDefaultAsync(kasalikSababi => kasalikSababi.Id == id);

            appDbContext.KasalikSabablari.Remove(kasalikSababi);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<KasalikSababi>> GetAll() =>
            await appDbContext.KasalikSabablari.ToListAsync();

        public async Task Update(int id, KasalikSababi yangiKasalikSababi)
        {
            var kasalikSababi = await appDbContext.KasalikSabablari
                .FirstOrDefaultAsync(kasalikSababi => kasalikSababi.Id == id);
            yangiKasalikSababi.Id = id;
            appDbContext.KasalikSabablari.Attach(kasalikSababi).CurrentValues.SetValues(yangiKasalikSababi);
            await appDbContext.SaveChangesAsync();
        }
    }
}
