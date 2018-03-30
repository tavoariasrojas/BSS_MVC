using ServiceStack.DataAnnotations;

namespace BSS.DATA
{
    public class Tipo_pago
    {
        [AutoIncrement]
        public int tpa_codigo { get; set; }

        public string tpa_descripcion { get; set; }

    }
}