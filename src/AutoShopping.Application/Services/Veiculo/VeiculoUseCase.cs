using AutoShopping.Application.Interfaces.Boundaires.Veiculo;
using AutoShopping.Application.ViewModel;
using System.Threading.Tasks;

namespace AutoShopping.Application.Services.Veiculo
{
    public class VeiculoUseCase : IVeiculoUseCase
    {
        private readonly IVeiculoOutputPort _outputPort;
        //private readonly ISqlRepository _sqlRepository;

        public VeiculoUseCase(IVeiculoOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public async Task Execute(VeiculoModel input)
        {
            input.Validate();
            if (input.Valid)
            {
                _outputPort.Success(new VeiculoOutput($"Ok"));
                return;
            }
            _outputPort.WriteError(input.Notifications);
        }
    }
}
