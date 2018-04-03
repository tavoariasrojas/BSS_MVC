using System.Collections.Generic;
using BSS.DATA;
using DAL.Interfaces;
using ServiceStack.OrmLite;
using System.Linq;
using System;

namespace DAL.Metodos
{
    public class MSeg_usuario : MConnection, ISeg_usuario
    {
        public void ActualizarSegUsuario(Seg_usuario seg_usuario)
        {
            _db.Update(seg_usuario);
        }

        public Seg_usuario BuscarSegUsuario(string su_usuario)
        {
            return _db.Select<Seg_usuario>(x => x.su_usuario == su_usuario).FirstOrDefault();
        }

        public void EliminarSegUsuario(string su_usuario)
        {
            _db.Delete<Seg_usuario>(x => x.su_usuario == su_usuario);
        }

        public void InsertarSegUsuario(Seg_usuario seg_usuario)
        {
            _db.Insert(seg_usuario);
        }

        public List<Seg_usuario> ListarSegUsuarios()
        {
            return _db.Select<Seg_usuario>();
        }

        public bool ValidaSegUsuario(string su_usuario, string contrasena)
        {
            var valido = _db.Select<Seg_usuario>(x => x.su_usuario == su_usuario && x.su_contrasena == contrasena);
            if (valido != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
