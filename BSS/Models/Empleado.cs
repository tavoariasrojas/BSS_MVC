using System;
using System.ComponentModel;

namespace BSS.Models
{
    public class Empleado
    {
        [DisplayName("Código del empleado")]
        public int emp_codigo { get; set; }

        [DisplayName("Tipo de identificación")]
        public string emp_ti_codigo { get; set; }

        [DisplayName("Número de identificación")]
        public string emp_identificacion { get; set; }

        [DisplayName("Nombre de empleado")]
        public string emp_nombre { get; set; }

        [DisplayName("Primer apellido")]
        public string emp_pri_apellido { get; set; }

        [DisplayName("Segundo apellido")]
        public string emp_seg_apellido { get; set; }

        [DisplayName("Fecha de nacimiento")]
        public DateTime emp_fec_nacimiento { get; set; }

        [DisplayName("Forma de pago")]
        public int emp_fps_salario { get; set; }

        [DisplayName("Monto del salario")]
        public decimal emp_salario_monto { get; set; }

        [DisplayName("Moneda")]
        public string emp_mon_codigo { get; set; }

        [DisplayName("Estado del empleado")]
        public string emp_estado { get; set; }

        [DisplayName("Usuario que ingreso")]
        public string emp_usu_insercion { get; set; }

        [DisplayName("Fecha de ingreso")]
        public DateTime emp_fec_insercion { get; set; }

        [DisplayName("Usuario que modifica")]
        public string emp_usu_modificacion { get; set; }

        [DisplayName("Fecha de modificación")]
        public DateTime emp_fec_modificacion { get; set; }
    }

}