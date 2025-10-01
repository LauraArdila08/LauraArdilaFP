namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            encuentre y muestre el valor máximo y mínimo de los números ingresados.*/

            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i + 1}, con índice {i}:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maximo = numeros[0];
            int minimo = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                    maximo = numeros[i];
                if (numeros[i] < minimo)
                    minimo = numeros[i];
            }

            Console.WriteLine($"El valor máximo ingresado es: {maximo}");
            Console.WriteLine($"El valor mínimo ingresado es: {minimo}");

            /* 2. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
            orden de los elementos del vector. Se deben mostrar los dos vectores.]*/

            char[] caracteres = new char[6];

            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i + 1}, con índice {i}:");
                caracteres[i] = Char.Parse(Console.ReadLine());
            }

            Console.WriteLine("Vector original:");
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write($"{caracteres[i]} |");
            }
            Console.WriteLine();

            char[] invertido = new char[caracteres.Length];
            for (int i = 0; i < caracteres.Length; i++)
            {
                invertido[i] = caracteres[caracteres.Length - 1 - i];
            }

            Console.WriteLine("Vector invertido:");
            for (int i = 0; i < invertido.Length; i++)
            {
                Console.Write($"{invertido[i]} |");
            }
            Console.WriteLine();


            /*3. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
            0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
            número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
            vector resaltando el número en un color diferente. Si no se encuentra el número, se debe
            devolver y mostrar -1.*/


            int[] vector20 = new int[20];
            Random rand = new Random();

            for (int i = 0; i < vector20.Length; i++)
            {
                vector20[i] = rand.Next(0, 51);
            }

            Console.WriteLine("Vector generado:");
            for (int i = 0; i < vector20.Length; i++)
            {
                Console.Write($"{vector20[i]} |");
            }
            Console.WriteLine();

            Console.WriteLine("Ingrese un número entero positivo para buscar en el vector:");
            int numeroBuscado = int.Parse(Console.ReadLine());

            int posicion = -1;
            for (int i = 0; i < vector20.Length; i++)
            {
                if (vector20[i] == numeroBuscado)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El número {numeroBuscado} se encuentra en la posición {posicion}.");
                Console.WriteLine("Vector resaltando el número encontrado:");

                for (int i = 0; i < vector20.Length; i++)
                {
                    if (vector20[i] == numeroBuscado)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{vector20[i]} |");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{vector20[i]} |");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("-1");
            }



            /*4. Escribir un algoritmo que permita:
             Crear un vector con rango impar, exceptuando el 1,
             Pedirle al usuario un número entero y almacenarlo en la mitad del vector.
             Llenar la primera mitad del vector, con los números menores al número almacenado
            en la posición de la mitad.
             Llenar la parte inicial del vector, con los números menores al número almacenado en
            la posición de la mitad.
             Llenar la parte final del vector, con los números mayores al número almacenado en la
            posición de la mitad.
             Mostrar el vector en pantalla.*/
                       

            int tamano;
            do
            {
                Console.WriteLine("Ingrese el tamaño impar del vector (mayor que 1):");
                tamano = int.Parse(Console.ReadLine());
            } while (tamano <= 1 || tamano % 2 == 0);

            int[] vectorImpar = new int[tamano];

            int mitad = tamano / 2;
            Console.WriteLine($"Ingrese un número entero para almacenar en la posición central (índice {mitad}):");
            int numCentral = int.Parse(Console.ReadLine());
            vectorImpar[mitad] = numCentral;

            for (int i = 0; i < mitad; i++)
            {
                vectorImpar[i] = numCentral - (mitad - i);
            }

            for (int i = mitad + 1; i < tamano; i++)
            {
                vectorImpar[i] = numCentral + (i - mitad);
            }

            Console.WriteLine("Vector resultante:");
            for (int i = 0; i < tamano; i++)
            {
                Console.Write($"{vectorImpar[i]} |");
            }
            Console.WriteLine();

            /*5. Escribir un algoritmo que permita:
             Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el usuario.
             LLenar el primer vector con números aleatorios entre 0 y su rango+1
             LLenar el segundo vector con números aleatorios entre rango y rango*2
             Combinar los dos vectores en uno solo.
             Mostrar en pantalla los tres vectores*/

            
            Console.WriteLine("Ingrese el tamaño del primer vector:");
            int rango1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tamaño del segundo vector:");
            int rango2 = int.Parse(Console.ReadLine());

            int[] vector1 = new int[rango1];
            int[] vector2 = new int[rango2];
            Random random = new Random();

            for (int i = 0; i < rango1; i++)
            {
                vector1[i] = random.Next(0, rango1 + 2);
            }

            for (int i = 0; i < rango2; i++)
            {
                vector2[i] = random.Next(rango2, rango2 * 2 + 1);
            }

            int[] combinado = new int[rango1 + rango2];
            vector1.CopyTo(combinado, 0);
            vector2.CopyTo(combinado, rango1);

            Console.WriteLine("Primer vector:");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write($"{vector1[i]} |");
            }
            Console.WriteLine();

            Console.WriteLine("Segundo vector:");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write($"{vector2[i]} |");
            }
            Console.WriteLine();

            Console.WriteLine("Vector combinado:");
            for (int i = 0; i < combinado.Length; i++)
            {
                Console.Write($"{combinado[i]} |");
            }
            Console.WriteLine();
        }
    }
}
