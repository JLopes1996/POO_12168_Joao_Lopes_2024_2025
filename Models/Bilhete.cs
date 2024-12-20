using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa um bilhete para um espetáculo do jardim zoológico.
    /// </summary>
    public class Bilhete : Espectaculo
    {
        #region Atributos

        /// <summary>
        /// Id sequencial único do bilhete.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Preço do bilhete.
        /// </summary>
        public float Preco { get; set; }

        /// <summary>
        /// Tipo do bilhete (ex.: adulto, criança, idoso, estudante).
        /// </summary>
        public string Tipo { get; set; } // Ex: adulto, criança, estudante

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Bilhete.
        /// </summary>
        /// <param name="nome">Nome do espetáculo associado ao bilhete.</param>
        /// <param name="horario">Horário do espetáculo.</param>
        /// <param name="duracao">Duração do espetáculo.</param>
        /// <param name="animal">Animal que vai estar no espetáculo.</param>
        /// <param name="local">Local onde o espetáculo será realizado.</param>
        /// <param name="capacidade">Capacidade máxima do espetáculo.</param>
        /// <param name="descrição">Descrição do espetáculo.</param>
        /// <param name="id">Id sequencial único do bilhete.</param>
        /// <param name="preco">Preço do bilhete.</param>
        /// <param name="tipo">Tipo do bilhete.</param>
        public Bilhete(string nome, DateTime horario, string duracao, Animal animal, string local, string capacidade, string descrição, int id, float preco, string tipo)
        : base(nome, horario, duracao, animal, local, capacidade, descrição)
        {
            Id = id;
            Preco = preco;
            Tipo = tipo;
        }

        #endregion
    }
}