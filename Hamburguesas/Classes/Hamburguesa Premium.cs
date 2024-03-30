public class HamburguesaPremium : Hamburguesa
{
    public HamburguesaPremium(string pan, string carne) : base(pan, carne)
    {
        this.ingredientes_adicionales = new List<string>() {
            "Papas Fritas",
            "Refresco"
        };
        this.pan = pan;
        this.carne = carne;
    }

    public override void AgregarIngredientes(string[] args)
    {
        Console.WriteLine("No se le pueden agregar ingredientes adicionales a la hamburguesa premium.");
    }

    public override string ToString()
    {
        return $"Hamburguesa Premium:\n\tCarne: {this.carne}\n\tPan: {this.pan}\t\n";
    }
}