/* 5.       Leer 10 números enteros, almacenarlos en un arreglo y 
            determinar en qué posición se encuentra el número primo con mayor cantidad de dígitos pares. */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}

/*

1. Determinar si el numero es par
2. Determinar si es el numero con mayor cantidad de digitos que el ultimo numero primo
3. Printearlo
*/

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

int NumeroDeDigitos(int num){
    string stringNum = num.ToString();
    int resultado = 0;
    foreach (char i in stringNum)
    {
        resultado++;
    }

    return resultado;
}

int ultimoMax = 0;
int ultimoNumeroDeDigitos = 0;
int maxIndex = 0;
for (int i = 0; i < intArr.Length; i++)
{
    if (esPrimo(intArr[i])){
        if (NumeroDeDigitos(intArr[i]) > ultimoNumeroDeDigitos){
            ultimoMax = intArr[i];
            ultimoNumeroDeDigitos = NumeroDeDigitos(intArr[i]);
            maxIndex = i;
        }
    }
}

Console.WriteLine($"Posicion {maxIndex}: El numero {ultimoMax} es el numero primo con mas digitos.\n Digitos: {ultimoNumeroDeDigitos}");