using CreditoDebito;
using Poco;

namespace Manager.Request
{
    public class CompDebitoCreditoRecepcionRequest : solicitudRecepcionFactura
    {
        public int TipoFactura { get; set; }
        public string CodigoControl { get; set; }
        public notaFiscalComputarizadaCreditoDebito Factura { get; set; }
    }
}
