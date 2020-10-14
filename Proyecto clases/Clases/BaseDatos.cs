using System;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto_clases.Clases
{

    public static class BaseDatos
    {
        static List<Alumno> TablaAlumnos = new List<Alumno>();
        static List<Materia> TablaMaterias = new List<Materia>();

        public static bool Guardar(Alumno alumno)
        {
            TablaAlumnos.Add(alumno);
            return true;
        }
        public static bool Guardar(Materia materia)
        {
            TablaMaterias.Add(materia);
            return true;
        }

        public static void Actualizar(int id, Alumno alumno)
        {
            var actualizar = TablaAlumnos.Where(x => x.IdAlumno == id).FirstOrDefault();
            actualizar.Nombre = alumno.Nombre;
            actualizar.CURP = alumno.CURP;
            actualizar.Activo = alumno.Activo;
            actualizar.Sexo = alumno.Sexo;
        }
        public static void Actualizar(int id,Materia materia)
        {
           var actualizar= TablaMaterias.Where(x=> x.IdMateria==id).FirstOrDefault();
           actualizar.Nombre=materia.Nombre;        
        }

        public static List<Alumno> ListarAlumno()
        {
            return TablaAlumnos;
        }
        public static List<Materia> ListarMateria()
        {
            return TablaMaterias;
        }


        public static void BorrarListaAlumnos()
        {
            TablaAlumnos.Clear();
            Console.WriteLine("Se borraron todos los alumnos...");
            Console.ReadKey();
        }


        public static void BorrarListaMeterias()
        {
            TablaMaterias.Clear();
            Console.WriteLine("Se borraron todas las materias...");
            Console.ReadKey();
        }

        public static void BorrarAlumno(int id)
        {
            var borrar = TablaAlumnos.Where(x => x.IdAlumno == id).FirstOrDefault();
            TablaAlumnos.Remove(borrar);
        }

        public static void BorrarMateria(int id)
        {
            var borrar = TablaMaterias.Where(x => x.IdMateria == id).FirstOrDefault();
            TablaMaterias.Remove(borrar);
        }


    }


}