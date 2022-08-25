// Parte 1
Console.Write("Ingrese su nombre:");
String st = Console.ReadLine();
Console.WriteLine("Hola " + st);
Console.ReadLine();

// Parte 2
Console.Write("Ingrese un numero n:");
int n = int.Parse(Console.ReadLine());
int total = 0;
for (int i = 1; i < n; i++)
{
    total += n;
}
Console.Write("La sumatoria de 1 hasta " + n + " es de " + total);

Console.ReadLine();