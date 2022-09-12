/*
Ídem. al ejercicio 16.a) y 16.b) pero devolviendo el resultado 
en un parámetro de salida void Fac(int n, out int f)
*/
void FacNoRecursivo(int n,out int resultado){
    resultado = 1;
    for (int i = 1; i <= n; i++){
        resultado *= i;
    }
}
void FacRecursivo(int n,out int resultado){
    resultado = 1;
    if(n!=0){
        FacRecursivo(n-1, out resultado);
        resultado *= n;
    }
}
int FacRecursivoExpressionBodied(int n, out int resultado){
    resultado = (n==0) ? 1 : n * FacRecursivoExpressionBodied(n-1, out resultado);
    return resultado;
}

int numero = int.Parse(args[0]);
int resultado;

FacNoRecursivo(numero,out resultado);
Console.WriteLine(resultado);

FacRecursivo(numero,out resultado);
Console.WriteLine(resultado);

FacRecursivoExpressionBodied(numero, out resultado);
Console.WriteLine(resultado);