using System;
public class PezGlobo: Peces //Herencia
{
    public bool EsDomestico { get; set; }
    public PezGlobo (string nombre, string familia, string clasificacion, string alimento, string respiracion, int cantidadAletas, string nado)
    {
        Nombre=nombre;
        Familia=familia;
        Clasificacion=clasificacion;
        Alimento=alimento;
        Respiracion=respiracion;
        CantidadDeAletas=cantidadAletas;
        Nado=nado;
    }
    public PezGlobo() //Polimorfismo
    {
        EsDomestico = false;
    }
    public PezGlobo(bool esDomestico) //Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Inflarse() //Abstracción
    {
        Console.WriteLine("Los peces globo pueden inflarse cuando se asustan y se sienten amenazados");
    }
    public void Personalidad()
    {
        DescribirPersonalidad();
        DescribirSueño();
    }

    private void DescribirPersonalidad() //Encapsulamiento
    {
        Console.WriteLine("Los peces globo son algo asustadizos");
    }

    private void DescribirSueño() //Encapsulamiento
    {
        Console.WriteLine("Los peces globo duermen mucho");
    }
}