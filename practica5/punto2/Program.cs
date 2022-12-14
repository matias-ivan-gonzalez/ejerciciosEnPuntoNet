/*
Agregar a la clase Cuenta del ejercicio anterior un método estático GetCuentas() que
devuelva un List<Cuenta> con todas las cuentas creadas. Controlar que la
modificación de la lista devuelta, por ejemplo borrando algún elemento,
no afecte el listado que internamente mantiene la clase Cuenta. Sin embargo
debe ser posible interactuar efectivamente con los objetos Cuenta de la lista
devuelta. Verificar que el siguiente código produzca la salida por consola
que se indica:

Se creo la cuenta Id=1
Se creo la cuenta Id=2
Se depositó 50 en la cuenta 1 (Saldo=50)
1
2
Se extrajo 30 en la cuenta 1 (Saldo=20)
*/

new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.GetCuentas();
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.GetCuentas();
Console.WriteLine(cuentas.Count);
// se recupera nuevamente la lista de cuentas
cuentas[0].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo
Console.ReadLine();

class Cuenta{
    private double _saldo;
    private int _titularDNI;
    private string? _titularNombre;
    static int s_id=1;
    static int s_depositos = 0;
    static int s_extracciones = 0;
    static double s_totalDepositado = 0;
    static double s_totalExtraido = 0;
    static int s_extraccionesDenegadas=0;
    int _idCuenta;
    static List<Cuenta> s_cuentas = new List<Cuenta>();

    public Cuenta(){
        this._saldo = 0;
        Console.WriteLine($"Se creo la cuenta Id={s_id}");
        s_cuentas.Add(this);
        _idCuenta = s_id;
        s_id++;
    }

    public static List<Cuenta> GetCuentas(){
        return new List<Cuenta>(s_cuentas);
    }

    public static void ImprimirDetalle(){
        Console.WriteLine("\nDETALLE");
        Console.WriteLine($"CUENTAS CREADAS: {s_id-1}");
        Console.WriteLine($"DEPÓSITOS:       {s_depositos}           - Total depositado:  {s_totalDepositado}");
        Console.WriteLine($"Extracciones:    {s_extracciones}           - Total extraído:    {s_totalExtraido}");
        Console.WriteLine($"                             - Saldo                {s_totalDepositado - s_totalExtraido}");
        Console.WriteLine($" * Se denegaron {s_extraccionesDenegadas} extracciones por falta de fondos");
    }

    public Cuenta Depositar(double monto){
        _saldo += monto;
        s_depositos++;
        s_totalDepositado += monto;
        Console.WriteLine($"Se depositó {monto} en la cuenta {_idCuenta} (Saldo={_saldo})");
        return this;
    }

    public Cuenta Extraer(double monto){
        if (_saldo - monto >= 0){
            _saldo -= monto;
            s_extracciones++;
            s_totalExtraido += monto;
            Console.WriteLine($"Se extrajo {monto} en la cuenta {_idCuenta} (Saldo={_saldo})");
        }
        else{
            Console.WriteLine("Operación denegada - Saldo insuficiente");
            s_extraccionesDenegadas++;
        }
        return this;
    }

}