/*
Realizar un análisis sintáctico para determinar si los paréntesis en una expresión
aritmética están bien balanceados. Verificar que por cada paréntesis de apertura
exista uno de cierre en la cadena de entrada. Utilizar una pila para resolverlo.
Los paréntesis de apertura de la entrada se almacenan en una pila hasta encontrar
uno de cierre, realizándose entonces la extracción del último paréntesis de apertura
almacenado. Si durante el proceso se lee un paréntesis de cierre y la pila está vacía,
entonces la cadena es incorrecta. Al finalizar el análisis, la pila debe quedar
vacía para que la cadena leída sea aceptada, de lo contrario la misma no es válida.
*/

bool analizarParentesisDeString(List<char> caracteres){
    Stack<char> pila = new Stack<char>();
    for (int i = 0; i < caracteres.Count; i++){
        char caracter = caracteres[i];
        if (caracter.ToString() == ")" && pila.Count == 0){
            Console.WriteLine("No está balanceado");
            return false;
        }
        if (caracter.ToString() == "("){
            pila.Push(caracter);
        }
        else{
            if (caracter.ToString() == ")"){
                pila.Pop();
            }
        }
    }
    if (pila.Count == 0){
        Console.WriteLine("Está balanceado");
        return true;
    }
    Console.WriteLine("No está balanceado");
    return false;
}

List<char> caracteres = "(())".ToList();
analizarParentesisDeString(caracteres);
caracteres = "))((".ToList();
analizarParentesisDeString(caracteres);
caracteres = "(((".ToList();
analizarParentesisDeString(caracteres);
caracteres = "()()(".ToList();
analizarParentesisDeString(caracteres);
caracteres = "(()()(())((())))".ToList();
analizarParentesisDeString(caracteres);

Console.ReadLine();