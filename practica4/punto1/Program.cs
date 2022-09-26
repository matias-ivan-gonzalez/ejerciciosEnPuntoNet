/*
Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI. Escribir un
algoritmo que permita al usuario ingresar en una consola una serie de datos de la
forma Nombre,Documento,Edad<ENTER>. Una vez finalizada la entrada de datos,
el programa debe imprimir en la consola un listado con 4 columnas de la
siguiente forma:
Nro) Nombre Edad DNI.
Ejemplo de listado por consola:
1) Juan Perez 40 2098745
2) José García 41 1965412
...
NOTA: Puede utilizar: Console.SetIn(new System.IO.StreamReader(nombreDeArchivo));
para cambiar la entrada estándar de la consola y poder leer directamente
desde un archivo de texto.
*/

void cargarPersonas(){
    string input = "";
    int i = 1;
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
}

cargarPersonas();
Console.ReadLine();

public class Persona{
    public string nombre;
    public int edad;
    public int dni;

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
}

