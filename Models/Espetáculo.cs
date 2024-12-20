using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa um espetáculo realizado no jardim zoológico.
    /// </summary>
    public class Espectaculo
    {
        #region Atributos

        /// <summary>
        /// Nome do espetáculo.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Horário do espetáculo.
        /// </summary>
        public DateTime Horario { get; set; }

        /// <summary>
        /// Duração do espetáculo.
        /// </summary>
        public string Duracao { get; set; }


        /// <summary>
        /// Animal que vai estar no espetáculo.
        /// </summary>
        public Animal Animal { get; set; }


        /// <summary>
        /// Local onde o espetáculo será realizado.
        /// </summary>
        public string Local { get; set; }

        /// <summary>
        /// Capacidade do espetáculo.
        /// </summary>
        public string Capacidade { get; set; }

        /// <summary>
        /// Descricao do espetáculo.
        /// </summary>
        public string Descrição { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Espetáculo.
        /// </summary>
        /// <param name="nome">Nome do espetáculo.</param>
        /// <param name="horario">Horário do espetáculo.</param>
        /// <param name="duracao">Duração do espetáculo.</param>
        /// <param name="animal">Animal que vai estar no espetáculo.</param>
        /// <param name="local">Local onde o espetáculo será realizado.</param>
        /// <param name="capacidade">Capacidade do espetáculo.</param>
        /// <param name="descrição">Descricao do espetáculo.</param>
        public Espectaculo(string nome, DateTime horario, string duracao, Animal animal, string local, string capacidade, string descrição)
        {
            Nome = nome;
            Horario = horario;
            Duracao = duracao;
            Animal = animal;
            Local = local;
            Capacidade = capacidade;
            Descrição = descrição;
        }

        #endregion
    }
}