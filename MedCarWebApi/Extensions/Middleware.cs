using MedCar.Service.IServices;
using MedCar.Service.Services;
using MedCarDomin.AppDbContexts;
using MedCareServices.IRepository;
using MedCareServices.Repository;
using Microsoft.EntityFrameworkCore;

namespace MedCareWebApi.Extensions
{
    public static class Middleware
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("ConnectionString")));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IBelgisiRepository, BelgisiRepository>();
            services.AddTransient<IDavolanishJadvaliRepository, DavolanishJadvaliRepository>();
            services.AddTransient<IDavoUsuliRepository, DavoUsuliRepository>();
            services.AddTransient<IKasalikNomiRepository, KasalikNomiRepository>();
            services.AddTransient<IKasalikSababiRepository, KasalikSababiRepository>();
            services.AddTransient<IKlinikaRepository, KlinikaRepository>();
            services.AddTransient<IKutilganKasalikRepository, KutilganKasalikRepository>();
            services.AddTransient<IParhezTaomRepository, ParhezTaomRepository>();
            services.AddTransient<ISanatoriyaRepository, SanatoriyaRepository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IBelgisiService, BelgisiService>();
            services.AddTransient<IDavolanishJadvaliService, DavolanishJadvaliService>();
            services.AddTransient<IDavoUsuliService, DavoUsuliService>();
            services.AddTransient<IKasalikNomiService, KasalikNomiService>();
            services.AddTransient<IKasalikSababiService, KasalikSababiService>();
            services.AddTransient<IKlinikaService, KlinikaService>();
            services.AddTransient<IKutilganKasalikService, KutilganKasalikService>();
            services.AddTransient<IParhezTaomService, ParhezTaomService>();
            services.AddTransient<ISanatoriyaService, SanatoriyaService>();
            services.AddAutoMapper(typeof(Program));
        }
    }
}
