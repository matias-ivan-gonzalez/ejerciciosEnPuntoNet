/*
Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso
(diciembre, noviembre, octubre ..., enero)
c) Solicitar al usuario que ingrese un texto y responder 
si el texto tipeado corresponde al nombre de un mes
Nota: en todos los casos utilizar un for iterando sobre 
una variable de tipo Meses
*/

// Punto A
for (Meses m = Meses.diciembre; m >= Meses.enero; m--){
    Console.WriteLine(m);
}
Console.Write("Ingrese un mes: ");
string ingreso = Console.ReadLine();
/*
Console.WriteLine(
    Enum.IsDefined(typeof(Meses),ingreso)
    ? "Corresponde a un mes" : "No corresponde a un mes"
);
*/
//Arriba se soluciona de otra manera, pero el ejercicio pide usar for
bool corresponde = false;
for (Meses m = Meses.diciembre; m >= Meses.enero; m--){
    corresponde = (m.ToString() == ingreso);
}
Console.WriteLine(
    (corresponde)
    ? "Corresponde a un mes" : "No corresponde a un mes"
);
Console.ReadLine();
enum Meses {
    enero,febrero,marzo,abril,mayo,junio,
    julio,agosto,septiembre,octubre,noviembre,diciembre
}