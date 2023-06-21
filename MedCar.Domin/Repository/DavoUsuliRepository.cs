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
    public class DavoUsuliRepository : IDavoUsuliRepository
    {
        AppDbContext appDbContext;

        public DavoUsuliRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(int KasalikNomisId, DavoUsuli davoUsuli)
        {
            var kasalikNomi = await appDbContext.DavoUsulLari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);

            await appDbContext.DavoUsulLari.AddAsync(davoUsuli);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var davoUsuli = await appDbContext.DavoUsulLari
                .FirstOrDefaultAsync(davoUsuli => davoUsuli.Id == id);

            appDbContext.DavoUsulLari.Remove(davoUsuli);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<DavoUsuli>> GetAll() =>
            await appDbContext.DavoUsulLari.ToListAsync();

        public async Task Update(int id, DavoUsuli yangiDavoUsuli)
        {
            var davoUsuli = await appDbContext.DavoUsulLari
                .FirstOrDefaultAsync(davoUsuli => davoUsuli.Id == id);
            yangiDavoUsuli.Id = id;
            appDbContext.DavoUsulLari.Attach(davoUsuli).CurrentValues.SetValues(yangiDavoUsuli);
            await appDbContext.SaveChangesAsync();
        }
    }
}
