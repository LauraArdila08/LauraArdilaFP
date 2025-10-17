using System.Diagnostics.Metrics;
using System.Numerics;

namespace _31.TallerProgramaciónModular
{
    internal class Program
    {
        /*1. Desarrolla un programa que permita: 
         Ingresar una palabra 
         LLevar la palabra ingresada a un vector de caracteres 
         Contar la cantidad de vocales y consonantes en la palabra proporcionada por el
        usuario.*/

        static void Main()
        {
            BorrarPantalla();
            string palabra = IngresarPalabra();
            char[] caracteres = ConvertirAVector(palabra);
            ContarVocalesYConsonantes(caracteres);
        }

        static string IngresarPalabra()
        {
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower();
            return palabra;
        }

        static char[] ConvertirAVector(string palabra)
        {
            char[] vector = palabra.ToCharArray();
            Console.WriteLine("\nLa palabra en vector de caracteres es:");
            foreach (char c in vector)
            {
                Console.Write($"|{c}| ");
            }
            Console.WriteLine();
            return vector;
        }

        static void ContarVocalesYConsonantes(char[] vector)
        {
            int vocales = 0;
            int consonantes = 0;

            foreach (char c in vector)
            {
                if (char.IsLetter(c))
                {
                    if ("aeiou".Contains(c))
                        vocales++;
                    else
                        consonantes++;
                }
            }

            Console.WriteLine($"\nCantidad de vocales: {vocales}");
            Console.WriteLine($"Cantidad de consonantes: {consonantes}");
        }


        static void BorrarPantalla()
        {
            Console.Clear();
        }
    }

}

