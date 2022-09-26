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
    string input;
    int i = 1;
    do {
        new Persona().imprimirDatos(i);
        i++;
        Console.WriteLine("Escriba -1 para salir o toque enter para continuar");
        input = Console.ReadLine();
    }
    while(input != "-1");
}

cargarPersonas();
Console.ReadLine();

public class Persona{
    public string nombre;
    public int edad;
    public int dni;

    public Persona(){
        Console.Write("Ingrese nombre, documento y edad separados por comas y en ese mismo orden: ");
        string entrada = Console.ReadLine();
        string[] atributos = entrada.Split(",");
        this.nombre = atributos[0];
        this.dni = int.Parse(atributos[1]);
        this.edad = int.Parse(atributos[2]);
    }

    public void imprimirDatos(int posicion){
        Console.WriteLine($"{posicion} {nombre} {edad} {dni}");
    }
}

