using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //punto 1
            /* desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre
             por pantalla la suma de los elementos de cada columna */

           /* int filas = 10;
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];
            Random rand = new Random(); 

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    
                    matriz[i, j] = rand.Next(1, 10); //escoger un numero aleatorio <- son muchos numeros para poner individualmente :/
                }
            }

            Console.WriteLine("Suma de cada columna:");
            for (int j =0; j < columnas; j++)
            {
                int suma = 0;
                for (int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }
                Console.WriteLine("Columna " + j + ": " + suma);
            }*/

            //punto 2
            /* desarollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa caracters
             en cada posicion de la matriz hasta llenarla. el programa debe intercambiar la primera fila con la
            ultima fila de la matriz. al final se debe imprimir la matriz original, y la matriz con el intercambio 
            de filas */
          Console.WriteLine("Ingrese la cantidad de filas (n)");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de columnas (m)");
            int m = int.Parse(Console.ReadLine());

            char[,] matriz = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j =0; j < m; j++)
                {
                    Console.WriteLine("Ingrese un caracter para [" + i + "," + j + "]");
                    matriz[i,j] = char.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            } Console.WriteLine( );

            for (int j = 0; j < m; j++)
            {
                char temp = matriz[0, j]; // 0, j es la primera fila
                matriz[0, j] = matriz[n - 1, j]; // n - 1 , j es la ultima
                matriz[n - 1, j] = temp;
            }
            Console.WriteLine("Matriz con las filas intercambiadas:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(matriz[i, j]);
                }
            }

        }
    }
}
