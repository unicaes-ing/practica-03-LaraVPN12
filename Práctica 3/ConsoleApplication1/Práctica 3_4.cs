using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_3_4
    {
        static void Main(string[] args)
        {
            int duracion;
            double costo;
            int zona;
            Console.Write("Ingrese la duración en minutos: ");
            duracion = Convert.ToInt32(System.Console.ReadLine());
            Console.Write("Elija su ubicación: \n");
            Console.Write("1. Zona Occidental   2. Zona Oriental    3. Zona Central\n");
            zona = Convert.ToInt32(System.Console.ReadLine());

            if (zona == 1)
            {
                costo = (0.32 * duracion);
                Console.WriteLine("Su costo total es: {0}", costo);
            }
            Console.ReadKey();

            if (zona == 2)
            {
                costo = (0.36 * duracion);
                Console.WriteLine("Su costo total es: {0}", costo);
            }
            Console.ReadKey();

            if (zona == 3)
            {
                costo = (0.25 * duracion);
                Console.WriteLine("Su costo total es: {0}", costo);
            }
            Console.ReadKey();


        }
    }
}
