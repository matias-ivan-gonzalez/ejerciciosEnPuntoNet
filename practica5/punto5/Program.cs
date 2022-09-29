/*
Qué líneas del código siguiente provocan error de compilación? 
Analizar cuándo es posible acceder a miembros estáticos y de instancia.


class A {
    char c;
    static string st;
    void metodo1() {
        // Este metodo hace un uso correcto de las variables
        st = "string";
        c = 'A';
    }
    static void metodo2(){
        new ClaseA().c = 'a'; // Error de compilación, esta clase no existe
        st = "st2";
        c = 'B'; // No podemos referenciar a variables de instancia en contextos estaticos
        new A().st = "otro string"; // Error de compilación
        // No podemos acceder a la variable estatica st desde una instancia
    }
}
*/