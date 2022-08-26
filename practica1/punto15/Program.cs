/*
Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es bisiesto si
es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto debe ser divisible
por 400.
*/

Console.Write("Ingrese un año: ");
int ano = int.Parse(Console.ReadLine());
Console.WriteLine(
    (
        (ano % 4 == 0 && ano % 100 != 0)
        ||
        (ano % 100 == 0 && ano % 400 == 0)
    ) 
    ? "Es bisiesto" : "No es bisiesto"
);
Console.ReadLine();