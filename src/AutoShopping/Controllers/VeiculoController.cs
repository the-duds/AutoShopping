using AutoShopping.Application.Interfaces.Boundaires.Veiculo;
using AutoShopping.Application.ViewModel;
using AutoShopping.Model;
using AutoShopping.Presenter;
using FluentMediator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AutoShopping.Controllers
{
    /// <summary>
    /// Rota Veiculos
    /// </summary>
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class VeiculoController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Controller responsável por rotas relacionadas a Veiculos.
        /// </summary>
        /// <param name="mediator">Interface de mediator para chamar os use case da aplicação.</param>
        public VeiculoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Rota de Cadastro de Veículos
        /// </summary>
        /// <param name="veiculo">Modelo de informações para o cadastro de Veiculos.</param>
        /// <param name="presenter">Apresentação de resultados da rota.</param>
        /// <returns></returns>
        [HttpPost, Route("")]
        [ProducesResponseType(typeof(VeiculoOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostVendedor(VeiculoModel veiculo, [FromServices] VeiculoPresenter presenter)
        {
            await _mediator.PublishAsync(veiculo).ConfigureAwait(false);

            return presenter.ViewModel;
        }
    }
}
