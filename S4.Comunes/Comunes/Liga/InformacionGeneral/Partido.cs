namespace Comunes.Liga.InformacionGeneral;

public class Partido : ClaseExtension
{
    public int IdPartido { get; set; }
    public int IdTorneo { get; set; }
    public int IdPlantelLocal { get; set; }
    public int IdPlantelVisitante { get; set; }
    public int MarcadorLocal { get; set; }
    public int MarcadorVisitante { get; set; }
    public DateTime FechaPartido { get; set; }
}
