using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModel
{
    public class PagoServicoDto
    {
        public int IdServicioList { get; set; }
        public string Name { get; set; }
        public int? ServicioHeaderId { get; set; }
        [Required (ErrorMessage = "El campo es requerido")]
        public string ReferenciaPago { get; set; }
        //public string Telefono { get; set; }
        public string Monto { get; set; }
    }
}
