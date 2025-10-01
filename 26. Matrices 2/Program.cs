namespace _26._Matrices_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*26. Escribe un programa que realice la suma de dos matrices de dimensiones 2x3. 
            Requisitos del programa: 
            -Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas. 
            -Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3). 
            -Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices. 
            -Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).*/

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] matrizSuma = new int[2, 3];

            Console.WriteLine("Ingrese los elementos de la primera matriz (2x3):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Posición [{i + 1},{j + 1}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los elementos de la segunda matriz (2x3):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Posición [{i + 1},{j + 1}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Sumar las dos matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Mostrar la matriz resultante
            Console.WriteLine("Matriz resultante de la suma:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizSuma[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
