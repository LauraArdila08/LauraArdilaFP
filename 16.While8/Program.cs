namespace _16.While8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*16. Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. 
            El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. 
            Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número.*/

            int numero1 = 0;
            int numero2 = 0;
            Random rnd = new Random();

            numero1 = rnd.Next(1, 100);

            Console.WriteLine("Adivine el número: Ingrese un número del 1 al 100");
            numero2 = Int32.Parse(Console.ReadLine());

            if(numero1 == numero2)
            {
                Console.WriteLine($"El número es correcto. El número escogido era {numero1}"
            }
            else
            {
                if (numero2 <numero1) 
                { 

                }
                else
                {

                }
            }
        }

    }
}
