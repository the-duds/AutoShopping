using AutoShopping.Application.Interfaces.Boundaires.Venda;
using AutoShopping.Application.ViewModel;
using System.Threading.Tasks;

namespace AutoShopping.Application.Services.Venda
{
    public class VendaUseCase : IVendaUseCase
    {
        private readonly IVendaOutputPort _outputPort;

        public VendaUseCase(IVendaOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public async Task Execute(VendaModel input)
        {
            input.Validate();
            if (input.Valid)
            {
                _outputPort.Success(new VendaOutput($"Ok"));
                return;
            }
            _outputPort.WriteError(input.Notifications);
        }
    }
}
