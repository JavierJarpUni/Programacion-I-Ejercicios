using System.Reflection;
using System.Reflection.PortableExecutable;

public abstract class Entity {
    public virtual int health {get; set;}
    
    public Entity(int health){
        this.health = health;
    }

    public abstract void TakeDamage(int damage);

    public virtual int GetHealth() => this.health;
}


public class Player : Entity
{
    public virtual float stamina {get; set;}
    public virtual int mana {get; set;}
    
    public Player(int health, int stamina, int mana) : base(health)
    {
        base.health = health;
        this.stamina = (int) stamina;
        this.mana = (int) mana;
    }

    public override void TakeDamage(int damage)
    {
        base.health -= damage;
        Console.WriteLine($"Jugador tomo {damage} de dano.");
    }
}

public class Enemy : Entity
{

    public virtual string name {get; set;}
    public Enemy(int health, string name) : base(health)
    {
        base.health = health;
        this.name = name;
    }

    public override void TakeDamage(int damage)
    {
        base.health -= damage;
        Console.WriteLine($"{this.name} tomo {damage}.");
    }

    public void AttackPlayer(int damage, Player player){
        Console.WriteLine($"{this.name} attacked player.");
        player.TakeDamage(damage);
    }
}