using System;

namespace Jardim_Zoológico.Models
{
    /// <summary>
    /// Representa um animal do jardim zoológico.
    /// </summary>
    public class Animal
    {
        #region Atributos
        /// <summary>
        /// Id sequencial único do animal.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do animal.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de nascimento ou idade do animal.
        /// </summary>
        public DateTime DataDeNascimento { get; set; }

        /// <summary>
        /// Tipo do animal (por exemplo: leão, girafa).
        /// </summary>
        public string Tipo { get; set; } // Tipo do animal: ex: leão, girafa, etc

        /// <summary>
        /// Tipo de comida preferida do animal.
        /// </summary>
        public Comida Comida { get; set; } // Comida do animal: carne, peixe, vegetariano

        /// <summary>
        /// Jaula onde o animal se encontra.
        /// </summary>
        public Jaula Jaula { get; set; } // Jaula onde o animal se encontra

        /// <summary>
        /// Veterinário responsável pelo animal.
        /// </summary>
        public Veterinario Veterinario { get; set; }// O veterinário do animal
        #endregion

        #region Construtor
        /// <summary>
        /// Construtor da classe Animal.
        /// </summary>
        /// <param name="id">Id sequencial único do animal.</param>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="idade">Data de nascimento ou idade do animal.</param>
        /// <param name="tipo">Tipo do animal (por exemplo: leão, girafa).</param>
        /// <param name="comida">Tipo de comida preferida do animal.</param>
        /// <param name="jaula">Jaula onde o animal se encontra.</param>
        /// <param name="veterinario">Veterinário responsável pelo animal.</param>
        public Animal(int id, string nome, DateTime idade, string tipo, Comida comida, Jaula jaula, Veterinario veterinario)
        {

            Id = id;
            Nome = nome;
            DataDeNascimento = idade;
            Tipo = tipo;
            Comida = comida;
            Jaula = jaula;
            Veterinario = veterinario;
        }

        #endregion
    }
}