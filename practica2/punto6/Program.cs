/*
Determinar qué hace el siguiente programa y explicar
qué sucede si no se pasan parámetros
cuando se invoca desde la línea de comandos.
*/

Console.WriteLine("¡Hola {0}!", args[0]);

/*
    Respuesta:
    El programa imprime ¡Hola argumento0!, al no pasarle un argumento
    se genera una exception al intentar acceder una posicion inexistente
    del array args "IndexOutOfRangeException"
*/