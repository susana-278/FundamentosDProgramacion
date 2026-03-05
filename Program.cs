using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //punto 3//
            /* int x1 = 0;
             int x2 = 0;
             int x3 = 0;
             int y1 = 0;
             int y2 = 0;
             int y3 = 0;
             float distanciaX1Y1 = 0;
             float distanciaX2Y2 = 0;
             float distanciaX3Y3 = 0;    

             Console.WriteLine("Ingrese tres coordenadas en x,y para formar un triángulo");

             Console.WriteLine("Ingrese el digito de x de la primera coordenada");
             x1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el digito de y de la primera coordenada");
             y1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el digito de x de la segunda coordenada");
             x2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el digito de y de la segunda coordenada");
             y2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el digito de x de la tercera coordenada");
             x3 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el digito de y de la tercera coordenada");
             y3 = Convert.ToInt32(Console.ReadLine());

             distanciaX1Y1 = ((float)Math.Sqrt(((x2 - x1)) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
             distanciaX2Y2 = ((float)Math.Sqrt(((x3 - x1)) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));
             distanciaX3Y3 = ((float)Math.Sqrt(((x3 - x2)) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));

             if (distanciaX1Y1 + distanciaX2Y2 > distanciaX3Y3 && distanciaX2Y2 + distanciaX3Y3 > distanciaX1Y1 && distanciaX1Y1 + distanciaX3Y3 > distanciaX2Y2)
             {
                 Console.WriteLine("Los puntos pueden formar un triángulo");
             }
             else
             {
                 Console.WriteLine("Los puntos no pueden formar un triángulo");
             }*/

            //punto 4//
            /*char MovePersonaje = ' ';

            Console.WriteLine("El personaje solo se mueve de manera horizontal. Presionse la tecla D para que el personaje se mueva hacia la derecha." +
                "Presione la tecla I para que el personaje se mueva hacia la izquierda");
            MovePersonaje = char.Parse(Console.ReadLine());

            switch (MovePersonaje)
            {
                case 'D':
                    MovePersonaje = 'D';
                    Console.WriteLine("El personaje se mueve hacia la derecha");
                    break;

                case 'I':
                    MovePersonaje = 'I';
                    Console.WriteLine("El personaje se mueve hacia la izquierda");
                    break;
                default:
                    Console.WriteLine("No me puedo mover en otra dirección");
                    break;*/

            int vidas;
            char acciones = ' ';

            Console.WriteLine("Ingrese una acción que pueda realizar el personaje: c = disparar, x = hablar con rana, t = modo turbo, i = el personaje es invencible");
            acciones = char.Parse(Console.ReadLine());
            Random rnd = new Random();
            vidas = rnd.Next(0, 5);

            if (vidas > 0)
            {
                Console.WriteLine($"El personaje {vidas} vidas");
                switch (acciones)
                {
                    case 'c':
                        Console.WriteLine("El personaje esta disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje esta hablando con la rana");
                        break;
                    case 't':
                        Console.WriteLine("El personaje esta en modo turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje esta invencible");
                        break;
                    default:
                        Console.WriteLine("El personaje no esta realizando ninguna acción");
                        break;
                }



            }
        }
    }
}


