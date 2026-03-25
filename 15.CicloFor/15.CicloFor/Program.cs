using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int acumulador = 0;

           for (int contador  = 0; contador <=5; contador++)
            {
                acumulador += contador;
            }


            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/


            /*Realizar un progra,a que permita obtener la factorial de un numero entero ingresado por el teclado*/
            /*int acumulador = 1;
              int numero = 1;

              Console.WriteLine("Ingrese el número");
              numero=int.Parse(Console.ReadLine());   


              for (int contador = 1; contador <= numero; contador++)
              {
                  acumulador *= contador;
              }

              Console.WriteLine($"El factorial de {numero} es: {acumulador}");*/


            /*Realizar un programa que permita imprimir por pamntalla los números múltiplos de 5, el usuario debe ingresar por el teclado
             el rango de números a evaluar.*/

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ingrese el primer número");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = int.Parse(Console.ReadLine());
         
            for (int contador = num1; contador <= num2; contador++)
            {
                if (contador%5 == 0)
                {
                    Console.Write(contador);
                }
               
            }
        }
    }
}
