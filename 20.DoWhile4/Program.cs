namespace _20.DoWhile4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20. Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
            El número de partidos perdidos  
            El número de partidos empatados  
            El número de partidos ganados  
            El porcentaje de partidos perdidos  
            El porcentaje de partidos empatados  
            El porcentaje de partidos ganados*/

            char resultadoPartidos = ' ';
            int numPartidos = 0;
            int partidosGanados = 0;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;

            do
            {
                Console.WriteLine($"Ingrese el resultado del partido: ganado: g, perdido: p, empatado: e.");
                resultadoPartidos = Char.Parse( Console.ReadLine() );

                switch (resultadoPartidos) 
                {
                    case 'g':
                        partidosGanados++;
                        break;
                    case 'p':
                        partidosPerdidos++;
                        break;
                    case 'e':
                        partidosEmpatados++;
                        break;
                }

                numPartidos++;

            } while (numPartidos<5);

            Console.WriteLine($"Número de partidos jugados: {numPartidos}.");
            Console.WriteLine($"Partidos ganados: {partidosGanados * 100 / numPartidos}%. Partidos perdidos: {partidosPerdidos * 100 / numPartidos}%. Partidos empatados: {partidosEmpatados * 100 / numPartidos}%");
        }
        
    }
}
