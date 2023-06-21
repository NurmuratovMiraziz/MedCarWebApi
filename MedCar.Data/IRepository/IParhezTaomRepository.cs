using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IParhezTaomRepository
    {
        public Task Add(int KasalikNomisId, ParhezTaom parhezTaom);
        public Task<IEnumerable<ParhezTaom>> GetAll();
        public Task Update(int id, ParhezTaom yangiParhezTaom);
        public Task Delete(int id);
    }
}
