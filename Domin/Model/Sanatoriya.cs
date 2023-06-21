using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCarDomin.Model
{
    public class Sanatoriya
    {
        public int Id { get; set; }
        public string Nomi { get; set; }
        public KasalikNomi KasalikNomi { get; set; }
    }
}
