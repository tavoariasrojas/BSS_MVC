using System.ComponentModel;

namespace BSS.Models
{
    public class Control_venta_credito
    {
        [DisplayName("Secuencia")]
        public long cvc_secuencia { get; set; }

        [DisplayName("N° de factura")]
        public long cvc_fma_sec_factura { get; set; }

        [DisplayName("Tipo")]
        public string cvc_tm_codigo { get; set; }

        [DisplayName("Moneda")]
        public string cvc_moneda { get; set; }

        [DisplayName("Monto")]
        public decimal cvc_monto { get; set; }

    }
}