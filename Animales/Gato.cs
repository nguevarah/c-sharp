using System;
public class Gato: Mamifero //Herencia
{
    public string Raza { get; set; }
    public bool EsDomestico { get; set; }
    public Gato (string nombre, string raza, int patas, string familia, string clasificacion, string alimento, string respiracion, string periodoLactancia, string periodoCuidadoParental)
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
   
    public Gato() //Polimorfismo
    {
        EsDomestico = true;
    }
    public Gato(bool esDomestico) //Polimorfismo
    {
        EsDomestico = esDomestico;
    }
    public void Maullar() //Abrastracción
    {
        Console.WriteLine("Maulla miiaauu");
    }
    public void Jugar()
    {
        Console.WriteLine("Este gato juega");
    }
    public void Caminar()
    {
        Console.WriteLine("Este gato camina");
    }
    public void Personalidad()
    {
        DescribirPersonalidad();
        DescribirSueño();
    }

    private void DescribirPersonalidad() //Encapsulamiento
    {
        Console.WriteLine("Los gatos no son muy amigables");
    }

    private void DescribirSueño() //Encapsulamiento
    {
        Console.WriteLine("Los gatos duermen mucho");
    }
}