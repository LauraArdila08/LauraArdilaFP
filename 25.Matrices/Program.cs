namespace _25.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales-Matrices

            int[,] numeros = new int[2, 2]; //El arreglo va a tener 2 filas y 2 columnas, el rango f*c = 2+2=4 posiciones.
                                            //El rango es la cantidad de posiciones que tiene el arreglo.
            string[,] nombres = new string[3, 2]; //El arreglo va a tener 3 filas y 2 columnas, el rango f*c = 3*2=6 posiciones.
            char[,] letras = new char[2, 3]; //El arreglo va a tener 2 filas y 3 columnas, el rango f*c = 2*3=6 posiciones.
            bool[,] booleanos = new bool[2, 5]; //El arreglo va a tener 2 filas y 2 columnas, el rango f*c = 2*5=10 posiciones.
            object[,] objetos = new object[4, 2];

            //Asignación de valores con f, c

            numeros [0, 0] = 1;
            numeros [0, 1] = 2;
            numeros [1, 0] = 3;
            numeros [1, 1] = 4;
            // numeros [2, 2] = 5; //Error ya que el indice está fuera del arreglo.
            
            //Recuperar datos almacenados en una posición.
            Console.WriteLine($"Valor almacenado en la posición con índices 1,0: { numeros[1,0] }");

            //Declaración e inicialización de matrices con valores por defecto

            string[,] apellidos =
                {
                    {"Pérez", "Gómez" },
                    {"Rodríguez", "López" },
                    {"Sánchez", "Martínez" },
                    {"Ardila" , "Fernández" }
                };

            //Recorrer una matriz para almacenar datos.
            for (int i = 0; i < 3; i++) //Recorre las filas
            {
                for (int j = 0; j < 2; j++) //Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el nombre para la posición con índice {i},{j}: ");
                    nombres[i, j] = Console.ReadLine();
                }
            }

            //Recorrer una matriz para recuperar datos.
            for (int i = 0; i < nombres.GetLength(0); i++) //.GetLenght(0) devuelve el número de filas
            {
                for (int j = 0; j < nombres.GetLength(1); j++) //GetLenght devuelve el número de columnas
                {
                    Console.WriteLine($"Ingreese el nombre para la posición con índice {i},{j}: ");
                }

                for (int k = 0; k < letras.GetLength(0); k++) 
                {
                    for (int j = 0; j < letras.GetLength(1); j++) 
                    {
                        Console.WriteLine($"Ingrese un caracter para la posición con índice {i},{j}:");
                        letras [i, j] = Convert.ToChar(Console.ReadLine());
                    }
                }
            }
        }
    }
}
