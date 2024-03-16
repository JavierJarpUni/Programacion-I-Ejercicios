using System.Runtime.InteropServices;

public class Centralita{
    public int cont {get; set;}
    public double acum {get; set;}

    public int getTotalLlamadas() => this.cont;

    public double getTotalFacturado() => this.acum;

    public void registerLlamada(Llamada llamda){
        Console.WriteLine("Llamda Registrada:" + llamda);
        this.cont += 1;
        Console.WriteLine("Calculado precio y facturando...");
        this.acum += llamda.CalcularPrecio();
        Console.WriteLine(this);
    }

    public override string ToString()
    {
        return $"Centralita:\n\tTotal De Llamadas Registradas: {this.cont}\n\tPrecio: {this.acum}";
    }
}