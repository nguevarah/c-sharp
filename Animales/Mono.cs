using System;
public class Mono: Mamifero //Herencia
{
    public bool EsDomestico { get; set; }
    public string Especie { get; set; }
    public Mono (string nombre, string especie, string familia, string clasificacion, string alimento, string respiracion, string periodoLactancia, string periodoCuidadoParental)
    {
        Nombre=nombre;
        Especie=especie;
        Familia=familia;
        Clasificacion=clasificacion;
        Alimento=alimento;
        Respiracion=respiracion;
        PeriodoDeLactancia=periodoLactancia;
        PeriodoDeCuidadoParental=periodoCuidadoParental;
    }
    public Mono() //Polimorfismo
    {
        EsDomestico = false;
    }
    public Mono(bool esDomestico) //Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Aullar() //Abstracción
    {
        Console.WriteLine("Los monos aullan");
    }
    public void Trepar()
    {
        Console.WriteLine("Los monos trepan árboles y estructuras");
    }
     public void Personalidad()
    {
        DescribirPersonalidad();
        DescribirSueño();
    }

    private void DescribirPersonalidad() //Encapsulamiento
    {
        Console.WriteLine("Los monos son algo agresivos");
    }

    private void DescribirSueño() //Encapsulamiento
    {
        Console.WriteLine("Los monos no duermen mucho");
    }
}