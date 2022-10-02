/*
Crear un programa para gestionar empleados en una empresa. 
Los empleados deben tener las propiedades públicas de sólo lectura Nombre, DNI,
FechaDeIngreso, SalarioBase y Salario. Los valores de estas propiedades 
(a excepción de Salario que es una propiedad calculada) deben establecerse por
medio de un constructor adecuado.
Existen dos tipos de empleados: Administrativo y Vendedor. No se podrán crear
objetos de la clase padre Empleado, pero sí de sus clases hijas
(Administrativo y Vendedor). Aparte de las propiedades de solo lectura
mencionadas, el administrativo tiene otra propiedad pública de lectura/escritura
llamada Premio y el vendedor tiene otra propiedad pública de lectura/escritura
llamada Comision.
La propiedad de solo lectura Salario, se calcula como el salario base más la
comisión o el premio según corresponda.
Las clases tendrán además un método público llamado AumentarSalario() que
tendrá una implementación distinta en cada clase. En el caso del administrativo
se incrementará el salario base en un 1% por cada año de antigüedad que posea
en la empresa, en el caso del vendedor se incrementará el salario base en un 5%
si su antigüedad es inferior a 10 años o en un 10% en caso contrario.
El siguiente código (ejecutado el día 9/4/2022) debería mostrar en la consola
el resultado indicado:

Empleado[] empleados = new Empleado[] {
new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10000) {Premio=1000},
new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 10000) {Comision=2000},
new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 10000) {Comision=2000}
};
foreach (Empleado e in empleados)
{
    e.informarEstado();
    e.AumentarSalario();
    e.informarEstado();
}

Respuesta esperada:

Administrativo Nombre: Ana, DNI: 20000000 Antigüedad: 4
Salario base: 10000, Salario: 11000
-------------
Administrativo Nombre: Ana, DNI: 20000000 Antigüedad: 4
Salario base: 10300, Salario: 11300
-------------
Vendedor Nombre: Diego, DNI: 30000000 Antigüedad: 12
Salario base: 10000, Salario: 12000
-------------
Vendedor Nombre: Diego, DNI: 30000000 Antigüedad: 12
Salario base: 11000, Salario: 13000
-------------
Vendedor Nombre: Luis, DNI: 33333333 Antigüedad: 11
Salario base: 10000, Salario: 12000
-------------
Vendedor Nombre: Luis, DNI: 33333333 Antigüedad: 11
Salario base: 11000, Salario: 13000
-------------

Recomendaciones: Observar que el método AumentarSalario() y la propiedad de solo
lectura Salario en la clase Empleado pueden declararse como abstractos.
Intentar no utilizar campos sino propiedades auto-implementadas todas las veces
que sea posible. Además sería deseable que la propiedad SalarioBase definida
en Empleado sea pública para la lectura y protegida para la escritura, para que
pueda establecerse desde las subclases Administrativo y Vendedor.
*/

Empleado[] empleados = new Empleado[] {
    new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10000) {Premio=1000},
    new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 10000) {Comision=2000},
    new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 10000) {Comision=2000}
};
foreach (Empleado e in empleados){
    e.informarEstado();
    e.AumentarSalario();
    e.informarEstado();
}
Console.ReadLine();

public abstract class Empleado{
    protected string Nombre{get;}
    protected int DNI{get;}
    protected DateTime FechaDeIngreso{get;}
    public double SalarioBase{get;protected set;}
    public abstract double Salario{get;}
    public abstract void AumentarSalario();
    public void informarEstado(){
        Console.WriteLine(
            $"{this.GetType()} Nombre: {Nombre}, DNI: {DNI} Antigüedad: {DateTime.Now.Year-FechaDeIngreso.Year}\nSalario base: {SalarioBase}, Salario: {Salario}"
        );
        Console.WriteLine("-------------------");
    }
    public Empleado(string nombre, int dni, DateTime fechaDeIngreso, double salarioBase){
        this.Nombre = nombre;
        this.DNI = dni;
        this.FechaDeIngreso = fechaDeIngreso;
        this.SalarioBase = salarioBase;
    }

}

public class Administrativo : Empleado{
    public double Premio{get;set;}
    public override double Salario{get{ return SalarioBase + Premio;}}
    public override void AumentarSalario(){
        SalarioBase += (DateTime.Now.Year - FechaDeIngreso.Year) * ((1 * SalarioBase) / 100);
    }
    public Administrativo(string nombre, int dni, DateTime fechaDeIngreso, double salarioBase) 
    : base(nombre, dni, fechaDeIngreso, salarioBase){}

}

public class Vendedor : Empleado{
    public double Comision{get;set;}
    public override double Salario{get{ return SalarioBase + Comision;}}
    public override void AumentarSalario(){
        SalarioBase += ((DateTime.Now.Year - FechaDeIngreso.Year) < 10) 
        ? ((SalarioBase * 5) / 100) : ((SalarioBase * 10) / 100);
    }
    public Vendedor(string nombre, int dni, DateTime fechaDeIngreso, double salarioBase) 
    : base(nombre, dni, fechaDeIngreso, salarioBase){}

}