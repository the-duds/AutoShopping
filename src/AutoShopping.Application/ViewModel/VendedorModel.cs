using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace AutoShopping.Application.ViewModel
{
    public class VendedorModel : Notifiable, IValidatable
    {
        /// <summary>
        /// Numero Identificador - Gerado Automaticamente 
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Nome Completo do Vendedor
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Numero de CPF do Vendedor
        /// </summary>
        public string CPF { get; set; }
        /// <summary>
        /// Email do Vendedor
        /// </summary>
        public string Email { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires().IsNotNullOrEmpty(Nome, nameof(Nome), "Nome do Vendedor não pode ser vazio")
                .Requires().IsNotNullOrEmpty(CPF, nameof(CPF), "CPF do vendedor não pode ser vazio")
                .Requires().IsNotNullOrEmpty(Email.ToString(), nameof(Email), "E-mail do Vendedor não pode ser vazio")
                .Requires().IsNotEmpty(Id, nameof(Id), "Id não deve ser instanciado, pois será auto indicado")
            );
        }
    }
}
