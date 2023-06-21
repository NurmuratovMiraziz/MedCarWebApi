using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IDavolanishJadvaliRepository
    {
        public Task Add(int KasalikNomisId, DavolanishJadvali davolanishJadvali);
        public Task<IEnumerable<DavolanishJadvali>> GetAll();
        public Task Update(int id, DavolanishJadvali yangiDavolanishJadvali);
        public Task Delete(int id);
    }
}
