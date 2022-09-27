/*
Codificar la clase Nodo de un árbol binario de búsqueda de valores enteros. 
Un árbol binario de búsqueda no tiene valores duplicados y el valor de un nodo
cualquiera es mayor a todos los valores de su subárbol izquierdo
y es menor a todos los valores de su subárbol derecho.
Desarrollar los métodos:
1. Insertar(valor): Inserta valor en el árbol descartándolo en caso que ya exista.
2. GetInorden(): devuelve un ArrayList con los valores ordenados en forma creciente.
3. GetAltura(): devuelve la altura del árbol.
4. GetCantNodos(): devuelve la cantidad de nodos que posee el árbol.
5. GetValorMáximo(): devuelve el valor máximo que contiene el árbol.
6. GetValorMínimo(): devuelve el valor mínimo que contiene el árbol.
A modo de ejemplo, el siguiente código debe arrojar por consola la salida
que se muestra.

Nodo n = new Nodo(7);
n.Insertar(8);
n.Insertar(10);
n.Insertar(3);
n.Insertar(1);
n.Insertar(5);
n.Insertar(14);
foreach (int i in n.GetInOrder())
{
Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine(n.GetAltura());
Console.WriteLine(n.GetCantNodos());
Console.WriteLine(n.GetValorMaximo());
Console.WriteLine(n.GetValorMinimo());
*/

Nodo n = new Nodo(7);
n.Insertar(8);
n.Insertar(10);
n.Insertar(3);
n.Insertar(1);
n.Insertar(5);
n.Insertar(14);
foreach (int i in n.GetInorden()){
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine(n.GetAltura());
Console.WriteLine(n.GetCantNodos());
Console.WriteLine(n.GetValorMaximo());
Console.WriteLine(n.GetValorMinimo());

Console.ReadLine();

public class Nodo{
    int? _valor = null;
    Nodo _subArbolIzquierdo = null;
    Nodo _subArbolDerecho = null;

    int cantNodos = 1;
    int valorMaximo = -1;
    int valorMinimo = 999999999;

    public Nodo(int valor){
        this._valor = valor;
    }

    private Nodo(){}

    private bool nodoNoEsNull(Nodo nodo){
        return nodo != null;
    }

    Nodo InicializarSiNoLoEsta(Nodo nodo){
        if (!nodoNoEsNull(nodo)){
            nodo = new Nodo();
            return nodo;
        }
        return nodo;
    }

    public bool Insertar(int valor){
        bool resultado;
        if (valor == _valor){
            return false;
        }
        if (_valor == null){
            this._valor = valor;
            return true;
        }
        if (valor < _valor){
            _subArbolIzquierdo = InicializarSiNoLoEsta(_subArbolIzquierdo);
            resultado = _subArbolIzquierdo.Insertar(valor);
        }
        else{
            _subArbolDerecho = InicializarSiNoLoEsta(_subArbolDerecho);
            resultado = _subArbolDerecho.Insertar(valor);
        }
        if (resultado){
            cantNodos++;
        }
        return resultado;
    }

    public List<int?> GetInorden(){
        List<int?> lista = new List<int?>();
        lista = this.Inorden(lista);
        valorMaximo = (int) lista.AsQueryable().Max();
        valorMinimo = (int) lista.AsQueryable().Min();
        return lista;
    }

    private List<int?> Inorden(List<int?> lista){
        if (nodoNoEsNull(_subArbolIzquierdo)){
            lista = _subArbolIzquierdo.Inorden(lista);
        }
        if (this._valor != null){
            lista.Add(_valor);
        }
        if (nodoNoEsNull(_subArbolDerecho)){
            lista = _subArbolDerecho.Inorden(lista);
        }
        return lista;
    }
 

    public int GetAltura(){
        return altura(this);
    }

    private int altura(Nodo ab) {
        if (ab == null) 
            return -1;
        else 
            return (1 + Math.Max(altura(ab._subArbolIzquierdo), altura(ab._subArbolDerecho)));
    }

    public int altura() {
        return altura(this);
    }

    public int GetCantNodos(){
        return cantNodos;
    }

    public int GetValorMaximo(){
        return valorMaximo;
    }

    public int GetValorMinimo(){
        return valorMinimo;
    }
}