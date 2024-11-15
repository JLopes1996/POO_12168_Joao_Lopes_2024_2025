using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    public class Espectaculo
    {
        // Atributos do Espetáculo

        public string Nome { get; set; }
        public DateTime Horario { get; set; }
        public TimeSpan Duracao { get; set; }
        public Animal Animal { get; set; }

        // Construtor da classe Espetáculo

        public Espectaculo(string nome, DateTime horario, TimeSpan duracao, Animal animal)
        {
            Nome = nome;
            Horario = horario;
            Duracao = duracao;
            Animal = animal;
        }

        //Método para imprimir dados sobre o Espetáculo

        public void InfoEspetaculo()
        {
            Console.WriteLine($" O Espetaculo {Nome} começa às {Horario}, terá a duração de {Duracao}" +
                $"e contará com {Animal.Tipo}.");
        }
    }
}