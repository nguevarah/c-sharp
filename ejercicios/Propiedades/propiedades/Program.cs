﻿using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno();
            b.Id = 2;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Lopez";

            Alumno c = new Alumno(3);
            c.PrimerNombre = "Pedro";
            c.SegundoNombre = "Diaz";

            Alumno d = new Alumno("Juan", "Jimenez");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
