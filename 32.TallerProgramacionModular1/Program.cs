using System.Runtime.ExceptionServices;

namespace _32.TallerProgramacionModular1
{
    internal class Program
    {
        /*2. Crear un programa que permita gestionar una lista de tareas:  
         Agregar tareas.  
         Eliminar tareas  
         Mostrar la lista de tareas. */

        static string [] tareas = new string[100];
        static int cantidadTareas = 0;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Eliminar tarea");
                Console.WriteLine("3. Mostrar tareas");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarTarea();
                        break;
                    case 2:
                        EliminarTarea();
                        break;
                    case 3:
                        MostrarTareas();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo\n");
                        break;
                }
            } while (opcion != 4);
        }

        static void AgregarTarea()
        {           

            if (cantidadTareas < tareas.Length)
            {
                Console.WriteLine("nIngrese la tarea");
                tareas[cantidadTareas] = Console.ReadLine();
                cantidadTareas++;
            }
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            Console.WriteLine("\nIngrese el número de la tarea a eliminar:");

            int numeroTarea = Convert.ToInt32(Console.ReadLine());

            for (int i = numeroTarea - 1; i < cantidadTareas - 1; i++)
            {
                tareas[i] = tareas[i + 1];
            }
            tareas[cantidadTareas - 1] = null;
            cantidadTareas--;

        }

        static void MostrarTareas()
        {
            Console.WriteLine("nLista de tareas:");
            for (int i = 0; i < cantidadTareas; i++)
            {
                Console.Write( $"{i + 1} {tareas[i]}\n");

            }

        }

        
    }
}
