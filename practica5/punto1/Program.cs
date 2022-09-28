Cuenta c1 = new Cuenta();
c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
Cuenta c2 = new Cuenta();
c2.Depositar(200).Depositar(800);
new Cuenta().Depositar(20).Extraer(20);
c2.Extraer(1000).Extraer(1);
Cuenta.ImprimirDetalle();
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

    public Cuenta(){
        this._saldo = 0;
        Console.WriteLine($"Se creo la cuenta Id={s_id}");
        _idCuenta = s_id;
        s_id++;
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