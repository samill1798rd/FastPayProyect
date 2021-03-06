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

        //presenta la vista en el cual se crean los pagos
        public IActionResult CreatePago(int id)
        {
            var dbObj = _procesoLocalServices.GetServicioById(id);

            var datosVm = _mapper.Map<PagoServicoDto>(dbObj);

            datosVm.Monto = GetRandomNumber();

            return View(datosVm);
        }

        //presenta la vista en la cuals se generan y guardan los pagos
        [HttpPost]
        public IActionResult SavePago(PagoServicoDto dto)
        {
            IniciarlizarOperacionesApi();

            var obj = _ApiFiHogarServices.CreateAccountTransfer(CurrentAccount, dto.Monto);

            var model = _mapper.Map<Trasaciones>(dto);
            model.FechaCreacion = DateTime.Now;

            _procesoLocalServices.SaveTransaciones(SetOperactionBussiness(model,dto));


            return RedirectToAction("Success", dto);
        }

        private Trasaciones SetOperactionBussiness(Trasaciones model, PagoServicoDto dto)
        {
          
            model.Correo = Correo;
            model.ServicioName = dto.IdServicioList;
            model.ServicioTipo = dto.ServicioHeaderId;
      
            return model;
        }

        //presenta la vista donde muestra un mensaje de operacion terminada
        public IActionResult Success(PagoServicoDto dto)
        {

            return View(dto);
        }

        //presenta la vista donde muestra el historial de transaciones de un usario
        public IActionResult HistorialTransaciones()
        {
            var obj = _procesoLocalServices.GetTransationByCorreo(Correo); 

            return View(SetMappingTransaciones(obj));
        }
        //presenta la vista donde muestra el historial de transaciones de todos los usuarios
        public IActionResult HistorialCuentaPrincipal()
        {
            var obj = _procesoLocalServices.GetTransationAll();

            return View(SetMappingTransaciones(obj));
        }



        private List<TransationDto> SetMappingTransaciones(IEnumerable<Trasaciones> model)
        {
            
            var listTransactionDto = new List<TransationDto>();

            foreach (var item in model)
            {
                var servicioObj = _procesoLocalServices.GetServicioById(item.ServicioName);
                var transaction = new TransationDto();
                transaction.ServicioName = servicioObj.Name;
                transaction.ServicioTipo = servicioObj.ServicioHeader.Name;
                transaction.Monto = item.Monto;
                transaction.ReferenciaPago = item.ReferenciaPago;
                transaction.Correo = item.Correo;
                transaction.FechaCreacion = item.FechaCreacion;

                listTransactionDto.Add(transaction);
            }

            return listTransactionDto;
        }


        //presenta la vista donde se obtiene un servico por id
        [AllowAnonymous]
        public PartialViewResult GetServicoById(int id)
        {
            var dbObj = _procesoLocalServices.GetServicioListByModuloId(id);

            var datosVm = _mapper.Map<IEnumerable<ServicosDto>>(dbObj);


            return PartialView("_ListServicos", datosVm);
        }
        //muestra el balance en tiempo real
        [AllowAnonymous]
        public JsonResult GetBalance()
        {
            IniciarlizarOperacionesApi();

            var obj = _ApiFiHogarServices.GetAccountInformation();

            var balance = obj.Result.Data.Account[0].Balance[0].Amount.amount.ToString();

            return Json(balance);
        }

        //genera el monto ramdom
        private string GetRandomNumber()
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
            _ApiFiHogarServices.GetSecondToken(UserObj.NoCuenta.Trim(), UserObj.NoCuenta.Trim());
        }
    }
}
