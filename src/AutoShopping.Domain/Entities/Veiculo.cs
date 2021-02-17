using System;

namespace AutoShopping.Domain.Entities
{
    public class Veiculo
    {
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
    }
}
