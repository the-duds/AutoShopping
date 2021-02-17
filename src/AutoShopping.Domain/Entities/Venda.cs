using System;
using System.Collections.Generic;

namespace AutoShopping.Domain.Entities
{
    public class Venda
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Vendedor { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
