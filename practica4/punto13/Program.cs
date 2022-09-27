/*
Reemplazar estas líneas de código por otras equivalentes que utilicen el 
operador null-coalescing (?? ) y/o la asignación null-coalescing (??=)

if (st1 == null){
    if (st2 == null){
        st = st3;
    }
    else{
        st = st2;
    }
}
else{
    st = st1;
}
if (st4 == null){
    st4 = "valor por defecto";
}

Resolución y prueba:
*/
string? st,
st1 = null,
st2 = null,
st3 = "Prueba de asignacion a st",
st4 = null;

st = st1 ?? st2 ?? st3;
Console.WriteLine(st);

st4 ??= "Valor por defecto";
Console.WriteLine(st4);

st4 = "Prueba";
st4 ??= "Valor por defecto";

Console.WriteLine(st4);

Console.ReadLine();