using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CondicionalesSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nombre = " ";
            float sueldo = 0;
            Console.WriteLine("Ingrese el nombre del usuario");
            nombre=Console.ReadLine();//Todo lo que el usuario ingresa desde la consola se lee aqui como una cadena de caracteres
            Console.WriteLine("Ingrese su sueldo");
            sueldo = Convert.ToSingle( Console.ReadLine() );
            if (sueldo >= 3000)
            {
                Console.WriteLine($"El usuario {nombre}, debe abonar sus impuestos");
            }*/

            float edad =0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToSingle(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web :)");
            }
        }

    }
}
