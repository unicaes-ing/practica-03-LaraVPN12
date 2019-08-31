using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_3_6
    {
        static void Main(string[] args)
        {
            double monto;
            Console.WriteLine("Ingrese el monto de su compra:");
            monto = Convert.ToDouble(Console.ReadLine());
            if (monto >= 0 && monto <= 100)
            {
                Console.WriteLine("DESCUENTO: 0%");
                Console.WriteLine("TOTAL A PAGAR: {0:C2}", monto);
            }

            if (monto > 100 && monto <= 200)
            {
                Console.WriteLine("DESCUENTO: {0:C2}",(monto*0.12));
                monto = monto + (monto * 0.12);
                Console.WriteLine("TOTAL A PAGAR: {0:C2}", monto);
            }

            if (monto > 200 && monto <= 500)
            {
                Console.WriteLine("DESCUENTO: {0:C2}", (monto * 0.15));
                monto = monto + (monto * 0.15);
                Console.WriteLine("TOTAL A PAGAR: {0:C2}", monto);
            }

            if (monto > 500)
            {
                Console.WriteLine("DESCUENTO: {0:C2}",(monto * 0.2));
                monto = monto + (monto * 0.2);
                Console.WriteLine("TOTAL A PAGAR: {0:C2}", monto);
            }
            Console.ReadKey();
        }
    }
}
