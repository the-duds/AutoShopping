using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace AutoShopping.Application.ViewModel
{
    public class VendaModel : Notifiable, IValidatable
    {
        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public string Vendedor { get; set; }
        public List<VeiculoModel> Veiculos { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires().IsNotNullOrEmpty(Data.ToString(), nameof(Data), "Data da Venda não pode ser vazio")
                .Requires().IsNotNullOrEmpty(Vendedor, nameof(Vendedor), "Vendedor responsavel pela venda não pode ser vazio")
                .Requires().IsNotNull(Veiculos, nameof(Veiculos), "Lista de Veiculos não pode ser vazio")
                .Requires().IsNotEmpty(Id, nameof(Id), "Id não deve ser instanciado, pois será auto indicado")
            );
        }
    }
}
