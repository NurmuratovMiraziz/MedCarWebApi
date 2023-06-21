using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IKasalikNomiRepository
    {
        public Task Add(KasalikNomi kasalikNomi);
        public Task<IEnumerable<KasalikNomi>> GetAll();
        public Task Update(int id, KasalikNomi yangiKasalikNomi);
        public Task Delete(int id);
    }
}
