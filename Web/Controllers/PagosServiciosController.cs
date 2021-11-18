using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.ViewModel;

namespace Web.Controllers
{
    [Authorize]
    public class PagosServiciosController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public PagosServiciosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePago(int id)
        {
            var datosVm = new ServicosDto { Id = 1, Cuenta = "00000", IsActive = true, Nombre = "Pago Luz 1", ServicoGrupoId = 1 };

            return View(datosVm);
        }


        [HttpPost]
        public IActionResult SavePago(ServicosDto dto)
        {
            return null;
        }

        [AllowAnonymous]
        public PartialViewResult GetServicoById(int id)
        {
            var datosVm = GetServicios();

            return PartialView("_ListServicos", datosVm);
        }

        private List<ServicosDto> GetServicios()
        {
            var datosVm = new List<ServicosDto>();

            datosVm.Add(new ServicosDto { Id = 1, Cuenta = "00000", IsActive = true, Nombre = "Pago Luz 1", ServicoGrupoId = 1 });
            datosVm.Add(new ServicosDto { Id = 1, Cuenta = "00000", IsActive = true, Nombre = "Pago Luz 1", ServicoGrupoId = 1 });
            datosVm.Add(new ServicosDto { Id = 1, Cuenta = "00000", IsActive = true, Nombre = "Test 1", ServicoGrupoId = 1 });
            datosVm.Add(new ServicosDto { Id = 2, Cuenta = "00000", IsActive = true, Nombre = "Test 2", ServicoGrupoId = 2 });
            datosVm.Add(new ServicosDto { Id = 3, Cuenta = "00000", IsActive = true, Nombre = "Test 3", ServicoGrupoId = 3 });
            datosVm.Add(new ServicosDto { Id = 4, Cuenta = "00000", IsActive = true, Nombre = "Test 4", ServicoGrupoId = 4 });
            datosVm.Add(new ServicosDto { Id = 5, Cuenta = "00000", IsActive = true, Nombre = "Test 5", ServicoGrupoId = 5 });

            return datosVm;
        }
    }


}
