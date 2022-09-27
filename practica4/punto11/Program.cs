/*
¿Qué salida produce en la consola el siguiente programa?
*/

object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o);
s.Procesar((dynamic)o, o);
s.Procesar((dynamic)o, (dynamic)o);
s.Procesar(o, (dynamic)o);
s.Procesar(5, 5);
Console.ReadLine();
class Sobrecarga{
    public void Procesar(int i, object o){
        Console.WriteLine($"entero: {i} objeto:{o}");
    }
    public void Procesar(dynamic d1, dynamic d2){
        Console.WriteLine($"dynamic d1: {d1} dynamic d2:{d2}");
    }
}

/*
Primero va al segundo metodo, ya que son dos objects y los toma como dynamic.
Luego, va al primero, porque al castear a dynamic y recibir un int, se ajusta
a su tipo, lo toma como tal y matchea con los parametros del primer metodo.
Luego, sigue yendo al primero.
En el 4to caso, va al segundo, porque envia un object y un dynamic, matcheando
con el segundo, a causa el parametro numero 2.
Dos int, van al primero.

Salida:
dynamic d1: 5 dynamic d2:5
entero: 5 objeto:5
entero: 5 objeto:5
dynamic d1: 5 dynamic d2:5
entero: 5 objeto:5
*/