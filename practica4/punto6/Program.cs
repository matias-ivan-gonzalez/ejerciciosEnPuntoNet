﻿/*
Codificar una clase llamada Ecuacion2 para representar una ecuación de 2o grado.
Esta clase debe tener 3 campos privados, los coeficientes a, b y c de tipo double.
La única forma de establecer los valores de estos
campos será en el momento de la instanciación de un objeto Ecuacion2.

Codificar los siguientes métodos:
● GetDiscriminante(): devuelve el valor del discriminante (double), el discriminante
tiene la siguiente formula, (b^2)-4*a*c.
● GetCantidadDeRaices(): devuelve 0, 1 ó 2 dependiendo de la cantidad de raíces
reales que posee la ecuación. Si el discriminante es negativo no tiene raíces reales,
si el discriminante es cero tiene una única raíz, si el discriminante es mayor
que cero posee 2 raíces reales.
● ImprimirRaices(): imprime la única o las 2 posibles raíces reales de la ecuación.
En caso de no poseer soluciones reales debe imprimir una leyenda que
así lo especifique.
*/

public class Ecuacion2{
    double _a;
    double _b;
    double _c;

    public Ecuacion2(double a, double b, double c){
        this._a = a;
        this._b = b;
        this._c = c;
    }

    public double GetDiscriminante(){
        return (Math.Pow(_b,2)) - 4 * _a * _c;
    }

    public int GetCantidadDeRaices(){
        switch (this.GetDiscriminante()){
            case <0:
                return 0;
            case 0:
                return 1;
            default:
                return 2;
        }
    }

    public void ImprimirRaices(){
        int raices = this.GetCantidadDeRaices();
        Console.WriteLine(
           this.GetCantidadDeRaices() == 0 
           ? "No posee soluciones reales" : raices
        );
    }
}