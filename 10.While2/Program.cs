namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int numero = 0;
            int factorial = 1;

            Console.WriteLine("Ingrese un número para calcular su factorial:");
            numero = int.Parse(Console.ReadLine());

            while (numero > 1)
            {
                factorial *= numero;
                numero--;
            }

            Console.WriteLine($"El factorial es: {factorial}");
        }
    }
}
