/*
Escribir una función (método int Fib(int n)) que calcule el término
n de la serie de Fibonacci.
Fib(n) = 1, si n <=2
Fib(n) = Fib(n-1) + Fib(n-2), si n > 2
*/

Console.Write(Fib(int.Parse(args[0])));

int Fib(int n){
    return (n==0) ? 0 : ((n<=2) ? 1 : (Fib(n-1) + Fib(n-2)));
}