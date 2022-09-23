/*
Utilizar la clase Queue<T> para implementar un programa que realice el cifrado
de un texto aplicando la técnica de clave repetitiva.
La técnica de clave repetitiva consiste en desplazar un carácter una cantidad
constante de acuerdo a la lista de valores que se encuentra en la clave. Por
ejemplo: para la siguiente tabla de caracteres:
A B C D E F G H I J K L M N Ñ O P Q R S T U V W X Y Z sp
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28
Si la clave es {5,3,9,7} y el mensaje a cifrar “HOLA MUNDO”
Se cifra de la siguiente manera:
H O L A sp M U N D O ← Mensaje original
8 16 12 1 28 13 22 14 4 16 ← Código sin cifrar
5 3 9 7 5 3 9 7 5 3 ← Clave repetida
13 19 21 8 5 16 3 21 9 19 ← Código cifrado
M R T H E O C T I R ← Mensaje cifrado
A cada carácter del mensaje original se le suma la cantidad indicada en la clave.
En el caso que la suma fuese mayor que 28 se debe volver a contar desde
el principio, Implementar una cola con los números de la clave encolados
y a medida que se desencolen para utilizarlos en el cifrado, se vuelvan
a encolar para su posterior utilización.
Programar un método para cifrar y otro para descifrar.
*/

Dictionary<string, int> letras = new Dictionary<string, int>(){

    {"a", 1}, {"b", 2}, {"c", 3}, {"d", 4}, {"e", 5}, {"f", 6},
    {"g", 7}, {"h", 8}, {"i", 9}, {"j", 10}, {"k", 11}, {"l", 12},
    {"m", 13}, {"n", 14},{"ñ", 15}, {"o", 16}, {"p", 17}, {"q", 18},
    {"r", 19}, {"s", 20}, {"t", 21}, {"u", 22}, {"v", 23}, {"w", 24},
    {"x", 25}, {"y", 26}, {"z", 27}, {" ", 28}
};

List<string> cifrar(char[] values, Queue<int> claveOriginal){
    Queue<int> clave = new Queue<int>(claveOriginal);
    List<string> codigoCifrado = new List<string>();
    for (int i = 0; i < values.Length; i++){
        int claveActual = clave.Dequeue();
        string letra = Char.ToString(values[i]).ToLower();
        int posicion = letras[letra];
        int nuevaPosicion = posicion + claveActual;
        if(nuevaPosicion > 27)
           nuevaPosicion -= 28;
        string nuevaLetra = letras.FirstOrDefault(l => l.Value == nuevaPosicion).Key;
        codigoCifrado.Add(nuevaLetra);
        clave.Enqueue(claveActual);
    }
    foreach (var letra in codigoCifrado){
        Console.Write(letra);
    }
    Console.WriteLine();
    return codigoCifrado;
}

List<string> descifrar(List<string> mensajeCifrado, Queue<int> claveOriginal){
    Queue<int> clave = new Queue<int>(claveOriginal);
    List<string> codigoDescifrado = new List<string>();
    foreach (var letra in mensajeCifrado){
        int posicionCifrada = letras.FirstOrDefault(l => l.Key == letra).Value;
        int claveActual = clave.Dequeue();
        int posicionReal = posicionCifrada - claveActual;
        string letraReal = letras.FirstOrDefault(l => l.Value == posicionReal).Key;
        Console.Write(letraReal);
        clave.Enqueue(claveActual);
    }
    return codigoDescifrado;
}

Queue<int> clave = new Queue<int>();
Console.Write("Ingrese una clave de cifrado numerica sin espacios: ");
string input = Console.ReadLine();
Char[] values =  input.ToCharArray();
foreach (var value in values){
    clave.Enqueue(int.Parse(value.ToString()));
}
Console.Write("Ingrese una frase a cifrar: ");
input = Console.ReadLine().ToUpper();
values =  input.ToCharArray();

List<string> mensajeCifrado = cifrar(values, clave);
descifrar(mensajeCifrado, clave);

Console.ReadLine();

