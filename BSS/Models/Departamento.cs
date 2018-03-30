using System.ComponentModel;

namespace BSS.Models
{
    public class Departamento
    {
        [DisplayName("Código del departamento")]
        public int dep_codigo { get; set; }

        [DisplayName("Ccompañía")]
        public int dep_co_compania { get; set; }

        [DisplayName("Sucursal")]
        public int dep_suc_codigo { get; set; }

        [DisplayName("Descripción del departamento")]
        public string dep_descripcion { get; set; }

        [DisplayName("Estado")]
        public string dep_estado { get; set; }
    }

}