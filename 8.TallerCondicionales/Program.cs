namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller Condicionales -Prueba de Escritorio

            /*1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

            int num1 = 0;
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
            
        }
    }
}
