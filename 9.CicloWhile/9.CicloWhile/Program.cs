using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                contador++;

                    Console.WriteLine($"Contador: {contador} - Acumulador = {acumulador}");
         
            }
            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/

            int contador = 1;
            int acumulador = 1;
            int numero = 0;

            Console.WriteLine("Ingrese un número paraa calcular su factorial");
            numero=Int32.Parse(Console.ReadLine());

            while (contador <=numero)
            {
                acumulador *= contador;
                contador++;

            }
            Console.WriteLine($"La factorial del número {numero} es: {acumulador}");
        }

    }
}
