using System;
public class Aves: BaseAnimal //Herencia
{
    public string ColorPlumaje { get; set; }
    public string ColorPico { get; set; }
    public string Vuelo { get; set; }
    public string Canto { get; set; }
    public string TiempoDeIncubacion { get; set; }

    public void Volar() 
    {
        Console.WriteLine("Este tipo de ave vuela " + Vuelo);
    }
    public void Cantar() 
    {
        Console.WriteLine ("Este tipo de ave tiene un canto " + Canto);
    }
    public void Incubar()
    {
        Console.WriteLine("La hembra tiene un tiempo de incubación de " + TiempoDeIncubacion);
    }
}