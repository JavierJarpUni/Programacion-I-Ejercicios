using System.Security.AccessControl;

public abstract class Empleado {
    public string nombre {get; set;}
    public decimal salario {get; set;}

    public Empleado(string nombre, decimal salario) {
        this.nombre = nombre;
        this.salario = salario;
    }

    public virtual void MostrarDetalles(){
        Console.WriteLine($"Nombre: {nombre}.");
        Console.WriteLine($"Salario: {salario:C}.");
    }
}

public class EmpleadoTiempoCompleto : Empleado{
    public EmpleadoTiempoCompleto(string nombre, decimal salario) : base(nombre, salario) { }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine("Tipo: Empleado Tiempo Completo.");
    }
}

public class EmpleadoPorHora : Empleado{
    public int horasTrabajadas {get; set;}

    public EmpleadoPorHora(string nombre, decimal salarioPorHora, int horasTrabajadas) : base(nombre, salario: salarioPorHora){
        this.horasTrabajadas = horasTrabajadas;
    }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Tipo: Empleado Por Hora.\n Horas Trabajadas: {horasTrabajadas}.");
    }
}