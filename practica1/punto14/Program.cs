/*
Escribir un programa que multiplique por 365 el número entero ingresado por el usuario desde
la consola. El resultado debe imprimirse en la consola dígito por dígito, separado por un espacio
comenzando por el dígito menos significativo al más significativo.
*/

Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());
String resultado = (numero * 365).ToString();
for (int i = resultado.Length-1; i >= 0; i--) {
    Console.WriteLine(resultado[i]);
}
Console.WriteLine(numero * 365); // Muestra el numero entero
Console.ReadLine();