namespace punto1;
static class Procesador {
public static void Alquilar(IAlquilable x, Persona p) => x.SeAlquilaA(p);
public static void Atender(IAlquilable x) => Console.WriteLine();

}