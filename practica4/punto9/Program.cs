/*
Prestar atención a los siguientes programas (ninguno funciona correctamente):

¿Qué se puede decir acerca de la inicialización de los objetos? ¿En qué casos 
son inicializados automáticamente y con qué valor?

//En este caso se inicializa automaticamente en null la variable _bar

Foo f = new Foo();
f.Imprimir();
class Foo{
    string? _bar;
    public void Imprimir(){
        Console.WriteLine(_bar.Length);
    }
}

//En este caso NO se inicializa automaticamente en null la variable _bar,
ya que es una variable local al método imprimir

Foo f = new Foo();
f.Imprimir();
class Foo{
    public void Imprimir(){
        string? _bar;
        Console.WriteLine(_bar.Length);
    }
}
*/