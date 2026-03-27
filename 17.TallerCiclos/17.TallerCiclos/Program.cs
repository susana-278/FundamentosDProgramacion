using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Punto 1
            /* Algoritmo que permita calcular el promedio de calificaciones, el algoritmo
            le permitirá al usuario, introducir tantas calificaciones como así desee,
            en el momento en que seleccione que no desea continuar capturando
            calificaciones, el algoritmo debe presentar el promedio de las
            calificaciones capturadas previamente. */

            /*double calificación;
            double suma = 0.0f;
            int contador = 0;
            string opcion;

            do
            {
                Console.WriteLine("Ingrese la calificación adquirida");
                calificación = double.Parse(Console.ReadLine());

                suma += calificación; //acumulador
                contador++;

                Console.WriteLine("Desea ingresar otra calificación? (SI/NO)");
                opcion = Console.ReadLine();

            }
            while (opcion == "SI");
            {
                double promedio = 0.0f;


                if (contador != 0) ;
                {
                    promedio = suma / contador;
                }
                Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
            }*/

            //Punto 2
            /* Se reqeuiere un algoritmo para mostrar por pantalla los divisores de un número ingresado por teclado.
              Tener en cuenta que dados dos números enteros a y b, se dice que b es divisor de a si se cumple al
              efectuar una división entera a/b el residuo es 0, en C# utilizar el operador Mod para obtemer el
              residuo de una división de dos números.*/

           /* int numero = 0;

            Console.WriteLine("Ingrese el valor del número");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divisores del número {numero}");

            for (int contador = numero; contador >= 1; contador--)
            {
                if (numero % contador == 0)
                {
                    Console.WriteLine(contador);
                }

            }
            Console.ReadLine(); */

            //Punto 3

            /* Dados dos números enteros ingresados por teclado: b que es la base y e que es el exponente,
             se requirere calcular el resultado de la potenciación */

            /*int basenum = 0;
            int exp = 0;
            int resultado = 1; //cant be 0 bcs im multiplying
            string opción;

            do
            {


                Console.WriteLine("Ingrese el valor de la base:");
                basenum = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el valor del exponente:");
                exp = int.Parse(Console.ReadLine());


                for (int contador = 1; contador <= exp; contador++) //cant be 0 bcs im multiplying
                {
                    resultado *= basenum;
                }

                Console.WriteLine($"El resultado es: {resultado}");
                Console.WriteLine("Desea continuar? (SI/NO)");
                opción = Console.ReadLine();
            } while (opción != "NO");
            
            Console.ReadLine();*/

            //Punto 4
            /* Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilómetros durante 10 dias,
               para determinar si es apto para la prueba de 5 kilómetros. Para considerarlo se debe cumplir:

             * Que en ninguna de sus prubeas realice un tiempo mayor que 20 minutos
             * Que al menos en una de las pruebas realice un tiempo menor de 15 minutos
             * Que su promedio sea mayor o igual a 18 minutos
              
             Diseñar un algoritmo para registrar los datos y decidir si es apto para la competencia */
            double tiempo = 0;
            double suma = 0;
            bool menor15 = false;
            bool mayor20 = false;

            for (int dia = 1; dia <= 10; dia++)
            {
                Console.WriteLine("Ingrese el tiempo del dia" + dia);
                tiempo = double.Parse(Console.ReadLine());

                suma += tiempo;

                if (tiempo > 20)
                {
                    mayor20 = true;
                }
                if (tiempo < 15)
                {
                    menor15 = true;
                }

            }
            double promedio = suma / 10;

            if (!mayor20 && menor15 && promedio <= 18)
            {
                Console.WriteLine("El atelta es APTO");

            }
            else
            {
                Console.Write("El atleta NO es APTO");
            }
            Console.ReadLine();
        } 
    }
}
