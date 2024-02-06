/* 4.       Leer 10 números enteros, almacenarlos en un arreglo y 
        determinar cuántos números de los almacenados en dicho arreglo comienzan en dígito primo*/

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}

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

int resultado = 0;
for (int i = 0; i < intArr.Length; i++)
{
    int firstDigit = Convert.ToInt32(intArr[i].ToString()[0].ToString());
    if (esPrimo(Convert.ToInt32(firstDigit))){
        Console.WriteLine($"Posicion {i}: El numero {intArr[i]} comienza con un numero primo, {firstDigit}.");
        resultado += 1;
    }
}

Console.WriteLine($"\nNumero de elementos que comienzan con un numero primo: {resultado}.");