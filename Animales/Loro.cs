using System;
public class Loro: Aves //Herencia
{
    public string Especie { get; set; }
    public bool EsDomestico { get; set; }
    public Loro (string nombre, string especie, string familia, string clasificacion, string alimento, string respiracion, string colorPlumaje, string colorPico, string vuelo, string canto, string tiempoIncubacion)
    {
        Nombre=nombre;
        Especie=especie;
        Familia=familia;
        Clasificacion=clasificacion;
        Alimento=alimento;
        Respiracion=respiracion;
        ColorPlumaje=colorPlumaje;
        ColorPico=colorPico;
        Vuelo=vuelo;
        Canto=canto;
        TiempoDeIncubacion=tiempoIncubacion;
    }
    public Loro() //Polimorfismo
    {
        EsDomestico = true;
    }
    public Loro(bool esDomestico) //Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Hablar() //Abstracción
    {
        Console.WriteLine("Los loros hablan y pueden repetir muchas palabras");
    }
    public void Acicalar()
    {
        Console.WriteLine("Los loros se acicalan a si mismos y a sus compañeros");
    }   
    public void Personalidad()
    {
        DescribirPersonalidad();
        DescribirSueño();
    }

    private void DescribirPersonalidad() //Encapsulamiento
    {
        Console.WriteLine("Los loros son amigables");
    }

    private void DescribirSueño() //Encapsulamiento
    {
        Console.WriteLine("Los loros duermen regularmente");
    }
}
