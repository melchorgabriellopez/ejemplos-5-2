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
            /*   int IdAlumno;
               string Nombre;
               bool Estatus;

               DateTime FechaNacimiento = DateTime.Now;

               IdAlumno = 1;
               Nombre = "pedro perez";
               Estatus=true; 

               Console.Write(Nombre);
   */
            //  var Valor="asdasd";


            // operadore : Matematicos, Logicos y comparacion
            // +,-,*,/   % \ v =
            // && y, || o , ~ no
            // >,<,>=,<=,==,===, !=, !==        



            int Suma;
            int Resta;
            int Numero1 = 7;
            int Numero2 = 30;
            int Numero3 = 16;

            Suma = Numero1 + Numero2;
            Resta = Numero1 - Numero2;


            Console.WriteLine(Suma);
            Console.WriteLine(Resta);
            Console.WriteLine(Numero1 * Numero2);



            // Estructura de condicion
            /* if, switch,else

              variable a comprar |operador| valor a comparar 
                   
              if(condiciones)
              {
                  instruccion
              }
              else
              {
                  instrueccion
              }    

              switch (valor)
              {
                  case valor:
                     instruccion
                     break;
                  default:
                     intruccion
                     break;   
              }     

            */

            if (Numero3 > 0)
                Console.WriteLine(Numero1 / Numero3);
            else
                Console.WriteLine("No se puede divir entre cero ");


            if (Numero1 > Numero2)
            {
                if (Numero1 > Numero3)
                    Console.WriteLine($"{Numero1} es mayor");
                else
                {
                    if (Numero3 > Numero2)
                        Console.WriteLine($"{Numero3} es mayor");
                    else
                        Console.WriteLine($"{Numero2} es mayor");
                }
            }
            else
            {
                if (Numero2 > Numero3)
                    Console.WriteLine($"{Numero2} es mayor");
                else
                {
                    if (Numero3 > Numero1)
                        Console.WriteLine($"{Numero3} es mayor");
                    else
                        Console.WriteLine($"{Numero1} es mayor");
                }
            }


            if (Numero1 > Numero2 && Numero1 > Numero3)
                Console.WriteLine($"{Numero1} es mayor");

            if (Numero2 > Numero1 && Numero2 > Numero3)
                Console.WriteLine($"{Numero2} es mayor");

            if (Numero3 > Numero1 && Numero3 > Numero2)
                Console.WriteLine($"{Numero3} es mayor");

           
             Console.WriteLine("Teclee una opcion:");
            string opcion = Console.ReadLine();

            switch (int.Parse(opcion) )
            {
                case 1:
                    Console.WriteLine($"tecleaste la opcion {opcion}");
                    break;
                case 10:
                    Console.WriteLine($"tecleaste la opcion {opcion}");
                    break;
                case 12:
                    Console.WriteLine($"tecleaste la opcion {opcion}");
                    break;
                default:
                    Console.WriteLine($"{opcion} no es una opcion valida");
                    break;
            }

        }
    }
}
