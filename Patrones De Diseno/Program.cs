// Patron de diseño creacional: Singleton

using System.Security.Cryptography.X509Certificates;

public class Database {
    private static Database instance;

    private Database() { }

    public static Database GetInstance(){

        if (instance == null){
            instance = new Database();
        }

        return instance;
    }

    public void Query(string sql){
        Console.WriteLine($"Ejecutando consulta: {sql}");
    }
}


// Patron de diseño De Comportamiento: Observer

public interface IObserver{
    void Update(ISubject subject);
}

public interface ISubject{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

public class Subject : ISubject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer){
        this.observers.Add(observer);
    }

    public void Detach(IObserver observer){
        this.observers.Remove(observer);
    }

    public void Notify(){
        foreach(var observer in observers){
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic(){
        Console.WriteLine("Haciendo algo importante...");
        this.Notify();
    }
}

// Concrete Observer classes
public class ConcreteObserverOne : IObserver
{
    public void Update(ISubject subject)
    {
        // React to the update from the subject
        Console.WriteLine("ConcreteObserverOne: Notified about the event.");
    }
}

public class ConcreteObserverTwo : IObserver
{
    public void Update(ISubject subject)
    {
        // React to the update from the subject
        Console.WriteLine("ConcreteObserverTwo: Notified about the event.");
    }
}

