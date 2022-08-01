using System;
public class Aguila: Aves //Herencia
{
    public bool EsDomestico { get; set; }
    public string Especie { get; set; }
    public Aguila (string nombre, string especie, string familia, string clasificacion, string alimento, string respiracion, string colorPlumaje, string colorPico, string vuelo, string canto, string tiempoIncubacion)
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
    public Aguila() //Polimorfismo
    {
        EsDomestico = false;
    }
    public Aguila(bool esDomestico) //Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void VolarAlto() //Abstracción
    {
        Console.WriteLine("Las águilas vuelan alto");
    }
    public void Cazar()
    {
        Console.WriteLine("Las águilas cazan peces, ratones, entre otros animales de menor tamaño");
    }
    public void Personalidad()
    {
        DescribirPersonalidad();
        DescribirSueño();
    }

    private void DescribirPersonalidad() //Encapsulamiento
    {
        Console.WriteLine("Las aguilas son algo agresivas");
    }

    private void DescribirSueño() //Encapsulamiento
    {
        Console.WriteLine("Las aguilas no duermen mucho");
    }

}
