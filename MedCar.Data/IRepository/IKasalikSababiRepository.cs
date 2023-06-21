using MedCarDomin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCareServices.IRepository
{
    public interface IKasalikSababiRepository
    {
        public Task Add(int KasalikNomisId, KasalikSababi kasalikSababi);
        public Task<IEnumerable<KasalikSababi>> GetAll();
        public Task Update(int id, KasalikSababi yangiKasalikSababi);
        public Task Delete(int id);
    }
}
