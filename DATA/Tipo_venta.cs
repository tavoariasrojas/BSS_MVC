﻿using ServiceStack.DataAnnotations;

namespace BSS.DATA
{
    public class Tipo_venta
    {
        [AutoIncrement]
        public int tv_codigo { get; set; }

        public string tv_descripcion { get; set; }

    }
}