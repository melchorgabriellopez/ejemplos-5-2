using System;
using Proyecto_clases.Clases;
namespace Proyecto_clases
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            while (!Salir)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("_______________________________");
                Console.WriteLine("Alta alumnos ................ 1");
                Console.WriteLine("Borrar lista de alumnos ..... 2");
                Console.WriteLine("Borrar alumno  .............. 3");
                Console.WriteLine("Actualizar alumno  .......... 4");
                Console.WriteLine("Listar alumnos .............. 5");
                Console.WriteLine("Alta Materias ............... 6");
                Console.WriteLine("Borrar lista de Materias .... 7");
                Console.WriteLine("Borrar Materias ............. 8");
                Console.WriteLine("Actualizar Materia .......... 9");
                Console.WriteLine("Listar Materias..............10");
                Console.WriteLine("Salir ....................... 0");
                Console.WriteLine("_______________________________");
                Console.Write("Opcion=> ");
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
                        BaseDatos.BorrarListaAlumnos();
                        break;
                    case 3:
                        BorrarAlumno();
                        break;
                    case 4:
                        ActualizarAlumno();
                        break;
                    case 5:
                        ListarAlumno();
                        break;
                    case 6:
                        GuardarMateria();
                        break;
                    case 7:
                        BaseDatos.BorrarListaMeterias();
                        break;
                    case 8:
                        BorrarMateria();
                        break;
                    case 9:
                        ActualizarMateria();
                        break;
                    case 10:
                        ListarMateria();
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        Console.ReadKey();
                        break;
                }
            }

            void GuardarAlumno()
            {
                Console.Clear();//limpia pantalla
                Console.WriteLine("Alta Alumno");
                Console.WriteLine("____________________________");
                Alumno alumno = new Alumno();

                Console.WriteLine("Codigo");
                alumno.IdAlumno = int.Parse(Console.ReadLine());

                Console.WriteLine("Nombre");
                alumno.Nombre = Console.ReadLine();

                Console.WriteLine("Curp");
                alumno.Nombre = Console.ReadLine();



                BaseDatos.Guardar(alumno);

                Console.WriteLine("____________________________");

                Console.WriteLine("Se guardo corectamente...!");
                Console.ReadKey();

            }
            void ListarAlumno()
            {
                Console.Clear();//limpia pantalla
                Console.WriteLine("Lista de Alumnos");
                Console.WriteLine("____________________________");

                foreach (Alumno item in BaseDatos.ListarAlumno())
                {
                    Console.WriteLine($"{item.IdAlumno} {item.Nombre}");
                }


                Console.WriteLine("____________________________");
                Console.WriteLine($"Total de registros : {BaseDatos.ListarAlumno().Count}");

                Console.WriteLine("");
                Console.WriteLine("Precione una tecla para continuar");
                Console.ReadKey();
            }
        }
        private static void ActualizarAlumno()
        {
            Console.Clear();//limpia pantalla
            Console.WriteLine("Modificar Alumno");
            Console.WriteLine("____________________________");
            Alumno alumno = new Alumno();

            Console.WriteLine("Codigo");
            var Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Nombre");
            alumno.Nombre = Console.ReadLine();

            Console.WriteLine("Curp");
            alumno.CURP = Console.ReadLine();

            BaseDatos.Actualizar(Codigo, alumno);

            Console.WriteLine("____________________________");

            Console.WriteLine("Se Modifico corectamente...!");
            Console.ReadKey();
        }
        private static void BorrarAlumno()
        {
            Console.Clear();//limpia pantalla
            Console.WriteLine("Borrar Alumno");
            Console.WriteLine("____________________________");
            Console.WriteLine("Codigo :");
            var Codigo = int.Parse(Console.ReadLine());
            BaseDatos.BorrarAlumno(Codigo);

            Console.WriteLine("____________________________");

            Console.WriteLine("Se borro corectamente...!");
            Console.ReadKey();
        }
        private static void ListarMateria()
        {
            Console.Clear();//limpia pantalla
            Console.WriteLine("Lista de Materias");
            Console.WriteLine("____________________________");
            foreach (Materia item in BaseDatos.ListarMateria())
            {
                Console.WriteLine($"{item.IdMateria} - {item.Nombre}");
            }
            Console.WriteLine("____________________________");
            Console.WriteLine($"Total de registros : {BaseDatos.ListarMateria().Count}");
            Console.WriteLine("");
            Console.WriteLine("Precione una tecla para continuar");
            Console.ReadKey();

        }
        private static void GuardarMateria()
        {
            Console.Clear();//limpia pantalla
            Console.WriteLine("Alta Materia");
            Console.WriteLine("____________________________");
            Materia materia = new Materia();

            Console.WriteLine("Codigo :");
            materia.IdMateria = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre :");
            materia.Nombre = Console.ReadLine();

            BaseDatos.Guardar(materia);
            Console.WriteLine("____________________________");

            Console.WriteLine("Se guardo corectamente...!");
            Console.ReadKey();

        }
        private static void ActualizarMateria()
        {
            Console.Clear();//limpia pantalla
            Console.WriteLine("Modificar Materia");
            Console.WriteLine("____________________________");
            Materia materia = new Materia();

            Console.WriteLine("Codigo");
            var Codigo = int.Parse(Console.ReadLine());


            Console.WriteLine("Nombre");
            materia.Nombre = Console.ReadLine();



            BaseDatos.Actualizar(Codigo, materia);

            Console.WriteLine("____________________________");

            Console.WriteLine("Se Modifico corectamente...!");
            Console.ReadKey();
        }
        private static void BorrarMateria()
        {
            Console.Clear();//limpia pantalla
            Console.WriteLine("Borrar materia");
            Console.WriteLine("____________________________");
            Console.WriteLine("Codigo :");
            var Codigo = int.Parse(Console.ReadLine());
            BaseDatos.BorrarMateria(Codigo);

            Console.WriteLine("____________________________");

            Console.WriteLine("Se borro corectamente...!");
            Console.ReadKey();
        }
    }
}