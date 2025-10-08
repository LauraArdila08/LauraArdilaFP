using System;

namespace Parcial3Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Registro y análisis de calificaciones de estudiantes
            Implemente un programa que gestione la información académica de 5 estudiantes, almacenando sus datos en una matriz estructurada y realizando cálculos sobre sus calificaciones.
            
            Requisitos del programa:

            Creación de la matriz:
            Utilice una matriz de 6 columnas por 6 filas (1 fila para encabezados y 5 filas para datos de estudiantes).
            
            La primera fila debe contener los encabezados de las columnas, en el siguiente orden:
            | Nombre del Estudiante | Grado | Nota Parcial 1 | Nota Parcial 2 | Examen Final | Nota Final |*/

            string[,] matriz = new string[6, 6];

            matriz[0, 0] = "Nombre del Estudiante";
            matriz[0, 1] = "Grado";
            matriz[0, 2] = "Nota Parcial 1";
            matriz[0, 3] = "Nota Parcial 2";
            matriz[0, 4] = "Examen Final";
            matriz[0, 5] = "Nota Final";

            /*Ingreso de datos:
            Para cada uno de los 5 estudiantes, el programa debe solicitar por teclado:

            -Nombre completo del estudiante.
            -Grado (solo se permiten los grados: 6°, 7°, 8°, 9°). Validar la entrada.
            -Nota del Parcial 1 (valor decimal entre 0.0 y 5.0). Validar la entrada.
            -Nota del Parcial 2 (valor decimal entre 0.0 y 5.0). Validar la entrada.
            -Nota del Examen Final (valor decimal entre 0.0 y 5.0). Validar la entrada.
            
            -Calcular la Nota Final como el promedio de las tres notas (Parcial 1, Parcial 2 y Examen Final) .*/

            //En la consola se debe ysar comas en vez de puntos al momento de escribir las notas

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre del estudiante {i}: ");
                matriz[i, 0] = Console.ReadLine();
                                
                while (true)
                {
                    Console.WriteLine($"Ingrese el grado del estudiante {i} (6, 7, 8, 9):");
                    string gradoInput = Console.ReadLine();
                    if (gradoInput == "6" || gradoInput == "7" || gradoInput == "8" || gradoInput == "9")
                    {
                        matriz[i, 1] = gradoInput;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Grado inválido. Ingrese 6, 7, 8 o 9.");
                    }
                }
                                
                while (true)
                {
                    Console.WriteLine($"Ingrese la nota del parcial 1 del estudiante {i}: ");
                    string notaInput = Console.ReadLine();
                    if (decimal.TryParse(notaInput, out decimal nota) && nota >= 0.0m && nota <= 5.0m)
                    {
                        matriz[i, 2] = nota.ToString("0.00");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Ingrese un valor entre 0.0 y 5.0");
                    }
                }

                
                while (true)
                {
                    Console.WriteLine($"Ingrese la nota del parcial 2 del estudiante {i}: ");
                    string notaInput = Console.ReadLine();
                    if (decimal.TryParse(notaInput, out decimal nota) && nota >= 0.0m && nota <= 5.0m)
                    {
                        matriz[i, 3] = nota.ToString("0.00");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Ingrese un valor entre 0.0 y 5.0");
                    }
                }

                
                while (true)
                {
                    Console.WriteLine($"Ingrese la nota del examen final del estudiante {i}: ");
                    string notaInput = Console.ReadLine();
                    if (decimal.TryParse(notaInput, out decimal nota) && nota >= 0.0m && nota <= 5.0m)
                    {
                        matriz[i, 4] = nota.ToString("0.00");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Ingrese un valor entre 0.0 y 5.0");
                    }
                }

                
                decimal nota1 = decimal.Parse(matriz[i, 2]);
                decimal nota2 = decimal.Parse(matriz[i, 3]);
                decimal nota3 = decimal.Parse(matriz[i, 4]);
                matriz[i, 5] = ((nota1 + nota2 + nota3) / 3).ToString("0.00");
            }

            /*Visualización de la matriz:
            Una vez ingresados todos los datos, mostrar en pantalla la matriz completa con los encabezados y los datos de cada estudiante.*/
            Console.WriteLine("\nMatriz Registro Notas Estudiantes:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "| \t");
                }
                Console.WriteLine();
            }

            /*Análisis de calificaciones:
            Determinar y mostrar en pantalla:
            El nombre del estudiante con la mayor nota final.*/

            decimal mayorNotaFinal = -1.0m;
            string estudianteMayorNota = "";
            for (int i = 1; i < matriz.GetLength(0); i++)
            {
                decimal notaFinalEstudiante = decimal.Parse(matriz[i, 5]);
                if (notaFinalEstudiante > mayorNotaFinal)
                {
                    mayorNotaFinal = notaFinalEstudiante;
                    estudianteMayorNota = matriz[i, 0];
                }
            }
            Console.WriteLine($"\nEl estudiante con la mayor nota final es {estudianteMayorNota} con una nota de {mayorNotaFinal}");
        }
    }
}
