/*
Implementar un programa que permita al usuario ingresar números por la consola. Debe
ingresarse un número por línea finalizado el proceso cuando el usuario ingresa una
línea vacía. A medida que se van ingresando los valores el sistema debe mostrar por
la consola la suma acumulada de los mismos. Utilizar la instrucción try/catch
para validar que la entrada ingresada sea un número válido, en caso contrario
advertir con un mensaje al usuario y proseguir con el ingreso de datos.
*/

Console.WriteLine("Ingrese varios numeros para ver su suma, de una entrada vacia para finalizar: ");
string input = Console.ReadLine();
int total = 0;
while(input != ""){
    try{
        int numero = int.Parse(input);
        total += numero;
        Console.WriteLine("Total = " + total);
    }    
    catch (System.Exception){
        Console.WriteLine("Caracter incorrecto, ingrese un numero");
    }
    finally{
        input = Console.ReadLine();
    }
}

Console.ReadLine();