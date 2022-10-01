/*
¿Qué líneas del siguiente código provocan error de compilación y por qué?

Las lineas señaladas no compilan, se deben a la accesibilidad de la clase
Persona, la cual por defecto es privada, con un cambio en esto, se solucionaria
el problema de compilación.

class Persona {
    public string Nombre { get; set; }
}
public class Auto {
    private Persona _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1; Error de compilacion
    protected Persona SegundoDueño { Error de compilacion
        set => _dueño2 = value;
    }
}
Solucion:
*/
public class Persona {
    public string Nombre { get; set; }
}
public class Auto {
    private Persona _dueño1, _dueño2;
    public Persona GetPrimerDueño() => _dueño1;
    protected Persona SegundoDueño {
        set => _dueño2 = value;
    }
}
