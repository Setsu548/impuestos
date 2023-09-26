using Computarizada;

namespace Manager.Request
{
    public class CompHospitalesRecepcionRequest: solicitudRecepcionFactura
    {
        public string CodigoControl { get; set; }
        public facturaComputarizadaHospitalClinica Factura { get; set; }
    }
}
