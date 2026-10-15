namespace ModelsVideojuego;

public class Arquero : Personaje
{
    public int NumeroFlechas {get; set;}

    public Arquero()
    {
        
    }

    public Arquero(string _nombre, int _vida, int _numeroFlechas) : base(_nombre, _vida)
    {
        this.NumeroFlechas = _numeroFlechas;
    }
    public override string ObtenerDescripcion()
    {
        return $"Mago {Nombre} - Vida: {Vida} - Nº Flechas: {NumeroFlechas}";
    }
}