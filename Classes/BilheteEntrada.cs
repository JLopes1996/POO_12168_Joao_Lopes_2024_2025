using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    internal class BilheteEntrada
    {

        // Atributos do BilheteEntrada
        public double Preco { get; set; }
        public string Tipo { get; set; } // Ex: adulto, criança, estudante
        public DateTime Horario { get; set; }

        // Construtor da classe Utilizador

        public BilheteEntrada(double preco, string tipo, DateTime horario)
        {
            Preco = preco;
            Tipo = tipo;
            Horario = horario;

        }

        //Método para imprimir dados sobre o Utilizador

        public void InfoCliente()
        {
            Console.WriteLine($"Comprou o bilhete:{Tipo} por {Preco}.");
        }
    }
}
