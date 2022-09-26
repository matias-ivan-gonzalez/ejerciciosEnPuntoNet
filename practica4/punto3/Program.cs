/*
Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero
si la persona que recibe el mensaje tiene más edad que la persona enviada como
parámetro. 
Utilizarlo para realizar un programa que devuelva la persona más jóven
de la lista.
*/

void cargarPersonas(){
    string input = "";
    int i = 1;
    Persona personaDeMenorEdad = null;
    Console.WriteLine("Con -1 en cualquier entrada de datos saldrá del programa");
    do {
        try{
            Console.Write("Ingrese nombre, documento y edad separados por comas y en ese mismo orden: ");
            input = Console.ReadLine();
            string[] atributos = input.Split(",");
            string nombre = atributos[0];
            int dni = int.Parse(atributos[1]);
            int edad = int.Parse(atributos[2]);
            Persona p1 = new Persona(nombre,dni,edad);
            p1.imprimirDatos(i);
            i++;
            if (personaDeMenorEdad==null){
                personaDeMenorEdad = p1;
            }
            else{
                if(personaDeMenorEdad.EsMayorQue(p1)){
                    personaDeMenorEdad = p1;
                }
            }    
        }
        catch (System.Exception){
            if (input == "-1"){
                Console.WriteLine("La ejecución ha finalizado");
            }
            else{
                Console.WriteLine("Ha ocurrido un error, respete el formato de ingreso");
            }
        }
    }
    while(input != "-1");
    if (personaDeMenorEdad != null){
        Console.WriteLine("La persona con menor edad es: ");
        personaDeMenorEdad.imprimirDatos();        
    }

}

cargarPersonas();
Console.ReadLine();

public class Persona{
    string nombre;
    int edad;
    int dni;

    public Persona(string nombre, int edad, int dni){
        this.nombre = nombre;
        this.dni = dni;
        this.edad = edad;
    }

    public void imprimirDatos(int posicion){
        Console.WriteLine($"{posicion}) {nombre} {edad} {dni}");
    }

    public void imprimirDatos(){
        Console.WriteLine($"{nombre} {edad} {dni}");
    }

    public bool EsMayorQue(Persona p){
        return this.edad > p.edad;
    }
}

