/*
Contestar sobre el siguiente programa:

¿Por qué no es necesario agregar :base en el constructor de Taxi?
Porque asigna simplemente variables propias, nada que tenga que 
ver con la superclase Auto

Eliminar el segundo constructor de la clase Auto y modificar la
clase Taxi para el programa siga funcionando


Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
class Auto {
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
    public Auto() { }
}
class Taxi : Auto {
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros) => this.Pasajeros = pasajeros;
}
*/

Taxi t = new Taxi(3);
Console.WriteLine($"Un {t.Marca} con {t.Pasajeros} pasajeros");
class Auto {
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;
}
class Taxi : Auto {
    public int Pasajeros { get; private set; }
    public Taxi(string marca) : base(marca) {}
    public Taxi(int pasajeros) : this("Generic") => this.Pasajeros = pasajeros;
}