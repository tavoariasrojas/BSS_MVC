using ServiceStack.DataAnnotations;

namespace BSS.DATA
{
    public class Tipo_prod_serv
    {
        [AutoIncrement]
        public int tps_codigo { get; set; }

        public string tps_des_tipo { get; set; }
    }

}