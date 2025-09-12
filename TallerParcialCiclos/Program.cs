using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

namespace TallerParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
            le permitirá al usuario, introducir tantas calificaciones como así desee, 
            en el momento en que seleccione que no desea continuar capturando 
            calificaciones, el algoritmo debe presentar el promedio de las 
            calificaciones capturadas previamente.*/

            /*int calificacion = 0;
            int cantCalificaciones = 0;
            char continuar = ' ';
            int suma = 0;

            

            do
            {
                Console.WriteLine("Ingrese una calificación:");
                calificacion = int.Parse(Console.ReadLine());

                suma += calificacion;

                Console.WriteLine("¿Desea seguir ingresando calificaciones? si: s, no: n.");
                continuar = Char.Parse(Console.ReadLine());

                cantCalificaciones++;
            } while (continuar == 's');

        
            Console.WriteLine($"El promedio de las calificaciones ingresadas es: {suma / cantCalificaciones}");

            /*2. Se requiere un algoritmo para mostrar por pantalla los divisores de un 
            número ingresado por teclado. 
            Tener en cuenta que dados dos números enteros a y b, se dice que b es 
            divisor de a si se cumple que al efectuar una división entera a/b el 
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números. 
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            2, 1 que son los divisores del número 6.*/



            /*5.Se aplicó una encuesta a n personas solicitando su opinión sobre el
            tema del servicio militar obligatorio para las mujeres.Las opciones de
            respuesta fueron: a favor, en contra y no responde. Se solicita un
            algoritmo que calcule qué porcentaje de los encuestados marcó cada
            una de las respuestas.*/

            /*int encuestados = 0;
            int respuesta = 0;
            int cantAFavor = 0;
            int cantEnContra = 0;
            int cantNoResponde = 0;
            int n = 5;

            do
            {
                Console.WriteLine("¿Cuál es su opinión sobre que el servicio militar sea obligatorio para las mujeres? " +
                    "A favor: 1, En contra: 2, No responde: 3.");
                respuesta = int.Parse(Console.ReadLine());

                if(respuesta == 1)
                {
                    cantAFavor++;
                }
                else
                {
                    if(respuesta == 2)
                    {
                        cantEnContra++;
                    }
                    else
                    {
                        cantNoResponde++;
                    }
                }

                encuestados++;

            } while (encuestados<n);

            Console.WriteLine($"La cantidad de personas a favor es: {cantAFavor * 100 /encuestados}%");
            Console.WriteLine($"La cantidad de personas en contra es: {cantEnContra * 100 / encuestados}%");
            Console.WriteLine($"La cantidad de personas que no respondieron es: {cantNoResponde * 100 / encuestados}%");

            /*6. Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos 
            de esos números son positivos, cuántos negativos, cuántos son neutros 
            (0); además que imprima por pantalla la sumatoria de los números 
            positivos y la de los negativos*/

            int cantPositivos = 0;
            int cantNegativos = 0;
            int cantNeutros = 0;
            int sumaPositivos = 0;
            int sumaNegativos = 0;
            int numero = 0;

            for (int i = 0; i < 5; i++) 
            { 
                Console.WriteLine("Ingrese un número:");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    cantNegativos++;
                    sumaNegativos =+ cantNegativos;
                }
                else
                {
                    if (numero > 0)
                    {
                        cantPositivos++;
                        sumaPositivos =+ cantPositivos;
                    }
                    else
                    {
                        cantNeutros++;
                    }
                }
            }

            Console.WriteLine($"La cantidad de números positivos es: {cantPositivos}, la cantidad de números negativos es: {cantNegativos} y la cantidad de números neutros es: {cantNeutros}");
            Console.WriteLine ($"La suma de los números positivos es: {sumaPositivos} y la suma de los números negativos es: {sumaNegativos}");
        }
    }
}
