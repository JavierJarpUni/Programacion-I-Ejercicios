/* 9.       Leer 10 números enteros, almacenarlos en un arreglo y 
        calcular la factorial a cada uno de los números leídos almacenándolos en otro arreglo */

Console.WriteLine("Ingresar 10 numeros:");
int[] intArr = new int[10];
for (int i = 0; i < 10; i++)
{
    Console.Write($"Ingresa el numero del indice {i}:  ");
    intArr[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write($"El arreglo contiene ");
    Console.Write("[{0}]\n", string.Join(", ", intArr));
}

int Factorial(int arr){
        int resultado = 1;

        for (int i = 1; i < arr + 1; i++)
        {
                resultado *= i;
                
        }

        return resultado;
}

int[] facArr = new int[10];
for (int i = 0; i < facArr.Length; i++)
{
        facArr[i] = Factorial(intArr[i]);
}

Console.Write("[{0}]\n", string.Join(", ", facArr));