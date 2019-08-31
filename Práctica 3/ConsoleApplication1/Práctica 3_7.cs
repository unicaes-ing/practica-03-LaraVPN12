using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Práctica_3_7
    {
        static void Main(string[] args)
        {
            int unidad_inicial, unidad_final;
            double cantidad;
            Console.WriteLine("UNIDADES DE MASA");
            Console.WriteLine("Ingrese la unidad:\n1. Onza\n2. Libra\n3. Gramo\n4. Tonelada");
            unidad_inicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad:");
            cantidad=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la unidad de conversión:\n1. Onza\n2. Libra\n3. Gramo\n4. Tonelada");
            unidad_final=Convert.ToInt32(Console.ReadLine());
            double resultado;

            if(unidad_inicial==1 && unidad_final==2){
                resultado = cantidad * 0.0625;
                Console.WriteLine("{0} onzas a Libras es igual a: {1:N2}", cantidad, resultado);
            }
            if (unidad_inicial == 1 && unidad_final == 3)
            {
                resultado = cantidad * 28.3495;
                Console.WriteLine("{0} onzas a Gramos es igual a: {1:N2}", cantidad, resultado);
            }
            if (unidad_inicial == 1 && unidad_final == 4)
            {
                resultado = cantidad * 0.00002834;
                Console.WriteLine("{0} onzas a Toneldas es igual a: {1:N6}",cantidad,resultado);
            }
            if (unidad_inicial == 2 && unidad_final == 1)
            {
                resultado = cantidad * 16;
                Console.WriteLine("{0} libras a Onzas es igual a: {1}", cantidad, resultado);
            }
            if (unidad_inicial == 2 && unidad_final == 3)
            {
                resultado = cantidad * 453.592;
                Console.WriteLine("{0} libras a Gramos es igual a: {1:N2}", cantidad, resultado);
            }
            if (unidad_inicial == 2 && unidad_final == 4)
            {
                resultado = cantidad * 0.0004535;
                Console.WriteLine("{0} libras a onzas es igual a: {1:N4}", cantidad, resultado);
            }
            if (unidad_inicial == 3 && unidad_final == 1)
            {
                resultado = cantidad * 0.03527;
                Console.WriteLine("{0} gramos a Onzas es igual a: {1:N2}", cantidad, resultado);
            }
            if (unidad_inicial == 3 && unidad_final == 2)
            {
                resultado = cantidad * 0.0022;
                Console.WriteLine("{0} gramos a Libras es igual a: {1:N2}", cantidad, resultado);
            }
            if (unidad_inicial == 3 && unidad_final == 4)
            {
                resultado = cantidad * 0.000001;
                Console.WriteLine("{0} gramos a Toneladas es igual a: {1:N6}", cantidad, resultado);
            }
            if (unidad_inicial == 4 && unidad_final == 1)
            {
                resultado = cantidad * 35274;
                Console.WriteLine("{0} toneladas a Onzas es igual a: {1}", cantidad, resultado);
            }
            if (unidad_inicial == 4 && unidad_final == 2)
            {
                resultado = cantidad * 2204.62;
                Console.WriteLine("{0} toneldas a Libras es igual a: {1:N2}", cantidad, resultado);
            }
            if (unidad_inicial == 4 && unidad_final == 3)
            {
                resultado = cantidad * 1000000;
                Console.WriteLine("{0} toneldas a Gramos es igual a: {1}", cantidad, resultado);
            }
            if (unidad_inicial == unidad_final)
            {
                Console.WriteLine("Las unidades de medida son iguales");
            }
            Console.ReadKey();
            


        }
    }
}
