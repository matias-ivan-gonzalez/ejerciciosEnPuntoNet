/*
Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
consola.
*/
Console.Write("Ingrese un número entero:");
int numero = int.Parse(Console.ReadLine());
for (int i = 1; i <= numero; i++) {
    Console.Write(
        (numero % i == 0) ? i + "\n" : null
    );
}
Console.ReadLine();