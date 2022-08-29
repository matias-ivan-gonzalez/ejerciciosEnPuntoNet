/*
Investigar sobre el tipo DateTime y usarlo 
para medir el tiempo de ejecución de los algoritmos
implementados en el ejercicio anterior.
*/

using System.Text;

DateTime startTime;
DateTime endTime;
StringBuilder parametros = new StringBuilder();

Console.WriteLine("Medición usando StringBuilder");
startTime = DateTime.Now;
//StringBuilder parametros = new StringBuilder();
String espacio = " ";
// Crear una string que muestre todos los parametros ingresados
foreach (var arg in args) {
    parametros.Append(arg);
    parametros.Append(espacio);
}
Console.WriteLine(parametros.ToString());
endTime = DateTime.Now;
Console.WriteLine(endTime.Subtract(startTime).Milliseconds);

Console.WriteLine("Medición usando String");
startTime = DateTime.Now;
string p = " ";
string space = " ";
// Crear una string que muestre todos los parametros ingresados
foreach (var arg in args) {
    p += arg + space;
}
Console.WriteLine(parametros);
endTime = DateTime.Now;
Console.WriteLine(endTime.Subtract(startTime).Milliseconds);