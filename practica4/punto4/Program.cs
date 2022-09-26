/*
Codificar la clase Hora de tal forma que el siguiente código produzca la salida
por consola que se observa.

Hora h = new Hora(23,30,15);
h.Imprimir();
Salida: 23 horas, 30 minutos y 15 segundos
*/

Hora h = new Hora(23,30,15);
h.Imprimir();
Console.ReadLine();
public class Hora{
    int horas;
    int minutos;
    int segundos;

    public Hora(int horas, int minutos, int segundos){
        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos;
    }

    public void Imprimir(){
        Console.WriteLine($"{horas} horas, {minutos} minutos y {segundos} segundos");
    }
}