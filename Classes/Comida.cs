using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    public class Comida
    {
        // Atributos da comida

        public string Tipo { get; set; }
        public int Quantidade { get; set; }

        // Construtor da classe Comida

        public Comida(string tipo, int quantidade)
        {
            Tipo = tipo;
            Quantidade = quantidade;
        }

        // Método para imprimir dados sobre a Comida

        public void InfoComida()
        {
            Console.WriteLine($" Alimentou o animal com {Quantidade} de {Tipo}.");
        }
    }
}