using System.Timers;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por 
            pantalla la suma de los elementos de cada columna. */

            int filas = 10;
            int columnas = 20;
            int[,] matriz = new int[filas, columnas];

            int suma=0;
                        
            Random rand = new Random();
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rand.Next(1, 51); 
                }
            }

            for (int j = 0; j < columnas; j++)
            {
                
                for (int i = 0; i < filas; i++)
                {
                    suma += matriz[i, j];
                }
                Console.WriteLine($"La suma de los elementos de la columna {j + 1} es: {suma}");
            }

            /*2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
            matriz con el intercambio de filas. */

            int n, m;

            Console.WriteLine("Ingrese el número de filas de la matriz:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            m = int.Parse(Console.ReadLine());

            char[,] matriz2 = new char[n, m];
            char temp;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Ingrese el carácter para la posición [{i},{j}]:");
                    matriz2[i, j] = char.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < m; j++)
            {
                temp = matriz2[0, j];
                matriz2[0, j] = matriz2[n - 1, j];
                matriz2[n - 1, j] = temp;
            }

            Console.WriteLine("Matriz con el intercambio de filas:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            /*3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            5x5 llena de números aleatorios. 
            El algoritmo debe permitir: 
            - Usa la función Random para generar los números aleatorios. 
            - Crea un arreglo adicional para almacenar la frecuencia de cada número. 
            - Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número */

            int[,] matriz3 = new int[5, 5];
            int[] frecuencia = new int[10];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz3[i, j] = random.Next(1, 11); 
                    frecuencia[matriz3[i, j] - 1]++; 
                }
            }
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Frecuencia de cada número del 1 al 10:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]} veces");
            }

            /*4. Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en 
            posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la 
            posición de una "X". 

            El algoritmo debe permitir: 
            - Usar la función Random para colocar las "X" en la matriz. 
            - Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado. 
            - Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la 
            posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz.*/

            char[,] tablero = new char[5, 5];
            Random rand2 = new Random();
            int x, y;
            for (int i = 0; i < 3; i++)
            {
                do
                {
                    x = rand2.Next(0, 5);
                    y = rand2.Next(0, 5);
                } while (tablero[x, y] == 'X'); 
                tablero[x, y] = 'X';
            }

            bool acierto = false;

            for (int intentos = 0; intentos < 3; intentos++)
            {
                Console.WriteLine("Ingrese la fila (0-4):");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la columna (0-4):");
                int columna = int.Parse(Console.ReadLine());
                if (tablero[fila, columna] == 'X')
                {
                    acierto = true;
                    Console.WriteLine($"¡Felicidades! Has acertado la posición de una 'X' en ({fila}, {columna})");
                    break;
                }
                else
                {
                    Console.WriteLine("No has acertado. Inténtalo de nuevo.");
                }
            }
            if (!acierto)
            {
                Console.WriteLine("Lo siento, no has acertado ninguna 'X'. El tablero era:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j] == 'X' ? 'X' : '.');
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }


        }
    }
}
