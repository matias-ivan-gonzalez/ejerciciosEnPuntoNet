/*
Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora
con un parámetro más que representa la plantilla de formato que debe aplicarse
a los números al imprimirse. La plantilla de formato es un string de acuerdo
a las convenciones de formato compuesto, por ejemplo “0.0” implica escribir
los valores reales con un dígito para la parte decimal.
void ImprimirMatrizConFormato(double[,] matriz, string formatString)
*/

void ImprimirMatrizConFormato(double[,] matriz, string formatString){
    for (int i = 0; i < matriz.GetLength(0); i++){
        for (int j = 0; j < matriz.GetLength(1); j++){
            Console.Write($"{matriz[i,j].ToString(formatString)} | ");
            //!TODO: REVISAR
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
}
double[,] matriz = new double[,]
{ {1.23,2.1,3.1231,4.1},
  {5,6,7,8},
  {9,10,11,12}
};
ImprimirMatrizConFormato(matriz,"0.0");
ImprimirMatrizConFormato(matriz,"0.00");
ImprimirMatrizConFormato(matriz,"0.000");
ImprimirMatrizConFormato(matriz,"0.0000");


Console.ReadLine();