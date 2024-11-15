using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Veterinario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        //Método para imprimir dados sobre o veterinário

        public void InfoVeterinário()
        {
            Console.WriteLine($"Veterinário {Nome}.");
        }
    }
}