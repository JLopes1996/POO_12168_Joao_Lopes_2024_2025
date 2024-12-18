using System;

namespace Jardim_Zoológico.Classes
{
    public class Espectaculo
    {
        // Atributos do Espetáculo

        public string Nome { get; set; }
        public DateTime Horario { get; set; }
        public TimeSpan Duracao { get; set; }
        public Animal Animal { get; set; }
        public string Local { get; set; }
        public string Capacidade { get; set; }
        public string Descrição { get; set; }


        // Construtor da classe Espetáculo

        public Espectaculo(string nome, DateTime horario, TimeSpan duracao, Animal animal, string local, string capacidade, string descrição)
        {
            Nome = nome;
            Horario = horario;
            Duracao = duracao;
            Animal = animal;
            Local = local;
            Capacidade = capacidade;
            Descrição = descrição;
        }
    }
}