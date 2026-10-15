namespace ModelsStreaming;

public class Serie : Contenido
{
    public int NumeroTemporadas {get; set;}

    public Serie()
    {
        
    }

    public Serie(string _titulo, int _duracion, int _numeroTemporadas) : base(_titulo, _duracion)
    {
        this.NumeroTemporadas = _numeroTemporadas;
    }
    public override string ObtenerDescripcion()
    {
        return $"Título serie: {Titulo} - Duración: {Duracion} min/cap - Número de temporadas: {NumeroTemporadas}";
    }
}