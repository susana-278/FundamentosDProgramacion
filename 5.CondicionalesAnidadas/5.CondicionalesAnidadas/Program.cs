using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Diseñar un algoritmo que lea tres números A, B, C y visualice el valor más grande. El usuario debe ingresar tres valores diferentes.*/
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese tres valores diferentes");

            Console.WriteLine("Ingrese el valor del número 1");
            num1= 0; Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = 0; Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = 0; Int32.Parse(Console.ReadLine());
            /*if (num1>num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El número mayor es:{num1}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es:{num3}");
                }

            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El número mayor es:{num2}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }*/
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El número mayor es:{num1}");
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"El número mayor es:{num2}");
                }
            }

        }  
    }
}
/*Realizar un algoritmo que permita solicitar 3 calificaciones, calcular el promedio.
 * Si el promedio se ubica en los siguientes rangos, escribir los correspondientes mensajes. Considerar la situación en donde el promedio generado no esté
 * contemplado en los rangos establecidos, mostrar un mensaje de error:
 * 9.5 - 10 Excelente
 * 8.5 - 9.4 Muy bien
 * 7.5 - 8.5 Bien*/

namespace _5.CondicionalesAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cal1 = 0;
            int cal2 = 0;
            int cal3 = 0;
            Console.WriteLine("Ingrese la primera calificación");
            cal1 = 0; Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda calificación");
            cal2 = 0; Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la tercera calificación");
            cal3 = 0; Int32.Parse(Console.ReadLine());
        }
        