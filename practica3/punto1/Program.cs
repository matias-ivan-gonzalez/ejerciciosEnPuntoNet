/*
Ejecutar y analizar cuidadosamente el siguiente programa:
*/

Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(false);
while (k.Key != ConsoleKey.End){
    Console.Clear();
    Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
    k = Console.ReadKey(false);
}