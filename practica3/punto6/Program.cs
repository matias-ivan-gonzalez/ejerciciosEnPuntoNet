/*
Implementar los siguientes métodos que devuelvan la suma, resta y 
multiplicación de matrices pasadas como parámetros.
Para el caso de la suma y la resta, las matrices deben ser del mismo
tamaño, en caso de no serlo devolver null. Para el caso de la
multiplicación la cantidad de columnas de A debe ser igual a la cantidad
de filas de B, en caso contrario generar una excepción ArgumentException.
double[,]? Suma(double[,] A, double[,] B)
double[,]? Resta(double[,] A, double[,] B)
double[,] Multiplicacion(double[,] A, double[,] B)
*/


double[,]? Suma(double[,] A, double[,] B){
    int Arows = A.GetLength(0);
    int Acolumns = A.GetLength(1);
    int Brows = B.GetLength(0);
    int Bcolumns = B.GetLength(1);

    if(!((Arows * Acolumns) == (Brows * Bcolumns))){
        return null;
    }
    double[,] resultado = new double[Arows,Acolumns];

    for (int i = 0; i < Arows; i++){
        for (int j = 0; j < Acolumns; j++){
            resultado[i,j] = A[i,j] + B[i,j];
            Console.Write(resultado[i,j] + " | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return resultado;
}

double[,]? Resta(double[,] A, double[,] B){
    int Arows = A.GetLength(0);
    int Acolumns = A.GetLength(1);
    int Brows = B.GetLength(0);
    int Bcolumns = B.GetLength(1);

    if(!((Arows * Acolumns) == (Brows * Bcolumns))){
        return null;
    }
    double[,] resultado = new double[Arows,Acolumns];

    for (int i = 0; i < Arows; i++){
        for (int j = 0; j < Acolumns; j++){
            resultado[i,j] = A[i,j] - B[i,j];
            Console.Write(resultado[i,j] + " | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return resultado;
}

double[,] Multiplicacion(double[,] A, double[,] B){
    int Arows = A.GetLength(0);
    int Acolumns = A.GetLength(1);
    int Brows = B.GetLength(0);
    int Bcolumns = B.GetLength(1);
    double[,] resultado = new double[Arows,Acolumns];
    try{
        if(!((Arows * Acolumns) == (Brows * Bcolumns))){
            throw new ArgumentException("No son del mismo tamaño");
        }

        for (int i = 0; i < Arows; i++){
            for (int j = 0; j < Acolumns; j++){
                resultado[i,j] = A[i,j] * B[i,j];
                Console.Write(resultado[i,j] + " | ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    catch (ArgumentException e){
        Console.WriteLine(e.Message);
    }
    return resultado;
}

double[,] a = new double[,]
{ {1,2,3,4},
{5,6,7,8},
{9,10,11,12} };

double[,] b = new double[,]{
   {2, 1, 0, 3} ,
   {7, 5, 6, 4} ,
   {10, 9, 8, 11} 
};

double[,] c = new double[,]{
   {2, 1, 0, 3} ,
   {7, 5, 6, 4} ,
   {10, 9, 8, 11} ,
   {16, 15, 14, 17}
};

Suma(a,b);
Resta(a,b);
Multiplicacion(a,b);


Suma(a,c);
Resta(a,c);
Multiplicacion(a,c);

Console.ReadLine();