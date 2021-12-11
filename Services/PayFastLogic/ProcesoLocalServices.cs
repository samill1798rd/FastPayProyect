using Common;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Model.FastPayModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.PayFastLogic
{
    public class ProcesoLocalServices : IProcesoLocalServices
    {

        private readonly PayFastAppDBContext _DBContext;

        public ProcesoLocalServices(PayFastAppDBContext dBContext)
        {
            _DBContext = dBContext;
        }

        //obtien el usuario actual por el correo
        public AspNetUsers GetUserByCorreo(string correo)
        {
            return _DBContext.AspNetUsers.FirstOrDefault(x => x.UserName == correo);
        }
        //obtien una lista de servicio por el modulo
        public IEnumerable<TblServicioList> GetServicioListByModuloId(int id)
        {
            return _DBContext.TblServicioList.Include(x => x.ServicioHeader)
                        .Where(x => x.ServicioHeader.IdServicioHeader == id).ToList();
        }
        //obtener una lista de transaciones por correo
        public IEnumerable<Trasaciones> GetTransationByCorreo(string correo)
        {
            return _DBContext.Trasaciones.Where(x => x.Correo == correo).ToList();
        }
        //obtener todas las transaciones en una lista.
        public IEnumerable<Trasaciones> GetTransationAll()
        {
            return _DBContext.Trasaciones.ToList();
        }
        //obtien un objecto de servicio por servicio id
        public TblServicioList GetServicioById(int? id)
        {
            return _DBContext.TblServicioList.Include(x => x.ServicioHeader)
                .SingleOrDefault(x => x.IdServicioList == id);
        }
        //guarda la transacion en la base de datos local
        public OperationResult<Trasaciones> SaveTransaciones(Trasaciones model)
        {
            var operation = new OperationResult<Trasaciones>();

            try
            {
                _DBContext.Trasaciones.Add(model);
                var row = _DBContext.SaveChanges();
                operation.Success = true;
                operation.Message.Add("Succes");
            }
            catch (Exception ex)
            {
                operation.ObjResult = model;
                operation.Success = false;
                operation.Message.Add("erro");
            }

            return operation;
        }


    }
}
