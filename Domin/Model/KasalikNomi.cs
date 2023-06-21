using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCarDomin.Model
{
    public class KasalikNomi
    {
        public int Id { get; set; }
        public string Nomi { get; set; }
        public IList<Belgisi> Belgisi { get; set; }
        public IList<KutilganKasalik> KutilganKasalik { get; set; }
        public IList<ParhezTaom> ParhezTaom { get; set; }
        public IList<Sanatoriya> Sanatoriya { get; set; }
        public IList<Klinika> Klinika { get; set; }
        public KasalikNomi()
        {
            Belgisi = new List<Belgisi>();
            KutilganKasalik = new List<KutilganKasalik>();
            ParhezTaom = new List<ParhezTaom>();
            Klinika = new List<Klinika>();
            Sanatoriya = new List<Sanatoriya>();
        }
        public DavoUsuli DavoUsuli { get; set; }
        public KasalikSababi KasalikSababi { get; set; }
        public DavolanishJadvali DavolanishJadvali { get; set; }
    }
}
