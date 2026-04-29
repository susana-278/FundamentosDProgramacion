using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ventas = new int[5, 7];
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Almacén {i + 1}");
                for (int j = 0; j < 7; j++)
                {
                    int valor;
                    do
                    {
                        Console.WriteLine($"Ingrese ventas para {dias} {j} : ");
                    } while (valor = int.TryParse(Console.ReadLine()));

                    ventas[i, j] = valor;
                }
            }

            Console.WriteLine("Matriz de ventas:");
            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine($"{dias} {j} ");

            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A {i + 1}");
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"{ventas[i, j]}");
                }
            }
            double[] promedio = new double[5];

            Console.WriteLine("Promedio semanal por almacén:");
            for (int i =0; i < 5; i++)
            {
                int suma = 0;
                for (int j =0; j < 7; j++)
                {
                    suma += ventas[i, j];
                    promedio[i] = suma / 7;
                    Console.WriteLine($"Almacen {i + 1}: {promedio[i]}");
                }
            }

            double sumaLunes = 0;
            double sumaViernes = 0;

            for (int i =0; i < 5; i++)
            {
                sumaLunes += ventas[i, 0];
                sumaViernes += ventas[i, 4];
            }
            Console.WriteLine($"Promedio Lunes: {sumaLunes}");
            Console.WriteLine($"Promedio Viernes: {sumaViernes}");

            int min = ventas[0, 0];
            int max = ventas[0, 0];

           for (int i = 0; i < 5; i++)
           {
                for (int j = 0; j < 7; j++)
                {

                }
           }

            double mejorProm = 0;
            int mejorAlmacen = 0;

            for (int i = 0; i < 5; i++)
            {
                if (promedio[i] > mejorProm);
                {
                    mejorProm = promedio[i];
                    mejorAlmacen = i;
                }
            }
            Console.WriteLine($"El almacen con el mayor promedio es: {mejorAlmacen}");

            int mejorDia = 0;
            int mejorTotal = 0;
            
            for (int j = 0; j < 7; j++)
            {
                int sumaDia = 0;
                for (int i =0; i < 5; i++)
                {
                    sumaDia += ventas[i, j];
                    if (j == 0 && sumaDia > mejorTotal)
                    {
                        mejorTotal = sumaDia;
                        mejorDia = j;
                    }
                }
                Console.WriteLine($"Día con mayor cantidad de ventas: {mejorDia}");
            }
        }
    }
}
