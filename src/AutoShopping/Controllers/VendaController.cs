using AutoShopping.Application.Interfaces.Boundaires.Venda;
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
    /// Rotas Vendas
    /// </summary>
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{api-version:apiVersion}/[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Controller responsável por rotas relacionadas a Vendas.
        /// </summary>
        /// <param name="mediator">Interface de mediator para chamar os use case da aplicação.</param>
        public VendaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Rota de Cadastro de Vendas
        /// </summary>
        /// <param name="venda">Modelo de informações para o cadastro de Vendas.</param>
        /// <param name="presenter">Apresentação de resultados da rota.</param>
        /// <returns></returns>
        [HttpPost, Route("")]
        [ProducesResponseType(typeof(VendaOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostVenda(VendaModel venda, [FromServices] VendaPresenter presenter)
        {
            await _mediator.PublishAsync(venda).ConfigureAwait(false);

            return presenter.ViewModel;
        }
        /// <summary>
        /// Rota de Consultar Venda Realizada
        /// </summary>
        /// <param name="id">Identificador da Venda</param>
        /// <returns></returns>

        [HttpGet, Route("{id}")]
        [ProducesResponseType(typeof(VendaOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(string id)
        {
            

            return null;
        }
        /// <summary>
        /// Rota de Alterar a Venda Realizada
        /// </summary>
        /// <param name="id">Identificador da Venda</param>
        /// <returns></returns>
        [HttpPut, Route("{id}")]
        [ProducesResponseType(typeof(VendaOutput), StatusCodes.Status202Accepted)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResult), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Put(string id)
        {


            return null;
        }
    }
}
