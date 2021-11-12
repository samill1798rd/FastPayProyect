using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PagosServiciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePago(int id)
        {
            return View();
        }
    }

    
}
