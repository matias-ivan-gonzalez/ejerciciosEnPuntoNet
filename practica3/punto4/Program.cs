/*
Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que
devuelven un vector con la diagonal correspondiente de la matriz pasada como
parámetro. Si la matriz no es cuadrada generar una excepción ArgumentException.
double[] GetDiagonalPrincipal(double[,] matriz)
double[] GetDiagonalSecundaria(double[,] matriz)
*/


void ValidarSiEsCuadrada(double[,] matriz){
    if((matriz.GetLength(0) * matriz.GetLength(1)) % 2 != 0)
        throw new ArgumentException("La matriz no es cuadrada");
}

double[] GetDiagonalPrincipal(double[,] matriz){
    ValidarSiEsCuadrada(matriz);
    double[] diagonal = new double[matriz.GetLength(0)];
    for (int i = 0; i < matriz.GetLength(0); i++){
        diagonal[i] = matriz[i,i];
        Console.Write(diagonal[i] + "| ");
    }
    Console.WriteLine();
    return diagonal;
}

double[] GetDiagonalSecundaria(double[,] matriz){
    double[] diagonal = new double[matriz.GetLength(0)];
    int k = matriz.GetLength(0) - 1;
    for (int i = 0; i < matriz.GetLength(0); i++){
        diagonal[i] = matriz[i,k];
        Console.Write(diagonal[i] + "| ");
        k--;
    }
    Console.WriteLine();
    return diagonal;
}

double[,] matriz = new double[,]
{ {1,2,3,4},
{5,6,7,8},
{9,10,11,12},
{13,14,15,16} };

try{
    GetDiagonalPrincipal(matriz);
    GetDiagonalSecundaria(matriz);
}
catch (ArgumentException e){
    Console.WriteLine(e.Message);
}
finally{
        Console.ReadLine();
}