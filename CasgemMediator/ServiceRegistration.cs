using CasgemMediator.Dal;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Reflection;

namespace CasgemMediator
{
    public static class ServiceRegistration
    {
        public static void AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Context>(x =>
            {
                x.UseNpgsql(configuration.GetConnectionString("Context"));
              
            });
            services.TryAddScoped<DbContext, Context>();
           
        }

       
      
    }
}
