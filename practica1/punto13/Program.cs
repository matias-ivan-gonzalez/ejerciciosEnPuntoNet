/*
Escribir un programa que calcule la suma de dos números reales introducidos por teclado y
muestre el resultado en la consola (utilizar double.Parse(st) para obtener el valor double a
partir del string st.
*/
Console.Write("Ingrese un número real: ");
double numero1 = double.Parse(Console.ReadLine());
Console.Write("Ingrese otro número real: ");
double numero2 = double.Parse(Console.ReadLine());
Console.WriteLine(numero1 + numero2);
Console.ReadLine();