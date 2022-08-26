Console.Write("Ingrese una palabra:");
String entrada = Console.ReadLine();
while(entrada!=""){
    Console.WriteLine("La palabra ingresada tiene " + entrada.Length);
    Console.Write("Ingrese una palabra:");
    entrada = Console.ReadLine();
}
Console.WriteLine("Terminó la ejecución");
Console.ReadLine();