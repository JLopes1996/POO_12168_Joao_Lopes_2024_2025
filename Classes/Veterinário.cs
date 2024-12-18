using System;

namespace Jardim_Zoológico.Classes
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Contacto { get; set; }

        public Veterinario(int id, string nome, string contacto)
        {
            Id = id;
            Nome = nome;
            Contacto = contacto;
        }
    }
}