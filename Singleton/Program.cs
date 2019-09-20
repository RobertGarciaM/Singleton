using System;
using Singleton.Singleton;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PatronSingleton.IntanciaSingleton.mensaje);
            PatronSingleton.IntanciaSingleton.mensaje = "Hola esta es una prueba";
            Console.WriteLine(PatronSingleton.IntanciaSingleton.mensaje);
        }
    }
}
