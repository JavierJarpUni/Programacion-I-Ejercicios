public interface AnimalAgresivo{
    public string Morder();
    public string Arrunar();
}

public abstract class Perro : AnimalAgresivo
{
    public virtual string ladrar(){
        return "Perro Ladrando";
    }

    public abstract string Dormir();

    public virtual string Morder(){
        return "Perro Muerde";
    }

    public virtual string Arrunar(){
        return "Perro arruna";
    }
}

public class Pomeranian : Perro
{
    public override string ladrar()
    {
        return "Pomeranian Ladrandando";
    }

    public override string Dormir()
    {
        return "Pomeranian Durmiendo";
    }
}

public class Chihuahua : Perro{
    public override string ladrar(){
        return "Chihuahua ladra.";
    }

    public override string Arrunar()
    {
        return "Chihuahua arruna.";
    }

    public override string Dormir()
    {
        return "Chihuahua duerme.";
    }

    public override string Morder()
    {
        return "Chihuahua muerde.";
    }
}