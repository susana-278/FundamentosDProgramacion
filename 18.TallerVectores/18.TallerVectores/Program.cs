using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //punto 1

            /* int[] numeros = new int[15]; //cantidad de espacios en el vector 
            int mayor;
            int menor; 

            for (int i = 0; i < numeros.Length ; i++) //0-14
            {
                Console.WriteLine("Ingrese el número " + (i + 1)); 
                numeros[i] = int.Parse(Console.ReadLine());
            }

            mayor = numeros[0];
            menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                if (numeros[i] < menor) 
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine("El número mayor es:" + mayor);
            Console.WriteLine("El número menor es:" + menor); */

            //punto 2
            /* int tamaño = 5;
            int[] vector1 = new int[tamaño];
            int[] vector2 = new int[tamaño];
            int iguales = 0;

            Console.WriteLine("VECTOR 1:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1));
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("VECTOR 2:");
            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1));
                vector2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < tamaño; i++)
            {
                if (vector1[i] == vector2[i])
                {
                    iguales++;
                }
            }

            Console.WriteLine("Cantidad de números iguales " + iguales); */

            //punto 3

            int tamaño = 6;
            char[] vector = new char[tamaño];
            char[] invertido = new char[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.WriteLine("Ingrese un carácter " + (i + 1));
                vector[i] = char.Parse(Console.ReadLine());
            }


        }

    }
}
