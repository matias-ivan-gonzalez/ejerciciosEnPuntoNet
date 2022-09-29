/*
¿Cuál es el error en el siguiente programa?
Nota: Observar que utilizar la convención de prefijar a los campos privados
con guión bajo, hace más difícil cometer este tipo de errores
*/
Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);
Console.ReadLine();
class Auto {
    private string marca; //No respeta la convención de empezar la variable con _
    public string Marca{
        set{
            Marca = value; //StackOverflowException
            // Marca no es una variable de la clase Auto, ademas, deberia declararse con _
        }
        get{
            return marca;
        }
    }
}