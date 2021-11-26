using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.ApiFiHogar;
using System.Collections.Generic;
using System.Security.Claims;
using Web.ViewModel;

namespace Web.Controllers
{
    [Authorize]
    public class PagosServiciosController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApiFiHogarServices _ApiFiHogarServices;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private string CurrentAccount;
        public PagosServiciosController(ILogger<HomeController> logger, IApiFiHogarServices apiFiHogarServices, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _ApiFiHogarServices = apiFiHogarServices;
            _httpContextAccessor = httpContextAccessor;

            var user = _httpContextAccessor.HttpContext.User.Identity.Name;

            SetCurrentAccount();

            _ApiFiHogarServices.GetSecondToken("matilde_1", "matilde_1");
        }
        public IActionResult Index()
        {
            


            var test1 = _ApiFiHogarServices.GetAccountTransationsDetail("0000");
            _ApiFiHogarServices.CreateAccountTransfer(CurrentAccount);


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

        private void SetCurrentAccount()
        {
            var accountObj = _ApiFiHogarServices.GetAccountInformation();
            CurrentAccount = accountObj.Result.Data.Account[0].account[0].Identification;
        }
    }


}
