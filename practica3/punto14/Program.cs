/*
Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base
10 a otra base realizando divisiones sucesivas. Por ejemplo para pasar 35 en base 10 a binario
dividimos sucesivamente por dos hasta encontrar un cociente menor que el divisor, luego el
resultado se obtiene leyendo de abajo hacia arriba el cociente de la última división seguida por
todos los restos.
*/

void convertirABase(int numero, int b){
    Dictionary<int,string> letras = new Dictionary<int, string>()
    {
        {10,"A"}, {11,"B"}, {12,"C"}, {13,"D"}, {14,"E"}, {15,"F"}
    };
    Stack<int> pila = new Stack<int>();
    while(b <= numero){
        int resto = numero % b;
        numero = numero / b;
        pila.Push(resto);
    }
    pila.Push(numero);
    while (pila.Count != 0){
        dynamic valor = pila.Pop();
        if (valor >= 10){
            valor = letras[valor];
        }
        Console.Write(valor);
    }
    Console.WriteLine();
}

convertirABase(35,2);
convertirABase(10,3);
convertirABase(10,4);
convertirABase(10,5);
convertirABase(10,6);
convertirABase(10,7);
convertirABase(35,8);
convertirABase(35,9);
convertirABase(35,10);
convertirABase(10,11);
convertirABase(35,12);
convertirABase(35,13);
convertirABase(35,14);
convertirABase(35,15);
convertirABase(10,16);
convertirABase(1000,16);

Console.ReadLine();