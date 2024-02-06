/* 6.       Leer 10 números enteros, almacenarlos en un arreglo y 
            determinar en qué posiciones se encuentran los números con más de 3 dígitos */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
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

Console.WriteLine("Encontrando todos los numeros con mas de 3 digitos...");
for (int i = 0; i < intArr.Length; i++)
{
    if (NumeroDeDigitos(intArr[i]) > 3){
        Console.WriteLine($"Posicion {i}: {intArr[i]}");
    }
}