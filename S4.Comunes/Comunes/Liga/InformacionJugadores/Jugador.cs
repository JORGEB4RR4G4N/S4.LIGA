namespace Comunes.Liga.InformacionJugadores;

public class Jugador : ClaseExtension
{
    public int IdJugador { get; set; }
    public string NombreJugador { get; set; }
    public string PrimerApellido { get; set; }
    public double? Estatura { get; set; }
    public int? Peso { get; set; }
    public int? IdOrigen { get; set; }
    public int? IdPosicion { get; set; }
    public int? Numero { get; set; }
    public DateTime? FechaNacimiento { get; set; }
}
