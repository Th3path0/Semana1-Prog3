using System.ComponentModel.DataAnnotations;

namespace _1semana.Models
{
    public class Zodiaco
    {
        public int Operador1 { get; set; }

        public string Operador2 { get; set; }

        public int Accion { get; set; }

        [Display(Name = "La respuesta es : ")]
        public string Respuesta { get; set; }

    }
}
