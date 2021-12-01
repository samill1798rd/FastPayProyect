using AutoMapper;
using Model.ApiFiHogarEntity.Transaction;
using Model.FastPayModel;
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

            CreateMap<PagoServicoDto, Trasaciones>();
            CreateMap<Trasaciones, TransationDto>();




        }
    }
}
