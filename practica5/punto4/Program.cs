/*
Indicar en cada caso si la definición de la clase A es correcta, en caso de
no serlo detallar cuál es el error.


Double constructor, estatico y de instancia, ambos funcionan bien
class A {
    public static int s_a=0;
    static A() {
        s_a++;
    }
    public A() {
        s_a++;
    }
}

El error es que no se permiten modificadores de acceso en constructores
estaticos
class A {
    static int s_a = 0;
    public static A() {
        s_a++;
    }
    A() {
        s_a++;
    }
}

El problema es que un constructor estatico no puede tener parámetros
class A {
    static int s_a = 0;
    static A(int a) {
        s_a=a;
    }
    A(int a) {
        s_a = a;
    }
}

El problema acá es que al definir un constructor que recibe un parametro
se desestima el constructor vacio, y ademas, al ser privado por defecto,
no puede utilizarse por fuera de la clase, si se va a definir un constructor de 
instancia con parametros, se deberia evaluar implementar el constructor vacio
tambien si asi se desea (y que sea accesible, no privado como el caso A(int a))
class A {
    static int s_a = 0;
    int a = 0;
    static A() {
        s_a = 30;
    }
    A(int a) {
        s_a = a;
        this.a = a;
    }
}

No podemos hacer referencia a variables de instancia en un contexto
estatico
class A {
    static int s_a = 0;
    int a = 0;
    static A() {
        a = 30;
    }
    A(int a) {
        a = s_a;
    }
}
Es correcto
class A {
    static int s_a = 1;
    int a = 0;
    static A() => s_a += s_a;
    public static A GetInstancia() => new A(1);
    A(int a) => this.a = a + s_a;
}

Es correcto aunque ya hay por ejemplo una implementacion de PI en Math, siendo
Math.PI
class A {
    const double PI = 3.1416;
    static double DoblePI = 2 * PI;
}
Es incorrecto porque DoblePI es una constante y parte de su inicializacion
incluye a una variable, cuyo valor puede cambiar, contradiciendo la 
inmutabilidad para la que fue pensada const
class A {
    static double PI = 3.1416;
    const double DoblePI = 2*PI;
}
Es correcta, aunque por convencion, los campos estaticos deberian empezar
con s_, quedando el nombre como s_lista
class A {
    public static readonly List<int> _lista;
    static A() {
        _lista = new List<int>();
    }
    public static void P(int i) {
        _lista.Add(i);
    }
}

Incorrecto, no se puede asignar un campo de solo lectura estatico excepto
en un constructor estatico o inicializador de variable, ademas, la variable
no sigue la convencion de s_
class A {
    static readonly List<int> _lista;
    static A() {
        _lista = new List<int>();
    }
    public static void P(List<int> li) {
        _lista = li;
    }
}
Es correcto, aunque vector no sigue el estandar s_

class A {
    static int[] vector = { 1, 2, 3 };
    public int this[int i]{
        get { 
            return vector[i]; 
            }
    }
}
Es incorrecto, no se puede utilizar this(instancia) en un contexto estatico,
y tampoco respeta el estandar s_
class A {
    static int[] vector = { 1, 2, 3 };
    public static int this[int i] {
        get { 
            return vector[i]; 
            }
    }
}
*/