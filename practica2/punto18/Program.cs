/*
Codificar el método Swap que recibe 2 parámetros enteros
e intercambia sus valores. El cambio debe apreciarse en
el método invocador.
*/

void Swap(int a,int b){
    Console.WriteLine("A: " + a);
    Console.WriteLine("B: " + b);
    int auxiliar = a;
    a = b;
    b = auxiliar;
    Console.WriteLine("A: " + a);
    Console.WriteLine("B: " + b);
}

int primero = int.Parse(args[0]);
int segundo = int.Parse(args[1]);
Swap(primero, segundo);