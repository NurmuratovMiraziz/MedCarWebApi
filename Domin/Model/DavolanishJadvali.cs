using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCarDomin.Model
{
    public class DavolanishJadvali
    {
        public int Id { get; set; }
        public string Malumot { get; set; }
        public int KasalikNomiId { get; set; }
        public KasalikNomi KasalikNomi { get; set; }
    }
}
