/* 8.       Leer 10 números enteros, almacenarlos en un arreglo y 
            determinar cuántos números negativos hay. */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}


bool esNegativo(int num){

    if (num < 0) return true;
    return false;
}

int resultado = 0;
foreach (int i in intArr)
{
    if (esNegativo(i)){
        resultado++;
        Console.WriteLine($"{i} es negativo.");
    }
}

Console.WriteLine($"El arreglo tiene {resultado} numeros negativos.");