/*
Completar la clase Cuenta para que el siguiente código produzca la salida indicada:

Nombre: No especificado, DNI: No especificado, Monto: 0
Nombre: No especificado, DNI: 30222111, Monto: 0
Nombre: José Perez, DNI: No especificado, Monto: 0
Nombre: María Diaz, DNI: 20287544, Monto: 0
Nombre: María Diaz, DNI: 20287544, Monto: 200
Nombre: María Diaz, DNI: 20287544, Monto: 50
Operación cancelada, monto insuficiente

Utilizar en la medida de lo posible la sintaxis :this en el encabezado de los
constructores para invocar a otro constructor ya definido.
*/

Cuenta cuenta = new Cuenta();
cuenta.Imprimir();
cuenta = new Cuenta(30222111);
cuenta.Imprimir();
cuenta = new Cuenta("José Perez");
cuenta.Imprimir();
cuenta = new Cuenta("Maria Diaz", 20287544);
cuenta.Imprimir();
cuenta.Depositar(200);
cuenta.Imprimir();
cuenta.Extraer(150);
cuenta.Imprimir();
cuenta.Extraer(1500);

Console.ReadLine();

class Cuenta{
    private double _monto;
    private int _titularDNI;
    private string? _titularNombre;

    public Cuenta(){}

    public Cuenta(int dni) : this(null,dni){}
    public Cuenta(string nombre): this(nombre,-404){}
    public Cuenta(string nombre, int dni){
        this._titularNombre = nombre;
        this._titularDNI = dni;
        this._monto = 0;
    }

    public void Imprimir(){
        string noEspecificado = "No especificado";
        string nombre = _titularNombre != null ? _titularNombre : noEspecificado;
        string dni = _titularDNI != -404 ? _titularDNI.ToString() : noEspecificado;
        string monto = _monto.ToString();
        Console.WriteLine(
            $"Nombre: {nombre}, DNI: {dni}, Monto: {monto}"
        );
    }

    public void Depositar(double monto){
        _monto += monto;
    }

    public void Extraer(double monto){
        if (_monto - monto >= 0){
            _monto -= monto;
        }
        else{
            Console.WriteLine("Operación cancelada, monto insuficiente");
        }
    }

}