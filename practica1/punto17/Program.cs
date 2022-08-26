/*
Utilizar el operador ternario condicional para establecer el contenido de una variable entera con
el menor valor de otras dos variables enteras.
*/

int a=10,b=5;
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
int c = (a<b) ? a : b;
Console.WriteLine($"c={c}");
Console.ReadLine();