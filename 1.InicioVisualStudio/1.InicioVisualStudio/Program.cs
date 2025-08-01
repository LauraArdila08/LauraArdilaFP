 namespace _1.InicioVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta es la declaración e inicialización de una varible
            string nombre="Laura";
            const string iva="19%";

            Console.Write("Hola, " + nombre + "\n"); 
            Console.Write("\tBienvenida a la clase de programación.");
            nombre = "Sofia";
            Console.Write("\n" + nombre);
            //iva = "20%;"; No sepuede cambiar el valor de una constante

            //Tipos de datos
            byte dato1 = 255;
            int dato2 = 209358;
            long dato3 = -484562135;
            double dato4 = 13.1415;
            char dato5 = '<';//Puede almacenar un solo caracter
            bool dato6= false;//Almacena true o false
            object dato7= new Program();
        }
    }
}
