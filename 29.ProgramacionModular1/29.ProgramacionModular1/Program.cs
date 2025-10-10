namespace _29.ProgramacionModular1
{
    internal class Program
    {
        //29. Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.

        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()]; 
            BorrarPantalla();
            LlenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);
        }

        //Módulo - Procedimiento que borra la pantalla
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Módulo - Procedimiento que recibe la matriz que se va a mostrar en pantalla
        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }
        }

        //Módulo - Función que llena la matriz a llenar y la devuelve con múltiplos de cinco
        static int[,] LlenarMatriz(int[,] matriz)
        {
            int numero = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        Console.WriteLine($"Ingrese un número para almacenar en la matriz:");
                        numero = int.Parse(Console.ReadLine());
                        BorrarPantalla();
                    } while (EsMultiplo5(numero)==false);
                    matriz[i, j] = numero;
                }
            }
            return matriz;
        }

        //Módulo - Función que comprueba si el número es múltiplo de 5

        static bool EsMultiplo5(int numero)
        {
            if (numero % 5 == 0 && numero !=0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error, debe digitar un número múltiplo de 5 a la matriz.");
                return false;
                
            }
        }

        //Módulo - Función que le pregunts al usuario el número de filas de la matriz y lo devuelve
        static int CapturarFilas ()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz:");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        //Módulo - Función que le pregunts al usuario el número de columnas de la matriz y lo devuelve
        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        
    }
}
