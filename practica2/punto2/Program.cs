/*
Sea el siguiente código:

El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas
variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la
consola no sea “Z Z”?
*/

object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);

Console.ReadLine();

/*
    Respuesta:
    No es Z Z porque luego de que hace o2 = o1, o2 guarda la referencia de o1,
    pero luego cambia por una Z, siguiendo o1 teniendo el mismo estado que antes
    (una "A"), quedando al final A Z
*/