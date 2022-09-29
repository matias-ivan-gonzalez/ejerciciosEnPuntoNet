/*
Modificar la definición de la clase Matriz realizada en la práctica 4.
Eliminar los métodos SetElemento(...) y GetElemento(...).
Definir un indizador adecuado para leer y escribir elementos de la matriz. 
Eliminar los métodos GetDiagonalPrincipal() y
GetDiagonalSecundaria() reemplazándolos 
*/

double[,] m = new double[,]
{ {1,2,3,4},
{5,6,7,8},
{9,10,11,12},
{13,14,15,16} };

Matriz m1 = new Matriz(m);

Console.WriteLine(m1[0,1]);
m1[0,1] = 99;
Console.WriteLine(m1[0,1]);
foreach (var valor in m1.diagonalPrincipal){
    Console.Write($"{valor} ");
}
Console.WriteLine();
foreach (var valor in m1.diagonalSecundaria){
    Console.Write($"{valor} ");
}
Console.WriteLine();


Console.ReadLine();

public class Matriz{
    
    double[,] _matriz;
    public double this[int i,int j]{
        get{
            return _matriz[i,j];
        }
        set{
            _matriz[i,j] = value;
        }
    }

    public double[] diagonalPrincipal{
        get{
            int filas = _matriz.GetLength(0);
            int columnas = _matriz.GetLength(1);
            if (filas != columnas){
                throw new ArgumentException("La matriz no es cuadrada");
            }
            double[] diagonalPrincipal = new double[filas];
            for (int i = 0; i < filas; i++){
                diagonalPrincipal[i] = _matriz[i,i];
            }
            return diagonalPrincipal;
        }
    }

    

    public double[] diagonalSecundaria{
        get{
            double[] diagonal = new double[_matriz.GetLength(0)];
            int k = _matriz.GetLength(0) - 1;
            for (int i = 0; i < _matriz.GetLength(0); i++){
                diagonal[i] = _matriz[i,k];
                k--;
            }
            return diagonal;
        }
    }

    public Matriz(int filas, int columnas){
        this._matriz = new double[filas,columnas];
    }

    public Matriz(double[,] matriz){
        this._matriz = matriz;
    }

    public void imprimir(){
        for (int i = 0; i < _matriz.GetLength(0); i++){
            for (int j = 0; j < _matriz.GetLength(1); j++){
                Console.Write($"{_matriz[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void imprimir(string formatString){
        for (int i = 0; i < _matriz.GetLength(0); i++){
            for (int j = 0; j < _matriz.GetLength(1); j++){
                Console.Write($"{_matriz[i,j].ToString(formatString)} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public double[] GetFila(int fila){
        int columnas = _matriz.GetLength(1);
        double[] filaBuscada = new double[columnas];
        for (int i = 0; i < columnas; i++){
            filaBuscada[i] = _matriz[fila,i];
        }
        return filaBuscada;
    }

    public double[] GetColumna(int columna){
        int filas = _matriz.GetLength(0);
        double[] columnaBuscada = new double[filas];
        for (int i = 0; i < filas; i++){
            columnaBuscada[i] = _matriz[i,columna];
        }
        return columnaBuscada;
    }

    public double[][] GetArregloDeArreglo(){
        int rows = _matriz.GetLength(0);
        int columns = _matriz.GetLength(1);
        double[][] arregloDeArreglos = new double[rows][];
        for (int i = 0; i < rows ; i++){
            arregloDeArreglos[i] = new double[columns];
            for (int j = 0; j < columns; j++){
                arregloDeArreglos[i][j] = _matriz[i,j];
            }
        }
        return arregloDeArreglos;
    }

    public void sumarle(Matriz m){
        for (int i = 0; i < _matriz.GetLength(0); i++){
            for (int j = 0; j < _matriz.GetLength(1); j++){
                this._matriz[i,j] += m._matriz[i,j];
                Console.Write($"{_matriz[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void restarle(Matriz m){
        for (int i = 0; i < _matriz.GetLength(0); i++){
            for (int j = 0; j < _matriz.GetLength(1); j++){
                this._matriz[i,j] -= m._matriz[i,j];
                Console.Write($"{_matriz[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void multiplicarPor(Matriz m){
        for (int i = 0; i < _matriz.GetLength(0); i++){
            for (int j = 0; j < _matriz.GetLength(1); j++){
                this._matriz[i,j] *= m._matriz[i,j];
                Console.Write($"{_matriz[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}