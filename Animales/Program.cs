using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("LISTADO DE ANIMALES");
            Console.WriteLine("===================");

            Perro p1 = new Perro();
            p1.Nombre="Brandy";
            p1.Raza="Cocker Spaniel";
            p1.Patas=4;
            p1.Familia="Cánidos";
            p1.Clasificacion="Mamiferos";
            p1.Alimento="Croquetas";
            p1.Respiracion="Pulmones";
            p1.PeriodoDeLactancia="Mes y medio";
            p1.PeriodoDeCuidadoParental="Tres meses";
            p1.EsDomestico = true;
            Console.WriteLine("\nNombre: " + p1.Nombre);
            Console.WriteLine("Raza: " + p1.Raza);
            Console.WriteLine("Patas: " + p1.Patas);
            Console.WriteLine("Familia: " + p1.Familia);
            Console.WriteLine("Clasificación: " + p1.Clasificacion);
            Console.WriteLine("Periodo de lactancia: " + p1.PeriodoDeLactancia);
            Console.WriteLine("Periodo de cuidado parental: " + p1.PeriodoDeCuidadoParental);
            Console.WriteLine("¿Es doméstico? " + p1.EsDomestico);
            p1.Comer();
            p1.Ladrar();
            p1.Jugar();
            p1.Caminar();
            p1.Personalidad();
            p1.Respirar();

            Gato g1 = new Gato();
            g1.Nombre="Bernabe";
            g1.Raza="Siamés";
            g1.Patas=4;
            g1.Familia="Felinos";
            g1.Clasificacion="Mamiferos";
            g1.Alimento="Atún";
            g1.Respiracion="Pulmones";
            g1.PeriodoDeLactancia="Mes y medio";
            g1.PeriodoDeCuidadoParental="Dos meses";
            g1.EsDomestico = true;
            Console.WriteLine("\nNombre: " + g1.Nombre);
            Console.WriteLine("Raza: " + g1.Raza);
            Console.WriteLine("Patas: " + g1.Patas);
            Console.WriteLine("Familia: " + g1.Familia);
            Console.WriteLine("Clasificación: " + g1.Clasificacion);
            Console.WriteLine("Periodo de lactancia: " + g1.PeriodoDeLactancia);
            Console.WriteLine("Periodo de cuidado parental: " + g1.PeriodoDeCuidadoParental);
            Console.WriteLine("¿Es doméstico? " + g1.EsDomestico);
            g1.Comer();
            g1.Maullar();
            g1.Jugar();
            g1.Caminar();
            g1.Personalidad();
            g1.Respirar();

            Mono m1 = new Mono();
            m1.Nombre="George";
            m1.Especie="Mono Capuchino";
            m1.Patas=4;
            m1.Familia="Cabidae";
            m1.Clasificacion="Mamiferos";
            m1.Alimento="Frutas y plantas";
            m1.Respiracion="Pulmones";
            m1.PeriodoDeLactancia="Ocho meses";
            m1.PeriodoDeCuidadoParental="Tres años";
            m1.EsDomestico = false;
            Console.WriteLine("\nNombre: " + m1.Nombre);
            Console.WriteLine("Especie: " + m1.Especie);
            Console.WriteLine("Patas: " + m1.Patas);
            Console.WriteLine("Familia: " + m1.Familia);
            Console.WriteLine("Clasificación: " + m1.Clasificacion);
            Console.WriteLine("Periodo de lactancia: " + m1.PeriodoDeLactancia);
            Console.WriteLine("Periodo de cuidado parental: " + m1.PeriodoDeCuidadoParental);
            Console.WriteLine("¿Es doméstico? " + m1.EsDomestico);
            m1.Comer();
            m1.Aullar();
            m1.Trepar();
            m1.Personalidad();
            m1.Respirar();

            Aguila a1 = new Aguila();
            a1.Nombre="Roxy";
            a1.Especie="Aguila Calva";
            a1.Familia="Accipítridos";
            a1.Clasificacion="Ave";
            a1.Alimento="Carne";
            a1.Respiracion="Pulmones";
            a1.ColorPlumaje="Blanco y café";
            a1.ColorPico="Amarillo intenso";
            a1.Vuelo="Suave";
            a1.Canto="Agudo";
            a1.TiempoDeIncubacion="1 Mes";
            a1.EsDomestico = false;
            Console.WriteLine("\nNombre: " + a1.Nombre);
            Console.WriteLine("Especie: " + a1.Especie);
            Console.WriteLine("Familia: " + a1.Familia);
            Console.WriteLine("Clasificación: " + a1.Clasificacion);
            Console.WriteLine("Color del plumaje: " + a1.ColorPlumaje);
            Console.WriteLine("Color de pico: " + a1.ColorPico);
            Console.WriteLine("¿Es doméstico? " + a1.EsDomestico);
            a1.Comer();
            a1.Volar();
            a1.Cantar();
            a1.Incubar();
            a1.VolarAlto();
            a1.Cazar();
            a1.Personalidad();
            a1.Respirar();

            Loro l1 = new Loro();
            l1.Nombre="Paquito";
            l1.Especie="Loro atolero";
            l1.Familia="Psittacidae";
            l1.Clasificacion="Ave";
            l1.Alimento="Semillas de girasol";
            l1.Respiracion="Pulmones";
            l1.ColorPlumaje="Blanco y café";
            l1.ColorPico="Amarillo claro";
            l1.Vuelo="Rápido";
            l1.Canto="Agudo";
            l1.TiempoDeIncubacion="25 días";
            l1.EsDomestico = true;
            Console.WriteLine("\nNombre: " + l1.Nombre);
            Console.WriteLine("Especie: " + l1.Especie);
            Console.WriteLine("Familia: " + l1.Familia);
            Console.WriteLine("Clasificación: " + l1.Clasificacion);
            Console.WriteLine("Color del plumaje: " + l1.ColorPlumaje);
            Console.WriteLine("Color de pico: " + l1.ColorPico);
            Console.WriteLine("¿Es doméstico? " + l1.EsDomestico);
            l1.Comer();
            l1.Volar();
            l1.Cantar();
            l1.Incubar();
            l1.Hablar();
            l1.Acicalar();
            l1.Personalidad();
            l1.Respirar();

            PezGlobo pg1 = new PezGlobo();
            pg1.Nombre="Gill";
            pg1.Familia="Tetraodontidae";
            pg1.Clasificacion="Pez";
            pg1.Alimento="Almejas y algas";
            pg1.Respiracion="Branquias";
            pg1.CantidadDeAletas=2;
            pg1.Nado="Suave";
            pg1.EsDomestico = false;
            Console.WriteLine("\nNombre: " + pg1.Nombre);
            Console.WriteLine("Familia: " + pg1.Familia);
            Console.WriteLine("Clasificación: " + pg1.Clasificacion);
            Console.WriteLine("Cantidad de aletas: " + pg1.CantidadDeAletas);
            Console.WriteLine("¿Es doméstico? " + pg1.EsDomestico);
            pg1.Comer();
            pg1.Nadar();
            pg1.Personalidad();
            pg1.Respirar();
        }
    }
}
