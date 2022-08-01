using System;
public class BaseAnimal
{
    public string Nombre { get; set; }
    public string Familia { get; set; }
    public string Clasificacion { get; set; }
    public string Alimento { get; set; }
    public string Respiracion { get; set; }

    public void Comer()
    {
        Console.WriteLine("Se alimenta de " + Alimento);
    }

    public void Respirar()
    {
        Console.WriteLine("Respira a través de " + Respiracion);
    }
}