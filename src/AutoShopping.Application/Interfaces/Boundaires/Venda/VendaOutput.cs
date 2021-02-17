namespace AutoShopping.Application.Interfaces.Boundaires.Venda
{
    public class VendaOutput
    {
        public VendaOutput(string response)
        {
            Result = response;
        }

        public string Result { get; private set; }
    }
}
