using MedCarDomin.Model;
using MedCareServices.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.Repository
{
    public class DavolanishJadvaliRepository : IDavolanishJadvaliRepository
    {
        App appDbContext;

        public DavolanishJadvaliRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task Add(int KasalikNomisId, DavolanishJadvali davolanishJadvali)
        {
            var kasalikNomi = await appDbContext.KasalikNomlari
                .FirstOrDefaultAsync(kasalikNomi => kasalikNomi.Id == KasalikNomisId);

            await appDbContext.DavolanishJadvallari.AddAsync(davolanishJadvali);
            await appDbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var davolanishJadvali = await appDbContext.DavolanishJadvallari
                .FirstOrDefaultAsync(davolanishJadvali => davolanishJadvali.Id == id);

            appDbContext.DavolanishJadvallari.Remove(davolanishJadvali);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<DavolanishJadvali>> GetAll() =>
            await appDbContext.DavolanishJadvallari.ToListAsync();

        public async Task Update(int id, DavolanishJadvali yangiDavolanishJadvali)
        {
            var davolanishJadvali = await appDbContext.DavolanishJadvallari
                .FirstOrDefaultAsync(davolanishJadvali => davolanishJadvali.Id == id);
            yangiDavolanishJadvali.Id = id;
            appDbContext.DavolanishJadvallari.Attach(davolanishJadvali).CurrentValues.SetValues(yangiDavolanishJadvali);
            await appDbContext.SaveChangesAsync();
        }
    }
}
