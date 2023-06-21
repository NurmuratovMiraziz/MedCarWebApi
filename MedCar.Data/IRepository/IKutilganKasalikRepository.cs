using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IKutilganKasalikRepository
    {
        public Task Add(int KasalikNomisId, KutilganKasalik kutilganKasalik);
        public Task<IEnumerable<KutilganKasalik>> GetAll();
        public Task Update(int id, KutilganKasalik yangiKutilganKasalik);
        public Task Delete(int id);
    }
}
