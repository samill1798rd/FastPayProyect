using Common;
using Model.FastPayModel;
using System.Collections.Generic;

namespace Services.PayFastLogic
{
    public interface IProcesoLocalServices
    {
        AspNetUsers GetUserByCorreo(string correo);
        IEnumerable<TblServicioList> GetServicioListByModuloId(int id);
        TblServicioList GetServicioById(int id);

        OperationResult<TblHistoricoTrasaciones> SaveHistoricoTransaciones(TblHistoricoTrasaciones model);

    }
}
