using CompraVenta;
using System.Collections.Generic;

namespace Manager.Request
{
    public class CompraVentaRecepcionPaqueteRequest
    {
        public List<string> ListaFacturas { get; set; }
        public solicitudRecepcionPaquete solicitudRecepcion { get; set; }
    }
}
