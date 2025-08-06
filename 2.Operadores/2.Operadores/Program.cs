namespace _2.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores Númericos
            //Cambio de signo

            int num1 = 5;
            int num2 = -num1;
            int num3 = +num2;
            int num4 = -num3;

            Console.WriteLine($"{num1} // {num2} // {num3} // {num4}");


            //Operadores aritméticos

            int num5 = 3 + 9; //Suma
            int num6 = 35 - 26;//Resta
            int num7 = 8 * 2; //Producto
            //float num8 =(float) 5 / 2; //División
            //float num8 = 5f / 3;
            //float num8 = 10 / 7f;
            float num8 = 13f / 5f;
            double num9 = 8d / 7;
            decimal num10 = 8 / 3m;

            Console.WriteLine($"Suma: {num5}, resta: {num6}, producto: {num7}, división: {num8}, num9: {num9}, num10: {num10}");

            //Operadores incremento (++), decremento (--)
            num1++;//num1 + 1; Incremento
            num2--;//num2 -1; Decremento
            num3 += 5; //num3 = num3 +5;
            num4 -= 33;//num4= num4 - 20;
            num5 *= 31;//num5 = num5 * 31;
            num7 /= num1;//num7 = num7 / num1

            //Orden de evaluacion operadores aritméticos
            int num11 = 3 * 8 / 5;// *,/
            int num12 = 3 / 8 * 3;// /,*
            int num13 = (3 * 8) / 2;// (),/
            int num14 = 3 * (8 / 2);// (),*
            int num15 = 3 + 8 * 2;// *,+
            int num16 = 3 + 8 * (6 - 2) / 4;// (),*,/,+
            Console.WriteLine($"num11: {num11}, num12: {num12}; num13: {num13}, num14: {num14}, num15: {num15}, num16: {num16}");

            //Operadore lógicos
            //Conjunción - AND - &&
            Console.WriteLine("TABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine($"V && V = {true && true}");
            Console.WriteLine($"V && F = {true && false}");
            Console.WriteLine($"F && V = {false && true}");
            Console.WriteLine($"F && F = {false && false}");

            //Disyunción - OR - ||
            Console.WriteLine("TABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine($"V || V = {true || true}");
            Console.WriteLine($"V || F = {true || false}");
            Console.WriteLine($"F || V = {false || true}");
            Console.WriteLine($"F || F = {false || false}");
            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2;
            bool exp4 = exp2 || exp3;
            bool exp5 = !exp4 || exp2;

            Console.WriteLine($"exp1: {exp1}, exp2: {exp2}, exp3: {exp3}. exp4: {exp4}, exp5: {exp5}");
        }
    }
}
