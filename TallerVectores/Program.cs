namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            encuentre y muestre el valor máximo y mínimo de los números ingresados.*/

            int[] numeros = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el dato para la posición {i + 1}, con índice {i}.");
                numeros[i] = int.Parse(Console.ReadLine());                         
                
            }
                    
            /*2. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
            orden de los elementos del vector. Se deben mostrar lo dos vectores.*/

            char[] caracteres = new char[6];
            
            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i + 1}, con índice {i}.");
                caracteres[i] = Char.Parse(Console.ReadLine());
                                
            }


            for (int i = 0; i < caracteres.Length; i++)
            {
                Console.Write($"{caracteres[i]} |");
            }

            Console.WriteLine();

            Array.Reverse(caracteres);
            for (int i = 0; i < caracteres.Length; i++)
            {
                
                Console.Write($"{caracteres[i]} |");
            }

            /*3. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
            0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
            número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
            vector resaltando el número en un color diferente. Si no se encuentra el número, se debe
            devolver y mostrar -1.*/

            Console.WriteLine() ;

            int [] vector20 = new int[20];
            Random rand = new Random();
            int numero = 0;

            Console.WriteLine("Ingrese un número entero positivo para buscar en el vector");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < vector20.Length; i++) 
            { 
                vector20[i] = rand.Next();
                              
                
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


            /*5. Escribir un algoritmo que permita:
             Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el usuario.
             LLenar el primer vector con números aleatorios entre 0 y su rango+1
             LLenar el segundo vector con números aleatorios entre rango y rango*2
             Combinar los dos vectores en uno solo.
             Mostrar en pantalla los tres vectores*/

            int rango = 0;
            int[] vector1 = new int[rango];
        }
    }
}
