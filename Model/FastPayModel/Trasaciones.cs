using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Model.FastPayModel
{
    public partial class Trasaciones
    {
        public int IdHistoricoTransaciones { get; set; }
        public string Monto { get; set; }
        public int? ServicioTipo { get; set; }
        public int? ServicioName { get; set; }
        public string Correo { get; set; }
        public string ReferenciaPago { get; set; }
    }
}
