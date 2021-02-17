using AutoShopping.Application.ViewModel;
using AutoShopping.Domain.Dto.Config;
using AutoShopping.Domain.Entities;
using AutoShopping.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShopping.Infra.Data.Repositories
{
    public class SqlRepository : ISqlRepository
    {
        private readonly BancoContext _context;
        public SqlRepository(BancoContext context)
        {
            _context = context;
        }

        public Venda IncluirVenda(VendaModel obj)
        {
            List<Veiculo> veiculos = obj.Veiculos.ConvertAll(x => new Veiculo { Id = x.Id, AnoFabricacao = x.AnoFabricacao, Marca = x.Marca, Modelo = x.Modelo });

            Venda venda = new Venda()
            {
                Id = Guid.NewGuid(),
                Data = obj.Data,
                Veiculos = veiculos,
                Vendedor = obj.Vendedor
            };
            _context.Vendas.Add(venda);
            _context.SaveChanges();
            return venda;
        }

        public Venda AlterarVenda(VendaModel obj)
        {
            throw new NotImplementedException();
        }
        public Venda ObterVenda(Guid id)
        {
            return _context.Vendas.Where(v => v.Id == id).FirstOrDefault();
        }
        public IEnumerable<Venda> ListarVendas()
        {
            return _context.Vendas.ToList();
        }

        public Veiculo IncluirVeiculo(VeiculoModel obj)
        {
            Veiculo veiculo = new Veiculo()
            {
                Marca = obj.Marca,
                Modelo = obj.Modelo,
                AnoFabricacao = obj.AnoFabricacao,
                Id = Guid.NewGuid()
            };
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return veiculo;
        }

        public Vendedor IncluirVendedor(VendedorModel obj)
        {
            Vendedor vendedor = new Vendedor()
            {
                Nome = obj.Nome,
                CPF = obj.CPF,
                Email = obj.Email
            };
            _context.Vendedores.Add(vendedor);
            _context.SaveChanges();
            return vendedor;
        }
    }
}
