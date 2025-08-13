namespace _3._Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos

            //Condicional simple
            /*string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine(); //Todo lo que leo desde la consola llega como string

            Console.WriteLine("Ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo>3000)
            {
                Console.WriteLine($"La persona {nombre}, debe pagar impuestos.");
            }*/


            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”.
            int edad = 0;

            Console.WriteLine("Ingrese la edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >19)
            {
                Console.WriteLine("Bienvenid@ a mi sitio web.");
            }
        }

    }
}
