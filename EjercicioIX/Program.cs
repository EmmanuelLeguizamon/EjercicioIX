using System;

namespace EjercicioIX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola. Escribi lo que quieras.");

            string t = Console.ReadLine();

            Console.WriteLine("Lo que escribiste, pero en mayúsculas: ");
            Console.WriteLine(t.ToUpper());

            Console.ReadKey();



        }
    }
}
