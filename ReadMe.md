# 1. Videojuego.
- ¿Por qué Personaje puede ser una clase abstracta?
    Porque no hay ninguna instancia de esa clase. Y en este ejercicio, al tener herencia no tendría sentido crear un objeto que sea solo Personaje sin que sea de ningún tipo.

- ¿Por qué un Mago puede almacenarse en una variable de tipo Personaje?
    Porque la clase Mago hereda de la clase Personaje, entonces en un List<Personaje> se puede almacenar objetos de cualquier clase que herede de Peronaje.

- ¿Qué método ObtenerDescripcion() se ejecutará para cada objeto?
    Se ejecutará el método que se haya desarrollado en cada clase  con la cabecera override en el mismo.