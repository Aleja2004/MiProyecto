using System;

namespace MiProyecto.Dominio
{
    public class Estudiante:Persona
    {
        //public Materia Materia {get;set;}
        //public Curso Curso {get;set;}
        //public Inscripcion Inscripcion {get;set;}
        public Curso Curso {get;set}
        public int Id { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}