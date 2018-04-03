using System.Collections.Generic;
using BSS.DATA;

namespace DAL.Interfaces
{
    public interface ISeg_usuario
    {
        List<Seg_usuario> ListarSegUsuarios();
        Seg_usuario BuscarSegUsuario(string su_usuario);
        void InsertarSegUsuario(Seg_usuario seg_usuario);
        void ActualizarSegUsuario(Seg_usuario seg_usuario);
        void EliminarSegUsuario(string su_usuario);
        bool ValidaSegUsuario(string su_usuario, string contrasena);
    }
}
