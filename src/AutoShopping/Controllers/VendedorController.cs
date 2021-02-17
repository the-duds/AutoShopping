using AutoShopping.Application.Interfaces.Boundaires.Vendedor;
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
    /// Rotas Vendedores.
    /// </summary>
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Controller responsável por rotas relacionadas a Vendedores.
        /// </summary>
        /// <param name="mediator">Interface de mediator para chamar os use case da aplicação.</param>
        public VendedorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Rota de Cadastro de Vendedores
        /// </summary>
        /// <param name="vendedor">Modelo de informações para o cadastro de vendedores.</param>
        /// <param name="presenter">Apresentação de resultados da rota.</param>
        /// <returns></returns>
        [HttpPost, Route("")]
        [ProducesResponseType(typeof(VendedorOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostVendedor(VendedorModel vendedor, [FromServices] VendedorPresenter presenter)
        {
            await _mediator.PublishAsync(vendedor).ConfigureAwait(false);

            return presenter.ViewModel;
        }
    }
}
