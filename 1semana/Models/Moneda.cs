using System.ComponentModel.DataAnnotations;

namespace _1semana.Models
{
    public class Moneda
    {
        public float Operador1 { get; set; }

        public string Operador2 { get; set; }

        public string Accion { get; set; }
        public string Accion2 { get; set; }

       /* public int dolar = 55; */

        [Display(Name = "La respuesta es : ")]
        
        public float Respuesta { get; set; }
       
        public string fake { get; set; }

    }
}
