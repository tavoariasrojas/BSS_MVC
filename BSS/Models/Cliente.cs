using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BSS.Models
{
    public class Cliente
    {
        [DisplayName("Código de cliente")]
        public int cli_codigo { get; set; }

        [DisplayName("Tipo de identificación")]
        public string cli_ti_codigo { get; set; }

        [DisplayName("Género")]
        public string cli_genero { get; set; }

        [DisplayName("N° de identificación")]
        public string cli_identificacion { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "Debe digitar un nombre")]
        public string cli_nombre { get; set; }

        [Required(ErrorMessage = "Debe digitar el primer apellido")]
        [DisplayName("Primer apellido")]
        public string cli_pri_apellido { get; set; }

        [DisplayName("Segundo apellido")]
        public string cli_seg_apellido { get; set; }

        [DisplayName("Fecha de nacimiento")]
        public DateTime cli_fec_nacimiento { get; set; }

        [DisplayName("País")]
        public string cli_pa_codigo { get; set; }

        [DisplayName("Correo electrónico")]
        [EmailAddress(ErrorMessage = "Verifique el correo electrónico")]
        public string cli_email { get; set; }
    }
}