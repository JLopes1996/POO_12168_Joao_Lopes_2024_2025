using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa a comida ingerida por um animal.
    /// </summary>
    public class Comida
    {
        #region Atributos

        /// <summary>
        /// Tipo de comida ingerida pelo animal.
        /// </summary>
        public string Tipo { get; set; }

        /// <summary>
        /// Quantidade de comida ingerida pelo animal.
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// Validade da comida ingerida pelo animal.
        /// </summary>
        public DateTime Validade { get; set; }

        /// <summary>
        /// Origem da comida ingerida pelo animal.
        /// </summary>
        public string Origem { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Comida.
        /// </summary>
        /// <param name="tipo">Tipo de comida ingerida pelo animal.</param>
        /// <param name="quantidade">Quantidade de comida ingerida pelo animal.</param>
        /// <param name="validade">Validade da comida ingerida pelo animal.</param>
        /// <param name="origem">Origem da comida ingerida pelo animal.</param>
        public Comida(string tipo, int quantidade, DateTime validade, string origem)
        {
            Tipo = tipo;
            Quantidade = quantidade;
            Validade = validade;
            Origem = origem;
        }

        #endregion
    }
}