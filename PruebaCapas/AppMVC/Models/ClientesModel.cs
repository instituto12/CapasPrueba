using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace AppMVC.Models
{
    public class ClientesModel
    {
        
        
            [DisplayName("Nro.Cliente")]
            public int NroCliente { get; set; }

            [DisplayName("Razón Social")]
            public string RazonSocial { get; set; }

            [DisplayName("Domicilio")]
            public string Domicilio { get; set; }

            
        
    }
}