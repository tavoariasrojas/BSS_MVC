using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace BSS
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                //Categoria
                cfg.CreateMap<Models.Categoria, DATA.Categoria>();
                cfg.CreateMap<DATA.Categoria, Models.Categoria>();

                //Citas_clientes
                cfg.CreateMap<Models.Citas_clientes, DATA.Citas_clientes>();
                cfg.CreateMap<DATA.Citas_clientes, Models.Citas_clientes>();

                //Cliente
                cfg.CreateMap<Models.Cliente, DATA.Cliente>();
                cfg.CreateMap<DATA.Cliente, Models.Cliente>();

                //Comapnia
                cfg.CreateMap<Models.Compania, DATA.Compania>();
                cfg.CreateMap<DATA.Compania, Models.Compania>();

                //Control_venta_credito
                cfg.CreateMap<Models.Control_venta_credito, DATA.Control_venta_credito>();
                cfg.CreateMap<DATA.Control_venta_credito, Models.Control_venta_credito>();

                //Cuenta_banco_proveedor
                cfg.CreateMap<Models.Cuenta_banco_proveedor, DATA.Cuenta_banco_proveedor>();
                cfg.CreateMap<DATA.Cuenta_banco_proveedor, Models.Cuenta_banco_proveedor>();

                //Departamento
                cfg.CreateMap<Models.Departamento, DATA.Departamento>();
                cfg.CreateMap<DATA.Departamento, Models.Departamento>();

                //Empleado
                cfg.CreateMap<Models.Empleado, DATA.Empleado>();
                cfg.CreateMap<DATA.Empleado, Models.Empleado>();

                //Estado
                cfg.CreateMap<Models.Estado, DATA.Estado>();
                cfg.CreateMap<DATA.Estado, Models.Estado>();

                //Estado_cita
                cfg.CreateMap<Models.Estado_cita, DATA.Estado_cita>();
                cfg.CreateMap<DATA.Estado_cita, Models.Estado_cita>();

                //Fac_detalle
                cfg.CreateMap<Models.Fac_detalle, DATA.Fac_detalle>();
                cfg.CreateMap<DATA.Fac_detalle, Models.Fac_detalle>();

                //Fac_maestro
                cfg.CreateMap<Models.Fac_maestro, DATA.Fac_maestro>();
                cfg.CreateMap<DATA.Fac_maestro, Models.Fac_maestro>();

                //Forma_pago_salario
                cfg.CreateMap<Models.Forma_pago_salario, DATA.Forma_pago_salario>();
                cfg.CreateMap<DATA.Forma_pago_salario, Models.Forma_pago_salario>();

                //Marca
                cfg.CreateMap<Models.Marca, DATA.Marca>();
                cfg.CreateMap<DATA.Marca, Models.Marca>();

                //Moneda
                cfg.CreateMap<Models.Moneda, DATA.Moneda>();
                cfg.CreateMap<DATA.Moneda, Models.Moneda>();

                //Pais
                cfg.CreateMap<Models.Pais, DATA.Pais>();
                cfg.CreateMap<DATA.Pais, Models.Pais>();

                //Producto
                cfg.CreateMap<Models.Producto, DATA.Producto>();
                cfg.CreateMap<DATA.Producto, Models.Producto>();

                //Puesto
                cfg.CreateMap<Models.Puesto, DATA.Puesto>();
                cfg.CreateMap<DATA.Puesto, Models.Puesto>();

                //Seg_modulo
                cfg.CreateMap<Models.Seg_modulo, DATA.Seg_modulo>();
                cfg.CreateMap<DATA.Seg_modulo, Models.Seg_modulo>();

                //Seg_opcion
                cfg.CreateMap<Models.Seg_opcion, DATA.Seg_opcion>();
                cfg.CreateMap<DATA.Seg_opcion, Models.Seg_opcion>();

                //Seg_opcion_por_rol
                cfg.CreateMap<Models.Seg_opcion_por_rol, DATA.Seg_opcion_por_rol>();
                cfg.CreateMap<DATA.Seg_opcion_por_rol, Models.Seg_opcion_por_rol>();

                //Seg_rol
                cfg.CreateMap<Models.Seg_rol, DATA.Seg_rol>();
                cfg.CreateMap<DATA.Seg_rol, Models.Seg_rol>();

                //Seg_rol_por_usuario
                cfg.CreateMap<Models.Seg_rol_por_usuario, DATA.Seg_rol_por_usuario>();
                cfg.CreateMap<DATA.Seg_rol_por_usuario, Models.Seg_rol_por_usuario>();

                //Seg_usuario
                cfg.CreateMap<Models.Seg_usuario, DATA.Seg_usuario>();
                cfg.CreateMap<DATA.Seg_usuario, Models.Seg_usuario>();

                //Sucursal
                cfg.CreateMap<Models.Sucursal, DATA.Sucursal>();
                cfg.CreateMap<DATA.Sucursal, Models.Sucursal>();

                //Telefono_cliente
                cfg.CreateMap<Models.Telefono_cliente, DATA.Telefono_cliente>();
                cfg.CreateMap<DATA.Telefono_cliente, Models.Telefono_cliente>();

                //Telefono_proveedor
                cfg.CreateMap<Models.Telefono_proveedor, DATA.Telefono_proveedor>();
                cfg.CreateMap<DATA.Telefono_proveedor, Models.Telefono_proveedor>();

                //Tipo_identificacion
                cfg.CreateMap<Models.Tipo_identificacion, DATA.Tipo_identificacion>();
                cfg.CreateMap<DATA.Tipo_identificacion, Models.Tipo_identificacion>();

                //Tipo_movimiento
                cfg.CreateMap<Models.Tipo_movimiento, DATA.Tipo_movimiento>();
                cfg.CreateMap<DATA.Tipo_movimiento, Models.Tipo_movimiento>();

                //Tipo_movimiento
                cfg.CreateMap<Models.Tipo_pago, DATA.Tipo_pago>();
                cfg.CreateMap<DATA.Tipo_pago, Models.Tipo_pago>();

                //Tipo_prod_serv
                cfg.CreateMap<Models.Tipo_prod_serv, DATA.Tipo_prod_serv>();
                cfg.CreateMap<DATA.Tipo_prod_serv, Models.Tipo_prod_serv>();

                //Tipo_producto
                cfg.CreateMap<Models.Tipo_producto, DATA.Tipo_producto>();
                cfg.CreateMap<DATA.Tipo_producto, Models.Tipo_producto>();

                //Tipo_telefono
                cfg.CreateMap<Models.Tipo_telefono, DATA.Tipo_telefono>();
                cfg.CreateMap<DATA.Tipo_telefono, Models.Tipo_telefono>();

                //Tipo_venta
                cfg.CreateMap<Models.Tipo_venta, DATA.Tipo_venta>();
                cfg.CreateMap<DATA.Tipo_venta, Models.Tipo_venta>();

                //Unidad_medida
                cfg.CreateMap<Models.Unidad_medida, DATA.Unidad_medida>();
                cfg.CreateMap<DATA.Unidad_medida, Models.Unidad_medida>();

            });
        }
    }
}