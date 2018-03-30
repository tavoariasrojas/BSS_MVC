using System;
using System.ComponentModel;

namespace BSS.Models
{
    public class Citas_clientes
    {
        [DisplayName("Númeto de cita")]
        public int cc_id { get; set; }

        [DisplayName("Título")]
        public string cc_titulo { get; set; }

        [DisplayName("Cliente")]
        public int cc_codigo_cliente { get; set; }

        [DisplayName("Fecha inicio")]
        public DateTime cc_fecha_inicio { get; set; }

        [DisplayName("Fecha final")]
        public DateTime cc_fecha_fin { get; set; }

        [DisplayName("Tipo de servicio")]
        public long cc_producto { get; set; }

        [DisplayName("Empleado asignado")]
        public int cc_empleado { get; set; }

        [DisplayName("Estado")]
        public string cc_estado { get; set; }
    }

}