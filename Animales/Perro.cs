using System;
public class Perro: Mamifero //Herencia
{
    public string Raza { get; set; }
    public bool EsDomestico { get; set; }
    public Perro (string nombre, string raza, int patas, string familia, string clasificacion, string alimento, string respiracion, string periodoLactancia, string periodoCuidadoParental)
    {
        Nombre=nombre;
        Raza=raza;
        Patas=patas;
        Familia=familia;
        Clasificacion=clasificacion;
        Alimento=alimento;
        Respiracion=respiracion;
        PeriodoDeLactancia=periodoLactancia;
        PeriodoDeCuidadoParental=periodoCuidadoParental;
    }
   
    public Perro() //Polimorfismo
    {
        EsDomestico = true;
    }
    public Perro(bool esDomestico) //Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Ladrar() //Abstracción
    {
        Console.WriteLine("Ladra woof woof");
    }
    public void Jugar()
    {
        Console.WriteLine("Este perro juega");
    }
    public void Caminar()
    {
        Console.WriteLine("Este perro camina");
    }
    public void Personalidad()
    {
        DescribirPersonalidad();
        DescribirSueño();
    }

    private void DescribirPersonalidad() //Encapsulamiento
    {
        Console.WriteLine("Los perros son amigables");
    }

    private void DescribirSueño() //Encapsulamiento
    {
        Console.WriteLine("Los perros duermen mucho");
    }
}