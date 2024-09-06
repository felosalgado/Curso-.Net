namespace ApiCitas.Models
{
    public class Cita
    {
        /// <example>1</example>
        public int CitaID { get; set; }

        /// <example>2</example>
        public int UsuarioID { get; set; }

        /// <example>2024-09-10T14:30:00</example>
        public DateTime FechaCita { get; set; }

        /// <example>Consulta médica general</example>
        public string Descripcion { get; set; }

        /// <example>Clínica San José</example>
        public string Lugar { get; set; }

        /// <example>Confirmada</example>
        public string Estado { get; set; }

        /// <example>2024-08-10T10:00:00</example>
        public DateTime FechaCreacion { get; set; }

        /// <example>2024-08-15T15:00:00</example>
        public DateTime? FechaModificacion { get; set; }
    }

}
