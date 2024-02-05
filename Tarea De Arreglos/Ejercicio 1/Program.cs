/*  1.       Leer 10 enteros, almacenarlos en un arreglo y 
            determinar en qué posición del arreglo está el mayor número leído. */

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

for (int i = 0; i < intArr.Length; i++)
{
    if (intArr[i] > currentMax){
        currentMax = intArr[i];
        maxIndex = i;
    }
}

Console.WriteLine($"El valor mas grande es {currentMax} en el indice {maxIndex}");