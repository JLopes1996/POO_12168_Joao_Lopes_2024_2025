using Jardim_Zoológico.Menu_Inicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardim_Zoológico.Classes
{
    public class Funcionario
    {
        // Atributos do Funcionário

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; } // Cargo do funcionário: gerente, funcionário limpeza, tratador...

        // Construtor da classe Funcionário

        public Funcionario(int id, string nome, string cargo)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
        }

        //Método para imprimir dados sobre o Funcionário

        public void InfoFuncionário()
        {
            Console.WriteLine($" O Funcionario {Nome} é {Cargo} do Zoológico.");
        }
    }
}