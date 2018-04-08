using AutoMapper;
using DAL.Interfaces;
using DAL.Metodos;
using BSS.DATA;
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
            try
            {
                var listaSegUsuarios = usu.ListarSegUsuarios();
                var usuarios = Mapper.Map<List<Models.Seg_usuario>>(listaSegUsuarios);
                ViewBag.Cantidad = usuarios.Count;
                return View(usuarios);
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
                    return RedirectToAction("Index", "Seg_usuario");

                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Producto usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioInsertar = Mapper.Map<DATA.Seg_usuario>(usuario);
                usu.InsertarSegUsuario(usuarioInsertar);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Details(string id)
        {
            var usuario = usu.BuscarSegUsuario(id);
            var usuarioMostrar = Mapper.Map<Models.Seg_usuario>(usuario);
            return View(usuarioMostrar);
        }

        public ActionResult Edit(string id)
        {
            var usuario = usu.BuscarSegUsuario(id);
            var usuarioMostrar = Mapper.Map<Models.Producto>(usuario);
            return View(usuarioMostrar);
        }
        [HttpPost]

        public ActionResult Edit(Models.Producto usuario)
        {
            var usuarioModicar = Mapper.Map<DATA.Seg_usuario>(usuario);
            if (ModelState.IsValid)
            {
                usu.ActualizarSegUsuario(usuarioModicar);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public ActionResult Delete(string id)
        {
            usu.EliminarSegUsuario(id);
            return RedirectToAction("Index");
        }
    }
}