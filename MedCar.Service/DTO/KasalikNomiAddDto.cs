using MedCarDomin.Model;

namespace MedCareWebApi.DTO
{
    public class KasalikNomiAddDto
    {
        public string Nomi { get; set; }
        public int BelgisiId { get; set; }
        public int KutilganKasalikId { get; set; }
        public int ParhezTaomId { get; set; }
        public int SanatoriyaId { get; set; }
        public int KlinikaId { get; set; }
        public int DavoUsuliId { get; set; }
        public int KasalikSababiId { get; set; }
        public int DavolanishJadvaaliId { get; set; }
    }
}
