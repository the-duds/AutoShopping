namespace AutoShopping.Application.Interfaces.Boundaires.Vendedor
{
    public class VendedorOutput
    {
        public VendedorOutput(string response)
        {
            Result = response;
        }

        public string Result { get; private set; }
    }
}
