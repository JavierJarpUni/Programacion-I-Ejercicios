/* 3.       Leer 10 enteros, almacenarlos en un arreglo y 
        determinar en qué posición del arreglo está el mayor número primo leído. */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}

int currentMax = 0;
int maxIndex = 0;

bool esPrimo(int num){
    bool es_primo = true;
        // Confirmar que el numero es primo
    if (num < 2) es_primo = false;
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            es_primo = false;
            break;
        }
    }

    return es_primo;
}

for (int i = 0; i < intArr.Length; i++)
{
    if (esPrimo(intArr[i]) && intArr[i] > currentMax){
        currentMax = intArr[i];
        maxIndex = i;
    }
}

if (currentMax != 0)
    Console.WriteLine($"\nEl valor primo mas grande es {currentMax} en el indice {maxIndex}");
else
    Console.WriteLine("\nNo existe numero primo en el arreglo");