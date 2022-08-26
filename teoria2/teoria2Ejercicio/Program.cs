object obj = 7.3; // obj apunta a un valor de tipo double
Console.WriteLine(obj.GetType());
obj = "Casa"; // ahora de tipo string
Console.WriteLine(obj.GetType());
obj = 4; // ahora de tipo int
Console.WriteLine(obj.GetType());

obj = 7.3; // obj apunta a un valor de tipo double
Console.WriteLine(obj);
obj = "Casa"; // ahora de tipo string
Console.WriteLine(obj);
obj = 4; // ahora de tipo int
Console.WriteLine(obj);

Console.WriteLine((int)obj + 1);

obj = 1 + 2.3;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = 1 + 'A';
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = "CAS" + 'A';
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

obj = "Área" + 51;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);

Console.WriteLine("Área" + 5 + 1); // Área51
Console.WriteLine(5 + 1 + "Área"); // 6Área

Console.ReadLine();