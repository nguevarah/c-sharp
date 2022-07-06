/*
using System;

namespace clases
{
     class Program
    {
        static int suma(int a, int b)
        {
            return a + b;
        }

        static string nombreCompleto (string nombre, string apellido)
        {
            return nombre + " " + apellido; 
        }

        static void Main(string[] args)
        {
            int resultado = suma (5, 7);

            Console.WriteLine("El resultado es " + resultado);

            string nombreApellido = nombreCompleto ( "Juan", " Perez");
            Console.WriteLine("El nombre completo es " + nombreApellido);
        }
    } 
}*/

using System;

namespace clases
{
     class Program
    {
        static void Main(string[]args)
/*         {
            Alumno alumno1 = new Alumno();
            alumno1.nombre = " Juan";

            Alumno alumno2 = new Alumno();
            alumno2.nombre = " Maria";

            Alumno alumno3 = new Alumno();
            alumno3.nombre = "Nely";

            Alumno alumno4 = new Alumno();
            alumno4.nombre = "Jose";

            Alumno alumno5 = new Alumno();
            Console.WriteLine(alumno5.nombre)
        } */

        Auto a = new Auto();
        a.Marca = "Ford";
        a.Modelo = "Mustang";
        a.Tipo = "Deportivo";

        Auto b = new Auto();
        b.Marca = "Toyota";
        b.Modelo = "Camaro";
        b.Tipo = "Deportivo";
