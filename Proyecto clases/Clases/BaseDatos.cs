using System.Collections.Generic;

namespace Proyecto_clases.Clases
{

    public static class BaseDatos
    {

          static List<Alumno> TablaAlumnos=new List<Alumno>();


        public static bool Guardar(Alumno alumno)
        {
            TablaAlumnos.Add(alumno);
            return true;
        } 

        public static List<Alumno> Listar ()
        {
            return TablaAlumnos;
        }

    }
}