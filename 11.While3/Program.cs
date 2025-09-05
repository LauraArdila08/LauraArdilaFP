namespace _11.While3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*11. Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. 
            Se debe mostrar por pantalla el total de la suma de los números ingresados*/

            int numero = 0;
            int suma = 0;
            

            while (0 <= numero)
            {
                Console.WriteLine("Ingrese un número:");
                numero = Int32.Parse(Console.ReadLine());

                suma = suma + numero;
            }

            Console.WriteLine($"La suma total es: {suma}");
        }
    }
}
