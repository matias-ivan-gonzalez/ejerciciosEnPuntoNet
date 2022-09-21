/*
Verificar con un par de ejemplos si la sección opcional [:formatString]
de formatos compuestos redondea o trunca cuando se formatean números reales
restringiendo la cantidad de decimales. Plantear los ejemplos con cadenas
de formato compuesto y con cadenas interpoladas.
*/

string Formatear(double num, string formato){
    Console.WriteLine(num.ToString(formato));
    return $"{num.ToString(formato)}";
}

double num1 = 12.5412;
double num2 = 10.3442;
double num3 = 123.9999;
double num4 = 0.01001;
double num5 = 0.98013;

Formatear(num3,"0");
Formatear(num1,"0.0");
Formatear(num4,"0.00");
Formatear(num2,"0.000");
Formatear(num5,"0.0000");

Console.ReadLine();
