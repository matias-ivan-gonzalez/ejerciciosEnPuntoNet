/*
Agregar un segundo constructor a la clase Hora para que pueda especificarse la hora
por medio de un único valor que admita decimales. Por ejemplo 3,5 indica la hora
3 y 30 minutos. Si se utiliza este segundo constructor, el método imprimir debe
mostrar los segundos con tres dígitos decimales. Así el siguiente código
debe producir la salida por consola que se observa.

new Hora(23, 30, 15).Imprimir();
new Hora(14.43).Imprimir();
new Hora(14.45).Imprimir();
new Hora(14.45114).Imprimir();

Salidas en orden:
23 horas, 30 minutos y 15 segundos
14 horas, 25 minutos y 48,000 segundos
14 horas, 27 minutos y 0,000 segundos
14 horas, 27 minutos y 4,104 segundos
*/

new Hora(23, 30, 15).Imprimir();
new Hora(14.43).Imprimir();
new Hora(14.45).Imprimir();
new Hora(14.45114).Imprimir();
Console.ReadLine();

public class Hora{
    int horas;
    int minutos;
    double segundos;

    public Hora(int horas, int minutos, int segundos){
        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos;
    }

    public Hora(double valor){
        TimeSpan t = TimeSpan.FromHours(valor);
        int horas = t.Hours;
        int minutos = t.Minutes;
        int segundos = t.Seconds;
        int milisegundos = t.Milliseconds;

        this.horas = horas;
        this.minutos = minutos;
        this.segundos = segundos + milisegundos / 1000.0;
    }

    public void Imprimir(){
        Console.WriteLine($"{horas} horas, {minutos} minutos y {segundos:0.000} segundos");
    }
}