namespace ApiCitas.Models
{    
    /// <summary>
    /// Esta clase representa el modelo Usuario.
    /// </summary>
    public class User
    {
        /// <example>1</example>
        public int IdUser { get; set; }
        /// <example>Manuel</example>
        public required string UserName { get; set; }
        /// <example>Rojas</example>
        public required string UserLastName { get; set; }
        /// <example>3156066418</example>
        public required string UserPhone { get; set; }
        /// <example>manuelrojasm13@gmail.com</example>
        public required string UserEmail { get; set; }
        /// <example></example>
        public required string UserDateBirth { get; set; }
    }
}