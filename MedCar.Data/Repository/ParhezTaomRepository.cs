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
    public class ParhezTaomRepository : IParhezTaomRepository
    {
        AppDbContext appDbContext;

        public ParhezTaomRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(int KasalikNomisId, ParhezTaom parhezTaom)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);
            kasalikNomi.ParhezTaom.Add(parhezTaom);
            await appDbContext.ParhezTaomlar.AddAsync(parhezTaom);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var parhezTaom = await appDbContext.ParhezTaomlar
                .FirstOrDefaultAsync(parhezTaom => parhezTaom.Id == id);

            appDbContext.ParhezTaomlar.Remove(parhezTaom);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ParhezTaom>> GetAll() =>
            await appDbContext.ParhezTaomlar.ToListAsync();

        public async Task Update(int id, ParhezTaom yangiParhezTaom)
        {
            var parhezTaom = await appDbContext.ParhezTaomlar
                .FirstOrDefaultAsync(parhezTaom => parhezTaom.Id == id);
            yangiParhezTaom.Id = id;
            appDbContext.ParhezTaomlar.Attach(parhezTaom).CurrentValues.SetValues(yangiParhezTaom);
            await appDbContext.SaveChangesAsync();
        }
    }
}
