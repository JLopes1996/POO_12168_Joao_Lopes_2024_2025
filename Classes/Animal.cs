using System;

namespace Jardim_Zoológico.Classes
{
    public class Animal
    {
        // Atributos do Animal

        public string Nome { get; set; } 
        public int Idade { get; set; } 
        public string Tipo { get; set; } // Tipo do animal: ex: leão, girafa, etc
        public Comida Comida { get; set; } // Comida do animal: carne, peixe, vegetariano
        public Jaula Jaula { get; set; } // Jaula onde o animal se encontra
        public Veterinario Veterinario { get; set; }// O veterinário do animal

        // Construtor da classe Animal

        public Animal(string nome, int idade, string tipo, Comida comida, Jaula jaula, Veterinario veterinario)
        {

            Nome = nome;
            Idade = idade;
            Tipo = tipo;
            Comida = comida;
            Jaula = jaula;
            Veterinario = veterinario;
        }
    }
}