using AutoShopping.Domain.Dto.Config;
using AutoShopping.Domain.Repositories;
using AutoShopping.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AutoShopping.Infra.IoC
{
    public static class DependencyResolver
    {
        public static void AddBancoContext(this IServiceCollection services)
        {
            services.AddDbContext<BancoContext>(opt => opt.UseInMemoryDatabase("BancoEmMemoria"));

        }

        public static void RegisterRepositories(this IServiceCollection services)
        {
            
            services.AddScoped<ISqlRepository, SqlRepository>();

        }
    }
}
