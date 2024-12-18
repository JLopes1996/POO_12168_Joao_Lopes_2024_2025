using System;

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
    }
}