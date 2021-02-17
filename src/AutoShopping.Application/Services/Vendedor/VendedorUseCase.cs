using AutoShopping.Application.Interfaces.Boundaires.Vendedor;
using AutoShopping.Application.ViewModel;
using System.Threading.Tasks;

namespace AutoShopping.Application.Services.Vendedor
{
    public class VendedorUseCase : IVendedorUseCase
    {
        private readonly IVendedorOutputPort _outputPort;

        public VendedorUseCase(IVendedorOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public async Task Execute(VendedorModel input)
        {
            input.Validate();
            if (input.Valid)
            {
                _outputPort.Success(new VendedorOutput($"Ok"));
                return;
            }
            _outputPort.WriteError(input.Notifications);
        }
    }
}
