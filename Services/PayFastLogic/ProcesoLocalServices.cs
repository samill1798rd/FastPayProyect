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

        public AspNetUsers GetUserByCorreo(string correo)
        {
            return _DBContext.AspNetUsers.FirstOrDefault(x => x.UserName == correo);
        }

        public IEnumerable<TblServicioList> GetServicioListByModuloId(int id)
        {
            return _DBContext.TblServicioList.Include(x => x.ServicioHeader)
                        .Where(x => x.ServicioHeader.IdServicioHeader == id).ToList();
        }

        public IEnumerable<Trasaciones> GetTransationByCorreo(string correo)
        {
            return _DBContext.Trasaciones.Where(x => x.Correo == correo).ToList();
        }

        public IEnumerable<Trasaciones> GetTransationAll()
        {
            return _DBContext.Trasaciones.ToList();
        }

        public TblServicioList GetServicioById(int? id)
        {
            return _DBContext.TblServicioList.Include(x => x.ServicioHeader)
                .SingleOrDefault(x => x.IdServicioList == id);
        }

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
