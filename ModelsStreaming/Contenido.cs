namespace ModelsStreaming;

public abstract class Contenido
{
    public string Titulo {get; set;}
    public int Duracion {get; set;}

    public Contenido()
    {
        
    }

    public Contenido(string _titulo, int _duracion)
    {
        this.Titulo = _titulo;
        this.Duracion = _duracion;
    }

    public abstract string ObtenerDescripcion();
}