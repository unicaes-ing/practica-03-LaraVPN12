using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_3_2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numero = rand.Next(1, 11);
            Console.WriteLine("El número generado fue: {0}", numero);
            Console.ReadKey();
        }
    }
}
