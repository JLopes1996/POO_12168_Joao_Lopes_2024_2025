using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Jardim_Zoológico.Classes
{
    public class Jaula
    {
        // Atributos da jaula

        public int Id { get; set; }
        public string Capacidade { get; set; } // Pequena, Média, Grande
        public Funcionario Funcionario { get; set; } // Funcionário responsável pela limpeza da jaula

        // Construtor da classe Jaula

        public Jaula(int id, string capacidade, Funcionario funcionario)
        {
            Id = id;
            Capacidade = capacidade;
            Funcionario = funcionario;
        }

        //Método para imprimir dados sobre a jaula

        public void InfoJaula()
        {
            Console.WriteLine($" A jaula {Capacidade} onde se encontra o foi limpa por {Funcionario.Nome}.");
        }
    }
}