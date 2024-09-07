using ApiCitas.Application.Contracts;
using ApiCitas.Application.Services;
using ApiCitas.Domain.Contracts;
using ApiCitas.Infraestructure.Data.Context;
using ApiCitas.Infraestructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCitas.Infraestructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ICitaServices, CitaServices>();
            services.AddScoped<ICitaRepository, CitaRepository>();
        }
    }
}

