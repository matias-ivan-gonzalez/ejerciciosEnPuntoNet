/*
Escribir un programa que reciba una lista de nombres como parámetro
e imprima por consola un
saludo personalizado para cada uno de ellos.
a) utilizando la sentencia for
b) utilizando la sentencia foreach
*/

Console.WriteLine("Resolucion con FOR:");
for (int i = 0; i < args.Length; i++) {
    Console.WriteLine("Hola {0}",args[i]);
}
Console.WriteLine("Resolucion con FOREACH:");
foreach (var arg in args){
    Console.WriteLine($"Hola {arg}");
}
Console.ReadLine();