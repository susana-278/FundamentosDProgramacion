using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._3Parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int pizza = 0;
            float precio = 15.000f; //precio de la pizza base
            char ingredientes = ' ';
            int pimiento = 0;  
            int tofu = 0;   
            int champiniones = 0;
            int tomate = 0; 
            int lechuga = 0;    

            int res = 0;
            int chorizo = 0;
            int pollo = 0;
            int tocineta = 0;   
            int cerdo = 0;  
            Console.WriteLine("Bienvenido a la pizzería Olafo");

            Console.WriteLine("Escoge el tipo de pizza deseado: 1 = vegetariano, 2 = meat lovers");
            pizza = int.Parse(Console.ReadLine());

            if (pizza == 1)
            {
                Console.WriteLine("Combos: Pimiento + Champiñones + Lechuga = $20.000");
                Console.WriteLine("Combos: Tofu + Champiñones + Lechuga = $30.000");


                Console.WriteLine("Escoge los ingredientes deseados: p = pimiento, t = tofu, c = champiñones, x = tomate, l = lechuga");
                ingredientes = char.Parse(Console.ReadLine());
               
                switch (ingredientes)
                {
                    case 'p':

                       Console.WriteLine("Se agrego pimiento");
                        break;
                    case 't':
                        Console.WriteLine("Se agrego tofu");
                        break;
                    case 'c':
                        Console.WriteLine("Se agregaron champiñiones");
                        break;
                    case 'x':
                        Console.WriteLine("Se agregaron tomates");
                        break;
                    case 'l':
                        Console.WriteLine("Se agrego lechuga");
                        break;
                    default:
                        Console.WriteLine("Escoge no más de 3 ingredientes");
                        break;


                }


                Console.WriteLine("p = pimiento, t = tofu, c = champiñones, x = tomate, l = lechuga");
                ingredientes = char.Parse(Console.ReadLine());

                switch (ingredientes)
                {
                    case 'p':

                        Console.WriteLine("Se agrego pimiento");
                        break;
                    case 't':
                        Console.WriteLine("Se agrego tofu");
                        break;
                    case 'c':
                        Console.WriteLine("Se agregaron champiñiones");
                        break;
                    case 'x':
                        Console.WriteLine("Se agregaron tomates");
                        break;
                    case 'l':
                        Console.WriteLine("Se agrego lechuga");
                        break;
                    default:
                        Console.WriteLine("Escoge no más de 3 ingredientes");
                        break;


                }


                Console.WriteLine("p = pimiento, t = tofu, c = champiñones, x = tomate, l = lechuga");
                ingredientes = char.Parse(Console.ReadLine());

                switch (ingredientes)
                {
                    case 'p':

                        Console.WriteLine("Se agrego pimiento");
                        break;
                    case 't':
                        Console.WriteLine("Se agrego tofu");
                        break;
                    case 'c':
                        Console.WriteLine("Se agregaron champiñiones");
                        break;
                    case 'x':
                        Console.WriteLine("Se agregaron tomates");
                        break;
                    case 'l':
                        Console.WriteLine("Se agrego lechuga");
                        break;
                    default:
                        Console.WriteLine("Escoge no más de 3 ingredientes");
                        break;
                }

                if (ingredientes == pimiento + champiniones + lechuga)
                {
                    Console.WriteLine("El precio de la pizza sera: 20.000$");
                } //p = pimiento, t = tofu, c = champiñones, x = tomate, l = lechuga

                else if (ingredientes == tofu + champiniones + lechuga)
                {
                    Console.WriteLine("La adición de ingredientes es de $30.000");
                    Console.WriteLine($"El precio total de la pizza es de {precio + 30.000f}");
                }
                else if (ingredientes == tofu + champiniones + tomate)
                {
                    Console.WriteLine("La adición de ingredientes es de $25.000$");
                    Console.WriteLine($"El precio total de la pizza es de {precio + 25.000f}");
                }
                else if (ingredientes == lechuga + champiniones + tomate)
                {
                    Console.WriteLine("La adición de ingredientes es de $25.000$");
                    Console.WriteLine($"El precio total de la pizza es de {precio + 25.000f}");
                }
              else  if (ingredientes == pimiento + tofu + lechuga)
                {
                    Console.WriteLine("La adición de ingredientes es de $25.000$");
                    Console.WriteLine($"El precio total de la pizza es de {precio + 25.000f}");
                }
               else  if (ingredientes == pimiento + tofu + tomate)
                {
                    Console.WriteLine("La adición de ingredientes es de $25.000");
                    Console.WriteLine($"El precio total de la pizza es de {precio + 25.000f}");
                }
               else  if (ingredientes == pimiento + tofu + tomate)
                {
                    Console.WriteLine("La adición de ingredientes es de $25.000");
                    Console.WriteLine($"El precio total de la pizza es de {precio + 25.000f}");
                }

            }

            if (pizza == 2)
            {
                Console.WriteLine("Combos: Res + Pollo = $10.000");
                Console.WriteLine("Combos: Res + Tocineta = $15.000");
                Console.WriteLine("Combos: Chorizo + Tocineta = $25.000");
                

                Console.WriteLine("Escoge los ingredientes deseados: r= res, a = chorizo, p = pollo, y = tocineta, z = cerdo");
                ingredientes = char.Parse(Console.ReadLine());


                switch (ingredientes)
                {
                    case 'r':
                        Console.WriteLine("Se agrego res");
                        break;
                    case 'a':
                        Console.WriteLine("Se agrego chorizo");
                        break;
                    case 'p':
                        Console.WriteLine("Se agrego pollo");
                        break;
                    case 'y':
                        Console.WriteLine("Se agrego tocineta ");
                        break;
                    case 'z':
                        Console.WriteLine("Se agrego cerdo");
                        break;
                    default:
                        Console.WriteLine("Escoge no más de 2 ingredientes");
                        break;


                }
               
                Console.WriteLine("r= res, a = chorizo, p = pollo, y = tocineta, z = cerdo");
                ingredientes = char.Parse(Console.ReadLine());


                switch (ingredientes)
                {
                    case 'r':
                        Console.WriteLine("Se agrego res");
                        break;
                    case 'a':
                        Console.WriteLine("Se agrego chorizo");
                        break;
                    case 'p':
                        Console.WriteLine("Se agrego pollo");
                        break;
                    case 'y':
                        Console.WriteLine("Se agrego tocineta ");
                        break;
                    case 'z':
                        Console.WriteLine("Se agrego cerdo");
                        break;
                    default:
                        Console.WriteLine("Escoge no más de 2 ingredientes");
                        break;


                }
             
                Console.WriteLine("r= res, a = chorizo, p = pollo, y = tocineta, z = cerdo");
                ingredientes = char.Parse(Console.ReadLine());


                switch (ingredientes)
                {
                    case 'r':
                        Console.WriteLine("Se agrego res");
                        break;
                    case 'a':
                        Console.WriteLine("Se agrego chorizo");
                        break;
                    case 'p':
                        Console.WriteLine("Se agrego pollo");
                        break;
                    case 'y':
                        Console.WriteLine("Se agrego tocineta ");
                        break;
                    case 'z':
                        Console.WriteLine("Se agrego cerdo");
                        break;
                    default:
                        Console.WriteLine("Escoge no más de 2 ingredientes");
                        break;


                } //r= res, a = chorizo, p = pollo, y = tocineta, z = cerdo
                if (ingredientes == res + pollo)
                {
                    Console.WriteLine("La adición de ingredientes es de $10.000");
                    Console.WriteLine($"El precio total de la pizza es {precio + 10.000f}");
                }
                else if (ingredientes == res + tocineta)
                {
                    Console.WriteLine("La adición de ingredientes es de $15.000");
                    Console.WriteLine($"El precio total de la pizza es {precio + 15.000f}");
                }
                else if (ingredientes == chorizo + tocineta)
                {
                    Console.WriteLine("La adición de ingredientes es de $25.000");
                    Console.WriteLine($"El precio total de la pizza es {precio + 15.000f}");
                }
            }


        }
    }
}

