/*
Señalar el error en cada uno de los siguientes casos:

class A {
    public string M1()
    => "A.M1";
}
class B : A {
    public override string M1()
    // Este metodo no esta declarado como virtual en la superclase
    => "B.M1";
}

class A {
    public abstract string M1();
    // El problema es que la clase A no es abstracta
}
class B : A {
    public override string M1()
    => "B.M1";
}

abstract class A {
    public abstract string M1()
    => "A.M1";
    // El problema es que se le declara un cuerpo al metodo abstracto
}
class B : A {
    public override string M1()
    => "B.M1";
}

class A {
    public override string M1()
    // Intenta invalidar un metodo que no puede, al no tener superclase
    => "A.M1";
}
class B : A {
    public override string M1()
    => "B.M1";
}

class A {
    public virtual string M1()
    => "A.M1";
}
class B : A {
    protected override string M1()
    // No se puede cambiar el modificador de acceso al invalidar metodo
    => "B.M1";
}

class A {
    public static virtual string M1() //error
    => "A.M1";
}
class B : A {
    public static override string M1()//error
    => "B.M1";
}
//Miembros estaticos no se pueden marcar como virtual y override

class A {
    virtual string M1() => "A.M1"; //error
}
class B : A {
    override string M1() => "B.M1"; //error
}
// Los miembros virtuales o abstractos no pueden ser privados

class A {
    protected A(int i) { }
}
class B : A {
    B() { } 
    // A no tiene constructor vacio y el de B no tiene parametro para matchear con el de la superclase
}

class A {
    private int _id;
    protected A(int i) => _id = i;
}
class B : A {
    B(int i):base(5) {
    _id=i; // el campo _id es privado y la subclase no puede accederlo
    }
}

class A {
private int Prop {
    set; public get;
    //El modificador de accesibilidad del descriptor de acceso tiene que
    // ser igual o mas restrictiva que la propiedad
}
}
class B : A {
}

abstract class A {
    public abstract int Prop
    {set; get;}
}
class B : A {
    //B no implementa el set de prop
    public override int Prop
    {
    get => 5;
    }
}

abstract class A {
    public int Prop {set; get;}
}
class B : A {
    // No se puede invalidar porque no esta marcado como virtual, abstract ni override
    public override int Prop {
        get => 5;
        set {}
    }
}
*/