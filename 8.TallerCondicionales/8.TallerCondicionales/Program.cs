using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /* int num1 = 0; //punto 1
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Ingrese tres valores diferentes");


            Console.WriteLine("Ingrese el valor del primer número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del tercer número");
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3 && num3 == num1)
            {
                Console.WriteLine("ERROR: Los números no pueden ser iguales.");
            }

            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                if (num1 > num2 && num1 > num3 && num2 > num3)
                {
                    Console.WriteLine($"El número mayor es: {num1}");

                }
                else
                    if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine($"El número mayor es: {num2}");
                }
                else
                    if (num3 > num1 && num3 > num2)
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }

                if (num1 > num2 && num2 > num3)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor serían: {num3}, {num2}, {num1}");
                }
                else
                    if (num2 > num3 && num3 > num1)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor serían: {num1}, {num3}, {num2}");
                }
                else
                    if (num3 > num1 && num1 > num2)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor serían: {num2}, {num1}, {num3}");
                }
                else
                    if (num1 > num3 && num3 > num2)
                {
                    Console.WriteLine($"Los números organizados de menor a mayor serían: {num2}, {num3}, {num1}");




                }



            }*/

            //punto 2
            int estado = 0;
            int numero;

            Console.WriteLine("Ingrese el estado del personaje: 1 = Invensible / 2 = Vencible");
                estado = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            numero = rnd.Next(1, 10);
            Console.WriteLine(numero);

            if (estado == 1 && numero > 0)
            {
                Console.WriteLine("El estado del personaje invensible y tiene munición, y por ende está disparando");
            }
            else
                if(estado != 1 && numero > 0)
            {
                Console.WriteLine("El personaje no esta disparando");
            }

                 
        }
    }
}