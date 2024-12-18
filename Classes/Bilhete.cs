using System;

namespace Jardim_Zoológico.Classes
{
    public class Bilhete: Espectaculo
    {
        // Atributos do Bilhete

        public double Preco { get; set; } 
        public string Tipo { get; set; } // Ex: adulto, criança, estudante

        // Construtor da classe Bilhete

        public Bilhete(string nome, DateTime horario, TimeSpan duracao, Animal animal, string local, string capacidade, string descrição, double preco, string tipo)
        : base(nome, horario, duracao, animal, local, capacidade, descrição)
        {
            Preco = preco;
            Tipo = tipo;
        }
    }
}