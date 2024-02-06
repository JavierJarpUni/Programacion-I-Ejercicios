/* 7.       Leer 10 números enteros, almacenarlos en un arreglo y 
            determinar a cuánto es igual el promedio entero de los datos del arreglo */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}

int EncontrarPromedio(int[] arr){

    int sum = 0;
    foreach (int i in arr)
    {
        sum += i;
    }

    return (int)(sum / arr.Length); 
}

Console.WriteLine($"El promedio del arreglo es: {EncontrarPromedio(intArr)}");