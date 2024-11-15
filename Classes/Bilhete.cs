using Jardim_Zoológico.Menu_Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    public class Bilhete: Espectaculo
    {
        // Atributos do Bilhete

        public double Preco { get; set; } 
        public string Tipo { get; set; } // Ex: adulto, criança, estudante

        // Construtor da classe Bilhete

        public Bilhete(string nome, DateTime horario, TimeSpan duracao, Animal animal, double preco, string tipo, int quantidade)
        : base(nome, horario, duracao, animal)
        {
            Preco = preco;
            Tipo = tipo;
        }

        // Método para imprimir dados sobre o Bilhete

        public void InfoBilhete()
        {
            Console.WriteLine($" Comprou o bilhete: {Tipo} pelo valor de {Preco}.");
        }
    }
}