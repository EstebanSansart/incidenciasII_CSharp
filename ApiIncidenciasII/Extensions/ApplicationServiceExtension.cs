using Aplicacion.Repository;
using Aplicacion.UnitOfWork;
using Dominio.Interfaces;

namespace ApiIncidenciasII.Extensions;
public static class ApplicationServiceExtension
{
    public static void ConfigureCors(this IServiceCollection services) =>
    services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
    });
    public static void AddAplicacionServices(this IServiceCollection services)
    {
        //services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
        //services.AddScoped<IPaisInterface,PaisRepository>();
        //services.AddScoped<ITipoPersona,TipoPersonaRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}