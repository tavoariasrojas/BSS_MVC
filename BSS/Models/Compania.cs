using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BSS.Models
{
    public class Compania
    {
        [Required(ErrorMessage = "Debe digitar un código")]
        [DisplayName("Código de la compañía")]
        public int co_compania { get; set; }

        [Required(ErrorMessage = "Debe digitar un nombre")]
        [DisplayName("Nombre de la compañía")]
        public string co_nombre { get; set; }

        [DisplayName("Descripción de la compañía")]
        public string co_descripcion { get; set; }

        [DisplayName("Cédula jurídica")]
        public string co_cedula_juridica { get; set; }

        [DisplayName("País")]
        public string co_pa_codigo { get; set; }

        [DisplayName("Moneda")]
        public string co_mon_codigo_defecto { get; set; }

        [DisplayName("Ubicación")]
        public string co_ubicacion { get; set; }
    }
}