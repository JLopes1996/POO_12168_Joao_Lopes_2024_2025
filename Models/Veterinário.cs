using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa um veterinário do jardim zoológico.
    /// </summary>
    public class Veterinario
    {
        #region Atributos

        /// <summary>
        /// Id sequencial único do veterinário.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do veterinário.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Contacto do veterinário.
        /// </summary>
        public string Contacto { get; set; }

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Veterinário.
        /// </summary>
        /// <param name="id">Id sequencial único do veterinário.</param>
        /// <param name="nome">Nome do veterinário.</param>
        /// <param name="contacto">Contacto do veterinário.</param>
        public Veterinario(int id, string nome, string contacto)
        {
            Id = id;
            Nome = nome;
            Contacto = contacto;
        }

        #endregion
    }
}