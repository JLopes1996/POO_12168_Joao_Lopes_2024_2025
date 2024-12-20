using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa um cliente do jardim zoológico.
    /// </summary>
    public class Cliente
    {
        #region Atributos

        /// <summary>
        /// Id sequencial único do cliente.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// NIF do cliente.
        /// </summary>
        public string NIF { get; set; }

        /// <summary>
        /// Contacto do cliente.
        /// </summary>
        public string Contacto { get; set; }

        /// <summary>
        /// Password do cliente.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Bilhete do cliente.
        /// </summary>
        public Bilhete Bilhete { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Cliente.
        /// </summary>
        /// <param name="id">Id sequencial único do cliente.</param>
        /// <param name="nome">Nome do cliente.</param>
        /// <param name="nif">NIF do cliente.</param>
        /// <param name="contacto">Contacto do cliente.</param>
        /// <param name="password">Password do cliente.</param>
        /// <param name="bilhete">Bilhete do cliente.</param>
        public Cliente(int id, string nome, string nif, string contacto, string password, Bilhete bilhete)
        {
            Id = id;
            Nome = nome;
            NIF = nif;
            Contacto = contacto;
            Password = password;
            Bilhete = bilhete;
        }

        #endregion
    }
}