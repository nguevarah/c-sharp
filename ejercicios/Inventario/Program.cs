using System;

namespace Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1 - Productos");
                Console.WriteLine("2 - Ingreso de Inventario");
                Console.WriteLine("3 - Salida de Inventario");
                Console.WriteLine("0 - Salir");
                opcion = Console.Read();

                switch (opcion)
                {
                    case 1:
                    Console.WriteLine("Productos");
                    Console.Read();
                    break;

                    default:
                    break;
                }
                if (opcion == 0)
                {
                    break;
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
