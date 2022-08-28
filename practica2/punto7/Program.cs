/*
Analizar el siguiente código. 
¿Qué líneas producen error de compilación y por qué?
*/

char c;
char? c2;
string? st;
// c = ""; No se puede convertir implicitamente el tipo string a char
// c = ''; literal de caracter vacio, no compila
// c = null; "c" no acepta valores nulos
c2 = null;
c2 = (65 as char?);
st = "";
// st = ''; literal de caracter vacio, no compila
st = null;
// st = (char)65;No se puede convertir implicitamente el tipo char a string
//st = (string)65;No se puede convertir el tipo int a string
st = 47.89.ToString();