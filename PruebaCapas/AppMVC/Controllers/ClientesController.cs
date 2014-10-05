using AppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using wflSistema;

namespace AppMVC.Controllers
{
    public class ClientesController : Controller
    {

        
        //
        // GET: /Clientes/

        public ActionResult Index()
        {

            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(ClientesModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.CUIL = model.CUIL;
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Insertar(ClientesModel cli)
        {
            wflClientes owflcli = new wflClientes();
            string strmensaje="";
            owflcli.insertarRegistro(ref strmensaje, cli.NroCliente, cli.CUIL, cli.RazonSocial, cli.Domicilio, null, null, null, null);
            return View();
        }

    }
}
