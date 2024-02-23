public class Animal{
    public string name {get; set;}

    public Animal(string name){
        this.name = name;
    }

    public virtual void Speak() {

    }
}

public class Dog : Animal {
    public Dog(string name) : base(name) {

    }

    public override void Speak(){
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal {
    public Cat(string name) : base(name) {

    }

    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}