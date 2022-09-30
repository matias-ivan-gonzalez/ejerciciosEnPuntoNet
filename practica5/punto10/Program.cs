/*
Identificar todos los miembros en la siguiente declaración de clase.
Indicar si se trata de un constructor, método, campo, propiedad o 
indizador, si es estático o de instancia, y en caso que
corresponda si es de sólo lectura, sólo escritura o lectura y
escritura. En el caso de las propiedades indicar también si se trata
de una propiedad auto-implementada.
Nota: La clase compila perfectamente. Sólo prestar atención a la
sintaxis, la semántica es irrelevante.
*/

// L = lectura  E = escritura  L/E = lectura/escritura
public class A{
    private static int a; // campo estatico L/E
    private static readonly int b; //campo estatico L
    public A() { } // constructor vacio de instancia
    public A(int i) : this() { } // constructor de instancia con referencia al constructor vacio
    static A() => b = 2; // constructor estatico que asigna a la variable de lectura b el valor 2
    int c; // campo de instancia
    public static void A1() => a = 1; // metodo estatico que pone al campo "a" de L/E con valor 1
    public int A1(int a) => A.a + a; // metodo de instancia que suma a la propiedad estatica su mismo valor
    public static int A2; // campo estatico de L/E
    static int A3 => 3; // propiedad estatica con lectura configurada para devolver 3
    private int A4() => 4; // metodo de instancia que retorna 4
    public int A5 { get => 5; } // propiedad de la instancia con lectura configurada para devolver 5
    int A6 { set => c = value; } // propiedad de instancia con escritura configurada para hacer que c = value
    public int A7 { get; set; } // propiedad de instancia con L/E autoimplementada
    public int A8 { get; } = 8; // propiedad de instancia con L autoimplementada y valor por defecto en 8
    public int this[int i] => i; // indizador que devuelve el indice que se le proporciona
}