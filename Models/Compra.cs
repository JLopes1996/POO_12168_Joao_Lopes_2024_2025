using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa a compra de um bilhete realizada por um cliente.
    /// </summary>
    public class Compra
    {
        #region Atributos

        /// <summary>
        /// Id sequencial único da compra do bilhete.
        /// </summary>
        public int IdBilhete { get; set; }

        /// <summary>
        /// Tipo de bilhete comprado pelo cliente.
        /// </summary>
        public string TipoBilhete { get; set; }

        /// <summary>
        /// Valor que o cliente pagou pelo bilhete.
        /// </summary>
        public float PrecoBilhete { get; set; }


        /// <summary>
        /// Nome do espetáculo associado ao bilhete que o cliente comprou.
        /// </summary>
        public string NomeEspetaculo { get; set; }


        /// <summary>
        /// Data da compra do bilhete.
        /// </summary>
        public DateTime DataCompra { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Compra.
        /// </summary>
        /// <param name="idBilhete">Id sequencial único da compra do bilhete..</param>
        /// <param name="tipoBilhete">Tipo de bilhete comprado pelo cliente.</param>
        /// <param name="precoBilhete">Valor que o cliente pagou pelo bilhete.</param>
        /// <param name="nomeEspetaculo">Nome do espetáculo associado ao bilhete que o cliente comprou.</param>
        /// <param name="dataCompra">Data da compra do bilhete.</param>
        public Compra(int idBilhete, string tipoBilhete, float precoBilhete, string nomeEspetaculo, DateTime dataCompra)
        {

            IdBilhete = idBilhete;
            TipoBilhete = tipoBilhete;
            PrecoBilhete = precoBilhete;
            NomeEspetaculo = nomeEspetaculo;
            DataCompra = dataCompra;
        }

        #endregion
    }
}