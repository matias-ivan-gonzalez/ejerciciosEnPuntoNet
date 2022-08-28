/*
Investigar acerca de la clase StringBuilder del espacio de nombre System.Text
¿En qué circunstancias es preferible utilizar StringBuilder en lugar
de utilizar string? Implementar un caso de ejemplo en el que
el rendimiento sea claramente superior utilizando
StringBuilder en lugar de string y otro en el que no.
*/

/*
    Respuesta: StringBuilder sirve para evitar instanciar multiples
    instancias de String a la hora de redefinir y/o concatenar
    cadenas a una ya existente, ahorrando memoria.
*/
using System.Text;

Console.WriteLine("Caso usando StringBuilder");
StringBuilder parametros = new StringBuilder();
String espacio = " ";
// Crear una string que muestre todos los parametros ingresados
foreach (var arg in args){
    parametros.Append(arg);
    parametros.Append(espacio);
}
Console.WriteLine(parametros.ToString());

Console.WriteLine("Caso usando String");

String username = "csharp"; // Asumimos que este dato nos llega desde otro lado
String dni = getDniForUsername(username);
Console.WriteLine(dni);

String getDniForUsername(String username){
    // Asumimos que esto se obtiene de una BDD
    return "15235764";
}

/*
    Ya que todos estos casos son de informacion inmutable, usamos
    String en vez de StringBuilder
*/

Console.ReadLine();