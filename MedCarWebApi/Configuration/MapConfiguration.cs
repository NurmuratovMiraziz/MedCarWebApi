using AutoMapper;
using MedCarDomin.Model;
using MedCareWebApi.DTO;

namespace MedCareWebApi.Configuration
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration()
        {
            CreateMap<BelgisiAddDto, Belgisi>().ReverseMap();
            CreateMap<DavolanishJadvaliAddDto, DavolanishJadvali>().ReverseMap();
            CreateMap<DavoUsuliAddDto, DavoUsuli>().ReverseMap();
            CreateMap<KasalikNomiAddDto, KasalikNomi>().ReverseMap();
            CreateMap<KasalikSababiAddDto, KasalikSababi>().ReverseMap();
            CreateMap<KlinikaAddDto, Klinika>().ReverseMap();
            CreateMap<KutilganKasalikAddDto, KutilganKasalik>().ReverseMap();
            CreateMap<ParhezTaomAddDto, ParhezTaom>().ReverseMap();
            CreateMap<SanatoriyaAddDto, Sanatoriya>().ReverseMap();
        }
    }
}
