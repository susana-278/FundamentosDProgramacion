using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* char DiaSemana = ' ';//<- dia de la semana
             float totalCompra = 0; //<- sueldo del descuento de la semana
             float descuento = 0;
             Console.WriteLine("Ingrese el día de la semana. l=lunes, m=martes, x=miercoles, j=jueves, v=viernes, s=sábado, d=domingo.");
             DiaSemana = Char.Parse (Console.ReadLine());
             Console.WriteLine("Ingrese el total de la compra");
             totalCompra = Single.Parse (Console.ReadLine());

             switch (DiaSemana) //<- changes based on what the case is
             {
                 case 'l':
                     descuento = totalCompra * 0.1f; //<- f means float
                     Console.WriteLine($"Hoy es Lunes, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                     break;
                 case 'm':
                     descuento = totalCompra * 0.15f;
                     Console.WriteLine($"Hoy es Martes, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                     break;
                 case 'x':
                     descuento = totalCompra * 0.1f;
                     Console.WriteLine($"Hoy es Miércoles, el duescuento es de {descuento}, el total de la compra es de {totalCompra}");
                     break;
                 case 'j':
                     descuento = totalCompra * 0.15f;
                     Console.WriteLine($"Hoy es Jueves, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                        break ;
                 case 'v':
                     descuento = totalCompra * 0.15f;
                     Console.WriteLine($"Hoy es Viernes, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                     break;
                 case 's':
                     descuento = totalCompra * 0.2f;
                     Console.WriteLine($"Hoy es Sábado, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                     break;
                 case 'd':
                     descuento = totalCompra * 0;
                     Console.WriteLine($"Hoy es Domingo, el descuento es de {descuento}, el total de la compra es de {totalCompra}");
                     break;
                 default:
                     Console.WriteLine("Selecione un día correcto de la semana");
                     break;

                 //this is like a chart full of different cases its honestly more understandable than the whole if and else stuff

             }*/

            /*Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.
             * Las operaciones disponibles serán: suma. resta. multiplicación, y división, las cuales se ejecutarán según la opción seleccionada por el usuario.*/
            /*/ char operación = ' ';
             float n1 = 0.0f;
             float n2 = 0.0f;
             float resultado = 0.0f;
             Console.WriteLine("Ingrese la operación a realizar: s=suma, r=resta, m=multiplicación, d=división");
             operación = Char.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el valor del primer número");
             n1 = Single.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el valor del segundo número");
             n2 = Single.Parse(Console.ReadLine());

             switch (operación)
             {
                 case 's':
                     resultado = n1+n2;
                 Console.WriteLine($"La suma de los dos números es {resultado}");    
                     break;
                 case 'r':
                     resultado = n1 - n2;
                     Console.WriteLine($"La resta de los dos números es {resultado}");
                     break;
                 case 'm':
                     resultado = n1 * n2;
                     Console.WriteLine($"La multiplicación de los dos números es {resultado}");
                     break;
                 case 'd':
                     resultado = n1 / n2;
                     Console.WriteLine($"La división de los dos números es {resultado}");
                     break;
                 default:
                     Console.WriteLine("Seleccione la operación correcta a realizar");
                     break;*/
            /*Algoritmo que permita ingresar dos números enteros y decir cual es el número mayor*/
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ingrese el valor del número 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 > num2 ? $"El número mayor es: {num1}" : $"El número mayor es: {num2}");
            /*if (num1 > num2)
             {
                 Console.WriteLine($"El número mayor es: {num1}");
             }
             else
             {
                 Console.WriteLine($"El número mayor es: {num2}");
             }*/ //this is what it means basically

            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(edad > 18 ? "Bienvenido a mi sitio web" : "No eres apto para mi sitio web");





        } 



    }
}
