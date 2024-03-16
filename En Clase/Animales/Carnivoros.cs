public abstract class Carnivore : Animal{
    public virtual string tipoDeCarne {get; set;}
    protected Carnivore(string nombre, string tipoDeCarne) : base(nombre)
    {
        this.nombre = nombre;
        this.tipoDeCarne = tipoDeCarne;
    }

    public override void Movimiento()
    {
        
    }

}