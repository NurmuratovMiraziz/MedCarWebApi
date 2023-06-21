using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface ISanatoriyaRepository
    {
        public Task Add(int KasalikNomisId, Sanatoriya sanatoriya);
        public Task<IEnumerable<Sanatoriya>> GetAll();
        public Task Update(int id, Sanatoriya yangiSanatoriya);
        public Task Delete(int id);
    }
}
