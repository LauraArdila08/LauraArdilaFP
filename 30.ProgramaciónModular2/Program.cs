using System.Security.Cryptography;

namespace _30.ProgramaciónModular2
{
    internal class Program
    {
        /*Algoritmo que muestre un menú con operaciones(+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado.
         Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que el desee ingresar.
         Si es división o resta solo dejar realizar la operación con dos números.*/
        static void Main()
        {
            int opcion;
            do
            {
                
                MostrarMenu();
                opcion = CapturarOpcion();
                RealizarOperaciones(opcion);
            } while (opcion != 5);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
        }

        static int CapturarOpcion()
        {
            Console.Write("Seleccione una opción: ");
            int opcion;
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 4)
            {
                Console.Write("Opción inválida, ingrese un número entre 1 y 4: ");
            }
            return opcion;
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void RealizarOperaciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
            }
        }

        static void Suma()
        {
            BorrarPantalla();
            Console.Write("¿Cuántos números desea sumar?");
            int cantidadSumar = int.Parse(Console.ReadLine());

            double suma = 0;
            for (int i = 1; i <= cantidadSumar; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                double num = double.Parse(Console.ReadLine());
                suma += num;
            }

            Console.WriteLine($"\nResultado de la suma: {suma}\n");
            
        }

        static void Resta()
        {
            BorrarPantalla();
            Console.Write("Ingrese el primer número:");
            double primerNumero = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            double segundoNumero = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nResultado de la resta: {primerNumero - segundoNumero}\n");
            
        }

        static void Multiplicacion()
        {
            BorrarPantalla();
            Console.Write("¿Cuántos números desea multiplicar?");
            int cantidadMultiplicar = int.Parse(Console.ReadLine());

            double resultado = 1;
            for (int i = 1; i <= cantidadMultiplicar; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                double num = double.Parse(Console.ReadLine());
                resultado *= num;
            }

            Console.WriteLine($"\nResultado de la multiplicación: {resultado}\n");
           

        }

        static void Division()
        {
            BorrarPantalla();
            Console.Write("Ingrese el primer número: ");
            double primerNumero = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número:");
            double segundoNumero = double.Parse(Console.ReadLine());

            if (segundoNumero != 0)
            {
                Console.WriteLine($"\nResultado de la división: {primerNumero / segundoNumero}\n");
            }
            else
            {
                Console.WriteLine("\nError: No se puede dividir entre cero\n");
            }
            
        }

    }

}
