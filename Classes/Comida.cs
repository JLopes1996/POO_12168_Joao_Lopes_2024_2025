using System;

namespace Jardim_Zoológico.Classes
{
    public class Comida
    {
        // Atributos da comida

        public string Tipo { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
        public string Origem { get; set; }

        // Construtor da classe Comida

        public Comida(string tipo, int quantidade, DateTime validade, string origem)
        {
            Tipo = tipo;
            Quantidade = quantidade;
            Validade = validade;
            Origem = origem;
        }
    }
}