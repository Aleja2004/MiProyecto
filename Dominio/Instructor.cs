using System;

namespace MiProyecto.Dominio
{
    public class Instructor:Persona
    {
        public int Id { get; set; }
        public string Rol { get; set; }
        public string Codigo { get; set; }
    }
}