using System;

namespace _16.While8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. 
            El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. 
            Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número.*/

            int numero1 = 0;
            int numero2 = 0;
            Random rnd = new Random();

            numero1 = rnd.Next(1, 101);

            Console.Write("Adivine el número.\nIngrese un número del 1 al 100:");
            numero2 = Int32.Parse(Console.ReadLine());

            while(numero1 != numero2)
            {
                if (numero2 > numero1)
                {
                    Console.WriteLine("Su intento es demasiado alto, intentelo de nuevo:");
                   
                }
                else
                {
                    Console.WriteLine("Su intento es demasiado bajo, intentelo de nuevo:");
                }
                numero2 = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Correcto. El número era {numero1}.");

        }

    }
}
