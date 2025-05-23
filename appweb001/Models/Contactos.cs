using System.ComponentModel.DataAnnotations;

namespace appweb001.Models
{
    public class Contactos
    {
        [Key] 
        public int Id { get;set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string CorreoE { get; set; }
        public  DateTime FechaNacimiento { get; set; }

    }
}
