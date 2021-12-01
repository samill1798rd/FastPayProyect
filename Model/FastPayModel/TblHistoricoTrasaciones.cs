using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Model.FastPayModel { 
    public partial class TblHistoricoTrasaciones
    {
        public int IdHistoricoTransaciones { get; set; }
        public string Monto { get; set; }
        public string PorcientoPagina { get; set; }
        public string ReferenciaPago { get; set; }
        public string Total { get; set; }
        public int? ServicioHeaderId { get; set; }
        public int? ServicioListId { get; set; }
        public string CedulaUser { get; set; }

        public virtual TblServicioNameCabezera ServicioHeader { get; set; }
        public virtual TblServicoList ServicioList { get; set; }
    }
}
