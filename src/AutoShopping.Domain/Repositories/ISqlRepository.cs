using AutoShopping.Application.ViewModel;
using AutoShopping.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AutoShopping.Domain.Repositories
{
    public interface ISqlRepository
    {
        public Venda IncluirVenda(VendaModel obj);
        public Venda AlterarVenda(VendaModel obj);
        public Venda ObterVenda(Guid id);
        public IEnumerable<Venda> ListarVendas();
        public Veiculo IncluirVeiculo(VeiculoModel obj);
        public Vendedor IncluirVendedor(VendedorModel obj);


    }
}
