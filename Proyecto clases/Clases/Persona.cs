using System;
using Proyecto_clases.Enumeradores;

namespace Proyecto_clases.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CURP{get;set;}

    }
}