/*
¿Qué salida por la consola produce el siguiente código?
¿Qué se puede inferir respecto de la excepción división por cero en
relación al tipo de los operandos?
*/

int x = 0;
try
{
Console.WriteLine(1.0 / x); // IEEE 754, por ello no tira exception
Console.WriteLine(1 / x); // División entera por cero, tira exception
Console.WriteLine("todo OK");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}

Console.ReadLine();