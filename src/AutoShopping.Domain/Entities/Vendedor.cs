using System;

namespace AutoShopping.Domain.Entities
{
    public class Vendedor
    {
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
    }
}
