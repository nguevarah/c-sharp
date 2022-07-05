using System;

namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string nombre = "";
            Console.WriteLine("Ingrese su nombre"); // cout
            nombre = Console.ReadLine(); // cin

            Console.WriteLine("Hola " +  nombre); // cout endl */



           /*  int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
               Console.WriteLine("Eres menor de edad"); 
            } */


            /* int contador = 0;
            while (true)
            {
                Console.Write("*");
                if (contador == 100)
                {
                    break;
                }
                contador++;
            } */


            /* for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
            } */


            Console.Write("Ingrese una opcion ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("1");
                    break;  
                case 2:
                    Console.WriteLine("2");
                    break;  
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }
    }
}
