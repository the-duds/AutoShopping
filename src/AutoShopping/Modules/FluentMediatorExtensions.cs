using Microsoft.Extensions.DependencyInjection;
using FluentMediator;
using AutoShopping.Application.ViewModel;
using AutoShopping.Application.Interfaces.Boundaires.Veiculo;
using AutoShopping.Application.Interfaces.Boundaires.Venda;
using AutoShopping.Application.Interfaces.Boundaires.Vendedor;

namespace AutoShopping.Modules
{
    /// <summary>
    /// Registra Mediator.
    /// </summary>
    public static class FluentMediatorExtensions
    {
        /// <summary>
        /// Metodo chamado no startup para registrar o Mediator
        /// </summary>
        /// <param name="services">Serviço de Mediator</param>
        /// <returns></returns>
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddFluentMediator(
                builder =>
                {
                    builder.On<VeiculoModel>().PipelineAsync()
                       .Call<IVeiculoUseCase>((handler, request) => handler.Execute(request));
                    builder.On<VendaModel>().PipelineAsync()
                      .Call<IVendaUseCase>((handler, request) => handler.Execute(request));
                    builder.On<VendedorModel>().PipelineAsync()
                      .Call<IVendedorUseCase>((handler, request) => handler.Execute(request));
                });

            return services;
        }
    }
}
