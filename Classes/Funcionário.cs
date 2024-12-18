using System;

namespace Jardim_Zoológico.Classes
{
    public class Funcionario
    {
        // Atributos do Funcionário

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; } // Cargo do funcionário: gerente, funcionário limpeza...
        public DateTime DataDeEntrada { get; set; }
        public float Salário { get; set; }
        public string Password { get; set; }

        // Construtor da classe Funcionário

        public Funcionario(int id, string nome, string cargo, DateTime dataDeEntrada, float salário, string password)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            DataDeEntrada = dataDeEntrada;
            Salário = salário;
            Password = password;
        }
    }
}