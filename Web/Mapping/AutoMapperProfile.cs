using AutoMapper;
using Model.ApiFiHogarEntity.Transaction;
using Model.FastPayModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModel;

namespace Web.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TblServicioList,ServicosDto>();
            CreateMap<TblServicioList,PagoServicoDto>();
            CreateMap<ServicosDto,TblServicioList>();


            CreateMap<PagoServicoDto, TblHistoricoTrasaciones>();
            CreateMap<TransactionDetail, TransationDto>();



            
        }
    }
}
