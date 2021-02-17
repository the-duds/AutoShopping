using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace AutoShopping.Application.ViewModel
{
    public class VeiculoModel : Notifiable, IValidatable
    {
        /// <summary>
        /// Numero Identificador - Gerado Automaticamente 
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Marca do Veiculo
        /// </summary>
        public string Marca { get; set; }

        /// <summary>
        /// Modelo do Veiculo
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Ano de Fabricação do Veiculo
        /// </summary>
        public int AnoFabricacao { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires().IsNotNullOrEmpty(Marca, nameof(Marca), "Marca do Veiculo não pode ser vazio")
                .Requires().IsNotNullOrEmpty(Modelo, nameof(Modelo), "Modelo do Veiculo não pode ser vazio")
                .Requires().IsNotNullOrEmpty(AnoFabricacao.ToString(), nameof(AnoFabricacao), "Ano de Fabricaçãodo Veiculo não pode ser vazio")
                .Requires().IsNotEmpty(Id, nameof(Id), "Id não deve ser instanciado, pois será auto indicado")
            );
        }
    }
}
