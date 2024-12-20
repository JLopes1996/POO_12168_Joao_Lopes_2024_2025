using System;
using System.Collections.Generic;

namespace Jardim_Zoológico.Models
{

    /// <summary>
    /// Representa uma jaula do jardim zoológico.
    /// </summary>
    public class Jaula
    {
        #region Atributos

        /// <summary>
        /// Id sequencial único da jaula.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Capacidade da jaula (Pequena, Média, Grande).
        /// </summary>
        public string Capacidade { get; set; } // Pequena, Média, Grande

        /// <summary>
        /// Lista de animais que se encontram na jaula.
        /// </summary>
        public List<Animal> Animais { get; set; } // Animais alocados na jaula

        #endregion

        #region Construtor

        /// <summary>
        /// Construtor da classe Jaula.
        /// </summary>
        /// <param name="id">Id sequencial único da jaula.</param>
        /// <param name="capacidade">Capacidade da jaula (Pequena, Média, Grande).</param>
        public Jaula(int id, string capacidade)
        {
            Id = id;
            Capacidade = capacidade;
            Animais = new List<Animal>();
        }

        #endregion
    }
}