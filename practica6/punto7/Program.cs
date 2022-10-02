/*
Ofrecer una implementación polimórfica para mejorar el siguiente programa:

Imprimidor.Imprimir(new A(), new B(), new C(), new D());
class A {
    public void ImprimirA() => Console.WriteLine("Soy una instancia A");
}
class B {
    public void ImprimirB() => Console.WriteLine("Soy una instancia B");
}
class C {
    public void ImprimirC() => Console.WriteLine("Soy una instancia C");
}
class D {
    public void ImprimirD() => Console.WriteLine("Soy una instancia D");
}
static class Imprimidor {
public static void Imprimir(params object[] vector) {
foreach (object o in vector) {
    if (o is A) { (o as A)?.ImprimirA(); }
    else if (o is B) { (o as B)?.ImprimirB(); }
    else if (o is C) { (o as C)?.ImprimirC(); }
    else if (o is D) { (o as D)?.ImprimirD(); }
}
}
}
*/

Imprimidor.Imprimir(new A(), new B(), new C(), new D());
Console.ReadLine();
class A {
    public void ImprimirInstancia() => Console.WriteLine($"Soy una instancia {this.GetType()}");
}
class B : A{
}
class C : A{
}
class D : A{
}
static class Imprimidor {
public static void Imprimir(params object[] vector) {
foreach (object o in vector) {
    if (o is A) { (o as A)?.ImprimirInstancia(); }
    else if (o is B) { (o as B)?.ImprimirInstancia(); }
    else if (o is C) { (o as C)?.ImprimirInstancia(); }
    else if (o is D) { (o as D)?.ImprimirInstancia(); }
}
}
}

