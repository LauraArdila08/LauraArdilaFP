namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*15. Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero;
            además, se quiere saber cuánto lleva ahorrado cada mes. */

            int mes = 1;
            int ahorroTotal = 0;
            int deposito = 0;

            while(mes <= 12)
            {
                Console.WriteLine($"¿Cuánto va a depositar en el mes {mes}?");
                deposito = Int32.Parse( Console.ReadLine() );

                ahorroTotal = ahorroTotal + deposito;

                Console.WriteLine($"Después del mes {mes} lleva ahorrado {ahorroTotal}");
                mes++;
            }

            Console.WriteLine($"El ahorro total al final del año es: {ahorroTotal}");
        }

    }
}
