using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCarDomin.Model
{
    public class Klinika
    {
        public int Id { get; set; }
        public string Nomi { get; set; }
        public string Manzili { get; set; }
        public IList<KasalikNomi> KasalikNomi { get; set; }
        public Klinika()
        {
            KasalikNomi = new List<KasalikNomi>();
        }
    }
}
