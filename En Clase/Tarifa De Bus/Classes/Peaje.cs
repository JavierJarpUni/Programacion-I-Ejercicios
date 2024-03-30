

public class Peaje{

    private Dictionary<string, double> _DestinoPrecios = new Dictionary<string, double>() {
    {"Samana", 200.0},
    {"Punta Cana", 500.0},
    {"Santiago", 600.0},
    {"Constanza", 400.0},
    {"La Vega", 400.0}
    };
    public int count {get; protected set;}
    public double acum {get; set;}
    public string name {get; set;}
    public List<Bus> buses = new List<Bus>();
    public Peaje(string name){
        this.name = name;
    }

    public double getAcumulado() => this.acum;
    public int getCount() => this.count;

    // Implement
    public double CobrarBus(Bus bus){
        Console.WriteLine($"Paso un Bus:\n\t{bus.ToString()}");
        double precioTotal = 0;
        
        precioTotal += _DestinoPrecios[bus.destino];
        switch (bus.tipoBus)
        {
            case(TipoBus.Platino):
            precioTotal += 20.0;
            break;
            case(TipoBus.Gold):
            precioTotal += 15.0;
            break;
            case(TipoBus.Bronze):
            precioTotal += 10.0;
            break;
            default:
            break;
        }
        this.acum += precioTotal;
        this.AgregarCount();
        return precioTotal;
    }

    public void AgregarCount(){
        this.count += 1;
    }
}