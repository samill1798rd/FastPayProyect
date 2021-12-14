namespace Web.ViewModel
{
    public class TransationDto
    {
        public int IdHistoricoTransaciones { get; set; }
        public string Monto { get; set; }
        public string? ServicioTipo { get; set; }
        public string? ServicioName { get; set; }
        public string Correo { get; set; }
        public string ReferenciaPago { get; set; }
        public DateTime? Fecha { get; set; }

    }
}
