﻿using ServiceStack.DataAnnotations;

namespace BSS.DATA
{
    public class Tipo_telefono
    {
        [AutoIncrement]
        public int tt_codigo { get; set; }

        public string tt_descripcion { get; set; }
    }
}