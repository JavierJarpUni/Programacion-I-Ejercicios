int[] my_arreglo = new int[5];

for (int i = 0; i < my_arreglo.Length; i++)
{
    Console.WriteLine(my_arreglo[i]);
    my_arreglo[i] = i;
    Console.WriteLine(my_arreglo[i]);
}