namespace AutoShopping.Application.Interfaces.Boundaires.Veiculo
{
    public class VeiculoOutput
    {
        public VeiculoOutput(string response)
        {
            Result = response;
        }

        public string Result { get; private set; }
    }
}
