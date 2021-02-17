using AutoShopping.Application.Interfaces.Boundaires.Veiculo;
using AutoShopping.Application.Interfaces.Boundaires.Venda;
using AutoShopping.Application.Interfaces.Boundaires.Vendedor;
using AutoShopping.Presenter;
using Microsoft.Extensions.DependencyInjection;

namespace AutoShopping.Modules
{
    /// <summary>
    /// Registra Presenter.
    /// </summary>
    public static class PresenterExtensions
    {
        /// <summary>
        /// Metodo chamado no startup para registrar os Presenter
        /// </summary>
        /// <param name="services">Serviço de Presenter</param>
        /// <returns></returns>
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<VeiculoPresenter, VeiculoPresenter>();
            services.AddScoped<IVeiculoOutputPort>(x => x.GetRequiredService<VeiculoPresenter>());

            services.AddScoped<VendaPresenter, VendaPresenter>();
            services.AddScoped<IVendaOutputPort>(x => x.GetRequiredService<VendaPresenter>());

            services.AddScoped<VendedorPresenter, VendedorPresenter>();
            services.AddScoped<IVendedorOutputPort>(x => x.GetRequiredService<VendedorPresenter>());

            return services;
        }
    }
}
