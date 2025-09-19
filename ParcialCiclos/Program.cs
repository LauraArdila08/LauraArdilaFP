namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa que calcule la nota final de un grupo de 10 alumnos a partir de sus evaluaciones. La calificación final se obtiene aplicando los siguientes porcentajes:
            -Práctica: 10%
            -Problemas: 50%
            -Teórica: 40%
            Las notas de cada evaluación estarán en un rango de 0 a 10.
            
            El programa debe realizar, para cada alumno, las siguientes acciones:
            -Solicitar el nombre del alumno.
            -Ingresar las tres calificaciones correspondientes a práctica, problemas y teórica.
            -Calcular la nota final ponderada según los porcentajes establecidos.
            -Determinar si el alumno aprueba (nota final > 6) o reprueba (nota final ≤ 6).
            -Mostrar en pantalla el nombre del alumno, la nota final y el resultado (aprobado o reprobado)*/

            //Al momento de ver probar en la consola y escribir las notas se debe usar coma "," en vez de punto "."

            string nombre = " ";
            float notaPractica = 0.0f;
            float notaProblemas = 0.0f;
            float notaTeorica = 0.0f;
            float notaFinal = 0.0f;
            string resultado = " ";
            float porcentajePratica = 0.0f;
            float porcentajeProblemas = 0.0f;
            float porcentajeTeorica = 0.0f;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Ingrese el nombre del alumno {i + 1}:");
                nombre = Console.ReadLine();

                Console.WriteLine("Escriba la nota correspondiente a Prática:");
                notaPractica = float.Parse(Console.ReadLine());

                Console.WriteLine("Escriba la nota correspondiente a Problemas:");
                notaProblemas = float.Parse(Console.ReadLine());

                Console.WriteLine("Escriba la nota correspondiente a Teórica:");
                notaTeorica = float.Parse(Console.ReadLine());

                porcentajePratica = notaPractica * 0.1f;
                porcentajeProblemas = notaProblemas * 0.5f;
                porcentajeTeorica = notaTeorica * 0.4f;

                notaFinal = porcentajePratica + porcentajeProblemas + porcentajeTeorica;

                if (notaFinal > 6) 
                {
                    resultado = "Aprobado";
                }
                else 
                {
                    resultado = "Reprobado";
                }
                Console.Write($"Nombre del alumno: {nombre}. Nota final: {notaFinal}. Resultado: {resultado}.");
                Console.WriteLine();
            }

            
        }
    }
}
