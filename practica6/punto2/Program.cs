/*
Aunque consultar en el código por el tipo de un objeto indica
habitualmente un diseño ineficiente, por motivos didácticos vamos
a utilizarlo. Completar el siguiente código, que utiliza las clases
definidas en el ejercicio anterior, para que se produzca la salida
indicada:
*/

using System;
A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
foreach (A a in vector){
    if(a.GetType().Equals(typeof(B))){
        a.Imprimir();
    }
}
Console.WriteLine();
foreach (A a in vector){
    if((a is B) && !(a is C)){
        a.Imprimir();
    }
}
Console.ReadLine();

class A {
    protected int _id;
    public A(int id) => _id = id;
    public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
}
class B : A{
    public B(int id) : base(id){}
    public override void Imprimir(){
        Console.Write($"B_{_id} --> ");
        base.Imprimir();
    }
}
class C : B{
    public C(int id) : base(id){}

    public override void Imprimir(){
        Console.Write($"C_{_id} --> ");
        base.Imprimir();
    }
}
class D : C{
    public D(int id) : base(id){}
    public override void Imprimir(){
        Console.Write($"D_{_id} --> ");
        base.Imprimir();
    }
}