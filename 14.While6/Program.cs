namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
            El algoritmo debe escribir en pantalla: 
            La cantidad de números introducidos que son mayores que 0 
            La cantidad de números introducidos menores que 0  
            La cantidad de números iguales a 0.*/

            int cantidadNumeros = 0;

            int mayoresCero = 0;
            int menoresCero = 0;
            int numCeros = 0;
            int num = 0;
            int contador = 0;
            

            Console.WriteLine("Cantidad de números a ingresar:");
            cantidadNumeros = Int32.Parse(Console.ReadLine());

            while(contador < cantidadNumeros)
            {
                Console.WriteLine("Escribe el número:");
                num = Int32.Parse(Console.ReadLine());

                if (num >0)
                {
                    mayoresCero++;
                }
                else
                {
                    if (num<0)
                    {
                        menoresCero++;
                    }
                    else
                    {
                        numCeros++;
                    }
                }
                contador++;
            }

            Console.WriteLine($"Cantidad de números mayores que 0: {mayoresCero}, cantidad de números menores que 0: {menoresCero}, cantidad de números iguales a 0: {numCeros}");



        }
    }
}
