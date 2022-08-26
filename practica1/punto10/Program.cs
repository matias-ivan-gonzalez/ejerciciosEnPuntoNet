for (int i = 1 ; i <= 1000 ; i++) {
    bool resultado = (i % 17 == 0 || i % 29 == 0) ? true : false;
    Console.Write(resultado==true ? i + "\n" : null);
}
Console.ReadLine();
