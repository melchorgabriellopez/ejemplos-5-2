using System;
using System.Collections.Generic;
using System.Linq;
using Proyecto_clases.Clases;
using Proyecto_clases.Enumeradores;

namespace Proyecto_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno= new Alumno();
            
            alumno.IdAlumno=1;
            alumno.Nombre="Pedro Perez";
            alumno.Activo=true; 
            alumno.FechaNacimiento=DateTime.Now;
            alumno.Sexo=Sexo.Indefinido;
            alumno.CURP="asdasdf";
 

          List<Alumno> alumnos = new List<Alumno>();  

          alumnos.Add(new Alumno{IdAlumno=1,Sexo=Sexo.Hombre,FechaNacimiento=DateTime.Parse( "25/01/2001"),CURP="asdasd",Activo=true,Nombre="Pedro perez" });   
          alumnos.Add(new Alumno{IdAlumno=2,Sexo=Sexo.Mujer,FechaNacimiento=DateTime.Parse( "30/10/2001"),CURP="sadfsd",Activo=true,Nombre="Maria Soto" });   
          alumnos.Add(new Alumno{IdAlumno=1,Sexo=Sexo.Hombre,FechaNacimiento=DateTime.Parse( "25/01/2001"),CURP="asdasd",Activo=true,Nombre="Pedro perez" });   
          alumnos.Add(new Alumno{IdAlumno=2,Sexo=Sexo.Mujer,FechaNacimiento=DateTime.Parse( "30/10/2001"),CURP="sadfsd",Activo=true,Nombre="Maria Soto" });   
          alumnos.Add(new Alumno{IdAlumno=1,Sexo=Sexo.Hombre,FechaNacimiento=DateTime.Parse( "25/01/2001"),CURP="asdasd",Activo=true,Nombre="Pedro perez" });   
          alumnos.Add(new Alumno{IdAlumno=2,Sexo=Sexo.Mujer,FechaNacimiento=DateTime.Parse( "30/10/2001"),CURP="sadfsd",Activo=true,Nombre="Maria Soto" });        
          alumnos.Add(new Alumno{IdAlumno=1,Sexo=Sexo.Hombre,FechaNacimiento=DateTime.Parse( "25/01/2001"),CURP="asdasd",Activo=true,Nombre="Pedro perez" });   
          alumnos.Add(new Alumno{IdAlumno=2,Sexo=Sexo.Mujer,FechaNacimiento=DateTime.Parse( "30/10/2001"),CURP="sadfsd",Activo=true,Nombre="Maria Soto" });     
          alumnos.Add(new Alumno{IdAlumno=1,Sexo=Sexo.Hombre,FechaNacimiento=DateTime.Parse( "25/01/2001"),CURP="asdasd",Activo=true,Nombre="Pedro perez" });   
          alumnos.Add(new Alumno{IdAlumno=2,Sexo=Sexo.Mujer,FechaNacimiento=DateTime.Parse( "30/10/2001"),CURP="sadfsd",Activo=true,Nombre="Maria Soto" });   
          alumnos.Add(new Alumno{IdAlumno=1,Sexo=Sexo.Hombre,FechaNacimiento=DateTime.Parse( "25/01/2001"),CURP="asdasd",Activo=true,Nombre="Pedro perez" });   
          alumnos.Add(new Alumno{IdAlumno=2,Sexo=Sexo.Mujer,FechaNacimiento=DateTime.Parse( "30/10/2001"),CURP="sadfsd",Activo=true,Nombre="Maria Soto" });   
         
          foreach(Alumno item in alumnos.Where(a=> a.Sexo==Sexo.Mujer && a.Activo==false))
          {
              Console.WriteLine($"{item.IdAlumno} {item.Nombre} {item.Sexo} " );
          } 
         
        }
    }
}
