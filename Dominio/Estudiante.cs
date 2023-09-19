using System;

namespace MiProyecto.Dominio
{
    public class Estudiante:Persona
    {
        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}