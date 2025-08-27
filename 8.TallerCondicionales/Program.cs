using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Taller Condicionales -Prueba de Escritorio

            1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.

            Forma larga con condicional anidado*/

            /*int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            int mayor = 0;

            Console.WriteLine("Ingrese el número 1:");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2:");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 3:");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1 != num2)
            {
                if ( num1 != num3)
                {
                    if (num3 != num2)
                    {
                        if(num1 > num2)
                        {
                            if(num1 > num3)
                            {
                                if(num2 > num3)
                                {
                                    Console.WriteLine($"El número mayor es: {num1}, Orden númerico: {num3}, {num2}, {num1}");
                                }
                                else
                                {
                                    Console.WriteLine($"El número mayor es: {num1}, Orden númerico: {num2}, {num3}, {num1}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"El número mayor es: {num3}, Orden númerico: {num2}, {num1}, {num3}");
                            }
                        }
                        else
                        {
                            if(num2>num3)
                            {
                                if(num1>num3)
                                {
                                    Console.WriteLine($"El número mayor es: {num2}, Orden númerico: {num3}, {num1}, {num2}");
                                }
                                else
                                {
                                    Console.WriteLine($"El número mayor es: {num2}, Orden númerico: {num1}, {num3}, {num2}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"El número mayor es: {num3}, Orden númerico: {num1}, {num2}, {num3}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar números diferentes.");
                    }
                }
                else 
                {
                    Console.WriteLine("Debe ingresar números diferentes.");
                }
            }

            else 
            {
                Console.WriteLine("Debe ingresar números diferentes");
            }

            //Forma más simplificada operador lógico && y condicional anidado

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            int numMayor = 0;
            int medio = 0;
            int menor = 0;

            Console.WriteLine("Ingrese el número 1:");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2:");
            numero2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número 3:");
            numero3 = Int32.Parse(Console.ReadLine());

            if(numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                if (numero1>numero2 && numero1>numero3)
                {
                    numMayor = numero1;
                    if (numero2 > numero3)
                    {
                        medio = numero2;
                        menor = numero3;
                        Console.WriteLine($"El mayor es: {numMayor}, orden númerico {menor}, {medio}, {numMayor}");
                    }
                    else
                    {
                        medio = numero3;
                        menor = numero2;
                        Console.WriteLine($"El mayor es: {numMayor}, orden númerico {menor}, {medio}, {numMayor}");
                    }
                }
                else
                {
                    if (numero2>numero3)
                    {
                        numMayor = numero2;
                        if (numero3>numero1)
                        {
                            medio = numero3;
                            menor = numero1;
                            Console.WriteLine($"El mayor es: {numMayor}, orden númerico {menor}, {medio}, {numMayor}");
                        }
                        else
                        {
                            medio = numero1;
                            menor = numero3;
                            Console.WriteLine($"El mayor es: {numMayor}, orden númerico {menor}, {medio}, {numMayor}");
                        } 
                        

                    }
                    else
                    {
                        numMayor = numero3;
                        if (numero2 > numero1)
                        {
                            medio = numero2;
                            menor = numero1;
                            Console.WriteLine($"El mayor es: {numMayor}, orden númerico {menor}, {medio}, {numMayor}");
                        }
                        else
                        {
                            medio = numero1;
                            menor = numero2;
                            Console.WriteLine($"El mayor es: {numMayor}, orden númerico {menor}, {medio}, {numMayor}");
                        }
                    }
                }
                             
            }
            else
            {
                Console.WriteLine("Debe ingresar números diferentes.");
            }
        }*/


            /*2. El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si 
            cuenta con munición y si se encuentra en estado invencible, crear un programa que: 
            a. Permita ingresar por teclado si el personaje está en estado invencible (True). 
            b. La cantidad de munición que tiene el personaje en el momento será calculada por el 
            sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#. 
            */

            int municion = 0;
            Random rand = new Random();

            municion = rand.Next(0,10);

            Console.WriteLine("¿El estado del personaje es invencible?: true (verdadero), false (falso).");
            bool invencible = bool.Parse(Console.ReadLine());

            /*c. Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y 
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
            no hacer nada.*/
            if (invencible && municion>0 && municion <=10)
            {
                Console.WriteLine($"Munición: {municion}");
                Console.WriteLine("El personaje está disparando.");
            }


            /*4. El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha), 
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve 
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado. */
            char movimiento = ' ';

            Console.WriteLine("Mueve al personaje presionando solo una tecla: d, i.");
            movimiento = char.Parse(Console.ReadLine());

            switch (movimiento)
            {
                case 'd': // Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la derecha"
                    Console.WriteLine("El personaje se mueve hacia la derecha.");
                    break;
                case 'i': //Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la izquierda"
                    Console.WriteLine("El personaje se mueve hacia la izquierda.");
                    break;
                default: // En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra dirección"
                    Console.WriteLine("No me puedo mover en otra dirección.");
                    break;

            }


            /*5. El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que 
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita: */

            //Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje. (Función Random) 
            int vidas;
            Random rnd = new Random();
                        
            vidas = rnd.Next(0, 6);
            Console.WriteLine($"El personaje tiene {vidas} vidas");

            char accion = ' ';

            /*Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En 
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar 
            ninguna acción”*/
            if (vidas>0)
            {
                //Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al carácter que se ingrese: 
                Console.WriteLine("Ingrese una accion: c, x, t, i");
                accion = Char.Parse(Console.ReadLine());

                switch (accion)
                {
                    
                    case 'c': //Si se ingresa ‘c’, mostrar en consola “el personaje está disparando” 
                        Console.WriteLine("El personaje está disparando.");
                        break;
                    case 'x': //Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
                        Console.WriteLine("El personaje está hablando con la rana.");
                        break;
                    case 't': //Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo” 
                        Console.WriteLine("El personaje está en modo Turbo.");
                        break;
                    case 'i': //Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”
                        Console.WriteLine("El personaje es invencible.");
                        break;
                    default: 
                        Console.WriteLine("Debe ingresar un valor válido.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas y no puede realizar ninguna acción.");
            }





        }
    }
}
