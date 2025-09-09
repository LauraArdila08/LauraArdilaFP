namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que genera y suma los primeros 5 números

            int contador = 0;
            int acumulador = 0;

            do
            {
                contador++;
                acumulador = acumulador + contador;

            } while (contador<5);

            Console.WriteLine($"La suma de los cinco primeros números enteros es : {acumulador}.");


            /*17.Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10.
            Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar*/

            int numeroIngresado = 0;
            string continuar = " ";
            int contador1 = 1;
                              

            do
            {
                Console.WriteLine("Ingrese un número para realizar su tabla de multiplicar:");
                numeroIngresado = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numeroIngresado} X {contador} = {numeroIngresado * contador}");
                    contador1++;

                } while (contador1 <= 10);

                contador1 = 1;
                Console.WriteLine("¿Quiere generar una nueva tabla de multiplicar? s: Si,  n: No");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");

            /*18. Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
            1. Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
            2. Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
        
            El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos.*/

            string nombre = "";
            int numeroCuenta = 0;
            int saldo = 0;
            string respuesta = "";
            int contador2 = 0;
            int acumulador1 = 0;

            do
            {
                Console.WriteLine("Ingrese nombre del usuario:");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese numero de cuenta del usuario:");
                numeroCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el saldo del usuario:");
                saldo = int.Parse(Console.ReadLine());

                if (saldo > 3000000)
                {
                    Console.WriteLine($"El usuario: {nombre}, con número de cuenta: {numeroCuenta} y saldo {saldo} es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"El usuario: {nombre}, con número de cuenta: {numeroCuenta} y saldo {saldo} No es apto para el crédito");
                }

                Console.WriteLine("¿Desea ingresar más usuarios? s: Si,  n: No");
                respuesta = Console.ReadLine().ToLower();

                contador2++;
                acumulador += saldo;

            } while (respuesta == "s");

            Console.WriteLine($"Número de usuarios preguntados: {contador2}. Promedio de los saldos: {acumulador / contador2}");
        }
    }
}
