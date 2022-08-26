/*
Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
¿Qué hace realmente?
*/
int sum = 0;
Console.WriteLine(sum);
int i = 1;
while (i <= 10)
{
    sum += i++;
    Console.WriteLine(sum);
}
Console.ReadLine();

// El error era que tenia un ; luego del while(i <= 10)