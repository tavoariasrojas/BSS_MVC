using System.ComponentModel;

namespace BSS.Models
{
    public class Cuenta_banco_proveedor
    {
        [DisplayName("Código")]
        public int cbp_codigo { get; set; }

        [DisplayName("Nombre banco")]
        public int cbp_banco { get; set; }

        [DisplayName("Moneda")]
        public string cbp_moneda { get; set; }

        [DisplayName("Cuenta bancaria")]
        public string cbp_num_cuenta { get; set; }

        [DisplayName("Estado")]
        public string cbp_estado { get; set; }
    }
}