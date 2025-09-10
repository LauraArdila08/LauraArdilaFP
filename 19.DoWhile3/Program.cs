namespace _19.DoWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*19. En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres,
            además se desea saber cuántos son mayores de edad y cuántos no.*/

            char genero = ' ';
            int cantidadEstudiantes = 0;
            int estudiantesMujer = 0;
            int estudiantesHombre = 0;
            int mayoresDeEdad = 0;
            int menoresDeEdad = 0;
            int edadEstudiante = 0;

            do
            {
                Console.WriteLine("Ingrese si el estudiante es hombre: h o mujer: m");
                genero = Char.Parse(Console.ReadLine());

                switch (genero)
                {
                    case 'h':
                        estudiantesHombre++;
                        break;
                    case 'm':
                        estudiantesMujer++;
                        break;
                    
                }

                Console.WriteLine("Ingrese la edad del estudiante:");
                edadEstudiante = Int32.Parse(Console.ReadLine());

                if (edadEstudiante < 18)
                {
                    menoresDeEdad++;
                }
                else
                {
                    mayoresDeEdad++;
                }

                cantidadEstudiantes++;

            } while (cantidadEstudiantes <100);

            Console.WriteLine($"La cantidad de estudiantes ingresados es {cantidadEstudiantes}.");
            Console.WriteLine($"La cantidad de estudiantes mujeres es: {estudiantesMujer} y la cantidad de estudiantes hombres es: {estudiantesHombre}");
            Console.WriteLine($"La cantidad de estudiantes mayores de edad son: {mayoresDeEdad} y la cantidad de estudiantes menor de edad son: {menoresDeEdad}");
        }
    }
}
