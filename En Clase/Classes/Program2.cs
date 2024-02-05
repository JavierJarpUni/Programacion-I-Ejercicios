string Input(string? new_string){
    if (new_string != null){
        Console.WriteLine(new_string);
    }
    return Console.ReadLine();
}


int num1 = Convert.ToInt32(Input("Digite el primer numero:"));
int num2 = Convert.ToInt32(Input("Digite el segundo numero:"));

int[] resultados = new int[2];
Operaciones operaciones = new Operaciones(num1, num2);
resultados[0] = operaciones.Sumar();
resultados[1] = operaciones.Restar();
Console.WriteLine($"El resultado de la suma de ambos numeros {resultados[0]}. \nEl resultado de la resta de ambos numeros es {resultados[1]}.");