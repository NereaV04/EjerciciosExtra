namespace ModelsStreaming;

public class Documental : Contenido
{
    public string Tematica {get; set;}

    public Documental()
    {
        
    }

    public Documental(string _titulo, int _duracion, string _tematica) : base(_titulo, _duracion)
    {
        this.Tematica = _tematica;
    }

    public override string ObtenerDescripcion()
    {
        return $"Título documental: {Titulo} - Duración: {Duracion} min/ep - Temática: {Tematica}";
    }
}
