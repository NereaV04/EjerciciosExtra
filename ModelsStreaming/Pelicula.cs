namespace ModelsStreaming;

public class Pelicula : Contenido
{
    public string Director {get; set;}

    public Pelicula()
    {
        
    }

    public Pelicula(string _titulo, int _duracion, string _director) : base(_titulo, _duracion)
    {
        this.Director = _director;
    }
    public override string ObtenerDescripcion()
    {
        return $"Título película: {Titulo} - Duración: {Duracion} min. - Director: {Director}";
    }
}