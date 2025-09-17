using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _22.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos Unidemensionales
            //Vectores

            int[] numeros = new int[5];
            string[] nombres = new string[4];

            //Almacenemos datos

            numeros[0] = 12;
            numeros[1] = 32;
            numeros[2] = 41;
            numeros[3] = 100;
            numeros[4] = 56;
            //numeros[5]= 23; Error fuera de rango: no se puede almacaenar el dato porque al condición con índice 5 no existe.

            //Recuperar datos
            Console.WriteLine($"El valor almacenado en la posición 4, con índice 3 es: {numeros[3]}.");


            //Recorrer para almacenar

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i + 1}, con índice {i}.");
                numeros[i] = int.Parse(Console.ReadLine());

            }

            //Otras formas de declarar e inicializar vectores

            char[] caracteres = new char[]{'a', 'b', 'c', 'd', 'e','f','g'};
            float[] numeros2 = {0.3f, 1.5f, 2.5f, 4.5f, 0.0f};

            //Recorrer para recuperar datos almacenados

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"P: {i + 1} -I {i}: {caracteres[i]}.");
            }


            Console.WriteLine();
            for (int i = 0; i < numeros2.Length; i++)
            {
                Console.Write($"{numeros2[i]} |");
            }

            Console.WriteLine();
            Console.WriteLine();

            //Recorrer nombres para almacenar

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la posición {i + 1}, con índice {i}.");
                nombres[i] = Console.ReadLine();
            }

            Console.WriteLine();
            //Recorrer nombres para recuperar datos almacenados
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"{nombres[i]} |");
            }
        }
    }
}
