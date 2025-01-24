namespace S4.Comunes.Liga.InformacionGeneral;

public class Torneo : ClaseExtension
{
    public int IdTorneo { get; set; }
    public string DescripcionTorneo { get; set; }
    public string Temporada { get; set; }
    public DateTime InicioTorneo { get; set; }
    public DateTime FinTorneo { get; set; }

}
