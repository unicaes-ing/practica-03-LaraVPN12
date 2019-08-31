using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double horas;
            Console.Write("Ingrese el número de horas: ");
            horas = Convert.ToInt32(System.Console.ReadLine());
            double minutos,segundos;
            minutos = horas / 60;
            segundos = horas / 3600;
            Console.WriteLine("{0} horas a minutos es igual a {1:N2}\n{0} horas a segundos es igual a {2:N5}",horas,minutos,segundos);
            Console.ReadKey();
          
           
        }
    }
}
