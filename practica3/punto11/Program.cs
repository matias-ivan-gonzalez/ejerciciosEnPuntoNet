/*
Señalar errores de ejecución en el siguiente código
*/

List<int> a = new List<int>() { 1, 2, 3, 4 };
a.Remove(5);
a.RemoveAt(4);
/*
El primer metodo bsuca e intenta eliminar el valor 5, pero al no
encontrarlo, simplemente retorna false, en el caso del removeAt, nos
da una excepcion ya que intenta acceder al indice número 4 del array
siendo que este mismo posee un maximo de 3 accesible por indice, y
dicha peticion excede las dimensiones de la estructura.

*/