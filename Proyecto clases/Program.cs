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
            /*  Alumno alumno= new Alumno();

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

       */


            bool Salir = false;
            while (!Salir)
            {
                Console.Clear();
                Console.WriteLine("Teclee una opcion:");
                int Opcion = int.Parse(Console.ReadLine());
                switch (Opcion)
                {
                    case 0:
                        Salir = true;
                        break;
                    case 1:
                        GuardarAlumno();
                        break;
                    case 2:
                        ListarAlumno();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.ReadKey();
                        break;
                }
            }

            void GuardarAlumno()
            {
                Console.Clear();
                Alumno alumno = new Alumno();

                Console.WriteLine("Codigo");
                alumno.IdAlumno = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre");
                alumno.Nombre = Console.ReadLine();

                BaseDatos.Guardar(alumno);

            }
            void ListarAlumno()
            {
                Console.Clear();

                foreach (Alumno item in BaseDatos.Listar())
                {
                    Console.WriteLine($"{item.IdAlumno} {item.Nombre}");
                }


                Console.WriteLine("Precione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
