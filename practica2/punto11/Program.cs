/*
¿Para qué sirve el método Split de la clase string?
Usarlo para escribir en la consola todas las palabras (una por línea)
de una frase ingresada por consola por el usuario.
*/

Console.Write("Ingrese una frase: ");
String frase = Console.ReadLine();
string[] palabras = frase.Split(" ");
foreach (var palabra in palabras) {
    Console.WriteLine(palabra);
}
Console.ReadLine();