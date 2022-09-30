/*
Dada la siguiente definición incompleta de clase:

class ListaDePersonas{
    public void Agregar(Persona p){
        . . .
    }
    . . .
}

Completarla y agregar dos indizadores de sólo lectura
Un índice entero que permite acceder a las personas de la lista por número de
documento. Por ejemplo p=lista[30456345] devuelve el objeto Persona que tiene
DNI=30456345 o null en caso que no exista en la lista.
Un índice de tipo char que devuelve un List<string> con todos los nombres
de las personas de la lista que comienzan con el carácter pasado como índice.
*/

ListaDePersonas listaDePersonas = new ListaDePersonas();
listaDePersonas.Agregar(new Persona("Juan",'M',123,new DateTime(1995,12,11)));
listaDePersonas.Agregar(new Persona("Marta",'F',456,new DateTime(1996,9,2)));
listaDePersonas.Agregar(new Persona("Maria",'M',789,new DateTime(1990,10,1)));
listaDePersonas.Agregar(new Persona("Federico",'M',101112,new DateTime(2000,11,5)));

Console.WriteLine(listaDePersonas[456]?.Nombre);
Console.WriteLine(listaDePersonas[999]?.Nombre);
Console.WriteLine(listaDePersonas[101112]?.Nombre);
listaDePersonas['M'].ForEach(p => Console.Write(p+"\n"));
listaDePersonas['J'].ForEach(p => Console.Write(p));


Console.ReadLine();

class ListaDePersonas{

    List<Persona> listaPersonas;

    public Persona? this[int dni]{
        get{ 
            return listaPersonas.Find(p => p.DNI == dni) ?? null;
        }
    }

    public List<string>? this[char caracter]{
        get{
            return listaPersonas.FindAll(p => p.Nombre.StartsWith(caracter)).Select(p => p.Nombre).ToList();
        }
    }

    public ListaDePersonas(){
        listaPersonas = new List<Persona>();
    }

    public void Agregar(Persona p){
        listaPersonas.Add(p);
    }
    
}


public class Persona {
    public string Nombre { get; set; }
    public char Sexo { get; set; }
    public int DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Persona(string nombre, char sexo, int dni, DateTime fechaNacimiento){
        this.Nombre = nombre;
        this.Sexo = sexo;
        this.DNI = dni;
        this.FechaNacimiento = fechaNacimiento;
    }
    public int edad{
        get{
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
    }

    public dynamic this[int i]
    {
        get{
            switch (i){
                case 0:
                    return Nombre;
                case 1:
                    return Sexo;
                case 2:
                    return DNI;
                case 3:
                    return FechaNacimiento;
                case 4:
                    return edad;
                default:
                    return "";
            }
        }
        set{
            switch (i){
                case 0:
                    Nombre = value;
                    break;
                case 1:
                    Sexo = value;
                    break;
                case 2:
                     DNI = value;
                    break;
                case 3:
                    FechaNacimiento = value;
                    break;
                default:
                    break;
            }
         }
    }
}