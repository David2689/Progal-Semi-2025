using System.ComponentModel.DataAnnotations;
namespace webappcademica.Models
{
    public class Docente
    {
        [Key]
        public int idDocnete { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public byte[] foto { get; set; }
    }
}
