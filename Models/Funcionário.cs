using System;

namespace Jardim_Zoológico.Models
{

    /// <summary>
    /// Representa um funcionário do jardim zoológico.
    /// </summary>
    public class Funcionario
    {
        #region Atributos

        /// <summary>
        /// Id sequencial único do funcionário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do funcionário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Cargo do funcionário: gerente, funcionário limpeza, veterinário.
        /// </summary>
        public string Cargo { get; set; }

        /// <summary>
        /// Data em que o funcionário começou a trabalhar no jardim zoológico.
        /// </summary>
        public DateTime DataDeEntrada { get; set; }

        /// <summary>
        /// Salário do funcionário.
        /// </summary>
        public float Salário { get; set; }

        /// <summary>
        /// Password do funcionário.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Contacto do funcionário.
        /// </summary>
        public string Contacto { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Funcionário.
        /// </summary>
        /// <param name="id">Id sequencial único do funcionário.</param>
        /// <param name="nome">Nome do funcionário.</param>
        /// <param name="cargo">Cargo do funcionário: gerente, funcionário limpeza, veterinário.</param>
        /// <param name="dataDeEntrada">Data em que o funcionário começou a trabalhar no jardim zoológico.</param>
        /// <param name="salário">Salário do funcionário.</param>
        /// <param name="password">Password do funcionário.</param>
        /// <param name="contacto">Contacto do funcionário.</param>
        public Funcionario(int id, string nome, string cargo, DateTime dataDeEntrada, float salário, string password, string contacto)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            DataDeEntrada = dataDeEntrada;
            Salário = salário;
            Password = password;
            Contacto = contacto;
        }

        #endregion
    }
}