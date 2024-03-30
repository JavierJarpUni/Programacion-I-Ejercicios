using System;
using System.Collections.Generic;

public class Hamburguesa{

        // Menu de los ingredientes adicionales
        readonly Dictionary<string, double> _ingredientesAdicionalesMenu = new Dictionary<string, double>() {
            {"Pepinillo", 1.99},
            {"Lechuga", 1.99},
            {"Tomate", 2.99},
            {"Bacon", 3.99},
            {"Ketchup", 0.99},
            {"Queso", 0.99},
            {"Papas Fritas", 2.99},
            {"Refresco", 4.99}
        };

        public string pan {get; protected set;}
        public string carne {get; set;}
        public double precio = 10.0;
        public List<string> ingredientes_adicionales;

        // Omiti agregar precio ya que se calcula dentro de la clase al agregar los ingredientes adicionales
        public Hamburguesa(string pan, string carne){
            this.ingredientes_adicionales = new List<string>(4);
            this.pan = pan;
            this.carne = carne;
        }

    public virtual void AgregarIngredientes(string[] args){
            foreach (string item in args)
            {
                this.ingredientes_adicionales.Add(item);
            }
        }

    public double GetPrecio(){
        foreach (string i in this.ingredientes_adicionales)
        {
            switch (i)
            {
                case ("Lechuga"):
                case ("Pepinillo"):
                case ("Tomate"):
                case ("Bacon"):
                case ("Ketchup"):
                case ("Queso"):
                case ("Papas Fritas"):
                case ("Refresco"):
                    Console.WriteLine($"{i}:\t" + "$" + _ingredientesAdicionalesMenu[i]);
                    this.precio += _ingredientesAdicionalesMenu[i];
                    break;

                default:
                    // Console.WriteLine($"{i} no es un ingrediente disponible.");
                    break;
            }
        }
        Console.WriteLine($"Total: {this.precio}");
        return this.precio;
    }

    public override string ToString()
    {
        string lista = "";
        foreach (string item in ingredientes_adicionales)
        {
            lista = lista + "\n\t\t\t" + item;
        }

        string _string = $"Hamburguesa Tradicional:\n\tCarne: {this.carne}\n\tPan: {this.pan}\t\n";
        _string += lista == "" ? "Sin Ingredientes Adicionales" : $"Ingredientes Adicionales: {lista}";
        return _string;
    }
}
