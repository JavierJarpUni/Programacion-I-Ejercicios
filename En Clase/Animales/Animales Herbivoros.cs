public class Camaron : Herbivoro
{
    public Camaron(string nombre, string tipoDeHierba) : base(nombre, tipoDeHierba)
    {
        this.nombre = nombre;
        this.tipoDeHierba = tipoDeHierba;
    }

    public override void Movimiento()
    {
        Console.WriteLine("Caminan en el suelo del oceano.");
    }
}

public class Vaca : Herbivoro
{
    public Vaca(string nombre, string tipoDeHierba) : base(nombre, tipoDeHierba)
    {
        this.nombre = nombre;
        this.tipoDeHierba = tipoDeHierba;
    }

    public override void Movimiento()
    {
        Console.WriteLine("Caminan como en cuatro patas.");
    }
}