using System;
using System.Collections.Generic;
using System.Linq;

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

            /*

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

            */

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
            /*
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
            */




            //ciclos  for,while, do while , foreach

            // for(inicio;condicion;incremento){} 
            /*
                        for(int i=0;i<3;i++ ) 
                        {
                            Console.WriteLine(i);
                        }    

                        for( int i=100; i<150;i+=5)
                             Console.WriteLine(i);
            
            for (int i = 100; i >= 0; i-=20)
            {
                Console.WriteLine(i);
            }
*/

            // while (condiciones){}

            /* int i = 0;

              while (i < 3)
              {
                  Console.WriteLine(i);
                  i++;
              }

              string Salir = "No";
              i = 0;
              while (Salir == "No")
              {
                  Console.WriteLine(i);
                  i++;
                  if (i==3)
                  {
                      Salir="Si";
                  }
              }
  */
            // do{}while(condiciones); 
            /*
                        int i = 0;
                        do
                        {
                            Console.WriteLine(i);
                            i++;

                        } while (i < 0);

                        string Salir = "Si";
                        i = 0;
                        do
                        {
                            Console.WriteLine(i);
                            i++;
                            if (i == 3)
                            {
                                Salir = "Si";
                            }
                        } while (Salir == "No");
            */


            //foreach(tipo variable in coleccion de datos)
            /*
                        List<string> Nombres = new List<string>();
                        Nombres.Add("Pedro");
                        Nombres.Add("Maria");
                        Nombres.Add("Jose");
                        Nombres.Add("Juan");
                        Nombres.Add("Francisco");

                        foreach (string nombre in Nombres)
                        {
                            Console.WriteLine(nombre);
                        }
            */

            // tipodato[] NombreArreglo=new tipodato[indice];
/*

            int[] Numeros = new int[10];
            
                      Numeros[0]=1;
                      Numeros[1]=2;
                      Numeros[5]=3000;
                      Numeros[9]=10;
              
            int Suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Numeros[i] = i + 1;
            }

            foreach (int item in Numeros)
            {
                Suma = Suma + item;
            }

            Console.WriteLine(Suma);
            //List<tipodato> Nombre=new List<tipodato>(); 

            List<int> ListaNumeros = new List<int>();

            //  ListaNumeros.Add(1);
            // ListaNumeros.Add(2);
            // ListaNumeros.Add(3);
            // ListaNumeros.Add(10);

            int SumaLista = 0;
            for (int i = 0; i < 10; i++)
            {
                ListaNumeros.Add(i + 1);
            }

            /*foreach (int numero in ListaNumeros)
            {
                SumaLista += numero;
            }

            SumaLista=  ListaNumeros.Sum(); 

            Console.WriteLine(SumaLista);
*/
          SumaNumeros(10,20);
         int x=  SumaNumeros2(1000, SumaNumeros2(36,SumaNumeros2(36,SumaNumeros2(52,SumaNumeros2(1,1)))));
         Console.WriteLine(x);
       

        }

      static void SumaNumeros(int numero1,int numero2 )
      {
          Console.WriteLine(numero1+numero2);
      }            

       static int SumaNumeros2(int numero1,int numero2 )
      {
         return numero1+numero2;
      } 
    }
}
