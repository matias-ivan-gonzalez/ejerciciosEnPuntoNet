Console.Write("Ingrese una palabra: ");
String palabra1 = new String(Console.ReadLine().OrderBy(ch => ch).ToArray());
Console.Write("Ingrese otra palabra: ");
String palabra2 = new String(Console.ReadLine().OrderBy(ch => ch).ToArray());
Console.WriteLine(
    (palabra1==palabra2) ? "Simetrica" : "No simetrica"
);
Console.ReadLine();