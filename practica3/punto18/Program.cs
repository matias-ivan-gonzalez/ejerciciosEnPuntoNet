// Cuál es la salida por consola del siguiente programa:

try{
    Metodo1();
}
catch{
    Console.WriteLine("Método 1 propagó una excepción no tratada");
    // Informa que metodo1 tiro una exception
}

try{
    Metodo2();
}
catch{
    Console.WriteLine("Método 2 propagó una excepción no tratada");
    // Imprime esto a causa de la exception del metodo2
}
try{
    Metodo3();
}
catch{
    Console.WriteLine("Método 3 propagó una excepción");
    // Maneja la exception tirada por metodo3
}

Console.ReadLine();

void Metodo1(){
    object obj = "hola";
    try{
        int i = (int)obj; // Luego tira exception acá
    }
    finally{
        Console.WriteLine("Bloque finally en Metodo1");
        // Imprime esto primero
    }
}

void Metodo2(){
    object obj = "hola";
    try{
        int i = (int)obj; // Exception aca
    }
    catch (OverflowException){
        Console.WriteLine("Overflow");
    }
}

void Metodo3(){
    object obj = "hola";
    try{
        int i = (int)obj;
    }
    catch (InvalidCastException){
        Console.WriteLine("Excepción InvalidCast en Metodo3");
        // Imprime el mensaje del InvalidCast
        // Propaga una exception
        throw;
    }
}