using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AplicationUserWebUser class
    public class AplicationUserWebUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Apellido { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string Cedula { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string NoCuenta { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string Sexo { get; set; }
        [PersonalData]
        [Column(TypeName = "datetime")]
        public DateTime? FechaNacimiento { get; set; }

        [PersonalData]
        [Column(TypeName = "integer")]
        public int? RolId { get; set; }
    }
}
