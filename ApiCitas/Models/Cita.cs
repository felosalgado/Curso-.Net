namespace ApiCitas.Models
{
    /// <summary>
    /// Esta clase representa el modelo Cita.
    /// </summary>
    public class Cita
    {
        /// <example>1</example>
        public required int CitaID { get; set; }

        /// <example>1</example>
        public required int UsuarioID { get; set; }

        /// <example>2024-09-10T14:30:00</example>
        public required DateTime CitaFecha { get; set; }

        /// <example>Consulta médica general</example>
        public required string CitaDescripcion { get; set; }

        /// <example>Clínica San José</example>
        public required string CitaLugar { get; set; }

        /// <example>Confirmada</example>
        public string CitaEstado { get; set; }

        /// <example>2024-08-10T10:00:00</example>
        public DateTime CitaFechaCreacion { get; set; }

        /// <example>2024-08-15T15:00:00</example>
        public DateTime? CitaFechaModificacion { get; set; }
    }

}