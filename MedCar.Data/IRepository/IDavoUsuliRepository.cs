using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IDavoUsuliRepository
    {
        public Task Add(int KasalikNomisId, DavoUsuli davoUsuli);
        public Task<IEnumerable<DavoUsuli>> GetAll();
        public Task Update(int id, DavoUsuli yangiDavoUsuli);
        public Task Delete(int id);
    }
}
