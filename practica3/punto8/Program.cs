/*
¿Qué líneas del siguiente método provocan error de compilación y por qué?
*/

var a = 3L;
dynamic b = 32;
object obj = 3;
a = a * 2.0; // No se puede cambiar el tipo a double porque es VAR y fue asignado como long al principio
b = b * 2.0;
b = "hola";
obj = b;
b = b + 11;
obj = obj + 11; //  no se puede aplicar a operandos del tipo object e int
var c = new { Nombre = "Juan" };
var d = new { Nombre = "María" };
var e = new { Nombre = "Maria", Edad = 20 };
var f = new { Edad = 20, Nombre = "Maria" };
f.Edad = 22; // No se puede asignar de esta manera al objeto anonimo porque es de solo lectura
d = c;
e = d;
f = e;