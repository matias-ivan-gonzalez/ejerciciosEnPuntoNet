/*
Implementar la clase Matriz que se utilizará para trabajar con matrices matemáticas.
Implementar los dos constructores y todos los métodos que se detallan a continuación:
public Matriz(int filas, int columnas)
public Matriz(double[,] matriz)
public void SetElemento(int fila, int columna, double elemento)
public double GetElemento(int fila, int columna)
public void imprimir()
public void imprimir(string formatString)
public double[] GetFila(int fila)
public double[] GetColumna(int columna)
public double[] GetDiagonalPrincipal()
public double[] GetDiagonalSecundaria()
public double[][] getArregloDeArreglo()
public void sumarle(Matriz m)
public void restarle(Matriz m)
public void multiplicarPor(Matriz m)
*/

void imprimirInfo(double[] info){
    Console.WriteLine();
    foreach (var value in info){
        Console.Write($"{value} ");
    }
    Console.WriteLine();
}

void imprimirInfoDeArreglo(double[][] arregloDeArreglos){
    Console.WriteLine();
    for (int i = 0; i < arregloDeArreglos[0].Length; i++){
        for (int j = 0; j < arregloDeArreglos[i].Length; j++){
            Console.Write($"{arregloDeArreglos[i][j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[,] matriz = new double[,]
{ {3,4,5,6},
{7,8,9,10},
{11,12,13,14},
{15,16,17,18}};

Matriz m = new Matriz(matriz);
m.imprimir();
m.imprimir("0.0");
m.SetElemento(1,3,100);

imprimirInfo(m.GetFila(0));

imprimirInfo(m.GetColumna(3));

imprimirInfo(m.GetDiagonalPrincipal());

imprimirInfo(m.GetDiagonalSecundaria());

imprimirInfoDeArreglo(m.GetArregloDeArreglo());

double[,] matriz2 = new double[,]
{ {1,2,3,4},
{5,6,7,8},
{9,10,11,12},
{13,14,15,16}};

Console.WriteLine("----------");

Matriz m2 = new Matriz(matriz2);
m.sumarle(m2);
m.restarle(m2);
m.multiplicarPor(m2);

Console.ReadLine();

public class Matriz{
    
    double[,] _matriz;

    public Matriz(int filas, int columnas){
        this._matriz = new double[filas,columnas];
    }

    public Matriz(double[,] matriz){
        this._matriz = matriz;
    }

    public void SetElemento(int fila, int columna, double elemento){
        _matriz[fila,columna] = elemento;
    }

    public double GetElemento(int fila, int columna){
        return _matriz[fila,columna];
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

    public double[] GetDiagonalPrincipal(){
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

    public double[] GetDiagonalSecundaria(){
        double[] diagonal = new double[_matriz.GetLength(0)];
        int k = _matriz.GetLength(0) - 1;
        for (int i = 0; i < _matriz.GetLength(0); i++){
            diagonal[i] = _matriz[i,k];
            k--;
        }
        return diagonal;
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