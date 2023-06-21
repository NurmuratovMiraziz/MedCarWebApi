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
    public class SanatoriyaRepository : ISanatoriyaRepository
    {
        AppDbContext appDbContext;

        public SanatoriyaRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Add(int KasalikNomisId, Sanatoriya sanatoriya)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);
            kasalikNomi.Sanatoriya.Add(sanatoriya);
            await appDbContext.Sanatoriyalar.AddAsync(sanatoriya);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var sanatoriya = await appDbContext.Sanatoriyalar
                .FirstOrDefaultAsync(sanatoriya => sanatoriya.Id == id);

            appDbContext.Sanatoriyalar.Remove(sanatoriya);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Sanatoriya>> GetAll()=>
            await appDbContext.Sanatoriyalar.ToListAsync();

        public async Task Update(int id, Sanatoriya yangiSanatoriya)
        {
            var sanatoriya = await appDbContext.Sanatoriyalar
                .FirstOrDefaultAsync(sanatoriya => sanatoriya.Id == id);
            yangiSanatoriya.Id = id;
            appDbContext.Sanatoriyalar.Attach(sanatoriya).CurrentValues.SetValues(yangiSanatoriya);
            await appDbContext.SaveChangesAsync();
        }
    }
}   
