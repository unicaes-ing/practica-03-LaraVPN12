using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_3_5
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Ingrese un número entero del 1 al 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Uno");
            }

            if (numero == 2)
            {
                Console.WriteLine("Dos");
            }
            
            if (numero == 3)
            {
                Console.WriteLine("Tres");
            }
            
            if (numero == 4)
            {
                Console.WriteLine("Cuatro");
            }
           
            if (numero == 5)
            {
                Console.WriteLine("Cinco");
            }
            
            if (numero == 6)
            {
                Console.WriteLine("Seis");
            }
          
            if (numero == 7)
            {
                Console.WriteLine("Siete");
            }
         
            if (numero == 8)
            {
                Console.WriteLine("Ocho");
            }
            
            if (numero == 9)
            {
                Console.WriteLine("Nueve");
            }
            
            if (numero == 10)
            {
                Console.WriteLine("Diez");
            }
            Console.ReadKey();
        }
    }
}
