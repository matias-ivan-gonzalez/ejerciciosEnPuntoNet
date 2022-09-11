/*
Implementar un programa que muestre todos los números primos
entre 1 y un número natural dado (pasado al programa como argumento
por la línea de comandos). Definir el método bool EsPrimo(int n)
que devuelve true sólo si n es primo. Esta función debe comprobar si n es
divisible por algún número entero entre 2 y la raíz cuadrada de n. 
(Nota: Math.Sqrt(d) devuelve la raíz cuadrada de d)
*/

// Consultar como hacerlo con el profesor
Console.Write("Ingrese un número natural: ");
int numero = int.Parse(Console.ReadLine());
for (int i = 2; i <= numero; i++) {
    if(EsPrimo(i)){
        Console.WriteLine(i + " es primo");
    }
}
Console.ReadLine();

bool EsPrimo(int n){
    bool resultado = false;
    if ((n % 2 != 0) && (Math.Sqrt(n) % 2 != 0)){ //si el nro es par y tiene una raíz cuadrada par entonces es primo
        resultado = true;
    }
    return resultado;
}