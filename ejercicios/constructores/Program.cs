using System;

namespace constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("Jose", "Martinez");
            Alumno a2 = new Alumno("Maria");
            Alumno a3 = new Alumno();

            Console.WriteLine("a1. " + a1.nombreCompleto());        
            Console.WriteLine("a2. " + a2.nombreCompleto());  
            Console.WriteLine("a1. " + a3.nombreCompleto());            
        }
    }
}
