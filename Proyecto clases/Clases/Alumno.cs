using System.Collections.Generic;

namespace Proyecto_clases.Clases
{
    public class Alumno :Persona
    {
      public Alumno()
      {
         this.Activo=true; 
      }
      public Alumno(int idAlumno,string nombre)

      {
          this.IdAlumno=idAlumno;
          this.Nombre=nombre;
          this.Activo=true;
      }
         public int IdAlumno {get;set;}  
      
         public bool Activo { get; set; }

         public List<Materia> Materias { get; set; }
    }
}