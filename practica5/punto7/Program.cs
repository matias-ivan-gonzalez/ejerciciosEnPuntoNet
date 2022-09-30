/*
Definir la clase Persona con las siguientes propiedades de lectura y escritura:
Nombre de tipo string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento
de tipo DateTime. Además definir una propiedad de sólo lectura (calculada)
Edad de tipo int. Definir un indizador de lectura/escritura que permita acceder
a las propiedades a través de un índice entero. Así, si p es un objeto Persona,
con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es
descartado. Observar que el tipo del indizador debe ser capaz almacenar
valores de tipo int, char, DateTime y string.
*/

Persona persona = new Persona();

persona[0] = "Matias";
persona[1] = 'M';
persona[2] = 123;
persona[3] = new DateTime(2001,02,06);
persona[4] = 11;

Console.WriteLine(persona[0]);
Console.WriteLine(persona[1]);
Console.WriteLine(persona[2]);
Console.WriteLine(persona[3]);
Console.WriteLine(persona[4]);
Console.WriteLine(persona.Nombre);
Console.WriteLine(persona.Sexo);
Console.WriteLine(persona.DNI);
Console.WriteLine(persona.FechaNacimiento);
Console.WriteLine(persona.edad);

Console.ReadLine();

public class Persona {
    public string Nombre { get; set; }
    public char Sexo { get; set; }
    public int DNI { get; set; }
    public DateTime FechaNacimiento { get; set; }
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