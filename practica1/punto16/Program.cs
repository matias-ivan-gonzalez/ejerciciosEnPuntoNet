/*
Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente
expresión (tip: observar qué pasa cuando b = 0):
if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
*/

int a=12, b=0;
if ((b != 0) && (a/b > 5)) {
    Console.WriteLine(a/b);
}
Console.ReadLine();

// Si b es cero nos tira una excepcion al intentar dividir por cero
/*
Usando el && nos aseguramos que no evalue el segundo condicional en caso
de que sea cero, por lo cual, no divide y no genera dicha exception
*/