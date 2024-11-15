using Jardim_Zoológico.Menu_Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Método para imprimir dados sobre o Animal.

        public void InfoAnimal()
        {
            Console.WriteLine($" {Tipo} {Nome}, {Idade} anos, está na {Jaula.Id}, alimenta-se de {Comida.Tipo}" +
                $"e o seu veterinário é: {Veterinario.Nome}");
        }
    }
}