﻿using System.Collections.Generic;
using BSS.DATA;

namespace DAL.Interfaces
{
    public interface IProducto
    {
        List<Producto> ListarProductos();
        Producto BuscarMoneda(long prod_codigo);
        void InsertarProducto(Producto producto);
        void ActualizarProducto(Producto producto);
        void EliminarProducto(long prod_codigo);
    }
}
