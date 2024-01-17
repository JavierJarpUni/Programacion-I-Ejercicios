void Print(string input){
    Console.WriteLine(input);
}

string Read(){
    return Console.ReadLine();
}

int Sumar(int num1, int num2){
    return num1 + num2;
}

int Restar(int num1, int num2){
    return num1 - num2;
}

int Multiplicar(int num1, int num2){
    return num1 * num2;
}

int Dividir(int num1, int num2){
    return num1 / num2;
}


Print("Ingrese un numero: ");
string string_num1 = Read();
while (!int.TryParse(string_num1, out int intValue)) {
    Print("Eso no es un numero.");
    Print("Intentalo de nuevo.");
    string_num1 = Read();
}
Print("Ingrese otro numero: ");
string string_num2 = Read();

while (!int.TryParse(string_num2, out int intValue)) {
    Print("Eso no es un numero.");
    Print("Intentalo de nuevo.");
    string_num2 = Read();
}

int num1 = int.Parse(string_num1);
int num2 = int.Parse(string_num2);

Print(String.Format("La suma de ambos numeros es: {0}. \n La resta de ambos numeros es: {1}. \n El producto de ambos numeros es: {2}. \n El cociente de ambos numeros es: {3}.", Sumar(num1, num2).ToString(), Restar(num1, num2).ToString(), Multiplicar(num1, num2).ToString(), num1, num2.ToString()));
