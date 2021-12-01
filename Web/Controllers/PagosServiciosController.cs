using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model.FastPayModel;
using Services.ApiFiHogar;
using Services.PayFastLogic;
using System;
using System.Collections.Generic;
using Web.ViewModel;

namespace Web.Controllers
{
    [Authorize]
    public class PagosServiciosController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IApiFiHogarServices _ApiFiHogarServices;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProcesoLocalServices _procesoLocalServices;
        private readonly IMapper _mapper;

        private string CurrentAccount;
        private string Correo;
        private AspNetUsers UserObj;
        public PagosServiciosController(
            ILogger<HomeController> logger,
            IApiFiHogarServices apiFiHogarServices,
            IHttpContextAccessor httpContextAccessor,
            IProcesoLocalServices procesoLocalServices,
            IMapper mapper
            )
        {
            _logger = logger;
            _ApiFiHogarServices = apiFiHogarServices;
            _httpContextAccessor = httpContextAccessor;
            _procesoLocalServices = procesoLocalServices;
            _mapper = mapper;

            Correo = _httpContextAccessor.HttpContext.User.Identity.Name;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePago(int id)
        {
            var dbObj = _procesoLocalServices.GetServicioById(id);

            var datosVm = _mapper.Map<PagoServicoDto>(dbObj);

            datosVm.Monto = GetRandomNumber();

            return View(datosVm);
        }


        [HttpPost]
        public IActionResult SavePago(PagoServicoDto dto)
        {
            IniciarlizarOperacionesApi();

            var obj =_ApiFiHogarServices.CreateAccountTransfer(CurrentAccount,dto.Monto);

            var model = _mapper.Map<TblHistoricoTrasaciones>(dto);


            return RedirectToAction("Success", dto);
        }

      
        public IActionResult Success(PagoServicoDto dto)
        {
        
            return View(dto);
        }


        public IActionResult HistorialTransaciones()
        {
            IniciarlizarOperacionesApi();

            var obj = _ApiFiHogarServices.GetAccountTransationsDetail(CurrentAccount);

            var objTransation = obj.Result.Data.Transaction;

            var model = _mapper.Map<IEnumerable<TransationDto>>(objTransation);

            return View(model);
        }


        private TblHistoricoTrasaciones SetOperactionBussiness(TblHistoricoTrasaciones model, PagoServicoDto dto)
        {
            model.PorcientoPagina = "3%";
            model.CedulaUser = UserObj.Cedula;
            model.Total = model.Monto;
            model.ServicioListId = dto.IdServicioList;

            return model;
        }

        [AllowAnonymous]
        public PartialViewResult GetServicoById(int id)
        {
            var dbObj = _procesoLocalServices.GetServicioListByModuloId(id);

            var datosVm = _mapper.Map<IEnumerable<ServicosDto>>(dbObj);


            return PartialView("_ListServicos", datosVm);
        }

        [AllowAnonymous]
        public JsonResult GetBalance()
        {
            IniciarlizarOperacionesApi();

            var obj = _ApiFiHogarServices.GetAccountInformation();

            var balance = obj.Result.Data.Account[0].Balance[0].Amount.amount.ToString();

            return Json(balance);
        }


        private string  GetRandomNumber()
        {
            return new Random().Next(500, 1000).ToString();
        }


        private void IniciarlizarOperacionesApi()
        {
            GetUserToLogginInAccountApi();
            SetCurrentAccount();
            
        }

        private void SetCurrentAccount()
        {
            var accountObj = _ApiFiHogarServices.GetAccountInformation();
            CurrentAccount = accountObj.Result.Data.Account[0].account[0].Identification;
        }

        private void GetUserToLogginInAccountApi()
        {
             UserObj = _procesoLocalServices.GetUserByCorreo(Correo);
            _ApiFiHogarServices.GetSecondToken(UserObj.NoCuenta, UserObj.NoCuenta);
        }
    }
}
