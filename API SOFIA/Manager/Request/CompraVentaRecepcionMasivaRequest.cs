using CompraVenta;
using System.Collections.Generic;

namespace Manager.Request
{
    public class CompraVentaRecepcionMasivaRequest
    {
        public List<string> ListaFacturas { get; set; }
        public solicitudRecepcionMasiva solicitudRecepcion { get; set; }
    }
}