Console.Write("Ingrese su nombre: ");
String nombre = Console.ReadLine();
Console.WriteLine("Con if y else");
string saludo = "Hola Mundo";
if(nombre == "Juan"){
    saludo = "¡Hola Amigo!";
}
else{
    if(nombre == "Maria"){
        saludo = "Buen día señora";
    }
    else{
        if (nombre == "Alberto"){
            saludo = "Hola Alberto";
        }
        else{
            saludo = (string.IsNullOrEmpty(nombre)) ? "¡Buen día mundo!" : $"Buen día {nombre}";
        }
    }
}

Console.WriteLine(saludo);
Console.WriteLine("Con switch");
Console.ReadLine();

switch (nombre)
{
    case "Juan":
        saludo = "¡Hola Amigo!";
        break;
    case "Maria":
        saludo = "Buen día señora";
        break;
    case "Alberto":
        saludo = "Hola Alberto";
        break;
    case "":
        saludo = "¡Buen día mundo!";
        break;
    default:
        saludo = $"Buen día {nombre}";
        break;
}

Console.WriteLine(saludo);
Console.ReadLine();