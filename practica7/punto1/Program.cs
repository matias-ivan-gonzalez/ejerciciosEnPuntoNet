/*
Codificar las clases e interfaces necesarias para modelar un sistema
que trabaja con las siguientes entidades: Autos, Libros, Películas, 
Personas y Perros. Algunas de estas entidades pueden ser:
alquilables (se pueden alquilar a una persona y ser devueltas por una
persona), vendibles (se pueden vender a una persona), lavables 
(se pueden lavar y secar) reciclables (se pueden reciclar) y atendibles
(se pueden atender). A continuación se describen estas relaciones:
● Son Alquilables: Libros y Películas
● Son Vendibles: Autos y Perros
● Son Lavables: Autos
● Son Reciclables: Libros y Autos
● Son Atendibles: Personas y Perros
Completar el código de la clase estática Procesador:

La ejecución del siguiente código debe mostrar en la consola 
la salida indicada:

Alquilando película a persona
Alquilando libro a persona
Atendiendo persona
Atendiendo perro
Película devuelta por persona
Libro devuelto por persona
Lavando auto
Reciclando libro
Reciclando auto
Secando auto
Vendiendo auto a persona
Vendiendo perro a persona
*/

Auto auto = new Auto();
Libro libro = new Libro();
Persona persona = new Persona();
Perro perro = new Perro();
Pelicula pelicula = new Pelicula();
Procesador.Alquilar(pelicula, persona);
Procesador.Alquilar(libro, persona);
Procesador.Atender(persona);
Procesador.Atender(perro);
Procesador.Devolever(pelicula, persona);
Procesador.Devolever(libro, persona);
Procesador.Lavar(auto);
Procesador.Reciclar(libro);
Procesador.Reciclar(auto);
Procesador.Secar(auto);
Procesador.Vender(auto, persona);
Procesador.Vender(perro, persona);