using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_3_3
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3;
            Console.Write("Ingrese el primer número: ");
            numero1 = Convert.ToInt32(System.Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToInt32(System.Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            numero3 = Convert.ToInt32(System.Console.ReadLine());
            int primero = 0, segundo = 0, tercero = 0;

            if (numero1 > numero2 && numero1 > numero3)
            {
                primero = numero1;

                if (numero2 > numero3)
                {
                    segundo = numero2;
                    tercero = numero3;
                   
                }
                if (numero3 > numero2)
                {
                    segundo = numero3;
                    tercero = numero2;
                    Console.WriteLine("Los numeros son {0},{1},{2}", primero, segundo, tercero);  
                }

                Console.ReadKey();

            }
            if (numero2 > numero1 && numero2 > numero3)
            {
                primero = numero2;
                if (numero1 > numero3)
                {
                    segundo = numero1;
                    tercero = numero3;
                    Console.WriteLine("Los numeros son {0},{1},{2}", primero, segundo, tercero);  
                }
                if (numero3 > numero1)
                {
                    segundo = numero3;
                    tercero = numero1;
                    Console.WriteLine("Los numeros son {0},{1},{2}", primero, segundo, tercero);  
                }
                Console.ReadKey();
            }
            if (numero3 > numero1 && numero3 > numero2)
            {
                primero = numero3;
                if (numero2 > numero1)
                {
                    segundo = numero2;
                    tercero = numero1;
                    Console.WriteLine("Los numeros son {0},{1},{2}", primero, segundo, tercero);  
                }
                if (numero1 > numero2)
                {
                    segundo = numero1;
                    tercero = numero2;
                    Console.WriteLine("Los numeros son {0},{1},{2}", primero, segundo, tercero);  
                }
                Console.ReadKey();
            }
        }
    }
}
