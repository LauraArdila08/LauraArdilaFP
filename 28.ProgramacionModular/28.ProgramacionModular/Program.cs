namespace _28.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Soy Laura,");
            MostrarMensajes($"tengo {CalcularEdad()} años.");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 2005)} años.");
        }

        //Módulo 1 - Procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("¡Bienvenid@ a la Programación Modular! =)");
            MostrarMensajes("Estoy siendo llamado desde MostrarMensaje()");
        }

        //Módulo 2 - Procedimiento con parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Función sin parámetros

        static int CalcularEdad()
        {
            int edad = 2025 - 2000;
            return edad;
        }

        //Módulo 4 - Función con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)//Sobrecarga de métodos con mismo nombre. Diferencia: Parámetro(s) y tipo de dato que devuelven
        {
            return añoActual-añoNacimiento;
        }
    }
}
