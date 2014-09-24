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


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Insertar(ClientesModel cli )
        {
            wflClientes owflcli = new wflClientes();
            string strmensaje="";
            owflcli.insertarRegistro(cli.NroCliente,cli.RazonSocial,ref strmensaje,cli.Domicilio);
            return View();
        }

    }
}
