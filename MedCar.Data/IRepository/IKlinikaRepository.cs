using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IKlinikaRepository
    {
        public Task Add(int KasalikNomisId, Klinika klinika);
        public Task<IEnumerable<Klinika>> GetAll();
        public Task Update(int id, Klinika yangiKlinika);
        public Task Delete(int id);
    }
}
