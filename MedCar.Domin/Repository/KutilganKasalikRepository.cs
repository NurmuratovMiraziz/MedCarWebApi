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
    public class KutilganKasalikRepository : IKutilganKasalikRepository
    {
        AppDbContext appDbContext;

        public KutilganKasalikRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(int KasalikNomisId, KutilganKasalik kutilganKasalik)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);
            kasalikNomi.KutilganKasalik.Add(kutilganKasalik);
            await appDbContext.KutilganKasaliklar.AddAsync(kutilganKasalik);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var kutilganKasalik = await appDbContext.KutilganKasaliklar
                .FirstOrDefaultAsync(kutilganKasalik => kutilganKasalik.Id == id);

            appDbContext.KutilganKasaliklar.Remove(kutilganKasalik);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<KutilganKasalik>> GetAll()=>
            await appDbContext.KutilganKasaliklar.ToListAsync();

        public async Task Update(int id, KutilganKasalik yangiKutilganKasalik)
        {
            var kutilganKasalik = await appDbContext.KutilganKasaliklar
                .FirstOrDefaultAsync(kutilganKasalik => kutilganKasalik.Id == id);
            yangiKutilganKasalik.Id = id;
            appDbContext.KutilganKasaliklar.Attach(kutilganKasalik).CurrentValues.SetValues(yangiKutilganKasalik);
            await appDbContext.SaveChangesAsync();
        }
    }
}
