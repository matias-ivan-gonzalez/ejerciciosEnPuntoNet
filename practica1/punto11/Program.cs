/*
Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y
contestar las preguntas.

¿Qué se puede concluir respecto del operador de división “/” ?
¿Cómo funciona el operador + entre un string y un dato numérico?
*/

Console.WriteLine("10/3 = " + 10 / 3);
// Obtiene el cociente de la division de 10 con 3 redondeado hacia abajo
Console.WriteLine("10.0/3 = " + 10.0 / 3);
// Obtiene el cociente de la division de 10.0 con 3 sin redondeo
Console.WriteLine("10/3.0 = " + 10 / 3.0);
// Obtiene el cociente de la division de 10 con 3.0 sin redondeo
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
// Devuelve 3, sin decimales ya que hablamos de variables enteras
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);
// Devuelve 3,3333333333333335 ya que hablamos de variables double

// Se concluye que el / obtiene el cociente de una división
// El operador + entre string y dato numerico los unifica en una unica string
Console.ReadLine();