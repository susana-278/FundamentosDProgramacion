using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //punto 1
            /*Realizar un algoritmo que permita obtener la suma de todos los números impares hasta el 99*/

            /*int contador = 1;
            int acumulador = 0;
            
            while (contador <= 99)
            {
               acumulador += contador;
               contador += 2;
                Console.WriteLine($"Contador: {contador} - Suma impares:{acumulador}");
                Console.WriteLine($"La suma de todos los números impares hasta el 99 es: {acumulador}");
            }*/

            //punto 2
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.
              Al usuario le corresponde ingresar la cantidad de números que va a introducir.
              
              La cantidad de números introducidos que son mayores que 0
              La cantidad de números introducidos menores que 0
              La cantidad de números iguales a 0.*/

            /*int cantidadNumeros = 0;
            int contador = 1;
            int numero = 0;
            int contadorCeros = 0;
            int contadorMayorCero = 0;  
            int contadorMenorCero = 0;
            Console.WriteLine("Ingrese la cantidad de números a ingresar");
            cantidadNumeros = int.Parse(Console.ReadLine());    
            while (contador <= cantidadNumeros)
            {
                Console.WriteLine($"Ingrese el valor del número {contador}");
                numero = int.Parse(Console.ReadLine()); 
                
                if (numero == 0)
                {
                    contadorCeros++;
                }
                else
                {
                    if (numero > 0)
                    {
                        contadorMayorCero++;
                    }
                    else
                        if (numero < 0)
                        {
                            contadorMenorCero++;    
                        }
                }
                contador++;
            }
            Console.WriteLine($"Ceros: {contadorCeros}, Mayores a cero: {contadorMayorCero}, Menores a cero: {contadorMenorCero}");*/

            //punto 3
            /*Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero;
             además, se quiere saber cuanto lleva ahorrado cada mes. */

            int contadorMeses = 0;
            float acumuladorAhorro = 0;
            float ahorro = 0;

            while (contadorMeses <= 12) //twelve months in a year wowwwwwwwwwww
            {
                Console.WriteLine($"En el mes {contadorMeses}, cuánto desea ahorrar:");
                ahorro = Single.Parse(Console.ReadLine());

                acumuladorAhorro += ahorro;
                Console.WriteLine($"Este mes usted ahorró ${ahorro}, para el mes {contadorMeses} usted tiene ahorrado $ {acumuladorAhorro}");

                contadorMeses++;
            }
        }
    }
}
