using AutoShopping.Application.Interfaces.Boundaires.Veiculo;
using AutoShopping.Application.Interfaces.Boundaires.Venda;
using AutoShopping.Application.Interfaces.Boundaires.Vendedor;
using AutoShopping.Application.Services.Veiculo;
using AutoShopping.Application.Services.Venda;
using AutoShopping.Application.Services.Vendedor;
using Microsoft.Extensions.DependencyInjection;

namespace AutoShopping.Modules
{
    /// <summary>
    /// Registra UseCase
    /// </summary>
    public static class UseCaseExtensions
    {
        /// <summary>
        /// Metodo chamado no startup para registrar os UseCase
        /// </summary>
        /// <param name="services">Serviço de UseCase</param>
        /// <returns></returns>
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IVeiculoUseCase,VeiculoUseCase>();
            services.AddScoped<IVendaUseCase,VendaUseCase>();
            services.AddScoped<IVendedorUseCase,VendedorUseCase>();

            return services;
        }
    }
}
