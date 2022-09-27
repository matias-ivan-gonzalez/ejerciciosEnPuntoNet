/*
¿Qué se puede decir en relación a la sobrecarga de métodos en este ejemplo?

class A{
    En este caso, tenemos el metodo que recibe un short
    public void Metodo(short n){
        Console.Write("short {0} - ", n);
    }
    En este caso, tenemos el metodo que recibe un int, diferenciandose del tipo
    de parámetro del método de arriba, por lo que es correcto
    public void Metodo(int n){
        Console.Write("int {0} - ", n);
    }
    En este caso, tenemos una sobrecarga de métodos incorrecta, ya que tiene el mismo
    tipo y orden de parámetros, difiriendo solamente en su tipo de retorno, lo
    cual no es tomado en cuenta a la hora de sobrecargar un método, razón por la
    cual, esto no funciona
    public int Metodo(int n){
        return n + 10;
    }
}
*/