/*
Escribir una función (método int Fac(int n)) que calcule el
factorial de un número n pasado al programa como parámetro
por la línea de comando
a) Definiendo una función no recursiva
b) Definiendo una función recursiva
c) idem a b) pero con expression-bodied methods 
(Tip: utilizar el operador condicional ternario)
*/
int FacNoRecursivo(int n){
    int total = 1;
    for (int i = 1; i <= n; i++){
        total *= i;
    }
    return total;
}
int FacRecursivo(int n){
    if(n==0){
        return 1;
    }
    return n * FacRecursivo(n-1);
}
int FacRecursivoExpressionBodied(int n){
    return (n==0) ? 1 : n * FacRecursivoExpressionBodied(n-1);
}

int numero = int.Parse(args[0]);
Console.WriteLine(FacNoRecursivo(numero));
Console.WriteLine(FacRecursivo(numero));
Console.WriteLine(FacRecursivoExpressionBodied(numero));