using Computarizada;

namespace Manager.Request
{
    public class CompEducativaRecepcionRequest : solicitudRecepcionFactura
    {
        public string CodigoControl { get; set; }
        public facturaComputarizadaSectorEducativo Factura { get; set; }
    }
}
