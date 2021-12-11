using Common;
using Model.FastPayModel;
using System.Collections.Generic;

namespace Services.PayFastLogic
{
    public interface IProcesoLocalServices
    {
        //obtener el usuario actual por el correo
        AspNetUsers GetUserByCorreo(string correo);
        //obtener una lista de servicio por el modulo
        IEnumerable<TblServicioList> GetServicioListByModuloId(int id);
        //obtener un objecto de servicio por servicio id
        TblServicioList GetServicioById(int? id);
        //guarda la transacion en la base de datos local
        OperationResult<Trasaciones> SaveTransaciones(Trasaciones Trasaciones);
        //obtener una lista de transaciones por correo
        IEnumerable<Trasaciones> GetTransationByCorreo(string correo);
        //obtener todas las transaciones en una lista.
        IEnumerable<Trasaciones> GetTransationAll();

    }
}
