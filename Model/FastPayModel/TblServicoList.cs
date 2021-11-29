using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Model.FastPayModel
{
    public partial class TblServicoList
    {
        public TblServicoList()
        {
            TblHistoricoTrasaciones = new HashSet<TblHistoricoTrasaciones>();
        }

        public int IdServicoList { get; set; }
        public string Name { get; set; }
        public int? ServicioHeaderId { get; set; }

        public virtual TblServicioNameCabezera ServicioHeader { get; set; }
        public virtual ICollection<TblHistoricoTrasaciones> TblHistoricoTrasaciones { get; set; }
    }
}
