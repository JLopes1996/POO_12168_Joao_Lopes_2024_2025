using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    public class Cliente
    {
        // Atributos do Utilizador

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NIF { get; set; }
        public string Contacto { get; set; }
        public string Password { get; set; }
        public Bilhete Bilhete { get; set; }

        // Construtor da classe Utilizador

        public Cliente(int id, string nome, string nif, string contacto, string password, Bilhete bilhete)
        {
            Id = id;
            Nome = nome;
            NIF = nif;
            Contacto = contacto;
            Password = password;
            Bilhete = bilhete;
        }

        //Método para imprimir dados sobre o Utilizador

        public void InfoCliente()
        {
            Console.WriteLine($"O cliente {Id} {Nome} comprou o bilhete {Bilhete.Tipo} por {Bilhete.Preco}.");
        }
    }
}
