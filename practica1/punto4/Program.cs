Console.Write("Ingrese su nombre: ");
String nombre = Console.ReadLine();
String saludo = (string.IsNullOrEmpty(nombre)) ? "Hola Mundo" : $"Hola {nombre}";
Console.WriteLine(saludo);
Console.ReadLine();