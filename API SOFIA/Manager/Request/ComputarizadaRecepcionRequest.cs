using CompraVenta;
using Poco;

namespace Manager.Request
{
    public class ComputarizadaRecepcionRequest : solicitudRecepcionFactura
    {
        public string CodigoControl { get; set; }
        public facturaComputarizadaCompraVenta Factura { get; set; }
    }
}
