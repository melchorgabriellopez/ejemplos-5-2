using System;

namespace ejemplos_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            // [ambito] (tipo de dato) Nombre Variable [valor] ; 

            // ambito: private, public, protected 

            // tipos de datos: Numero,Caracteres boleanos objeto y usuario
            // int,float,double, decimal, long ,short , byte   0 -255    
            // string
            // bool :true o false
            // datetime,stream,....
            // class,metodos...
            // private int IdAlumno=0;
            int IdAlumno;
            string Nombre;
            bool Estatus;

            DateTime FechaNacimiento = DateTime.Now;

            IdAlumno = 1;
            Nombre = "pedro perez";
            Estatus=true; 

            Console.Write(Nombre);

            var Valor="asdasd";


           // operadore : Matematicos, Logicos y comparacion
           // +,-,*,/   % \ v =
           // && y, || o , ~ no
           // >,<,>=,<=,==,===, !=, !==        

        }
    }
}
