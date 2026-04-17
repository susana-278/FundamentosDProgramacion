using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.ArreglosMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[,] numeros= new int [2,3]; // [] means vector , means matrice, new int [2,3] is the amount of rows (2) and columns (3) or smth
            numeros[0, 0] = 15;
            numeros[0, 1] = 15;
            numeros[0, 2] = 15;
            numeros[1,0] = 36;
            numeros[1,1] = 22;
            numeros[1, 2] = 100;
            string[,] nombres =
            {
                {"Ferney", "Ana" },
                {"Juan", "Carlos"},
                {"Yuli", "Esteban" }
            };

            Char[,] simbolos = new char[2, 5];
            for (int i = 0; i < 2; i++) //recorre las filas
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Ingrese el símbolo para la P{i}.{j}:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }

            }
            Console.Clear();
            //recorrer la matriz para recuperar los datos

            for (int i =0; i < simbolos.GetLength(0); i++) //get length (0) obtiene el numero de filas
            {
                for (int j = 0; j < simbolos.GetLength(1); j++)//get length (1) obtiene el numero de columnas
                {
                    Console.Write(simbolos[i, j] + " | ");
                }
                Console.WriteLine(); */


            /* Escribe un programa que realice la suma de dos matrices de dimensiones 2x3
               requisitos:
            - Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas

            - Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices

            - Muestra la matriz resultante de la suma en formato de matriz(2 filas, 3 columnas). */

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            Console.WriteLine("Ingrese los valores de la primera matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; i < 3; j++)
                {
                    Console.WriteLine($"Elemento [{i}], [{j}]: ");
                    matriz1[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }
        }
    }
}
