using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BSS.Models
{
    public class Categoria
    {
        [DisplayName("Código categoría")]
        public int cat_codigo { get; set; }

        [DisplayName("Producto o servicio")]
        [Required(ErrorMessage = "Debe seleccionar un producto o servicio")]
        public int cat_tps_codigo { get; set; }

        [DisplayName("Categoría")]
        [Required(ErrorMessage = "Debe digitar un nombre")]
        public string cat_nombre { get; set; }
    }
}