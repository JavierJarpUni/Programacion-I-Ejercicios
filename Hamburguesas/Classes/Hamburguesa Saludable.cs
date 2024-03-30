public class HamburguesaSaludable : Hamburguesa
{
    public HamburguesaSaludable(string carne, string ingrediente_adicional1, string ingrediente_adicional2) : base(default, carne)
    {
        this.ingredientes_adicionales = new List<string>(6);
        this.ingredientes_adicionales.Add(ingrediente_adicional1);
        this.ingredientes_adicionales.Add(ingrediente_adicional2);
        this.pan = "Integral";
        this.carne = carne;
    }

    public override void AgregarIngredientes(string[] args)
    {
        try
        {
            base.AgregarIngredientes(args);
        }
        catch (System.Exception)
        {
            Console.WriteLine("No se le pueden agregar mas ingredientes adicionales.");
            throw;
        }
    }

    public override string ToString()
    {
        string lista = "";
        foreach (string item in ingredientes_adicionales)
        {
            lista = lista + "\n\t\t\t" + item;
        }

        string _string = $"Hamburguesa Saludable:\n\tCarne: {this.carne}\n\tPan: {this.pan}\t\n";
        _string += lista == "" ? "Sin Ingredientes Adicionales" : $"Ingredientes Adicionales: {lista}";
        return _string;
    }
}