﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            return View();        
        }
    }
}
