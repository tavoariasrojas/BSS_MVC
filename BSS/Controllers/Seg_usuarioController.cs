using AutoMapper;
using DAL.Interfaces;
using DAL.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSS.Controllers
{
    public class Seg_usuarioController : Controller
    {
        ISeg_usuario usu;
        public Seg_usuarioController()
        {
            usu = new MSeg_usuario();
        }
        // GET: Seg_usuario
        public ActionResult Index()
        {
            var listaSegUsuarios = usu.ListarSegUsuarios();
            var usuarios = Mapper.Map<List<Models.Seg_usuario>>(listaSegUsuarios);
            ViewBag.Cantidad = usuarios.Count;
            return View(usuarios);
        }

        public ActionResult Login()
        {
            try
            {
                string message = string.Empty;
                string id = Request.Form["txtUsername"].ToString();
                string contra = Request.Form["txtContrasenna"].ToString();
                var usuario = usu.BuscarSegUsuario(id);
                if (usuario.su_contrasena.Equals(contra))
                {
                    return RedirectToAction("About", "Home");

                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
        }
    }
}