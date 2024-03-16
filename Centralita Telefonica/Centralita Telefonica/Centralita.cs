public class Centralita : Llamada{
    public int cont {get; set;}
    public double acum {get; set;}

    public virtual int getTotalLlamadas(){
        return 0;
    }

    public virtual double getTotalFacturado(){
        return 0.0;
    }

    public void registerLlamada(Llamada llamda){
        
    }
}