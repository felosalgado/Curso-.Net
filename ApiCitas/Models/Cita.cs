namespace ApiCitas.Models;

public class Cita
{
    public int CitaId { get; set; }
    public int UsuarioId { get; set; }
    public DateTime FechaCita { get; set; }
    public string Descripcion { get; set; }
    public string Lugar { get; set; }
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
}
