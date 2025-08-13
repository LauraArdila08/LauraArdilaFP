<<<<<<< HEAD
﻿namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAL SIMPLE
            /*String nombre = "";
            int sueldo = 0;
            
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();//Todo lo que leo desde la consola llega como string
            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo>3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos.");
            }*/

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”//

            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad>18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");

            }
        }
    }
}
