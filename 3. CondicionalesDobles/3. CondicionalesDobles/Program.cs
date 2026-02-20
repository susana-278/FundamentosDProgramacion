using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CondicionalesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**//*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en
           pantalla con el nombre de la persona, indicando que debe abonar impuestos. De lo contrario mostrar el mensaje "Persona exenta de impuestos".*//*
                                                                                                                                                          * 
            Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en                                                                                                                                              
            caso contrario informar el producto y la división del primer número respecto al segundo número.

           string nombre = "";
           float sueldo = 0;
           Console.WriteLine("Ingrese el nombre del usuario");
           nombre=Console.ReadLine();
           Console.WriteLine("Ingrese el valor del sueldo");
           sueldo=Single.Parse(Console.ReadLine());//Aquí se convierte el FLOAT utilizando la clase SINGLE

           if (sueldo >=3000)
           {
               //Cuando es verdad
               Console.WriteLine($"El usuario {nombre} debe abonar impuestos.");
           }  
           else
           {
               //Cuando es falso
               Console.WriteLine($"El usuario {nombre} esta exenta de impuestos");*/



            float n1 = 0;
            float n2 = 0;
            Console.WriteLine("Ingrese el valor del primer número");
            n1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del segundo número");
            n2 = Single.Parse(Console.ReadLine());
        }
    }
}
