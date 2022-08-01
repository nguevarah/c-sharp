using System;
public class Peces: BaseAnimal //Herencia
{
    public string Nado { get; set; }
    public int CantidadDeAletas { get; set; }
    
    public void Nadar()
    {
        Console.WriteLine("Este pez tiene un nado " + Nado);
    }
}