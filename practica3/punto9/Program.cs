/*
Señalar errores de compilación y/o ejecución en el siguiente código
*/

object obj = new int[10];
dynamic dyn = 13;
//Console.WriteLine(obj.Length);
/*A mi entender, no puede acceder al length ya que aunque es object
y encapsula un array, al ser object se atiene al protocolo de este, y
no al de un array.
*/

Console.WriteLine(dyn.Length);
/*
Error similar al anterior pero con la diferencia que se da en tiempo de
ejecucion y no de compilacion, encapsulamos un int dentro de una variable
DYNAMIC e intentamos acceder a su length, pero el compilador nos lo permite
pero luego tira una exception en runtime.
*/