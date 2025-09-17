using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;

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

            int calificacion = 0;
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

            int numero1 = 0;

            Console.WriteLine("Ingrese un número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los divisores del número {numero1} son:");
            for (int i = numero1; i >= 1; i--)
            {
                if (numero1 % i == 0)
                {
                    Console.WriteLine(i);
                    
                }
            }

            /*3. Dados dos números enteros ingresados por teclado: b que es la base y 
            e que es el exponente, se requiere calcular el resultado de la 
            potenciación.  
            Ejemplo: b=2, e=5  25=2*2*2*2*2= 32 
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la 
            potenciación correspondiente, hasta que el usuario ingrese por teclado 
            el carácter de escape ‘n’ */

            int baseNum = 0;
            int exponente = 0;
            int resultado = 1;
            char continuar2 = ' ';

            do
            {
                Console.WriteLine("Ingrese la base:");
                baseNum = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el exponente:");
                exponente = int.Parse(Console.ReadLine());

                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= baseNum;
                }

                Console.WriteLine($"El resultado de la potenciación es: {resultado}");
                resultado = 1;

                Console.WriteLine("¿Desea seguir ingresando bases y exponentes? si: s, no: n.");
                continuar2 = Char.Parse(Console.ReadLine());

            } while (continuar2 == 's');

            /*4. Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco 
            kilómetros durante 10 días, para determinar si es apto para la prueba de 
            5 kilómetros. Para considerarlo apto debe cumplir las siguientes 
            condiciones: 
            - Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos. 
            - Que al menos en una de las pruebas realice un tiempo menor de 15 minutos. 
            - Que su promedio sea menor o igual a 18 minutos. 
            Diseñar un algoritmo para registrar los datos y decidir si es apto para la 
            competencia. */

            int tiempo = 0;
            int cantTiempos = 1;
            int sumaTiempos = 0;

            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine($"Día {i}: Ingrese el tiempo que realizó en minutos:");
                tiempo = int.Parse(Console.ReadLine());

                if (tiempo > 20)
                {
                    Console.WriteLine("No es apto para la competencia.");
                    break;
                }
                else
                {
                    if (tiempo < 15)
                    {
                        cantTiempos++;
                    }
                    sumaTiempos += tiempo;
                }
            }

            if (sumaTiempos / 10 <= 18 && cantTiempos >= 1)
            {
                Console.WriteLine("Es apto para la competencia.");
            }
            else
            {
                Console.WriteLine("No es apto para la competencia.");
            }

            /*5.Se aplicó una encuesta a n personas solicitando su opinión sobre el
            tema del servicio militar obligatorio para las mujeres.Las opciones de
            respuesta fueron: a favor, en contra y no responde. Se solicita un
            algoritmo que calcule qué porcentaje de los encuestados marcó cada
            una de las respuestas.*/

            int encuestados = 0;
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
                    sumaNegativos += numero;
                }
                else
                {
                    if (numero > 0)
                    {
                        cantPositivos++;
                        sumaPositivos += numero;
                    }
                    else
                    {
                        cantNeutros++;
                    }
                }
            }

            Console.WriteLine($"La cantidad de números positivos es: {cantPositivos}, la cantidad de números negativos es: {cantNegativos} y la cantidad de números neutros es: {cantNeutros}.");
            Console.WriteLine ($"La suma de los números positivos es: {sumaPositivos} y la suma de los números negativos es: {sumaNegativos}.");

            /*7. Una persona desea realizar un muestreo con 70 personas para
            determinar el promedio de peso de los niños, jóvenes, adultos y viejos
            que existen en su zona y cuántos son de cada una de las categorías. 
            Las categorías están dadas por la siguiente tabla:*/

            int peso = 0;
            int edad = 0;
            int cantNinos = 0;
            int cantJovenes = 0;
            int cantAdultos = 0;   
            int cantViejos = 0;
            int cantPersonas = 1;
            int sumaPesoNinos = 0;
            int sumaPesoJovenes = 0;
            int sumaPesoAdultos = 0;
            int sumaPesoViejos = 0;

            for (int i = cantPersonas; i <= 6; i++) 
            {
                Console.WriteLine($"{i}: Ingrese su edad:");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su peso:");
                peso = int.Parse(Console.ReadLine());

                if (edad <= 13)
                {
                    cantNinos++;
                    sumaPesoNinos += peso;

                }
                else
                {
                    if (edad > 14 && edad <= 30)
                    {
                        cantJovenes++;
                        sumaPesoJovenes += peso;
                    }
                    else
                    {
                        if (edad > 31 && edad <= 60)
                        {
                            cantAdultos++;
                            sumaPesoAdultos += peso;
                        }
                        else
                        {
                            cantViejos++;
                            sumaPesoViejos += peso;
                        }
                    }
                }
            }            

            Console.WriteLine($"De los {cantNinos} niños, el promedio de su peso es: {sumaPesoNinos/cantNinos}. De los {cantJovenes} jóvenes, el promedio de su peso es: {sumaPesoJovenes/cantJovenes}.");
            Console.WriteLine($"De los {cantAdultos} adultos, el promedio de su peso es: {sumaPesoAdultos / cantAdultos}. De los {cantViejos} viejos el promedio de su peso es: {sumaPesoViejos / cantViejos}.");

            /*8. El Departamento de Transito de Antioquia. desea saber de los n autos 
            que entran a la ciudad de Medellín, cuántos autos entran con 
            calcomanía de un determinado color. Conociendo el último dígito de la 
            placa de cada automóvil se puede determinar el color de la calcomanía, 
            para determinar lo anterior utilice la siguiente tabla: 
            DÍGITO COLOR 
            1 o 2 - amarilla 
            3 o 4 - rosa 
            5 o 6 - roja 
            7 o 8 - verde 
            9 o 0 - azul */

            int cantVehiculos = 0;
            int ultimoDigito = 0;
            int cantPlacaAmarilla = 0;
            int cantPlacaRosa = 0;
            int cantPlacaRoja = 0;
            int cantPlacaVerde = 0;
            int cantPlacaAzul = 0;
            int continuar1 = 1;

            do
            {
                Console.WriteLine("Ingrese el último dígito de la placa del vehículo:");
                ultimoDigito = int.Parse(Console.ReadLine());

                if (ultimoDigito == 1 || ultimoDigito == 2)
                {
                    cantPlacaAmarilla++;
                }
                else
                {
                    if (ultimoDigito == 3 || ultimoDigito == 4)
                    {
                        cantPlacaRosa++;
                    }
                    else
                    {
                        if (ultimoDigito == 5 || ultimoDigito == 6)
                        {
                            cantPlacaRoja++;
                        }
                        else
                        {
                            if (ultimoDigito == 7 || ultimoDigito == 8)
                            {
                                cantPlacaVerde++;
                            }
                            else
                            {
                                if (ultimoDigito == 9 || ultimoDigito == 0)
                                {
                                    cantPlacaAzul++;
                                }
                            }
                        }
                    }
                }
                cantVehiculos++;

                Console.WriteLine("¿Desea seguir ingresando vehículos? Si: 1, No: 0.");
                continuar1 = int.Parse(Console.ReadLine());

            } while (continuar1 == 1);

            Console.WriteLine($"De los {cantVehiculos} vehículos ingresados, la cantidad de vehículos con placa amarilla es: {cantPlacaAmarilla}, " +
                $"la cantidad de vehículos con placa rosa es: {cantPlacaRosa}, la cantidad de vehículos con placa roja es: {cantPlacaRoja}, la cantidad de vehículos con placa verde es: {cantPlacaVerde} " +
                $"y la cantidad de vehículos con placa azul es: {cantPlacaAzul}.");

        }
    }
}
