public class Leon : Carnivore
{
    public string pelaje {get; set;}
    public Leon(string nombre, string tipoDeCarne, string pelaje) : base(nombre, tipoDeCarne)
    {
        this.nombre = nombre;
        this.tipoDeCarne = tipoDeCarne;
        this.pelaje = pelaje;
    }

    public override void Movimiento()
    {
        Console.WriteLine("En cuatro patas.");
    }
}

public class Tiburon : Carnivore {
    public string tipoDePez {get; set;}
    public override string tipoDeCarne { get => base.tipoDeCarne = tipoDePez; set => base.tipoDeCarne = tipoDePez; }
    public Tiburon(string nombre, string tipoDePez) : base(nombre, tipoDeCarne: tipoDePez)
    {
        this.nombre = nombre;
        this.tipoDeCarne = tipoDeCarne;
        this.tipoDePez = tipoDePez;
    }

    public override void Movimiento()
    {
        Console.WriteLine("El se mueve nadando.");
    }
}