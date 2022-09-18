/*
Implementar un método que devuelva un arreglo de arreglos con los mismos
elementos que la matriz pasada como parámetro:
double[][] GetArregloDeArreglo(double [,] matriz)
*/

double[][] GetArregloDeArreglo(double [,] matriz){
    int rows = matriz.GetLength(0);
    int columns = matriz.GetLength(1);
    double[][] arregloDeArreglos = new double[rows][];
    for (int i = 0; i < rows ; i++){
        arregloDeArreglos[i] = new double[columns];
        for (int j = 0; j < columns; j++){
            arregloDeArreglos[i][j] = matriz[i,j];
            Console.Write(arregloDeArreglos[i][j] + "- ");
        }
        Console.WriteLine();
    }
    return arregloDeArreglos;
}

double[,] matriz = new double[,]
{ {1,2,3,4},
{5,6,7,8},
{9,10,11,12} };

GetArregloDeArreglo(matriz);
Console.ReadLine();