/* 10.   Leer 10 números enteros, almacenarlos en un arreglo. Luego leer un entero y 
        determinar cuántos divisores exactos tiene este último número entre los valores almacenados en el arreglo. */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}

Console.WriteLine("\nIngresa un nuevo numero:");
int divisor = Convert.ToInt32(Console.ReadLine());

int resultado = 0;
for (int i = 0; i < intArr.Length; i++){
    if (divisor % intArr[i] == 0){
        Console.WriteLine($"{intArr[i]} es divisor de {divisor}.");
        resultado++;
    }
}

Console.WriteLine($"Existen {resultado} numeros que son divisor de {divisor} en el arreglo.");