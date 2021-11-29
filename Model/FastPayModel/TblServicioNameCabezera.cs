using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Model.FastPayModel
{
    public partial class TblServicioNameCabezera
    {
        public TblServicioNameCabezera()
        {
            TblHistoricoTrasaciones = new HashSet<TblHistoricoTrasaciones>();
            TblServicioList = new HashSet<TblServicioList>();
            TblServicoList = new HashSet<TblServicoList>();
        }

        public int IdServicioHeader { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblHistoricoTrasaciones> TblHistoricoTrasaciones { get; set; }
        public virtual ICollection<TblServicioList> TblServicioList { get; set; }
        public virtual ICollection<TblServicoList> TblServicoList { get; set; }
    }
}
