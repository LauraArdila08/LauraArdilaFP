namespace Parcial_Condicionales_LauraArdila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se debe desarrollar un programa en C# que permita (70%):

             Ingresar los siguientes datos del empleado:

             1.1-Nombre del empleado.
             1.2-Número de años trabajados en la empresa.
             1.3-Calificación del año actual (0.0, 0.4, 0.6, 1.0).
             1.4-Calificación del año anterior (debe ser uno de los mismos valores anteriores).*/

            string nombreEmpleado = " ";
            float añosTrabajados = 0.0f;
            float calificacionActual = 0.0f;
            float calificacionPasada = 0.0f;
            float promedioCalificacion = 0.0f;  
            float porcentajeAumento = 0.0f;
            float valorAumento = 0.0f;
            int sueldoBase = 2500000;

            Console.WriteLine("Ingrese el nombre del empleado:");
            nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese el número de años trabajados en la empresa:");
            añosTrabajados = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del año actual: (0.0, 0.4, 0.6, 1.0)");
            calificacionActual = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del año pasado: (0.0, 0.4, 0.6, 1.0)");
            calificacionPasada = Single.Parse(Console.ReadLine());


            /*2. Validar que las calificaciones ingresadas estén entre los valores permitidos.

            Si la calificación actual no corresponde a ninguno de los valores válidos (0.0, 0.4, 0.6, 1.0), el programa debe mostrar un mensaje de error y terminar inmediatamente.*/
            

            //3. Calcular el promedio de las dos calificaciones (año actual y anterior).

            promedioCalificacion = (calificacionActual + calificacionPasada) / 2;

            /*4. Según el número de años trabajados y el promedio de calificación, determinar el porcentaje de aumento salarial utilizando las siguientes reglas:

            añosTrabajados < 1  =   0%
            añosTrabajados > 5  =   30%
            0 < añosTrabajados <= 5 y 0 <= promedioCalificación < 0.4    =    5%
            0 < añosTrabajados <= 5 y 0.4 <= promedioCalificación < 0.6    =   10%
            0 < añosTrabajados <= 5 y 0.6 <= promedioCalificación <= 1.0   =   20%
            
            5. Todos los empleados tienen un sueldo base fijo de $2.500.000.
            El aumento se calcula como:  valorAumento = sueldoBase×(porcentajeAumento/100
            
            6. El programa debe mostrar al final:
            Nombre del empleado.
            Promedio de la calificación.
            Porcentaje de aumento aplicado.
            Valor del aumento en pesos*/

            

            if (añosTrabajados>0)
            {
                if (añosTrabajados <= 5)
                {
                    if ( promedioCalificacion>0 && promedioCalificacion <0.4)
                    {
                        porcentajeAumento = 5;
                        valorAumento = sueldoBase * (porcentajeAumento / 100);
                        Console.Write($"Nombre del empleado:{nombreEmpleado} \n Promedio de la calificación: {promedioCalificacion} \n Porcentaje de aumento aplicado {porcentajeAumento}% \n Valor del aumento: {valorAumento}COP");
                    }
                    else
                    {
                        if (0.4 <= promedioCalificacion && promedioCalificacion < 0.6)
                        {
                            porcentajeAumento = 10;
                            valorAumento = sueldoBase * (porcentajeAumento / 100);
                            Console.Write($"Nombre del empleado:{nombreEmpleado} \n Promedio de la calificación: {promedioCalificacion} \n Porcentaje de aumento aplicado {porcentajeAumento}% \n Valor del aumento: {valorAumento}COP");
                        }
                        else
                        {
                            if ( 0.6 <= promedioCalificacion && promedioCalificacion < 1.0)
                            {
                                porcentajeAumento = 20;
                                valorAumento = sueldoBase * (porcentajeAumento / 100);
                                Console.Write($"Nombre del empleado:{nombreEmpleado} \n Promedio de la calificación: {promedioCalificacion} \n Porcentaje de aumento aplicado {porcentajeAumento}% \n Valor del aumento: {valorAumento}COP"); 
                            }
                        }
                    }

                }
                else
                {
                    porcentajeAumento = 30;
                    valorAumento = sueldoBase * (porcentajeAumento / 100);
                    Console.Write($"Nombre del empleado:{nombreEmpleado} \n Promedio de la calificación: {promedioCalificacion} \n Porcentaje de aumento aplicado {porcentajeAumento}% \n Valor del aumento: {valorAumento}COP");
                }
            }
            else
            {
                porcentajeAumento = 0;
                Console.Write($"Nombre del empleado:{nombreEmpleado} \n Promedio de la calificación: {promedioCalificacion} \n Porcentaje de aumento aplicado {porcentajeAumento}% \n Valor del aumento: {valorAumento}COP");
            }
        }
    }
}
